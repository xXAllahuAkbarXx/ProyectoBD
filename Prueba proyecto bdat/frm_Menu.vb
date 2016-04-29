Public Class frm_Menu
    Private Sub btn_Usuario_Click(sender As Object, e As EventArgs) Handles btn_Usuario.Click
        Me.Hide()
        frm_CatalogoDeUsuarios.Show()
    End Sub

    Private Sub btn_Empresa_Click(sender As Object, e As EventArgs) Handles btn_Empresa.Click
        Me.Hide()
        frm_CatalogoDeEmpresas.Show()
    End Sub

    Private Sub btn_Comercio_Click(sender As Object, e As EventArgs) Handles btn_Comercio.Click
        Me.Hide()
        frm_CatalogoDeComercios.Show()
    End Sub

    Private Sub btn_Empleado_Click(sender As Object, e As EventArgs) Handles btn_Empleado.Click
        Me.Hide()
        frm_CatalogoDeEmpleado.Show()
    End Sub

    Private Sub btn_Deposito_Click(sender As Object, e As EventArgs) Handles btn_Deposito.Click
        Me.Hide()
        frm_Depositar.Show()
    End Sub

    Private Sub frm_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class