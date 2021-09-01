Public Class Form1
    Dim colorLedOn As Color = Color.Red
    Dim colorLedOff As Color = Color.Gray

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        TextBox1.Text = led2tbx()
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
        Dim valBin_String As String = ""
        valBin_String = Convert.ToString(checkBit(chb_bit0, shape_led0, colorLedOn, colorLedOff)) & valBin_String
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
