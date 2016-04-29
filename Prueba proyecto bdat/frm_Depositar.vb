Public Class frm_Depositar
    Private Sub frm_Depositar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_Depositar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
    End Sub
End Class