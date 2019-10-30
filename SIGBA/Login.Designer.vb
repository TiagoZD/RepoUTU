<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Btn_login = New System.Windows.Forms.Button
        Me.Txt_nombrelog = New System.Windows.Forms.TextBox
        Me.Txt_conlog = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Btn_ingles = New System.Windows.Forms.Button
        Me.Btn_español = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Btn_login
        '
        Me.Btn_login.BackgroundImage = CType(resources.GetObject("Btn_login.BackgroundImage"), System.Drawing.Image)
        Me.Btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_login.Location = New System.Drawing.Point(230, 286)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(339, 42)
        Me.Btn_login.TabIndex = 0
        Me.Btn_login.UseVisualStyleBackColor = True
        '
        'Txt_nombrelog
        '
        Me.Txt_nombrelog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_nombrelog.Location = New System.Drawing.Point(243, 186)
        Me.Txt_nombrelog.MaxLength = 15
        Me.Txt_nombrelog.Name = "Txt_nombrelog"
        Me.Txt_nombrelog.Size = New System.Drawing.Size(281, 13)
        Me.Txt_nombrelog.TabIndex = 1
        '
        'Txt_conlog
        '
        Me.Txt_conlog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_conlog.Location = New System.Drawing.Point(243, 244)
        Me.Txt_conlog.MaxLength = 12
        Me.Txt_conlog.Name = "Txt_conlog"
        Me.Txt_conlog.Size = New System.Drawing.Size(281, 13)
        Me.Txt_conlog.TabIndex = 2
        Me.Txt_conlog.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lenguaje"
        '
        'Btn_ingles
        '
        Me.Btn_ingles.BackColor = System.Drawing.Color.Transparent
        Me.Btn_ingles.BackgroundImage = CType(resources.GetObject("Btn_ingles.BackgroundImage"), System.Drawing.Image)
        Me.Btn_ingles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_ingles.FlatAppearance.BorderSize = 0
        Me.Btn_ingles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_ingles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_ingles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ingles.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_ingles.Location = New System.Drawing.Point(129, -5)
        Me.Btn_ingles.Name = "Btn_ingles"
        Me.Btn_ingles.Size = New System.Drawing.Size(58, 49)
        Me.Btn_ingles.TabIndex = 8
        Me.Btn_ingles.UseVisualStyleBackColor = False
        '
        'Btn_español
        '
        Me.Btn_español.BackColor = System.Drawing.Color.Transparent
        Me.Btn_español.BackgroundImage = CType(resources.GetObject("Btn_español.BackgroundImage"), System.Drawing.Image)
        Me.Btn_español.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_español.FlatAppearance.BorderSize = 0
        Me.Btn_español.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_español.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_español.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_español.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_español.Location = New System.Drawing.Point(81, -5)
        Me.Btn_español.Name = "Btn_español"
        Me.Btn_español.Size = New System.Drawing.Size(58, 49)
        Me.Btn_español.TabIndex = 9
        Me.Btn_español.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(254, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 10
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(802, 549)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_español)
        Me.Controls.Add(Me.Btn_ingles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_conlog)
        Me.Controls.Add(Me.Txt_nombrelog)
        Me.Controls.Add(Me.Btn_login)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "DataBank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_login As System.Windows.Forms.Button
    Friend WithEvents Txt_nombrelog As System.Windows.Forms.TextBox
    Friend WithEvents Txt_conlog As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_ingles As System.Windows.Forms.Button
    Friend WithEvents Btn_español As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
