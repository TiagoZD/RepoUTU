Public Class Listar
    Dim sql As String
    Dim dr As Odbc.OdbcDataReader
    Dim cx As New Odbc.OdbcConnection
    Dim cm As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New Data.DataSet
    Dim verifico7 As Boolean


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dgv_datoscuenta.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Txt_cirut_listar.Text = "" Then
                MsgBox("Campos obligatorios vacíos")
            Else

                ConexionODBC.Conectar()

                cm.Connection = cx
                sql = "SELECT id_cliente FROM cliente '" & Txt_cirut_listar.Text & "'"
                comando.Connection() = conexion
                comando.CommandText() = sql
                dr = comando.ExecuteReader()
                cm.ExecuteNonQuery()
                If dr.HasRows Then
                    verifico7 = True
                Else
                    verifico7 = False

                    If verifico7 = False Then
                        Dgv_datoscuenta.Visible = True
                        Label2.Visible = True
                        
                        da.SelectCommand = cm
                        da.Fill(ds, "cliente")
                        Dgv_datoscuenta.DataSource = ds.Tables("cliente")

                        ConexionODBC.cerrar()
                    Else
                        MsgBox("CI o RUT no ingresados en el sistema, vuelta a intentarlo")


                    End If
                End If
            End If

        Catch ex As Exception

            ConexionODBC.cerrar()
        End Try

    End Sub


    Private Sub Txt_cirut_datos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_cirut_listar.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Listar_Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Listar_Cuentas.Show()
        Me.Hide()
    End Sub
End Class