Public Class Modificar_cuenta
    Dim verifico2 As Boolean
    Dim dr2 As Odbc.OdbcDataReader
    Dim sql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Txt_cirut_cuenta.Text = "" And Txt_idcuenta.Text Then
                MsgBox("Campos obligatorios vacios")
            Else
                ConexionODBC.Conectar()
                sql = "SELECT ci FROM cliente" And "SELECT rut FROM empresa"
                sql = "SELECT id_cuenta FROM cuenta"
                comando.Connection() = conexion
                comando.CommandText() = sql
                dr2 = comando.ExecuteReader()
                If dr2.HasRows Then
                    verifico2 = True
                Else
                    verifico2 = False

                    If verifico2 = False Then
                        Txt_justing_cuenta.ReadOnly = False
                        ComboBox1.Enabled = True
                        ComboBox2.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Cuenta no existente en el sistema")
            ConexionODBC.cerrar()
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            ConexionODBC.Conectar()

            sql = "UPDATE cuenta SET just_ing='" & Txt_justing_cuenta.Text & "',moneda_cuenta='" & ComboBox1.SelectedItem & "',tipo_cuenta='" & ComboBox2.SelectedItem & "',)"
            comando.Connection() = conexion
            comando.CommandText() = sql
            comando.ExecuteReader()
            MsgBox("Cuenta ingresado con exito")
            ConexionODBC.cerrar()

        Catch ex As Exception
            MsgBox("Error en alta de cuenta")
        End Try


    End Sub
End Class