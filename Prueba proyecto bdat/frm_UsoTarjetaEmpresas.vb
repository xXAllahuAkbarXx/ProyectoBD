Public Class frm_UsoTarjetaEmpresas
    Private Sub frm_UsoTarjetaEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Chart1.Series("Empresas").Points.AddXY("Rednovo", 36)
        Me.Chart1.Series("Empresas").Points.AddXY("Grupo Idrapower", 18)
        Me.Chart1.Series("Empresas").Points.AddXY("Sigal", 6)
        Me.Chart1.Series("Empresas").Points.AddXY("Abaztec", 12)
        Me.Chart1.Series("Empresas").Points.AddXY("Brazza", 10)
        Me.Chart1.Series("Empresas").Points.AddXY("Lalsa", 18)
    End Sub
End Class