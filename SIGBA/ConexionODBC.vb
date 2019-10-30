Imports System.Data.Odbc
Module ConexionODBC

    Public datas As New Data.DataSet
    Public data As New Odbc.OdbcDataAdapter
    Public comando As New Odbc.OdbcCommand
    Public conexion As New OdbcConnection


    Public Sub Conectar()

        Dim conectar As String

        Try
            conectar = "DRIVER=IBM INFORMIX ODBC DRIVER (64-bit);UID =fcannepa; PWD=lenninlove; DLOC=en_US.819; CLOC=en_US.CP1252; PRO=onsoctcp; SRVR=ol_esi; HOST=192.168.5.50; DATABASE=databank"
            conexion.ConnectionString = conectar
            conexion.Open()

        Catch ex As Exception

            MsgBox("Error en la conexión con la Base de Datos")
            conexion.Close()
        End Try
    End Sub

    Public Sub cerrar()
        conexion.Close()
    End Sub
End Module
