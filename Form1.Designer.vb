<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.chb_bit0 = New System.Windows.Forms.CheckBox()
        Me.chb_bit1 = New System.Windows.Forms.CheckBox()
        Me.chb_bit3 = New System.Windows.Forms.CheckBox()
        Me.chb_bit2 = New System.Windows.Forms.CheckBox()
        Me.chb_bit7 = New System.Windows.Forms.CheckBox()
        Me.chb_bit6 = New System.Windows.Forms.CheckBox()
        Me.chb_bit5 = New System.Windows.Forms.CheckBox()
        Me.chb_bit4 = New System.Windows.Forms.CheckBox()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_quit = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shape_led4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shape_led5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shape_led7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shape_led6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shape_led2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shape_led3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shape_led1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shape_led0 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'chb_bit0
        '
        Me.chb_bit0.AutoSize = True
        Me.chb_bit0.Location = New System.Drawing.Point(100, 150)
        Me.chb_bit0.Name = "chb_bit0"
        Me.chb_bit0.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit0.TabIndex = 0
        Me.chb_bit0.Text = "BIT 0"
        Me.chb_bit0.UseVisualStyleBackColor = True
        '
        'chb_bit1
        '
        Me.chb_bit1.AutoSize = True
        Me.chb_bit1.Location = New System.Drawing.Point(100, 177)
        Me.chb_bit1.Name = "chb_bit1"
        Me.chb_bit1.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit1.TabIndex = 1
        Me.chb_bit1.Text = "BIT 1"
        Me.chb_bit1.UseVisualStyleBackColor = True
        '
        'chb_bit3
        '
        Me.chb_bit3.AutoSize = True
        Me.chb_bit3.Location = New System.Drawing.Point(100, 231)
        Me.chb_bit3.Name = "chb_bit3"
        Me.chb_bit3.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit3.TabIndex = 3
        Me.chb_bit3.Text = "BIT 3"
        Me.chb_bit3.UseVisualStyleBackColor = True
        '
        'chb_bit2
        '
        Me.chb_bit2.AutoSize = True
        Me.chb_bit2.Location = New System.Drawing.Point(100, 204)
        Me.chb_bit2.Name = "chb_bit2"
        Me.chb_bit2.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit2.TabIndex = 2
        Me.chb_bit2.Text = "BIT 2"
        Me.chb_bit2.UseVisualStyleBackColor = True
        '
        'chb_bit7
        '
        Me.chb_bit7.AutoSize = True
        Me.chb_bit7.Location = New System.Drawing.Point(100, 339)
        Me.chb_bit7.Name = "chb_bit7"
        Me.chb_bit7.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit7.TabIndex = 7
        Me.chb_bit7.Text = "BIT 7"
        Me.chb_bit7.UseVisualStyleBackColor = True
        '
        'chb_bit6
        '
        Me.chb_bit6.AutoSize = True
        Me.chb_bit6.Location = New System.Drawing.Point(100, 312)
        Me.chb_bit6.Name = "chb_bit6"
        Me.chb_bit6.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit6.TabIndex = 6
        Me.chb_bit6.Text = "BIT 6"
        Me.chb_bit6.UseVisualStyleBackColor = True
        '
        'chb_bit5
        '
        Me.chb_bit5.AutoSize = True
        Me.chb_bit5.Location = New System.Drawing.Point(100, 285)
        Me.chb_bit5.Name = "chb_bit5"
        Me.chb_bit5.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit5.TabIndex = 5
        Me.chb_bit5.Text = "BIT 5"
        Me.chb_bit5.UseVisualStyleBackColor = True
        '
        'chb_bit4
        '
        Me.chb_bit4.AutoSize = True
        Me.chb_bit4.Location = New System.Drawing.Point(100, 258)
        Me.chb_bit4.Name = "chb_bit4"
        Me.chb_bit4.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit4.TabIndex = 4
        Me.chb_bit4.Text = "BIT 4"
        Me.chb_bit4.UseVisualStyleBackColor = True
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(271, 433)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(75, 23)
        Me.btn_send.TabIndex = 9
        Me.btn_send.Text = "Send"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(352, 433)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 10
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_quit
        '
        Me.btn_quit.Location = New System.Drawing.Point(433, 433)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(75, 23)
        Me.btn_quit.TabIndex = 11
        Me.btn_quit.Text = "Exit"
        Me.btn_quit.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shape_led4, Me.shape_led5, Me.shape_led7, Me.shape_led6, Me.shape_led2, Me.shape_led3, Me.shape_led1, Me.shape_led0})
        Me.ShapeContainer1.Size = New System.Drawing.Size(882, 553)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'shape_led4
        '
        Me.shape_led4.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led4.BorderColor = System.Drawing.Color.Black
        Me.shape_led4.FillColor = System.Drawing.Color.Gray
        Me.shape_led4.Location = New System.Drawing.Point(350, 150)
        Me.shape_led4.Name = "shape_led4"
        Me.shape_led4.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led5
        '
        Me.shape_led5.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led5.BorderColor = System.Drawing.Color.Black
        Me.shape_led5.FillColor = System.Drawing.Color.Gray
        Me.shape_led5.Location = New System.Drawing.Point(300, 150)
        Me.shape_led5.Name = "shape_led5"
        Me.shape_led5.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led7
        '
        Me.shape_led7.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led7.BorderColor = System.Drawing.Color.Black
        Me.shape_led7.FillColor = System.Drawing.Color.Gray
        Me.shape_led7.Location = New System.Drawing.Point(200, 150)
        Me.shape_led7.Name = "shape_led7"
        Me.shape_led7.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led6
        '
        Me.shape_led6.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led6.BorderColor = System.Drawing.Color.Black
        Me.shape_led6.FillColor = System.Drawing.Color.Gray
        Me.shape_led6.Location = New System.Drawing.Point(250, 150)
        Me.shape_led6.Name = "shape_led6"
        Me.shape_led6.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led2
        '
        Me.shape_led2.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led2.BorderColor = System.Drawing.Color.Black
        Me.shape_led2.FillColor = System.Drawing.Color.Gray
        Me.shape_led2.Location = New System.Drawing.Point(450, 150)
        Me.shape_led2.Name = "shape_led2"
        Me.shape_led2.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led3
        '
        Me.shape_led3.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led3.BorderColor = System.Drawing.Color.Black
        Me.shape_led3.FillColor = System.Drawing.Color.Gray
        Me.shape_led3.Location = New System.Drawing.Point(400, 150)
        Me.shape_led3.Name = "shape_led3"
        Me.shape_led3.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led1
        '
        Me.shape_led1.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led1.BorderColor = System.Drawing.Color.Black
        Me.shape_led1.FillColor = System.Drawing.Color.Gray
        Me.shape_led1.Location = New System.Drawing.Point(500, 150)
        Me.shape_led1.Name = "shape_led1"
        Me.shape_led1.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led0
        '
        Me.shape_led0.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led0.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led0.BorderColor = System.Drawing.Color.Black
        Me.shape_led0.FillColor = System.Drawing.Color.Gray
        Me.shape_led0.Location = New System.Drawing.Point(550, 150)
        Me.shape_led0.Name = "shape_led0"
        Me.shape_led0.Size = New System.Drawing.Size(35, 35)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(246, 272)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 553)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_quit)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.chb_bit7)
        Me.Controls.Add(Me.chb_bit6)
        Me.Controls.Add(Me.chb_bit5)
        Me.Controls.Add(Me.chb_bit4)
        Me.Controls.Add(Me.chb_bit3)
        Me.Controls.Add(Me.chb_bit2)
        Me.Controls.Add(Me.chb_bit1)
        Me.Controls.Add(Me.chb_bit0)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chb_bit0 As CheckBox
    Friend WithEvents chb_bit1 As CheckBox
    Friend WithEvents chb_bit3 As CheckBox
    Friend WithEvents chb_bit2 As CheckBox
    Friend WithEvents chb_bit7 As CheckBox
    Friend WithEvents chb_bit6 As CheckBox
    Friend WithEvents chb_bit5 As CheckBox
    Friend WithEvents chb_bit4 As CheckBox
    Friend WithEvents btn_send As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_quit As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents shape_led0 As PowerPacks.OvalShape
    Friend WithEvents shape_led4 As PowerPacks.OvalShape
    Friend WithEvents shape_led5 As PowerPacks.OvalShape
    Friend WithEvents shape_led7 As PowerPacks.OvalShape
    Friend WithEvents shape_led6 As PowerPacks.OvalShape
    Friend WithEvents shape_led2 As PowerPacks.OvalShape
    Friend WithEvents shape_led3 As PowerPacks.OvalShape
    Friend WithEvents shape_led1 As PowerPacks.OvalShape
    Friend WithEvents TextBox1 As TextBox
End Class
