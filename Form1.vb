Public Class Form1
    'my broken enlish

    'variable save data byte
    Dim binVal_Str As String = "00000000"

    'connect COM port button click event
    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        Dim MsgConnect, StyleMsgConnect As String
        StyleMsgConnect = vbOKOnly + vbInformation
        'if cbb is nothing
        If Cbb_SerialPort.Text = "" Then
            MsgConnect = "Please select COM port!"
            MsgBox(MsgConnect, StyleMsgConnect, "Noti")
            'else selected com port
        Else
            'if port close -> open port
            If SerialPort.IsOpen = False Then
                SerialPort.PortName = Cbb_SerialPort.SelectedItem.ToString
                Try
                    SerialPort.Open()
                    MsgConnect = "Connect successfully."
                    btn_connect.Text = "Disconnect"
                Catch ex As Exception
                    MsgConnect = "COM Port used, select another port."
                End Try
                MsgBox(MsgConnect, StyleMsgConnect, "Noti")
            Else 'if port open -> close port
                timer_1.Enabled = False
                btn_effect.Text = "Run effect"
                SerialPort.Close()
                If SerialPort.IsOpen = False Then
                    MsgConnect = "Disconnect."
                    MsgBox(MsgConnect, StyleMsgConnect, "Noti")
                    btn_connect.Text = "Connect"
                End If
            End If
        End If
    End Sub

    'combobox index changed event, disconnect when changed COM port in combobox
    Private Sub Cbb_SerialPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbb_SerialPort.SelectedIndexChanged
        If SerialPort.IsOpen = True Then
            SerialPort.Close()
            MsgBox("Disconnect.", (vbOKOnly + vbInformation), "Noti")
            btn_connect.Text = "Connect"
        End If
    End Sub

    'drop down combobox show available COM port event
    Private Sub Cbb_SerialPort_DropDown(sender As Object, e As EventArgs) Handles Cbb_SerialPort.DropDown
        Dim COMPortList As ArrayList = New ArrayList()
        'clear array data of combobox
        COMPortList.Clear()
        'add new items
        COMPortList.AddRange(IO.Ports.SerialPort.GetPortNames)
        'sort comportlist in combobox
        sortCOMPortList(COMPortList)
        Cbb_SerialPort.DataSource = COMPortList
    End Sub

    'send data to COM port button click event
    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        If timer_1.Enabled = False Then
            If SerialPort.IsOpen = True Then
                'check bit and rewrite string data.
                checkBit(binVal_Str)
                updateLED(binVal_Str)
                updateTbx(binVal_Str)
                sendByte(tbx_binVal)
            Else
                Dim StyleMsgSend As String
                StyleMsgSend = vbOKOnly + vbInformation
                MsgBox("Please connect COM port!", StyleMsgSend, "Noti")
            End If
        End If
    End Sub

    'clear all bit button click event
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        If timer_1.Enabled = False Then
            If SerialPort.IsOpen = True Then
                'check bit and rewrite string data.
                For Each chbClear In Me.Controls.OfType(Of CheckBox)
                    If Strings.Left(chbClear.Name, 7) = "chb_bit" Then
                        chbClear.Checked = False
                    End If
                Next
                checkBit(binVal_Str)
                updateLED(binVal_Str)
                updateTbx(binVal_Str)
                sendByte(tbx_binVal)
            Else
                Dim StyleMsgSend As String
                StyleMsgSend = vbOKOnly + vbInformation
                MsgBox("Please connect COM port!", StyleMsgSend, "Noti")
            End If
        End If
    End Sub

    Private Sub tbx_timeLed_TextChanged(sender As Object, e As EventArgs) Handles tbx_timeLed.TextChanged

    End Sub

    Dim dir As Integer
    Dim indexEffect As Integer
    Private Sub btn_effect_Click(sender As Object, e As EventArgs) Handles btn_effect.Click
        If SerialPort.IsOpen = True Then
            'check bit and rewrite string data.
            timer_1.Interval = Convert.ToInt32(tbx_timeLed.Text)
            If timer_1.Enabled = True Then
                btn_effect.Text = "Run effect"
                timer_1.Enabled = False
            Else
                btn_effect.Text = "Stop effect"
                timer_1.Enabled = True
                If cbb_effect.SelectedItem.ToString = "Chasing left" Then
                    dir = -1
                    indexEffect = 8
                ElseIf cbb_effect.SelectedItem.ToString = "Chasing right" Then
                    dir = 1
                    indexEffect = 1
                End If
            End If

        Else
            Dim StyleMsgSend As String
            StyleMsgSend = vbOKOnly + vbInformation
            MsgBox("Please connect COM port!", StyleMsgSend, "Noti")
        End If
    End Sub

    Private Sub timer_1_Tick(sender As Object, e As EventArgs) Handles timer_1.Tick

        binVal_Str = "00000000"
        binVal_Str = Strings.Right(binVal_Str, 8 - indexEffect) & "1" & Strings.Left(binVal_Str, indexEffect - 1)

        If indexEffect >= 8 And dir = 1 Then
            indexEffect = 1
        ElseIf indexEffect <= 1 And dir = -1 Then
            indexEffect = 8
        Else
            indexEffect = indexEffect + dir
        End If

        updateLED(binVal_Str)
        updateTbx(binVal_Str)
        sendByte(tbx_binVal)
    End Sub

    'exit app button click click event
    Private Sub btn_quit_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
        End
    End Sub

    'change data type and update to textbox
    Public Sub updateTbx(uptbx As String)
        tbx_binVal.Text = uptbx
        tbx_hexVal.Text = UCase(Convert.ToString(Convert.ToUInt16(uptbx, 2), 16))
        tbx_decVal.Text = Convert.ToString(Convert.ToUInt16(uptbx, 2), 10)
        tbx_octVal.Text = Convert.ToString(Convert.ToUInt16(uptbx, 2), 8)
        tbx_ascii.Text = Strings.ChrW(Convert.ToString(Convert.ToUInt16(uptbx, 2)))
    End Sub

    Public Sub updateLED(binValCheck As String)
        Dim indexLED As Integer
        For Each shpCheck In ShapeContainer1.Shapes
            'check shape name
            If Strings.Left(shpCheck.Name, 7) = "shp_led" Then
                indexLED = Val(Strings.Right(shpCheck.Name, 1))
                'cut string and compare
                If Mid(binValCheck, 8 - indexLED, 1) = "1" Then
                    shpCheck.BackColor = Color.Red
                Else
                    shpCheck.BackColor = Color.Gray
                End If
            End If
        Next
    End Sub

    'check bit in checkbox, function loop follow loop way
    Public Sub checkBit(ByRef binVal_checkBit As String)
        Dim indexBit As Integer
        Dim resultBin As String
        'binVal_checkBit = ""
        For Each chbCheck In Me.Controls.OfType(Of CheckBox)
            'check checkbox name
            If Strings.Left(chbCheck.Name, 7) = "chb_bit" Then
                If chbCheck.Checked = True Then
                    resultBin = "1"
                Else
                    resultBin = "0"
                End If
                'get positions obit
                indexBit = Val(Strings.Right(chbCheck.Name, 1))
                'position bit = 0: <7 bit first> + <result bit>
                'position bit = 7: <result bit> + <7 bit last>
                'position bit = 1 - 6: <7 - index> + <result bit> + <index - 1>
                Select Case indexBit
                    Case 0
                        binVal_checkBit = Strings.Left(binVal_checkBit, 7) & resultBin
                    Case 7
                        binVal_checkBit = resultBin & Strings.Right(binVal_checkBit, 7)
                    Case 1 To 6
                        binVal_checkBit = Strings.Left(binVal_checkBit, 7 - indexBit) & resultBin & Strings.Right(binVal_checkBit, indexBit)
                End Select
            End If
        Next
    End Sub

    'send byte to serial port
    Public Sub sendByte(ByRef tbxBinVal As TextBox)
        Dim binVal As String = tbxBinVal.Text
        Dim sendbyte() As Byte = New Byte() {Convert.ToByte(binVal, 2)}
        'TextBox2.Text = UCase(Convert.ToString(Convert.ToUInt16(TextBox1.Text, 2), 16))
        SerialPort.Write(sendbyte, 0, 1)
    End Sub

    'sort name COM port
    Public Sub sortCOMPortList(ByRef comList As ArrayList)
        'sort list but still have some porblem
        comList.Sort()
        'dim index, list to save temp
        Dim i As Integer = 0
        Dim tempPortList As ArrayList = New ArrayList()
        'loop while index < (comList items)
        Do
            'if com port num < 10, exam: COM4
            If Len(comList.Item(i)) = 4 Then
                'add item in top list of temp list
                tempPortList.Add(comList.Item(i))
                'remove item in comList
                comList.RemoveAt(i)
            Else
                'else ignore, increase index
                i = i + 1
            End If
        Loop While i < comList.Count
        'add comlist at bottom temp list
        tempPortList.AddRange(comList)
        'renew comlist
        comList = tempPortList
    End Sub
End Class
