Public Class Menú_cajero

    Private Sub Menú_cajero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Btn_altacuenta.Enabled = False
        Btn_bajacliente.Enabled = False
        Btn_bajacuenta.Enabled = False
        Btn_depositar.Enabled = False
        Btn_listar.Enabled = False
        Btn_modicliente.Enabled = False
        Btn_modicuenta.Enabled = False
        Btn_retirar.Enabled = False
        Btn_estadodecuenta.Enabled = False
        Btn_altacliente.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Alta_Cuenta.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Alta_cliente.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Listar.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Estado_Cuenta.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Modificar_cliente_general.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Modificar_cuenta.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Baja_cliente_cuenta.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Baja_cliente_cuenta.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Depositar.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Retirar.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_cerrarcaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrarcaja.Click
        Btn_altacuenta.Enabled = False
        Btn_bajacliente.Enabled = False
        Btn_bajacuenta.Enabled = False
        Btn_depositar.Enabled = False
        Btn_listar.Enabled = False
        Btn_modicliente.Enabled = False
        Btn_modicuenta.Enabled = False
        Btn_retirar.Enabled = False
        Btn_estadodecuenta.Enabled = False
        Btn_altacliente.Enabled = False
        MsgBox("Caja cerrada con exito")
    End Sub

    Private Sub Btn_abrircaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_abrircaja.Click
        Btn_altacuenta.Enabled = True
        Btn_bajacliente.Enabled = True
        Btn_bajacuenta.Enabled = True
        Btn_depositar.Enabled = True
        Btn_listar.Enabled = True
        Btn_modicliente.Enabled = True
        Btn_modicuenta.Enabled = True
        Btn_retirar.Enabled = True
        Btn_estadodecuenta.Enabled = True
        Btn_altacliente.Enabled = True
        MsgBox("Caja Abierta con exito")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Tarjetas.Show()
    End Sub
End Class