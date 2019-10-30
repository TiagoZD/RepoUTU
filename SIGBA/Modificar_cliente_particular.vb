Public Class Modificar_cliente_particular
    Dim verifico2 As Boolean
    Dim dr2 As Odbc.OdbcDataReader
    Dim sql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Txt_ci_clienteparticular.Text = "" Then
                MsgBox("Campos obligatorios vacios")
            Else
                ConexionODBC.Conectar()
                sql = "SELECT id_cliente FROM cliente"
                comando.Connection() = conexion
                comando.CommandText() = sql
                dr2 = comando.ExecuteReader()
                If dr2.HasRows Then
                    verifico2 = True
                Else
                    verifico2 = False

                    If verifico2 = False Then
                        Txt_nombrecompleto_cliente.ReadOnly = False
                        Txt_domicilio_cliente.ReadOnly = False
                        Txt_tel_cliente.ReadOnly = False

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Cliente no existente en el sistema")
            ConexionODBC.cerrar()
        End Try
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            ConexionODBC.Conectar()

            sql = "UPDATE particular SET ci='" & Txt_cinuevo_cliente.Text & "',apellido='" & Txt_nombrecompleto_cliente.Text & "',calle='" & Txt_domicilio_cliente.Text & "',)"
            sql = "UPDATE particular SET telefono('" & Txt_tel_cliente.Text & "')"
            comando.Connection() = conexion
            comando.CommandText() = sql
            comando.ExecuteReader()
            MsgBox("Cliente ingresado con exito")
            ConexionODBC.cerrar()

        Catch ex As Exception
            MsgBox("Error en alta de cliente particular")
        End Try
    End Sub
End Class
