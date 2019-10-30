Imports System.Threading.Thread
Imports System.Globalization
Public Class Login

    Dim dr As Odbc.OdbcDataReader
    Dim sql As String
    Dim verifico As Boolean
    Private Sub Txtnombrelog_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_nombrelog.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_login.Click

        If Txt_nombrelog.Text = "" Or Txt_conlog.Text = "" Then
            MsgBox("Campos obligatorios vacios")

        ElseIf Txt_nombrelog.Text = "cajero" And Txt_conlog.Text = "opcajero" Then
            Me.Hide()
            Menú_cajero.Show()
        ElseIf Txt_nombrelog.Text = "gerente" And Txt_conlog.Text = "opgerente" Then
            Me.Hide()
            Menú_gerente.Show()
        ElseIf Txt_nombrelog.Text = "transferencia" And Txt_conlog.Text = "optrans" Then
            Me.Hide()
            Transferencia.Show()
        Else
            Label2.Visible = True
            Label2.Text = "Tipo de Usuario erroneo, verifique datos y vuelva a intentar"
        End If
    End Sub

    Private Sub Btn_salir_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Visible = False
    End Sub

    Private Sub Btn_español_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_español.Click
        CurrentThread.CurrentUICulture = New CultureInfo("ES")
        Dim LoginEs As New Login
        LoginEs.Show()

        InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(0)

    End Sub

    Private Sub Btn_ingles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ingles.Click
        CurrentThread.CurrentUICulture = New CultureInfo("EN")
        Dim LoginEn As New Login
        LoginEn.Show()

        LoginEn.Label2.RightToLeft = Windows.Forms.RightToLeft.Yes
    End Sub
End Class
