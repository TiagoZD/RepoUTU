<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Depositar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Depositar))
        Me.Txt_cuentadeposito_cheque = New System.Windows.Forms.TextBox
        Me.Txt_cuentadeposito_efectivo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txt_bancodeposito_cheque = New System.Windows.Forms.TextBox
        Me.Txt_bancodeposito_efectivo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Txt_monto_cheque = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Txt_monto_efectivo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txt_fechadeposito_cheque = New System.Windows.Forms.TextBox
        Me.Txt_fechadeposito_efectivo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Txt_cuentadeposito_cheque
        '
        Me.Txt_cuentadeposito_cheque.Location = New System.Drawing.Point(341, 298)
        Me.Txt_cuentadeposito_cheque.Name = "Txt_cuentadeposito_cheque"
        Me.Txt_cuentadeposito_cheque.Size = New System.Drawing.Size(164, 20)
        Me.Txt_cuentadeposito_cheque.TabIndex = 55
        '
        'Txt_cuentadeposito_efectivo
        '
        Me.Txt_cuentadeposito_efectivo.Location = New System.Drawing.Point(75, 296)
        Me.Txt_cuentadeposito_efectivo.Name = "Txt_cuentadeposito_efectivo"
        Me.Txt_cuentadeposito_efectivo.Size = New System.Drawing.Size(164, 20)
        Me.Txt_cuentadeposito_efectivo.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(374, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Cuenta a depositar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(103, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Cuenta a depositar"
        '
        'Txt_bancodeposito_cheque
        '
        Me.Txt_bancodeposito_cheque.Location = New System.Drawing.Point(341, 239)
        Me.Txt_bancodeposito_cheque.Name = "Txt_bancodeposito_cheque"
        Me.Txt_bancodeposito_cheque.Size = New System.Drawing.Size(164, 20)
        Me.Txt_bancodeposito_cheque.TabIndex = 51
        '
        'Txt_bancodeposito_efectivo
        '
        Me.Txt_bancodeposito_efectivo.Location = New System.Drawing.Point(75, 237)
        Me.Txt_bancodeposito_efectivo.Name = "Txt_bancodeposito_efectivo"
        Me.Txt_bancodeposito_efectivo.Size = New System.Drawing.Size(164, 20)
        Me.Txt_bancodeposito_efectivo.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(374, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Banco a depositar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(103, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Banco a depositar"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(341, 183)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(59, 21)
        Me.ComboBox2.TabIndex = 47
        '
        'Txt_monto_cheque
        '
        Me.Txt_monto_cheque.Location = New System.Drawing.Point(407, 184)
        Me.Txt_monto_cheque.Name = "Txt_monto_cheque"
        Me.Txt_monto_cheque.Size = New System.Drawing.Size(97, 20)
        Me.Txt_monto_cheque.TabIndex = 46
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(75, 181)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(59, 21)
        Me.ComboBox1.TabIndex = 45
        '
        'Txt_monto_efectivo
        '
        Me.Txt_monto_efectivo.Location = New System.Drawing.Point(142, 182)
        Me.Txt_monto_efectivo.Name = "Txt_monto_efectivo"
        Me.Txt_monto_efectivo.Size = New System.Drawing.Size(97, 20)
        Me.Txt_monto_efectivo.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(374, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Monto a depositar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(103, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Monto a depositar"
        '
        'Txt_fechadeposito_cheque
        '
        Me.Txt_fechadeposito_cheque.Location = New System.Drawing.Point(341, 127)
        Me.Txt_fechadeposito_cheque.Name = "Txt_fechadeposito_cheque"
        Me.Txt_fechadeposito_cheque.Size = New System.Drawing.Size(164, 20)
        Me.Txt_fechadeposito_cheque.TabIndex = 41
        '
        'Txt_fechadeposito_efectivo
        '
        Me.Txt_fechadeposito_efectivo.Location = New System.Drawing.Point(75, 125)
        Me.Txt_fechadeposito_efectivo.Name = "Txt_fechadeposito_efectivo"
        Me.Txt_fechadeposito_efectivo.Size = New System.Drawing.Size(164, 20)
        Me.Txt_fechadeposito_efectivo.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(368, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Fecha del deposito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(103, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Fecha del deposito"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.Color.Transparent
        Me.Button12.Location = New System.Drawing.Point(11, 454)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(33, 30)
        Me.Button12.TabIndex = 77
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(208, 322)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 26)
        Me.Button1.TabIndex = 78
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(474, 322)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 26)
        Me.Button2.TabIndex = 79
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Depositar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(601, 496)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Txt_cuentadeposito_cheque)
        Me.Controls.Add(Me.Txt_cuentadeposito_efectivo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_bancodeposito_cheque)
        Me.Controls.Add(Me.Txt_bancodeposito_efectivo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Txt_monto_cheque)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Txt_monto_efectivo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_fechadeposito_cheque)
        Me.Controls.Add(Me.Txt_fechadeposito_efectivo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Depositar"
        Me.Text = "DataBank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_cuentadeposito_cheque As System.Windows.Forms.TextBox
    Friend WithEvents Txt_cuentadeposito_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_bancodeposito_cheque As System.Windows.Forms.TextBox
    Friend WithEvents Txt_bancodeposito_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_monto_cheque As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_monto_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_fechadeposito_cheque As System.Windows.Forms.TextBox
    Friend WithEvents Txt_fechadeposito_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
