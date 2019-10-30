<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transferencia))
        Me.Button12 = New System.Windows.Forms.Button
        Me.Txt_operador_trans = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Txt_monto_trans = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txt_cuentadestino_trans = New System.Windows.Forms.TextBox
        Me.Txt_cuentaorigen_trans = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.Color.Transparent
        Me.Button12.Location = New System.Drawing.Point(13, 375)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(35, 32)
        Me.Button12.TabIndex = 12
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Txt_operador_trans
        '
        Me.Txt_operador_trans.Location = New System.Drawing.Point(71, 234)
        Me.Txt_operador_trans.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_operador_trans.Name = "Txt_operador_trans"
        Me.Txt_operador_trans.Size = New System.Drawing.Size(112, 20)
        Me.Txt_operador_trans.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(77, 217)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Operador"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"pesos", "dolares"})
        Me.ComboBox1.Location = New System.Drawing.Point(71, 169)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'Txt_monto_trans
        '
        Me.Txt_monto_trans.Location = New System.Drawing.Point(142, 169)
        Me.Txt_monto_trans.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_monto_trans.Name = "Txt_monto_trans"
        Me.Txt_monto_trans.Size = New System.Drawing.Size(75, 20)
        Me.Txt_monto_trans.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(84, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Monto a depositar"
        '
        'Txt_cuentadestino_trans
        '
        Me.Txt_cuentadestino_trans.Location = New System.Drawing.Point(246, 105)
        Me.Txt_cuentadestino_trans.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_cuentadestino_trans.Name = "Txt_cuentadestino_trans"
        Me.Txt_cuentadestino_trans.Size = New System.Drawing.Size(112, 20)
        Me.Txt_cuentadestino_trans.TabIndex = 19
        '
        'Txt_cuentaorigen_trans
        '
        Me.Txt_cuentaorigen_trans.Location = New System.Drawing.Point(71, 105)
        Me.Txt_cuentaorigen_trans.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Txt_cuentaorigen_trans.Name = "Txt_cuentaorigen_trans"
        Me.Txt_cuentaorigen_trans.Size = New System.Drawing.Size(112, 20)
        Me.Txt_cuentaorigen_trans.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(254, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Cuenta Destino"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(84, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Cuenta Origen"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(191, 230)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 27)
        Me.Button2.TabIndex = 47
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Transferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(422, 419)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Txt_operador_trans)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Txt_monto_trans)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_cuentadestino_trans)
        Me.Controls.Add(Me.Txt_cuentaorigen_trans)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button12)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Transferencia"
        Me.Text = "Transferencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Txt_operador_trans As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_monto_trans As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_cuentadestino_trans As System.Windows.Forms.TextBox
    Friend WithEvents Txt_cuentaorigen_trans As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
