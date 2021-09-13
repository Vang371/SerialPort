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
        Me.btn_send = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_quit = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shp_led4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.shp_led0 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Cbb_SerialPort = New System.Windows.Forms.ComboBox()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.tbx_binVal = New System.Windows.Forms.TextBox()
        Me.chb_bit0 = New System.Windows.Forms.CheckBox()
        Me.chb_bit1 = New System.Windows.Forms.CheckBox()
        Me.chb_bit2 = New System.Windows.Forms.CheckBox()
        Me.chb_bit3 = New System.Windows.Forms.CheckBox()
        Me.chb_bit4 = New System.Windows.Forms.CheckBox()
        Me.chb_bit5 = New System.Windows.Forms.CheckBox()
        Me.chb_bit6 = New System.Windows.Forms.CheckBox()
        Me.chb_bit7 = New System.Windows.Forms.CheckBox()
        Me.btn_effect = New System.Windows.Forms.Button()
        Me.tbx_ascii = New System.Windows.Forms.TextBox()
        Me.tbx_octVal = New System.Windows.Forms.TextBox()
        Me.tbx_decVal = New System.Windows.Forms.TextBox()
        Me.tbx_hexVal = New System.Windows.Forms.TextBox()
        Me.timer_1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbb_effect = New System.Windows.Forms.ComboBox()
        Me.tbx_timeLed = New System.Windows.Forms.TextBox()
        Me.lb_binVal = New System.Windows.Forms.Label()
        Me.lb_hexVal = New System.Windows.Forms.Label()
        Me.lb_decVal = New System.Windows.Forms.Label()
        Me.lb_octVal = New System.Windows.Forms.Label()
        Me.lb_ascii = New System.Windows.Forms.Label()
        Me.lb_progName = New System.Windows.Forms.Label()
        Me.lb_myName = New System.Windows.Forms.Label()
        Me.lb_effect = New System.Windows.Forms.Label()
        Me.tb_delayTime = New System.Windows.Forms.Label()
        Me.lb_led0 = New System.Windows.Forms.Label()
        Me.lb_led7 = New System.Windows.Forms.Label()
        Me.lb_led6 = New System.Windows.Forms.Label()
        Me.lb_led5 = New System.Windows.Forms.Label()
        Me.lb_led4 = New System.Windows.Forms.Label()
        Me.lb_led3 = New System.Windows.Forms.Label()
        Me.lb_led2 = New System.Windows.Forms.Label()
        Me.lb_led1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_send
        '
        Me.btn_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_send.Location = New System.Drawing.Point(165, 420)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(75, 29)
        Me.btn_send.TabIndex = 9
        Me.btn_send.Text = "Send"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(246, 420)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 29)
        Me.btn_clear.TabIndex = 10
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_quit
        '
        Me.btn_quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quit.Location = New System.Drawing.Point(767, 490)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(75, 30)
        Me.btn_quit.TabIndex = 11
        Me.btn_quit.Text = "Exit"
        Me.btn_quit.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shp_led4, Me.shp_led5, Me.shp_led7, Me.shp_led6, Me.shp_led2, Me.shp_led3, Me.shp_led1, Me.shp_led0})
        Me.ShapeContainer1.Size = New System.Drawing.Size(882, 553)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'shp_led4
        '
        Me.shp_led4.BackColor = System.Drawing.SystemColors.GrayText
        Me.shp_led4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shp_led4.BorderColor = System.Drawing.Color.Black
        Me.shp_led4.FillColor = System.Drawing.Color.Gray
        Me.shp_led4.FillGradientColor = System.Drawing.Color.Gray
        Me.shp_led4.Location = New System.Drawing.Point(560, 210)
        Me.shp_led4.Name = "shp_led4"
        Me.shp_led4.Size = New System.Drawing.Size(35, 35)
        '
        'shp_led5
        '
        Me.shp_led5.BackColor = System.Drawing.SystemColors.GrayText
        Me.shp_led5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shp_led5.BorderColor = System.Drawing.Color.Black
        Me.shp_led5.FillColor = System.Drawing.Color.Gray
        Me.shp_led5.FillGradientColor = System.Drawing.Color.Gray
        Me.shp_led5.Location = New System.Drawing.Point(500, 210)
        Me.shp_led5.Name = "shp_led5"
        Me.shp_led5.Size = New System.Drawing.Size(35, 35)
        '
        'shp_led7
        '
        Me.shp_led7.BackColor = System.Drawing.SystemColors.GrayText
        Me.shp_led7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shp_led7.BorderColor = System.Drawing.Color.Black
        Me.shp_led7.FillColor = System.Drawing.Color.Gray
        Me.shp_led7.FillGradientColor = System.Drawing.Color.Gray
        Me.shp_led7.Location = New System.Drawing.Point(380, 210)
        Me.shp_led7.Name = "shp_led7"
        Me.shp_led7.Size = New System.Drawing.Size(35, 35)
        '
        'shp_led6
        '
        Me.shp_led6.BackColor = System.Drawing.SystemColors.GrayText
        Me.shp_led6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shp_led6.BorderColor = System.Drawing.Color.Black
        Me.shp_led6.FillColor = System.Drawing.Color.Gray
        Me.shp_led6.FillGradientColor = System.Drawing.Color.Gray
        Me.shp_led6.Location = New System.Drawing.Point(440, 210)
        Me.shp_led6.Name = "shp_led6"
        Me.shp_led6.Size = New System.Drawing.Size(35, 35)
        '
        'shp_led2
        '
        Me.shp_led2.BackColor = System.Drawing.SystemColors.GrayText
        Me.shp_led2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shp_led2.BorderColor = System.Drawing.Color.Black
        Me.shp_led2.FillColor = System.Drawing.Color.Gray
        Me.shp_led2.FillGradientColor = System.Drawing.Color.Gray
        Me.shp_led2.Location = New System.Drawing.Point(680, 210)
        Me.shp_led2.Name = "shp_led2"
        Me.shp_led2.Size = New System.Drawing.Size(35, 35)
        '
        'shp_led3
        '
        Me.shp_led3.BackColor = System.Drawing.SystemColors.GrayText
        Me.shp_led3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shp_led3.BorderColor = System.Drawing.Color.Black
        Me.shp_led3.FillColor = System.Drawing.Color.Gray
        Me.shp_led3.FillGradientColor = System.Drawing.Color.Gray
        Me.shp_led3.Location = New System.Drawing.Point(620, 210)
        Me.shp_led3.Name = "shp_led3"
        Me.shp_led3.Size = New System.Drawing.Size(35, 35)
        '
        'shp_led1
        '
        Me.shp_led1.BackColor = System.Drawing.SystemColors.GrayText
        Me.shp_led1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shp_led1.BorderColor = System.Drawing.Color.Black
        Me.shp_led1.FillColor = System.Drawing.Color.Gray
        Me.shp_led1.FillGradientColor = System.Drawing.Color.Gray
        Me.shp_led1.Location = New System.Drawing.Point(740, 210)
        Me.shp_led1.Name = "shp_led1"
        Me.shp_led1.Size = New System.Drawing.Size(35, 35)
        '
        'shp_led0
        '
        Me.shp_led0.BackColor = System.Drawing.SystemColors.GrayText
        Me.shp_led0.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.shp_led0.BorderColor = System.Drawing.Color.Black
        Me.shp_led0.FillColor = System.Drawing.Color.Gray
        Me.shp_led0.FillGradientColor = System.Drawing.Color.Gray
        Me.shp_led0.Location = New System.Drawing.Point(800, 210)
        Me.shp_led0.Name = "shp_led0"
        Me.shp_led0.Size = New System.Drawing.Size(35, 35)
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
        Me.Cbb_SerialPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbb_SerialPort.FormattingEnabled = True
        Me.Cbb_SerialPort.IntegralHeight = False
        Me.Cbb_SerialPort.Location = New System.Drawing.Point(640, 114)
        Me.Cbb_SerialPort.Name = "Cbb_SerialPort"
        Me.Cbb_SerialPort.Size = New System.Drawing.Size(100, 26)
        Me.Cbb_SerialPort.TabIndex = 16
        '
        'btn_connect
        '
        Me.btn_connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connect.Location = New System.Drawing.Point(746, 111)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(96, 29)
        Me.btn_connect.TabIndex = 14
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'tbx_binVal
        '
        Me.tbx_binVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_binVal.Location = New System.Drawing.Point(213, 157)
        Me.tbx_binVal.Name = "tbx_binVal"
        Me.tbx_binVal.Size = New System.Drawing.Size(100, 24)
        Me.tbx_binVal.TabIndex = 17
        Me.tbx_binVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chb_bit0
        '
        Me.chb_bit0.AutoSize = True
        Me.chb_bit0.Location = New System.Drawing.Point(55, 157)
        Me.chb_bit0.Name = "chb_bit0"
        Me.chb_bit0.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit0.TabIndex = 0
        Me.chb_bit0.Text = "BIT 0"
        Me.chb_bit0.UseVisualStyleBackColor = True
        '
        'chb_bit1
        '
        Me.chb_bit1.AutoSize = True
        Me.chb_bit1.Location = New System.Drawing.Point(55, 184)
        Me.chb_bit1.Name = "chb_bit1"
        Me.chb_bit1.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit1.TabIndex = 1
        Me.chb_bit1.Text = "BIT 1"
        Me.chb_bit1.UseVisualStyleBackColor = True
        '
        'chb_bit2
        '
        Me.chb_bit2.AutoSize = True
        Me.chb_bit2.Location = New System.Drawing.Point(55, 211)
        Me.chb_bit2.Name = "chb_bit2"
        Me.chb_bit2.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit2.TabIndex = 2
        Me.chb_bit2.Text = "BIT 2"
        Me.chb_bit2.UseVisualStyleBackColor = True
        '
        'chb_bit3
        '
        Me.chb_bit3.AutoSize = True
        Me.chb_bit3.Location = New System.Drawing.Point(55, 238)
        Me.chb_bit3.Name = "chb_bit3"
        Me.chb_bit3.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit3.TabIndex = 3
        Me.chb_bit3.Text = "BIT 3"
        Me.chb_bit3.UseVisualStyleBackColor = True
        '
        'chb_bit4
        '
        Me.chb_bit4.AutoSize = True
        Me.chb_bit4.Location = New System.Drawing.Point(55, 265)
        Me.chb_bit4.Name = "chb_bit4"
        Me.chb_bit4.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit4.TabIndex = 4
        Me.chb_bit4.Text = "BIT 4"
        Me.chb_bit4.UseVisualStyleBackColor = True
        '
        'chb_bit5
        '
        Me.chb_bit5.AutoSize = True
        Me.chb_bit5.Location = New System.Drawing.Point(55, 292)
        Me.chb_bit5.Name = "chb_bit5"
        Me.chb_bit5.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit5.TabIndex = 5
        Me.chb_bit5.Text = "BIT 5"
        Me.chb_bit5.UseVisualStyleBackColor = True
        '
        'chb_bit6
        '
        Me.chb_bit6.AutoSize = True
        Me.chb_bit6.Location = New System.Drawing.Point(55, 319)
        Me.chb_bit6.Name = "chb_bit6"
        Me.chb_bit6.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit6.TabIndex = 6
        Me.chb_bit6.Text = "BIT 6"
        Me.chb_bit6.UseVisualStyleBackColor = True
        '
        'chb_bit7
        '
        Me.chb_bit7.AutoSize = True
        Me.chb_bit7.Location = New System.Drawing.Point(55, 346)
        Me.chb_bit7.Name = "chb_bit7"
        Me.chb_bit7.Size = New System.Drawing.Size(63, 21)
        Me.chb_bit7.TabIndex = 7
        Me.chb_bit7.Text = "BIT 7"
        Me.chb_bit7.UseVisualStyleBackColor = True
        '
        'btn_effect
        '
        Me.btn_effect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_effect.Location = New System.Drawing.Point(390, 420)
        Me.btn_effect.Name = "btn_effect"
        Me.btn_effect.Size = New System.Drawing.Size(98, 29)
        Me.btn_effect.TabIndex = 18
        Me.btn_effect.Text = "Run effect"
        Me.btn_effect.UseVisualStyleBackColor = True
        '
        'tbx_ascii
        '
        Me.tbx_ascii.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ascii.Location = New System.Drawing.Point(213, 291)
        Me.tbx_ascii.Name = "tbx_ascii"
        Me.tbx_ascii.Size = New System.Drawing.Size(100, 24)
        Me.tbx_ascii.TabIndex = 19
        Me.tbx_ascii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbx_octVal
        '
        Me.tbx_octVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_octVal.Location = New System.Drawing.Point(213, 256)
        Me.tbx_octVal.Name = "tbx_octVal"
        Me.tbx_octVal.Size = New System.Drawing.Size(100, 24)
        Me.tbx_octVal.TabIndex = 20
        Me.tbx_octVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbx_decVal
        '
        Me.tbx_decVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_decVal.Location = New System.Drawing.Point(213, 223)
        Me.tbx_decVal.Name = "tbx_decVal"
        Me.tbx_decVal.Size = New System.Drawing.Size(100, 24)
        Me.tbx_decVal.TabIndex = 21
        Me.tbx_decVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbx_hexVal
        '
        Me.tbx_hexVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_hexVal.Location = New System.Drawing.Point(213, 190)
        Me.tbx_hexVal.Name = "tbx_hexVal"
        Me.tbx_hexVal.Size = New System.Drawing.Size(100, 24)
        Me.tbx_hexVal.TabIndex = 22
        Me.tbx_hexVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'timer_1
        '
        '
        'cbb_effect
        '
        Me.cbb_effect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_effect.FormattingEnabled = True
        Me.cbb_effect.Items.AddRange(New Object() {"Chasing right", "Chasing left"})
        Me.cbb_effect.Location = New System.Drawing.Point(463, 338)
        Me.cbb_effect.Name = "cbb_effect"
        Me.cbb_effect.Size = New System.Drawing.Size(121, 26)
        Me.cbb_effect.TabIndex = 23
        Me.cbb_effect.Tag = ""
        Me.cbb_effect.Text = "Chasing right"
        '
        'tbx_timeLed
        '
        Me.tbx_timeLed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_timeLed.Location = New System.Drawing.Point(687, 338)
        Me.tbx_timeLed.Name = "tbx_timeLed"
        Me.tbx_timeLed.Size = New System.Drawing.Size(100, 24)
        Me.tbx_timeLed.TabIndex = 24
        Me.tbx_timeLed.Text = "500"
        '
        'lb_binVal
        '
        Me.lb_binVal.AutoSize = True
        Me.lb_binVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_binVal.Location = New System.Drawing.Point(144, 159)
        Me.lb_binVal.Name = "lb_binVal"
        Me.lb_binVal.Size = New System.Drawing.Size(49, 20)
        Me.lb_binVal.TabIndex = 25
        Me.lb_binVal.Text = "Bin :"
        '
        'lb_hexVal
        '
        Me.lb_hexVal.AutoSize = True
        Me.lb_hexVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_hexVal.Location = New System.Drawing.Point(144, 192)
        Me.lb_hexVal.Name = "lb_hexVal"
        Me.lb_hexVal.Size = New System.Drawing.Size(54, 20)
        Me.lb_hexVal.TabIndex = 26
        Me.lb_hexVal.Text = "Hex :"
        '
        'lb_decVal
        '
        Me.lb_decVal.AutoSize = True
        Me.lb_decVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_decVal.Location = New System.Drawing.Point(144, 225)
        Me.lb_decVal.Name = "lb_decVal"
        Me.lb_decVal.Size = New System.Drawing.Size(55, 20)
        Me.lb_decVal.TabIndex = 27
        Me.lb_decVal.Text = "Dec :"
        '
        'lb_octVal
        '
        Me.lb_octVal.AutoSize = True
        Me.lb_octVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_octVal.Location = New System.Drawing.Point(144, 258)
        Me.lb_octVal.Name = "lb_octVal"
        Me.lb_octVal.Size = New System.Drawing.Size(51, 20)
        Me.lb_octVal.TabIndex = 28
        Me.lb_octVal.Text = "Oct :"
        '
        'lb_ascii
        '
        Me.lb_ascii.AutoSize = True
        Me.lb_ascii.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ascii.Location = New System.Drawing.Point(144, 291)
        Me.lb_ascii.Name = "lb_ascii"
        Me.lb_ascii.Size = New System.Drawing.Size(63, 20)
        Me.lb_ascii.TabIndex = 29
        Me.lb_ascii.Text = "Ascii :"
        '
        'lb_progName
        '
        Me.lb_progName.AutoSize = True
        Me.lb_progName.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_progName.Location = New System.Drawing.Point(300, 50)
        Me.lb_progName.Name = "lb_progName"
        Me.lb_progName.Size = New System.Drawing.Size(384, 24)
        Me.lb_progName.TabIndex = 30
        Me.lb_progName.Text = "TEST SERIAL PORT"
        '
        'lb_myName
        '
        Me.lb_myName.AutoSize = True
        Me.lb_myName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_myName.Location = New System.Drawing.Point(12, 521)
        Me.lb_myName.Name = "lb_myName"
        Me.lb_myName.Size = New System.Drawing.Size(238, 23)
        Me.lb_myName.TabIndex = 31
        Me.lb_myName.Text = "Dương Gia Bảo - 18048681"
        '
        'lb_effect
        '
        Me.lb_effect.AutoSize = True
        Me.lb_effect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_effect.Location = New System.Drawing.Point(386, 340)
        Me.lb_effect.Name = "lb_effect"
        Me.lb_effect.Size = New System.Drawing.Size(71, 20)
        Me.lb_effect.TabIndex = 32
        Me.lb_effect.Text = "Effect :"
        '
        'tb_delayTime
        '
        Me.tb_delayTime.AutoSize = True
        Me.tb_delayTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_delayTime.Location = New System.Drawing.Point(612, 340)
        Me.tb_delayTime.Name = "tb_delayTime"
        Me.tb_delayTime.Size = New System.Drawing.Size(69, 20)
        Me.tb_delayTime.TabIndex = 33
        Me.tb_delayTime.Text = "Delay :"
        '
        'lb_led0
        '
        Me.lb_led0.AutoSize = True
        Me.lb_led0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led0.Location = New System.Drawing.Point(794, 173)
        Me.lb_led0.Name = "lb_led0"
        Me.lb_led0.Size = New System.Drawing.Size(49, 18)
        Me.lb_led0.TabIndex = 34
        Me.lb_led0.Text = "Led 1"
        '
        'lb_led7
        '
        Me.lb_led7.AutoSize = True
        Me.lb_led7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led7.Location = New System.Drawing.Point(374, 173)
        Me.lb_led7.Name = "lb_led7"
        Me.lb_led7.Size = New System.Drawing.Size(49, 18)
        Me.lb_led7.TabIndex = 35
        Me.lb_led7.Text = "Led 8"
        '
        'lb_led6
        '
        Me.lb_led6.AutoSize = True
        Me.lb_led6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led6.Location = New System.Drawing.Point(434, 173)
        Me.lb_led6.Name = "lb_led6"
        Me.lb_led6.Size = New System.Drawing.Size(49, 18)
        Me.lb_led6.TabIndex = 36
        Me.lb_led6.Text = "Led 7"
        '
        'lb_led5
        '
        Me.lb_led5.AutoSize = True
        Me.lb_led5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led5.Location = New System.Drawing.Point(494, 173)
        Me.lb_led5.Name = "lb_led5"
        Me.lb_led5.Size = New System.Drawing.Size(49, 18)
        Me.lb_led5.TabIndex = 37
        Me.lb_led5.Text = "Led 6"
        '
        'lb_led4
        '
        Me.lb_led4.AutoSize = True
        Me.lb_led4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led4.Location = New System.Drawing.Point(554, 173)
        Me.lb_led4.Name = "lb_led4"
        Me.lb_led4.Size = New System.Drawing.Size(49, 18)
        Me.lb_led4.TabIndex = 38
        Me.lb_led4.Text = "Led 5"
        '
        'lb_led3
        '
        Me.lb_led3.AutoSize = True
        Me.lb_led3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led3.Location = New System.Drawing.Point(614, 173)
        Me.lb_led3.Name = "lb_led3"
        Me.lb_led3.Size = New System.Drawing.Size(49, 18)
        Me.lb_led3.TabIndex = 39
        Me.lb_led3.Text = "Led 4"
        '
        'lb_led2
        '
        Me.lb_led2.AutoSize = True
        Me.lb_led2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led2.Location = New System.Drawing.Point(674, 173)
        Me.lb_led2.Name = "lb_led2"
        Me.lb_led2.Size = New System.Drawing.Size(49, 18)
        Me.lb_led2.TabIndex = 40
        Me.lb_led2.Text = "Led 3"
        '
        'lb_led1
        '
        Me.lb_led1.AutoSize = True
        Me.lb_led1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_led1.Location = New System.Drawing.Point(734, 173)
        Me.lb_led1.Name = "lb_led1"
        Me.lb_led1.Size = New System.Drawing.Size(49, 18)
        Me.lb_led1.TabIndex = 41
        Me.lb_led1.Text = "Led 2"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(882, 553)
        Me.Controls.Add(Me.lb_led1)
        Me.Controls.Add(Me.lb_led2)
        Me.Controls.Add(Me.lb_led3)
        Me.Controls.Add(Me.lb_led4)
        Me.Controls.Add(Me.lb_led5)
        Me.Controls.Add(Me.lb_led6)
        Me.Controls.Add(Me.lb_led7)
        Me.Controls.Add(Me.lb_led0)
        Me.Controls.Add(Me.tb_delayTime)
        Me.Controls.Add(Me.lb_effect)
        Me.Controls.Add(Me.lb_myName)
        Me.Controls.Add(Me.lb_progName)
        Me.Controls.Add(Me.lb_ascii)
        Me.Controls.Add(Me.lb_octVal)
        Me.Controls.Add(Me.lb_decVal)
        Me.Controls.Add(Me.lb_hexVal)
        Me.Controls.Add(Me.lb_binVal)
        Me.Controls.Add(Me.tbx_timeLed)
        Me.Controls.Add(Me.cbb_effect)
        Me.Controls.Add(Me.tbx_hexVal)
        Me.Controls.Add(Me.tbx_decVal)
        Me.Controls.Add(Me.tbx_octVal)
        Me.Controls.Add(Me.tbx_ascii)
        Me.Controls.Add(Me.btn_effect)
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
        Me.ShowIcon = False
        Me.Text = "Test serial port"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_send As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_quit As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents shp_led0 As PowerPacks.OvalShape
    Friend WithEvents shp_led4 As PowerPacks.OvalShape
    Friend WithEvents shp_led5 As PowerPacks.OvalShape
    Friend WithEvents shp_led7 As PowerPacks.OvalShape
    Friend WithEvents shp_led6 As PowerPacks.OvalShape
    Friend WithEvents shp_led2 As PowerPacks.OvalShape
    Friend WithEvents shp_led3 As PowerPacks.OvalShape
    Friend WithEvents shp_led1 As PowerPacks.OvalShape
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents Cbb_SerialPort As ComboBox
    Friend WithEvents btn_connect As Button
    Friend WithEvents tbx_binVal As TextBox
    Friend WithEvents chb_bit0 As CheckBox
    Friend WithEvents chb_bit1 As CheckBox
    Friend WithEvents chb_bit2 As CheckBox
    Friend WithEvents chb_bit3 As CheckBox
    Friend WithEvents chb_bit4 As CheckBox
    Friend WithEvents chb_bit5 As CheckBox
    Friend WithEvents chb_bit6 As CheckBox
    Friend WithEvents chb_bit7 As CheckBox
    Friend WithEvents btn_effect As Button
    Friend WithEvents tbx_ascii As TextBox
    Friend WithEvents tbx_octVal As TextBox
    Friend WithEvents tbx_decVal As TextBox
    Friend WithEvents tbx_hexVal As TextBox
    Friend WithEvents timer_1 As Timer
    Friend WithEvents cbb_effect As ComboBox
    Friend WithEvents tbx_timeLed As TextBox
    Friend WithEvents lb_binVal As Label
    Friend WithEvents lb_hexVal As Label
    Friend WithEvents lb_decVal As Label
    Friend WithEvents lb_octVal As Label
    Friend WithEvents lb_ascii As Label
    Friend WithEvents lb_progName As Label
    Friend WithEvents lb_myName As Label
    Friend WithEvents lb_effect As Label
    Friend WithEvents tb_delayTime As Label
    Friend WithEvents lb_led0 As Label
    Friend WithEvents lb_led7 As Label
    Friend WithEvents lb_led6 As Label
    Friend WithEvents lb_led5 As Label
    Friend WithEvents lb_led4 As Label
    Friend WithEvents lb_led3 As Label
    Friend WithEvents lb_led2 As Label
    Friend WithEvents lb_led1 As Label
End Class
