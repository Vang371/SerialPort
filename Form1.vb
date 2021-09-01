Public Class Form1

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
        valBin_String = Convert.ToString(checkBit(chb_bit0, shape_led0, Color.Red, Color.Gray)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit1, shape_led1, Color.Red, Color.Gray)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit2, shape_led2, Color.Red, Color.Gray)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit3, shape_led3, Color.Red, Color.Gray)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit4, shape_led4, Color.Red, Color.Gray)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit5, shape_led5, Color.Red, Color.Gray)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit6, shape_led6, Color.Red, Color.Gray)) & valBin_String
        valBin_String = Convert.ToString(checkBit(chb_bit7, shape_led7, Color.Red, Color.Gray)) & valBin_String

        Return valBin_String
    End Function

    Function checkBit(bitCheck As CheckBox, shpCtrl As Microsoft.VisualBasic.PowerPacks.OvalShape, colorLedOn As Color, colorLedOff As Color) As Integer
        If bitCheck.Checked = True Then
            shpCtrl.BackColor = colorLedOn
            Return 1
        Else
            shpCtrl.BackColor = colorLedOff
            Return 0
        End If
    End Function
End Class
