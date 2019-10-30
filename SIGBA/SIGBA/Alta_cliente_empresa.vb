Public Class Alta_cliente_empresa
    Dim verifico2 As Boolean
    Dim dr2 As Odbc.OdbcDataReader
    Dim sql As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Txt_rut_empresa.Text = "" Or Txt_domicilio_empresa.Text = "" Or Txt_nombreempresa_empresa.Text = "" Or Txt_tel_empresa.Text = "" Or Txt_nombrefantasia_empresa.Text = "" Then
                MsgBox("Campos obligatorios vacios")
            Else
                ConexionODBC.Conectar()
                sql = "SELECT id_cliente FROM empresa"
                comando.Connection() = conexion
                comando.CommandText() = Sql
                dr2 = comando.ExecuteReader()
                If dr2.HasRows Then
                    verifico2 = True
                Else
                    verifico2 = False

                    If verifico2 = False Then

                        ConexionODBC.Conectar()

                        sql = "INSERT INTO empresa VALUES('" & Txt_rut_empresa.Text & "','" & Txt_nombreempresa_empresa.Text & "','" & Txt_domicilio_empresa.Text & "','" & Txt_tel_empresa.Text & "','" & Txt_nombrefantasia_empresa.Text & "',)"
                        comando.Connection() = conexion
                        comando.CommandText() = sql
                        comando.ExecuteReader()
                        MsgBox("Empresa ingresada con exito")
                        ConexionODBC.cerrar()
                    Else
                        MsgBox("Empresa ya existe")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en alta Cuenta Bancaria")
            ConexionODBC.cerrar()
        End Try
    End Sub

    Private Sub Txt_rut_empresa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_rut_empresa.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_nombreempresa_empresa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_nombreempresa_empresa.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_domicilio_empresa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_domicilio_empresa.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_tel_empresa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_tel_empresa.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Alta_cliente_empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
