Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Public Class Form1
    Dim colorLedOn As Color = Color.Red
    Dim colorLedOff As Color = Color.Gray
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
                    MsgConnect = "COM Port used."
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

    Private Sub Cbb_SerialPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbb_SerialPort.SelectedIndexChanged
        If SerialPort.IsOpen = True Then
            SerialPort.Close()
            MsgBox("Disconnect.", (vbOKOnly + vbInformation), "Noti")
            btn_connect.Text = "Connect"
        End If
    End Sub
    Private Sub Cbb_SerialPort_DropDown(sender As Object, e As EventArgs) Handles Cbb_SerialPort.DropDown
        ' Show all available COM ports.
        Dim COMPortList As ArrayList = New ArrayList()
        COMPortList.Clear()
        COMPortList.AddRange(IO.Ports.SerialPort.GetPortNames)
        COMPortList.Sort()
        Cbb_SerialPort.DataSource = COMPortList
    End Sub

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

    Private Sub btn_quit_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
        End
    End Sub

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
End Class
