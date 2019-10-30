Public Class Estado_Cuenta
    Dim dr As Odbc.OdbcDataReader
    Dim sql As String
    Dim verifico8 As Boolean
    Dim cx As New Odbc.OdbcConnection
    Dim cm As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New Data.DataSet

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Txt_idcuenta_estadodeacc.Text = "" Then
                MsgBox("Campos obligatorios vacíos")
            Else

                ConexionODBC.Conectar()

                cm.Connection = cx
                sql = "SELECT id_cuenta FROM cuenta '" & Txt_idcuenta_estadodeacc.Text & "'"
                comando.Connection() = conexion
                comando.CommandText() = sql
                dr = comando.ExecuteReader()
                cm.ExecuteNonQuery()
                If dr.HasRows Then
                    verifico8 = True
                Else
                    verifico8 = False

                    If verifico8 = False Then

                        Label3.Visible = True
                        Dvg_saldoacc.Visible = True

                        da.SelectCommand = cm
                        da.Fill(ds, "saldo")
                        Dvg_saldoacc.DataSource = ds.Tables("saldo")
                    Else
                        MsgBox("ID Cuenta no registrada en el sistema, vuelva a intentar")
                    End If
                End If
            End If

        Catch ex As Exception


            ConexionODBC.cerrar()
        End Try

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_idcuenta_estadodeacc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Hide()
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Visible = False
        Dvg_saldoacc.Visible = False
    End Sub
End Class