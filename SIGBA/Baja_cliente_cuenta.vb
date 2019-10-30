Public Class Baja_cliente_cuenta
    Dim verifico2 As Boolean
    Dim dr2 As Odbc.OdbcDataReader
    Dim sql As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Txt_ci_rut.Text = "" Or Txt_idcuenta.Text = "" Then
            MsgBox("Campos obligatorios vacios")
        Else
            ConexionODBC.Conectar()

            sql = "DELETE FROM cuenta WHERE rut=" & Txt_ci_rut.Text & "',ci='" & Txt_ci_rut.Text & "',id_cuenta='" & Txt_idcuenta.Text & "',)"
            comando.Connection() = conexion
            comando.CommandText() = sql
            comando.ExecuteNonQuery()
            MsgBox("Cuenta borrada con exito")
            ConexionODBC.cerrar()
        End If
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Txt_nomcompleto.Text = "" Or Txt_docid.Text = "" Then
            MsgBox("Campos obligatorios vacios")
        Else
            ConexionODBC.Conectar()

            sql = "DELETE FROM particular WHERE ci=" & Txt_docid.Text & "',nombre='" & Txt_nomcompleto.Text & "',)"
            comando.Connection() = conexion
            comando.CommandText() = sql
            comando.ExecuteNonQuery()
            MsgBox("Cliente particular borrado con exito")
            ConexionODBC.cerrar()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Txt_rut.Text = "" Or Txt_nomempre.Text = "" Then
            MsgBox("Campos obligatorios vacios")
        Else
            ConexionODBC.Conectar()

            sql = "DELETE FROM empresa WHERE rut=" & Txt_rut.Text & "',nombre='" & Txt_nomempre.Text & "',)"
            comando.Connection() = conexion
            comando.CommandText() = sql
            comando.ExecuteNonQuery()
            MsgBox("Cliente empresa borrado con exito")
            ConexionODBC.cerrar()
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Hide()
    End Sub
End Class
