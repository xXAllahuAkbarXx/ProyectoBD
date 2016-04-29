Public Class frm_InicioDeSesion
    Private Sub btn_Entrar_Click(sender As Object, e As EventArgs) Handles btn_Entrar.Click
        If txt_Usuario.Text <> "" And txt_Contraseña.Text <> "" Then
            Dim dt As DataTable = ConnectionModule.connection.ReaderCommand("SELECT correoElectronico FROM Usuario WHERE correoElectronico = '" & txt_Usuario.Text & "'", "Usuario").Tables.Item(0)
            If dt.Rows.Count > 0 Then
                Me.Hide()
                frm_Menu.Show()
            Else
                MessageBox.Show("Usuario o contraseña equivocada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Usuario.Text = ""
                txt_Contraseña.Text = ""
                txt_Usuario.Focus()
            End If
        Else
            MessageBox.Show("Faltan datos por ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Usuario.Text = ""
            txt_Contraseña.Text = ""
            txt_Usuario.Focus()
        End If
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.Exit()
    End Sub

    Private Sub txt_Contraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Contraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call (Sub() btn_Entrar_Click(sender, e))()
        End If
    End Sub
End Class
