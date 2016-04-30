Public Class frm_CatalogoDeComercios
    Dim actualizando = False
    Dim puedoAgregar = False
    Private Sub frm_CatalogoDeComercios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub LoadDataGrid()
        Me.dGridComercios.DataSource = ConnectionModule.connection.ReaderCommand("SELECT idComercio, razonSocial, nombreComercial, RFC FROM Comercio WHERE activo = 1", "Comercio").Tables("Comercio")
        Me.dGridComercios.Columns("idComercio").Visible = False
        Me.dGridComercios.Columns("Borrar").DisplayIndex = 4
        Me.dGridComercios.Columns("razonSocial").Width = 284
        Me.dGridComercios.Columns("Borrar").Width = 50
        'Me.dGridComercios.AutoResizeColumnHeadersHeight()
        'Me.dGridComercios.Columns.Add("Borrar", "Borrar")
        'Me.dGridComercios.Columns("Borrar").CellType = "DataGridViewButtonColumn";
        'Me.dGridComercios.Columns("IDComercio").DisplayIndex = 0
        'Me.dGridComercios.Columns("razonSocial").DisplayIndex = 0
        'Me.dGridComercios.Columns("nombreComercial").DisplayIndex = 1
        'Me.dGridComercios.Columns("rfc").DisplayIndex = 2
        'Me.dGridComercios.Columns("IDComercio").DisplayIndex = 3
    End Sub
    Private Sub frm_CatalogoDeComercios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub
    Private Sub ResetControls()
        txtID.Text = ""
        txtNombre.Text = ""
        txtRazonSocial.Text = ""
        txtNombre.Text = ""
        txtRFC.Text = ""
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ResetControls()
        btnAceptar.Text = "Agregar"
        actualizando = False
        btnAceptar.BackColor = Color.FromArgb(0, 192, 0)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtNombre.Text <> "" And txtRazonSocial.Text <> "" And (txtRFC.Text <> "") Then
            'If (txtTelefono.Text.Length >= 8) Then
            If actualizando <> True Then
                ' If txtContraseña.Text <> "" Then
                'If txtCorreo.Text.Contains("@") And txtCorreo.Text.Contains(".") Then
                puedoAgregar = True
                'Else
                'MessageBox.Show("Ingrese un correo valido.", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If

                'Else
                'MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If
            Else
                    puedoAgregar = True
                End If
            'Else
            'MessageBox.Show("El telefono debe ser de minimo 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
        Else
            MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If puedoAgregar = True Then
            If txtID.Text = "" Then
                ConnectionModule.connection.NonQueryCommand("INSERT INTO Comercio (razonSocial, nombreComercial, RFC) VALUES ('" & txtRazonSocial.Text & "','" & txtNombre.Text & "','" & txtRFC.Text & "')")
            Else
                ConnectionModule.connection.NonQueryCommand("UPDATE Comercio SET razonSocial = '" + txtRazonSocial.Text + "', nombreComercial = '" + txtNombre.Text + "', RFC = '" + txtRFC.Text + "' WHERE '" + txtID.Text + "' = idComercio")
            End If

            btnAceptar.Text = "Agregar"
            actualizando = False
            puedoAgregar = False
            btnAceptar.BackColor = Color.FromArgb(0, 192, 0)
            ConnectionModule.connection.Clear(dGridComercios)
            ResetControls()
            LoadDataGrid()
            txtNombre.Focus()
        End If
    End Sub

    Private Sub dGridComercios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dGridComercios.CellClick
        actualizando = True
        If e.RowIndex < dGridComercios.RowCount - 1 Then
            txtID.Text = dGridComercios.CurrentRow.Cells.Item(1).Value
            txtRazonSocial.Text = dGridComercios.CurrentRow.Cells.Item(2).Value
            txtNombre.Text = dGridComercios.CurrentRow.Cells.Item(3).Value
            txtRFC.Text = dGridComercios.CurrentRow.Cells.Item(4).Value

            btnAceptar.Text = "Actualizar"
            btnAceptar.BackColor = Color.DodgerBlue
        End If
        If e.ColumnIndex = 0 Then
            If txtID.Text <> "" Then
                Dim response As MsgBoxResult

                response = MsgBox("¿Estás seguro que quieres eliminar el comercio '" & txtNombre.Text & "'?", MsgBoxStyle.YesNo, "Confirmación")

                If response = MsgBoxResult.Yes Then
                    ConnectionModule.connection.NonQueryCommand("UPDATE Comercio SET activo = 0 WHERE idComercio = " & txtID.Text)
                    ConnectionModule.connection.Clear(dGridComercios)

                    ResetControls()
                    LoadDataGrid()
                    btnAceptar.Text = "Agregar"
                    actualizando = False
                    btnAceptar.BackColor = Color.FromArgb(0, 192, 0)
                End If
            End If
        End If
    End Sub

End Class