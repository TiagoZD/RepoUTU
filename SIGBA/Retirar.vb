Public Class Retirar
    Dim verifico2 As Boolean
    Dim dr2 As Odbc.OdbcDataReader
    Dim sql As String
    Dim retiro As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Txt_numerocuenta_retiro.Text = "" Or Txt_cirut_retiro.Text = "" Or Txt_monto_retiro.Text = "" Then
                MsgBox("Campos obligatorios vacios")

                ConexionODBC.Conectar()

                sql = "SELECT saldo FROM cuenta WHERE cuenta=('" & Txt_numerocuenta_retiro.Text & "')"
                comando.Connection() = conexion
                comando.CommandText() = sql
                comando.ExecuteNonQuery()
                retiro = sql - Txt_monto_retiro.Text
                sql = "DELETE from saldo WHERE saldo='" & Txt_monto_retiro.Text & "')"
                comando.Connection() = conexion
                comando.CommandText() = sql
                comando.ExecuteNonQuery()
                MsgBox("Retiro realizado con exito")
                ConexionODBC.cerrar()

            End If

        Catch ex As Exception
            MsgBox("Error en retiro")
            ConexionODBC.cerrar()
        End Try
    End Sub
End Class
