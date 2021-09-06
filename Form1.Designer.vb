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
        Me.components = New System.ComponentModel.Container()
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
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Cbb_SerialPort = New System.Windows.Forms.ComboBox()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.tbx_binVal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'chb_bit0
        '
        Me.chb_bit0.AutoSize = True
        Me.chb_bit0.Location = New System.Drawing.Point(58, 131)
        Me.chb_bit0.Name = "chb_bit0"
        Me.chb_bit0.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit0.TabIndex = 0
        Me.chb_bit0.Text = "BIT 0"
        Me.chb_bit0.UseVisualStyleBackColor = True
        '
        'chb_bit1
        '
        Me.chb_bit1.AutoSize = True
        Me.chb_bit1.Location = New System.Drawing.Point(58, 158)
        Me.chb_bit1.Name = "chb_bit1"
        Me.chb_bit1.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit1.TabIndex = 1
        Me.chb_bit1.Text = "BIT 1"
        Me.chb_bit1.UseVisualStyleBackColor = True
        '
        'chb_bit3
        '
        Me.chb_bit3.AutoSize = True
        Me.chb_bit3.Location = New System.Drawing.Point(58, 212)
        Me.chb_bit3.Name = "chb_bit3"
        Me.chb_bit3.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit3.TabIndex = 3
        Me.chb_bit3.Text = "BIT 3"
        Me.chb_bit3.UseVisualStyleBackColor = True
        '
        'chb_bit2
        '
        Me.chb_bit2.AutoSize = True
        Me.chb_bit2.Location = New System.Drawing.Point(58, 185)
        Me.chb_bit2.Name = "chb_bit2"
        Me.chb_bit2.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit2.TabIndex = 2
        Me.chb_bit2.Text = "BIT 2"
        Me.chb_bit2.UseVisualStyleBackColor = True
        '
        'chb_bit7
        '
        Me.chb_bit7.AutoSize = True
        Me.chb_bit7.Location = New System.Drawing.Point(58, 320)
        Me.chb_bit7.Name = "chb_bit7"
        Me.chb_bit7.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit7.TabIndex = 7
        Me.chb_bit7.Text = "BIT 7"
        Me.chb_bit7.UseVisualStyleBackColor = True
        '
        'chb_bit6
        '
        Me.chb_bit6.AutoSize = True
        Me.chb_bit6.Location = New System.Drawing.Point(58, 293)
        Me.chb_bit6.Name = "chb_bit6"
        Me.chb_bit6.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit6.TabIndex = 6
        Me.chb_bit6.Text = "BIT 6"
        Me.chb_bit6.UseVisualStyleBackColor = True
        '
        'chb_bit5
        '
        Me.chb_bit5.AutoSize = True
        Me.chb_bit5.Location = New System.Drawing.Point(58, 266)
        Me.chb_bit5.Name = "chb_bit5"
        Me.chb_bit5.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit5.TabIndex = 5
        Me.chb_bit5.Text = "BIT 5"
        Me.chb_bit5.UseVisualStyleBackColor = True
        '
        'chb_bit4
        '
        Me.chb_bit4.AutoSize = True
        Me.chb_bit4.Location = New System.Drawing.Point(58, 239)
        Me.chb_bit4.Name = "chb_bit4"
        Me.chb_bit4.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit4.TabIndex = 4
        Me.chb_bit4.Text = "BIT 4"
        Me.chb_bit4.UseVisualStyleBackColor = True
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(226, 383)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(75, 23)
        Me.btn_send.TabIndex = 9
        Me.btn_send.Text = "Send"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(307, 383)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 10
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_quit
        '
        Me.btn_quit.Location = New System.Drawing.Point(388, 383)
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
        Me.shape_led4.Location = New System.Drawing.Point(357, 120)
        Me.shape_led4.Name = "shape_led4"
        Me.shape_led4.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led5
        '
        Me.shape_led5.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led5.BorderColor = System.Drawing.Color.Black
        Me.shape_led5.FillColor = System.Drawing.Color.Gray
        Me.shape_led5.Location = New System.Drawing.Point(307, 120)
        Me.shape_led5.Name = "shape_led5"
        Me.shape_led5.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led7
        '
        Me.shape_led7.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led7.BorderColor = System.Drawing.Color.Black
        Me.shape_led7.FillColor = System.Drawing.Color.Gray
        Me.shape_led7.Location = New System.Drawing.Point(207, 120)
        Me.shape_led7.Name = "shape_led7"
        Me.shape_led7.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led6
        '
        Me.shape_led6.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led6.BorderColor = System.Drawing.Color.Black
        Me.shape_led6.FillColor = System.Drawing.Color.Gray
        Me.shape_led6.Location = New System.Drawing.Point(257, 120)
        Me.shape_led6.Name = "shape_led6"
        Me.shape_led6.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led2
        '
        Me.shape_led2.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led2.BorderColor = System.Drawing.Color.Black
        Me.shape_led2.FillColor = System.Drawing.Color.Gray
        Me.shape_led2.Location = New System.Drawing.Point(457, 120)
        Me.shape_led2.Name = "shape_led2"
        Me.shape_led2.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led3
        '
        Me.shape_led3.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led3.BorderColor = System.Drawing.Color.Black
        Me.shape_led3.FillColor = System.Drawing.Color.Gray
        Me.shape_led3.Location = New System.Drawing.Point(407, 120)
        Me.shape_led3.Name = "shape_led3"
        Me.shape_led3.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led1
        '
        Me.shape_led1.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led1.BorderColor = System.Drawing.Color.Black
        Me.shape_led1.FillColor = System.Drawing.Color.Gray
        Me.shape_led1.Location = New System.Drawing.Point(507, 120)
        Me.shape_led1.Name = "shape_led1"
        Me.shape_led1.Size = New System.Drawing.Size(35, 35)
        '
        'shape_led0
        '
        Me.shape_led0.BackColor = System.Drawing.SystemColors.GrayText
        Me.shape_led0.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shape_led0.BorderColor = System.Drawing.Color.Black
        Me.shape_led0.FillColor = System.Drawing.Color.Gray
        Me.shape_led0.Location = New System.Drawing.Point(557, 120)
        Me.shape_led0.Name = "shape_led0"
        Me.shape_led0.Size = New System.Drawing.Size(35, 35)
        '
        'SerialPort
        '
        Me.SerialPort.PortName = "COM"
        '
        'Cbb_SerialPort
        '
        Me.Cbb_SerialPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbb_SerialPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbb_SerialPort.DropDownHeight = 120
        Me.Cbb_SerialPort.FormattingEnabled = True
        Me.Cbb_SerialPort.IntegralHeight = False
        Me.Cbb_SerialPort.Location = New System.Drawing.Point(643, 43)
        Me.Cbb_SerialPort.Name = "Cbb_SerialPort"
        Me.Cbb_SerialPort.Size = New System.Drawing.Size(100, 24)
        Me.Cbb_SerialPort.TabIndex = 16
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(749, 43)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(96, 23)
        Me.btn_connect.TabIndex = 14
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'tbx_binVal
        '
        Me.tbx_binVal.Location = New System.Drawing.Point(226, 212)
        Me.tbx_binVal.Name = "tbx_binVal"
        Me.tbx_binVal.Size = New System.Drawing.Size(100, 22)
        Me.tbx_binVal.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 553)
        Me.Controls.Add(Me.tbx_binVal)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.Cbb_SerialPort)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents Cbb_SerialPort As ComboBox
    Friend WithEvents btn_connect As Button
    Friend WithEvents tbx_binVal As TextBox
End Class
