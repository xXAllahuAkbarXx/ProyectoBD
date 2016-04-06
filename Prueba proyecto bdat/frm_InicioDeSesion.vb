Public Class frm_InicioDeSesion
    Private Sub btn_Entrar_Click(sender As Object, e As EventArgs) Handles btn_Entrar.Click
        Me.Hide()
        frm_CatalogoDeUsuarios.Show()
        'frm_CatalogoDeComercios.Show()
        'frm_CatalogoDeEmpresas.Show()
        'frm_CatalogoDeEmpleado.Show()
        'frm_UsoDeTarjeta.Show()
        'frm_UsoTarjetaEmpresas.Show()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Close()
    End Sub
End Class
