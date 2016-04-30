Public Class frm_CatalogoDeEmpresas
    Dim actualizando = False
    Dim puedoAgregar = False
    Private Sub LoadDataGrid()
        Me.dgrid_Empresa.DataSource = ConnectionModule.connection.ReaderCommand("SELECT idEmpresa, razonSocial, nombreComercial, RFC FROM Empresa WHERE activo = 1", "Empresa").Tables("Empresa")
<<<<<<< HEAD
        Me.dgrid_Empresa.Columns("razonSocial").DisplayIndex = 0
        Me.dgrid_Empresa.Columns("nombreComercial").DisplayIndex = 1
        Me.dgrid_Empresa.Columns("RFC").DisplayIndex = 2
    End Sub

    Private Sub frm_CatalogoDeEmpresas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
=======
        'txtNombre.Text = ConnectionModule.connection.ReaderCommand("SELECT * FROM Empresa WHERE activo = 1", "Empresa").Tables("Empresa").Rows(0).Item("nombreComercial")
>>>>>>> origin/master
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
        txtCp.Text = ""

    End Sub

    Private Sub LoadComboBox()

        Dim Estados As DataTable = ConnectionModule.connection.ReaderCommand("SELECT idEstado, nombreEstado FROM Estado", "Estado").Tables("Estado")
        cbEstado.Items.Add("-SELECCIONA-")
        cbMunicipio.Items.Add("-SELECCIONA-")
        For index As Integer = 0 To Estados.Rows.Count() - 1
            cbEstado.Items.Add(Estados.Rows(index).Item("nombreEstado"))
        Next
        cbEstado.SelectedIndex = 0
        cbMunicipio.SelectedIndex = 0
    End Sub


    Private Sub frm_CatalogoDeEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD
        LoadComboBox()
=======
        cbEstado.DataSource = ConnectionModule.connection.ReaderCommand("SELECT idEstado, nombreEstado FROM Estado", "Estado").Tables("Estado")
        cbEstado.DisplayMember = "nombreEstado"
        cbEstado.ValueMember = "idEstado"
>>>>>>> origin/master
        LoadDataGrid()
    End Sub

   

  

    Private Sub cbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstado.SelectedIndexChanged
        Dim Ciudades As DataTable = ConnectionModule.connection.ReaderCommand("SELECT idCiudad, nombreCiudad FROM Ciudad WHERE idEstado = " & cbEstado.SelectedIndex & "", "Ciudad").Tables("Ciudad")
        For index As Integer = 0 To Ciudades.Rows.Count() - 1
            cbMunicipio.Items.Add(Ciudades.Rows(index).Item("nombreCiudad"))
        Next
    End Sub

   
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtRazonSocial.Text <> "" And txtRFC.Text <> "" And txtNombre.Text <> "" And txtCalle.Text <> "" And
            txtNumero.Text <> "" And txtColonia.Text <> "" And cbEstado.Text <> "" And cbMunicipio.Text <> "" And
            txtCp.Text <> "" Then
            If actualizando <> True Then
                'VALIDACIONES
                puedoAgregar = True
            Else
                puedoAgregar = True
            End If
        Else
            MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If puedoAgregar = True Then
            If txtID.Text = "" Then
                ConnectionModule.connection.NonQueryCommand("INSERT INTO Empresa (RFC,razonSocial,nombreComercial,fechaInicioOperaciones,calle,numero,colonia,idCiudad,idEstado,idPais,codigoPostal,telefonoEmpresa,activo) VALUES ('" & txtRFC.Text & "','" & txtRazonSocial.Text & "','" & txtNombre.Text & "','" & dtpInicioDeOperaciones.Text & "', '" & txtCalle.Text & "', '" & txtNumero.Text & "', '" & txtColonia.Text & "', '" & cbMunicipio.SelectedIndex & "', '" & cbEstado.SelectedIndex & "', '1', '" & txtCp.Text & "', '" & txtTelefono.Text & "', '1')")
            Else
                ConnectionModule.connection.NonQueryCommand("UPDATE Empresa SET RFC = '" & txtRFC.Text & "', razonSocial = '" & txtRazonSocial.Text & "', nombreComercial = '" & txtNombre.Text & "', fechaInicioOperaciones = '" & dtpInicioDeOperaciones.Text & "', calle = '" & txtCalle.Text & "', numero = '" & txtNumero.Text & "', colonia = '" & txtColonia.Text & "', ciudad = '" & cbMunicipio.SelectedIndex & "', estado = '" & cbEstado.SelectedIndex & "', pais = 1, codigoPostal = '" & txtCp.Text & "', telefonoEmpresa = '" & txtTelefono.Text & "' WHERE idEmpresa = '" & txtID.Text & "'")
            End If
            btnAgregar.Text = "Agregar"
            actualizando = False
            puedoAgregar = False
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0)
            ConnectionModule.connection.Clear(dgrid_Empresa)
            ResetControls()
            LoadDataGrid()
            txtRFC.Focus()
        End If

    End Sub
End Class