Public Class Tarjetas
    Dim verifico2 As Boolean
    Dim dr2 As Odbc.OdbcDataReader
    Dim sql As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            
            ConexionODBC.Conectar()
            sql = "SELECT ci FROM particular"
            comando.Connection() = conexion
            comando.CommandText() = sql
            dr2 = comando.ExecuteReader()
            If dr2.HasRows Then
                verifico2 = True
            Else
                verifico2 = False

                If verifico2 = False Then

                    ConexionODBC.Conectar()

                    sql = "INSERT INTO tarjeta VALUES(numtar='" & Txt_numtarjeta.Text & "',pin='" & Txt_pin.Text & "',)"
                    comando.Connection() = conexion
                    comando.CommandText() = sql
                    comando.ExecuteNonQuery()
                    MsgBox("Tarjeta ingresada con exito")
                    ConexionODBC.cerrar()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error en alta Cuenta Bancaria")
            ConexionODBC.cerrar()
        End Try
    End Sub
End Class
