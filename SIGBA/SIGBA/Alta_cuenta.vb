Public Class Alta_Cuenta
    Dim sql As String
    Dim dr As Odbc.OdbcDataReader
    Dim verifico As Boolean

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Txt_ci_altacuenta.Text = "" Or Txt_justing_altacuenta.Text = "" Or Txt_nroapto_altacuenta.Text = "" Or Txt_calle_altacuenta.Text = "" Or Txt_nropuerta_altacuenta.Text = "" Or Cmb_tipocuenta_altacuenta.SelectedItem = "" Or Cmb_tipomoneda_altacuenta.SelectedItem = "" Then
                MsgBox("Campos obligatorios vacios")
            Else
                ConexionODBC.Conectar()
                sql = "SELECT id_cuenta FROM cuenta"
                comando.Connection() = conexion
                comando.CommandText() = sql
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    verifico = True
                Else
                    verifico = False

                    If verifico = False Then

                        ConexionODBC.Conectar()

                        sql = "INSERT INTO cuenta VALUES(0,'" & Txt_ci_altacuenta.Text & "','" & Cmb_tipocuenta_altacuenta.SelectedItem & "','" & Cmb_tipomoneda_altacuenta.SelectedItem & "','" & Cmb_domicilio_altacuenta.SelectedItem & "','" & Txt_calle_altacuenta.Text & "','" & Txt_nroapto_altacuenta.Text & "','" & Txt_nropuerta_altacuenta.Text & "','" & Txt_justing_altacuenta.Text & "','" & Txt_id_sucursal.Text & "')"
                        comando.Connection() = conexion
                        comando.CommandText() = sql
                        comando.ExecuteReader()
                        MsgBox("Cuenta Bancaria ingresada con exito")
                        ConexionODBC.cerrar()
                    Else
                        MsgBox("Cuenta Bancaria ya existe")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en alta de Cuenta ")
            ConexionODBC.cerrar()
        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Menú_Gerente.Show()
    End Sub

    Private Sub Txtdoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_ci_altacuenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txtapto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_nroapto_altacuenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txtnum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_nropuerta_altacuenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txtcalle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_calle_altacuenta.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txtjustificacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_justing_altacuenta.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class