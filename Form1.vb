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
        Dim cnt As Integer
        Dim valBin_String As String = ""
        For cnt = 1 To 8
            valBin_String = Convert.ToString(checkBit((cnt - 1))) & valBin_String
        Next
        Return valBin_String
    End Function

    Function checkBit(numOfLed As Integer) As Integer
        Dim checkBitResult As Integer
        Select Case numOfLed
            Case 0
                If chb_bit0.Checked = True Then
                    shape_led0.BackColor = Color.Cyan
                    checkBitResult = 1
                Else
                    shape_led0.BackColor = Color.DarkGray
                    checkBitResult = 0
                End If
            Case 1
                If chb_bit1.Checked = True Then
                    shape_led1.BackColor = Color.Cyan
                    checkBitResult = 1
                Else
                    shape_led1.BackColor = Color.DarkGray
                    checkBitResult = 0
                End If
            Case 2
                If chb_bit2.Checked = True Then
                    shape_led2.BackColor = Color.Cyan
                    checkBitResult = 1
                Else
                    shape_led2.BackColor = Color.DarkGray
                    checkBitResult = 0
                End If
            Case 3
                If chb_bit3.Checked = True Then
                    shape_led3.BackColor = Color.Cyan
                    checkBitResult = 1
                Else
                    shape_led3.BackColor = Color.DarkGray
                    checkBitResult = 0
                End If
            Case 4
                If chb_bit4.Checked = True Then
                    shape_led4.BackColor = Color.Cyan
                    checkBitResult = 1
                Else
                    shape_led4.BackColor = Color.DarkGray
                    checkBitResult = 0
                End If
            Case 5
                If chb_bit5.Checked = True Then
                    shape_led5.BackColor = Color.Cyan
                    checkBitResult = 1
                Else
                    shape_led5.BackColor = Color.DarkGray
                    checkBitResult = 0
                End If
            Case 6
                If chb_bit6.Checked = True Then
                    shape_led6.BackColor = Color.Cyan
                    checkBitResult = 1
                Else
                    shape_led6.BackColor = Color.DarkGray
                    checkBitResult = 0
                End If
            Case 7
                If chb_bit7.Checked = True Then
                    shape_led7.BackColor = Color.Cyan
                    checkBitResult = 1
                Else
                    shape_led7.BackColor = Color.DarkGray
                    checkBitResult = 0
                End If
        End Select
        Return checkBitResult
    End Function
End Class
