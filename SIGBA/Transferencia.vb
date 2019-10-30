Public Class Transferencia
    Dim verifico2 As Boolean
    Dim dr2 As Odbc.OdbcDataReader
    Dim sql As String
    Dim trans As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Txt_cuentaorigen_trans.Text = "" Or Txt_cuentadestino_trans.Text = "" Or Txt_monto_trans.Text = "" Then
                MsgBox("Campos obligatorios vacios")

                ConexionODBC.Conectar()

                Txt_monto_trans.Text = trans
                comando.Connection() = conexion
                comando.CommandText() = sql
                comando.ExecuteNonQuery()
                sql = "UPDATE cuenta SET saldo=('" & Txt_monto_trans.Text & "') WHERE cuenta=('" & Txt_cuentadestino_trans.Text & "')"
                comando.Connection() = conexion
                comando.CommandText() = sql
                comando.ExecuteNonQuery()
                MsgBox("Transferencia realizada con exito")
                ConexionODBC.cerrar()

            End If

        Catch ex As Exception
            MsgBox("Error en transferencia")
            ConexionODBC.cerrar()
        End Try
    End Sub
    Private Sub Txt_cuentaorigen_trans_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_cuentaorigen_trans.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Txt_cuentadestino_trans_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_cuentadestino_trans.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Txt_monto_transKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_monto_trans.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Txt_operador_transKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_operador_trans.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
