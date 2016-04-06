Public Class frm_UsoDeTarjeta
    Private Sub frm_UsoDeTarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.chartTarjetaComercios.Series("Comercios").Points.AddXY("H-E-B", 46)
        Me.chartTarjetaComercios.Series("Comercios").Points.AddXY("Soriana", 24)
        Me.chartTarjetaComercios.Series("Comercios").Points.AddXY("Wal-Mart", 14)
        Me.chartTarjetaComercios.Series("Comercios").Points.AddXY("S-Mart", 16)
    End Sub
End Class