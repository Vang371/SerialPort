Public Class Form1
    'control color led on and off
    Dim colorLedOn As Color = Color.Red
    Dim colorLedOff As Color = Color.Gray
    'connect COM port button click event
    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        Dim MsgConnect, StyleMsgConnect As String
        StyleMsgConnect = vbOKOnly + vbInformation
        If Cbb_SerialPort.Text = "" Then
            MsgConnect = "Please choose COM port!"
            MsgBox(MsgConnect, StyleMsgConnect, "Noti")
        Else
            If SerialPort.IsOpen = False Then
                SerialPort.PortName = Cbb_SerialPort.SelectedItem.ToString
                Try
                    SerialPort.Open()
                    MsgConnect = "Connect successfully."
                    btn_connect.Text = "Disconnect"
                Catch ex As Exception
                    MsgConnect = "COM Port used, choose another port."
                End Try
                MsgBox(MsgConnect, StyleMsgConnect, "Noti")
            Else
                SerialPort.Close()
                If SerialPort.IsOpen = False Then
                    MsgConnect = "Disconnect."
                    MsgBox(MsgConnect, StyleMsgConnect, "Noti")
                    btn_connect.Text = "Connect"
                End If
            End If
        End If
    End Sub
    'combobox index changed event, disconnect when changed COM port
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
        COMPortList.Clear()
        COMPortList.AddRange(IO.Ports.SerialPort.GetPortNames)
        COMPortList.Sort()
        sortCOMPortList(COMPortList)
        Cbb_SerialPort.DataSource = COMPortList
    End Sub
    'send data to COM port button click event
    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        If SerialPort.IsOpen = True Then
            TextBox1.Text = led2tbx()
            Dim test As String = TextBox1.Text
            Dim sendbyte() As Byte = New Byte() {Convert.ToByte(test, 2)}
            TextBox2.Text = UCase(Convert.ToString(Convert.ToUInt16(TextBox1.Text, 2), 16))
            SerialPort.Write(sendbyte, 0, 1)
        Else
            Dim StyleMsgSend As String
            StyleMsgSend = vbOKOnly + vbInformation
            MsgBox("Please connect COM port!.", StyleMsgSend, "Noti")
        End If
    End Sub
    'clear all bit button click event
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        chb_bit0.Checked = False
        chb_bit1.Checked = False
        chb_bit2.Checked = False
        chb_bit3.Checked = False
        chb_bit4.Checked = False
        chb_bit5.Checked = False
        chb_bit6.Checked = False
        chb_bit7.Checked = False
        TextBox1.Text = led2tbx()
    End Sub
    'exit app button click click event
    Private Sub btn_quit_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
        End
    End Sub

    'Function and Sub support
    Function led2tbx() As String
        Dim valBin_String As String
        valBin_String = Convert.ToString(checkBit(chb_bit0, shape_led0, colorLedOn, colorLedOff))
        valBin_String = Convert.ToString(checkBit(chb_bit1, shape_led1, colorLedOn, colorLedOff)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit2, shape_led2, colorLedOn, colorLedOff)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit3, shape_led3, colorLedOn, colorLedOff)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit4, shape_led4, colorLedOn, colorLedOff)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit5, shape_led5, colorLedOn, colorLedOff)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit6, shape_led6, colorLedOn, colorLedOff)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit7, shape_led7, colorLedOn, colorLedOff)) & valBin_String

        Return valBin_String
    End Function

    Function checkBit(bitCheck As CheckBox, shpCtrl As PowerPacks.OvalShape, clrLedOn As Color, clrLedOff As Color) As Integer
        If bitCheck.Checked = True Then
            shpCtrl.BackColor = clrLedOn
            Return 1
        Else
            shpCtrl.BackColor = clrLedOff
            Return 0
        End If
    End Function

    Public Sub sortCOMPortList(ByRef comList As ArrayList)
        Dim i As Integer = 0
        Dim tempPortList As ArrayList = New ArrayList()
        Do
            'Dim txtTemp As String = comList.Item(i)
            If Len(comList.Item(i)) = 4 Then
                tempPortList.Add(comList.Item(i))
                comList.RemoveAt(i)
            Else
                i = i + 1
            End If
        Loop While i < comList.Count
        tempPortList.AddRange(comList)
        comList = tempPortList
    End Sub
End Class
