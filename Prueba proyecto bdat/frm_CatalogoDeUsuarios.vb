Public Class frm_CatalogoDeUsuarios
    Dim actualizando = False
    Dim puedoAgregar = False
    Private Sub LoadDataGrid()
        Me.dgrid_Usuario.DataSource = ConnectionModule.connection.ReaderCommand("SELECT idUsuario, nombreCompleto, correoElectronico, telefonoContacto FROM Usuario WHERE activo = 1", "Usuario").Tables("Usuario")
        Me.dgrid_Usuario.Columns("Nombre").DisplayIndex = 0
        Me.dgrid_Usuario.Columns("Correo").DisplayIndex = 1
        Me.dgrid_Usuario.Columns("Telefono").DisplayIndex = 2
        Me.dgrid_Usuario.Columns("Borrar").DisplayIndex = 3
    End Sub

    Private Sub ResetControls()
        txtID.Text = ""
        txtNombre.Text = ""
        txtContraseña.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
    End Sub

    Private Sub frm_CatalogoDeUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtNombre.Text <> "" And txtCorreo.Text <> "" And (txtTelefono.Text <> "") Then
            If (txtTelefono.Text.Length >= 8) Then
                If actualizando <> True Then
                    If txtContraseña.Text <> "" Then
                        If txtCorreo.Text.Contains("@") And txtCorreo.Text.Contains(".") Then
                            puedoAgregar = True
                        Else
                            MessageBox.Show("Ingrese un correo valido.", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    Else
                        MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    puedoAgregar = True
                End If
            Else
                MessageBox.Show("El telefono debe ser de minimo 8 digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If puedoAgregar = True Then
            If txtID.Text = "" Then
                ConnectionModule.connection.NonQueryCommand("INSERT INTO Usuario (nombreCompleto, correoElectronico, contrasenia, telefonoContacto) VALUES ('" & txtNombre.Text & "','" & txtCorreo.Text & "','" & txtContraseña.Text & "','" & txtTelefono.Text & "')")
            Else
                ConnectionModule.connection.NonQueryCommand("UPDATE Usuario SET nombreCompleto = '" + txtNombre.Text + "', correoElectronico = '" + txtCorreo.Text + "', telefonoContacto = '" + txtTelefono.Text + "' WHERE '" + txtID.Text + "' = idUsuario")
            End If

            btnAceptar.Text = "Agregar"
            actualizando = False
            puedoAgregar = False
            btnAceptar.BackColor = Color.FromArgb(0, 192, 0)
            ConnectionModule.connection.Clear(dgrid_Usuario)
            ResetControls()
            LoadDataGrid()
            txtNombre.Focus()
        End If
    End Sub

    Private Sub dgrid_Usuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_Usuario.CellContentClick

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ResetControls()
        btnAceptar.Text = "Agregar"
        actualizando = False
        btnAceptar.BackColor = Color.FromArgb(0, 192, 0)
    End Sub

    Private Sub frm_CatalogoDeUsuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
    End Sub

    Private Sub dgrid_Usuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_Usuario.CellClick
        actualizando = True
        If e.RowIndex < dgrid_Usuario.RowCount - 1 Then
            txtID.Text = dgrid_Usuario.CurrentRow.Cells.Item(2).Value
            txtNombre.Text = dgrid_Usuario.CurrentRow.Cells.Item(3).Value
            txtCorreo.Text = dgrid_Usuario.CurrentRow.Cells.Item(1).Value
            txtTelefono.Text = dgrid_Usuario.CurrentRow.Cells.Item(4).Value

            btnAceptar.Text = "Actualizar"
            btnAceptar.BackColor = Color.DodgerBlue
        End If

        If e.ColumnIndex = 0 Then
            If txtID.Text <> "" Then
                Dim response As MsgBoxResult

                response = MsgBox("¿Estás seguro que quieres eliminar al usuario '" & txtNombre.Text & "'?", MsgBoxStyle.YesNo, "Confirmación")

                If response = MsgBoxResult.Yes Then
                    ConnectionModule.connection.NonQueryCommand("UPDATE Usuario SET activo = 0 WHERE idUsuario = " & txtID.Text)
                    ConnectionModule.connection.Clear(dgrid_Usuario)

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