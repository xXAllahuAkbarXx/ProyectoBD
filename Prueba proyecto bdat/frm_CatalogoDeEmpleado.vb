
Public Class frm_CatalogoDeEmpleado
    Dim actualizando = False
    Dim puedoAgregar = False
    Dim idEmpresa As Integer

    Private Sub frm_CatalogoDeEmpleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
    End Sub

    Private Sub LoadDataGrid()
        Me.dgrid_Empleado.DataSource = ConnectionModule.connection.ReaderCommand("SELECT idEmpleado, nombreEmpleado, apellidoPaterno, apellidoMaterno, RFC, tarjetaVales FROM Empleado" &
                                                                        "WHERE idEmpresa = " & idEmpresa & " AND activo = 1", "Empleado").Tables("Empleado")
        Me.dgrid_Empleado.Columns("nombreEmpleado").DisplayIndex = 0
        Me.dgrid_Empleado.Columns("apellidoPaterno").DisplayIndex = 1
        Me.dgrid_Empleado.Columns("apellidoMaterno").DisplayIndex = 2
        Me.dgrid_Empleado.Columns("RFC").DisplayIndex = 3
        Me.dgrid_Empleado.Columns("tarjetaVales").DisplayIndex = 4
        Me.dgrid_Empleado.Columns("Borrar").DisplayIndex = 5
    End Sub

    Private Sub ResetControls()
        lblNumeroEmpleado.Text = ""
        txtRFC.Text = ""
        txtNombre.Text = ""
        txtApellidoP.Text = ""
        txtApellidoM.Text = ""
        lblNumeroTarjeta.Text = ""
        txtNombre.Focus()
    End Sub

    Private Sub EnabledControls(ByVal enableControls As Boolean)
        lblNumeroEmpleado.Enabled = enableControls
        txtRFC.Enabled = enableControls
        txtNombre.Enabled = enableControls
        txtApellidoP.Enabled = enableControls
        txtApellidoM.Enabled = enableControls
        lblNumeroTarjeta.Enabled = enableControls
        dgrid_Empleado.Enabled = enableControls
        btnAceptar.Enabled = enableControls
        btnCancelar.Enabled = enableControls
    End Sub

    Private Sub LoadComboBox()

        Dim Empresas As DataTable = ConnectionModule.connection.ReaderCommand("SELECT * FROM Empresa", "Empresa").Tables("Empresa")

        For index As Integer = 0 To empresas.Rows.Count() - 1
            cmbEmpresa.Items.Add(empresas.Rows(index).Item("nombreComercial"))
        Next

    End Sub

    Private Sub frm_CatalogoDeEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBox()

        If (cmbEmpresa.Text = "") Then
            EnabledControls(False)
        End If
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtNombre.Text <> "" And txtApellidoP.Text <> "" And (txtApellidoM.Text <> "") And txtRFC.Text <> "" Then
            If (Validation.OnlyLetters(txtNombre.Text) And Validation.OnlyLetters(txtApellidoP.Text) And Validation.OnlyLetters(txtApellidoM.Text)) Then
                If actualizando <> True Then
                    puedoAgregar = True
                Else
                    puedoAgregar = True
                End If
            Else
                MessageBox.Show("No se permiten números en el nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If puedoAgregar = True Then
            If lblNumeroEmpleado.Text = "" Then


                Dim ultimaTarjeta As DataSet = ConnectionModule.connection.ReaderCommand("SELECT MAX(tarjetaVales) As ultimaTarjeta FROM Empleado", "Empleado")
                Dim numeroTarjeta As Int64 = Int64.Parse(ultimaTarjeta.Tables("Empleado").Rows(0).Item("ultimaTarjeta").ToString()) + 1

                ConnectionModule.connection.NonQueryCommand("INSERT INTO Empleado (idEmpresa, nombreEmpleado, apellidoPaterno, apellidoMaterno, RFC, tarjetaVales)" &
                                                            "VALUES (" & idEmpresa & ",'" & txtNombre.Text & "','" & txtApellidoP.Text & "','" & txtApellidoM.Text & "','" & txtRFC.Text & "', " & numeroTarjeta & ")")
            Else
                ConnectionModule.connection.NonQueryCommand("UPDATE Empleado SET nombreEmpleado = '" + txtNombre.Text + "', apellidoPaterno = '" +
                                                            txtApellidoP.Text + "', apellidoMaterno = '" + txtApellidoM.Text + "', RFC = '" + txtRFC.Text +
                                                            "' WHERE '" + lblNumeroEmpleado.Text + "' = idEmpleado")
            End If

            btnAceptar.Text = "Agregar"
            actualizando = False
            puedoAgregar = False
            btnAceptar.BackColor = Color.FromArgb(0, 192, 0)
            ConnectionModule.connection.Clear(dgrid_Empleado)
            ResetControls()
            LoadDataGrid()

        End If

    End Sub


    Private Sub dgrid_Empleado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_Empleado.CellClick
        actualizando = True
        If e.RowIndex < dgrid_Empleado.RowCount - 1 Then

            lblNumeroEmpleado.Text = dgrid_Empleado.CurrentRow.Cells.Item(1).Value
            txtNombre.Text = dgrid_Empleado.CurrentRow.Cells.Item(2).Value
            txtApellidoP.Text = dgrid_Empleado.CurrentRow.Cells.Item(3).Value
            txtApellidoM.Text = dgrid_Empleado.CurrentRow.Cells.Item(4).Value
            txtRFC.Text = dgrid_Empleado.CurrentRow.Cells.Item(5).Value
            lblNumeroTarjeta.Text = dgrid_Empleado.CurrentRow.Cells.Item(6).Value


            btnAceptar.Text = "Actualizar"
            btnAceptar.BackColor = Color.DodgerBlue
        End If

        If e.ColumnIndex = 0 Then
            If lblNumeroEmpleado.Text <> "" Then
                Dim response As MsgBoxResult

                response = MsgBox("¿Estás seguro que quieres eliminar al empleado '" & txtNombre.Text & "'?", MsgBoxStyle.YesNo, "Confirmación")

                If response = MsgBoxResult.Yes Then
                    ConnectionModule.connection.NonQueryCommand("UPDATE Empleado SET activo = 0 WHERE idEmpleado = " & lblNumeroEmpleado.Text)
                    ConnectionModule.connection.Clear(dgrid_Empleado)

                    ResetControls()
                    LoadDataGrid()
                    btnAceptar.Text = "Agregar"
                    btnAceptar.BackColor = Color.FromArgb(0, 192, 0)
                    actualizando = False
                End If
            End If
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ResetControls()
        btnAceptar.Text = "Agregar"
        actualizando = False
        btnAceptar.BackColor = Color.FromArgb(0, 192, 0)
    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresa.SelectedIndexChanged

        If (cmbEmpresa.Text <> "") Then
            EnabledControls(True)
            Dim Empresas As DataTable = ConnectionModule.connection.ReaderCommand("SELECT * FROM Empresa", "Empresa").Tables("Empresa")
            idEmpresa = Integer.Parse(Empresas.Rows(cmbEmpresa.SelectedIndex).Item("idEmpresa").ToString())
            LoadDataGrid()
        Else
            EnabledControls(False)
        End If

    End Sub
End Class