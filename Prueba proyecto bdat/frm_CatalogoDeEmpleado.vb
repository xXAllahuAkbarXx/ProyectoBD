Public Class frm_CatalogoDeEmpleado
    Private Sub frm_CatalogoDeEmpleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
    End Sub
End Class