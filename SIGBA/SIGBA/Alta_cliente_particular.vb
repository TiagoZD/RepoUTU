Public Class Alta_cliente_particular
    Dim verifico2 As Boolean
    Dim dr2 As Odbc.OdbcDataReader
    Dim sql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Txt_ci_cliente.Text = "" Or Txt_domicilio_cliente.Text = "" Or Txt_nombrecompleto_cliente.Text = "" Or Txt_tel_cliente.Text = "" Then
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

                        ConexionODBC.Conectar()

                        sql = "INSERT id_cliente INTO cliente VALUES('" & Txt_ci_cliente.Text & "','" & Txt_nombrecompleto_cliente.Text & "','" & Txt_domicilio_cliente.Text & "',)"
                        sql = "INSERT telefono INTO cliente_telefono WHERE telefono ('" & Txt_tel_cliente.Text & "')"
                        comando.Connection() = conexion
                        comando.CommandText() = sql
                        comando.ExecuteReader()
                        MsgBox("Cliente ingresado con exito")
                        ConexionODBC.cerrar()
                    Else
                        MsgBox("Cliente existente")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en alta cliente")
            ConexionODBC.cerrar()
        End Try
    End Sub

    Private Sub Txt_nombre_cliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_nombrecompleto_cliente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_ci_cliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_ci_cliente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_domicilio_cliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_domicilio_cliente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_tel_cliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_tel_cliente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class

