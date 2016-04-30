Public Class frm_CatalogoDeEmpresas
    Dim actualizando = False
    Dim puedoAgregar = False
    Private Sub LoadDataGrid()
        Me.dgrid_Empresa.DataSource = ConnectionModule.connection.ReaderCommand("SELECT idEmpresa, razonSocial, nombreComercial, RFC FROM Empresa WHERE activo = 1", "Empresa").Tables("Empresa")
    End Sub

    Private Sub ResetControls()
        txtID.Text = ""
        txtNombre.Text = ""
        txtRFC.Text = ""
        txtRazonSocial.Text = ""
        dtpInicioDeOperaciones.Text = ""
        txtCalle.Text = ""
        txtColonia.Text = ""
        cbEstado.Text = ""
        cbMunicipio.Text = ""

    End Sub

    Private Sub frm_CatalogoDeEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
        cbEstado.DataSource = ConnectionModule.connection.ReaderCommand("SELECT idEstado, nombreEstado FROM Estado", "Estado").Tables("Estado")
        cbEstado.DisplayMember = "nombreEstado"
        cbEstado.ValueMember = "idEstado"

    End Sub

   

  

    Private Sub cbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstado.SelectedIndexChanged
        Dim seleccion = cbMunicipio.SelectedIndex
        cbMunicipio.DataSource = ConnectionModule.connection.ReaderCommand("SELECT idCiudad, nombreCiudad FROM Ciudad WHERE idEstado = " & cbEstado.SelectedIndex & "", "Ciudad").Tables("Ciudad")
        cbMunicipio.DisplayMember = "nombreCiudad"
        cbMunicipio.ValueMember = "idCiudad"
    End Sub

   
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ConnectionModule.connection.NonQueryCommand("INSERT INTO Empresa (RFC,razonSocial,nombreComercial,fechaInicioOperaciones,calle,numero,colonia,idCiudad,idEstado,idPais,codigoPostal,activo) VALUES ('" & txtRFC.Text & "','" & txtRazonSocial.Text & "','" & txtNombre.Text & "','" & dtpInicioDeOperaciones.Text & "', '" & txtCalle.Text & "', '" & txtNumero.Text & "', '" & txtColonia.Text & "', '" & cbMunicipio.SelectedIndex & "', '" & cbEstado.SelectedIndex & "', '1', '" & txtCp.Text & "', '1')")
    End Sub
End Class