Public Class frm_CatalogoDeEmpresas
    Private Sub frm_CatalogoDeEmpresas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
    End Sub
End Class