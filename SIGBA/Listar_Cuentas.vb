Public Class Listar_Cuentas
    Dim sql As String
    Dim dr As Odbc.OdbcDataReader
    Dim cx As New Odbc.OdbcConnection
    Dim cm As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New Data.DataSet
    Dim verifico7 As Boolean



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ConexionODBC.Conectar()

        sql = "SELECT * FROM cuenta"

        da.SelectCommand = cm
        da.Fill(ds, "cuenta")
        DataGridView1.DataSource = ds.Tables("cuenta")

        ConexionODBC.cerrar()
    End Sub
End Class