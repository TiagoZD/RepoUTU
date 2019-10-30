Public Class Depositar
    Dim verifico2 As Boolean
    Dim dr2 As Odbc.OdbcDataReader
    Dim sql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Txt_fechadeposito_efectivo.Text = "" Or Txt_monto_efectivo.Text = "" Or Txt_bancodeposito_efectivo.Text = "" Or Txt_cuentadeposito_efectivo.Text = "" Then
                MsgBox("Campos obligatorios vacios")
            Else

                ConexionODBC.Conectar()

                sql = "UPDATE cuenta SET (fecha_i='" & Txt_fechadeposito_efectivo.Text & "',saldo='" & Txt_monto_efectivo.Text & "',id_cuenta='" & Txt_cuentadeposito_efectivo.Text & "',)"
                comando.Connection() = conexion
                comando.CommandText() = sql
                comando.ExecuteNonQuery()
                MsgBox("Deposito realizado con exito")
                ConexionODBC.cerrar()

            End If
        Catch ex As Exception
            MsgBox("Error en deposito")
            ConexionODBC.cerrar()
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Txt_fechadeposito_cheque.Text = "" Or Txt_monto_cheque.Text = "" Or Txt_bancodeposito_cheque.Text = "" Or Txt_cuentadeposito_cheque.Text = "" Then
                MsgBox("Campos obligatorios vacios")
            Else

                ConexionODBC.Conectar()

                sql = "UPDATE cuenta SET(fecha_i='" & Txt_fechadeposito_cheque.Text & "',saldo='" & Txt_monto_cheque.Text & "',id_cuenta='" & Txt_cuentadeposito_cheque.Text & "',)"
                comando.Connection() = conexion
                comando.CommandText() = sql
                comando.ExecuteNonQuery()
                MsgBox("Deposito realizado con exito")
                ConexionODBC.cerrar()

            End If
        Catch ex As Exception
            MsgBox("Error en deposito")
            ConexionODBC.cerrar()
        End Try
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Hide()
    End Sub
End Class