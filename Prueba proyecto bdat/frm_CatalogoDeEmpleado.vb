Public Class frm_CatalogoDeEmpleado
    Dim actualizando = False
    Dim puedoAgregar = False

    Private Sub frm_CatalogoDeEmpleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
    End Sub

    Private Sub LoadDataGrid()
        Me.dgrid_Empleado.DataSource = ConnectionModule.connection.ReaderCommand("SELECT idEmpleado, nombreEmpleado, apellidoPaterno, apellidoMaterno, RFC, tarjetaVales FROM Empleado WHERE activo = 1", "Empleado").Tables("Empleado")
        Me.dgrid_Empleado.Columns("nombreEmpleado").DisplayIndex = 0
        Me.dgrid_Empleado.Columns("apellidoPaterno").DisplayIndex = 1
        Me.dgrid_Empleado.Columns("apellidoMaterno").DisplayIndex = 2
        Me.dgrid_Empleado.Columns("RFC").DisplayIndex = 3
        Me.dgrid_Empleado.Columns("tarjetaVales").DisplayIndex = 4
        Me.dgrid_Empleado.Columns("Borrar").DisplayIndex = 5
    End Sub

    Private Sub ResetControls()
        txtNumeroEmpleado.Text = ""
        txtRFC.Text = ""
        txtNombre.Text = ""
        txtApellidoP.Text = ""
        txtApellidoM.Text = ""
        txtNumeroTarjeta.Text = ""
    End Sub

    Private Sub txtRFC_TextChanged(sender As Object, e As EventArgs) Handles txtRFC.TextChanged

    End Sub

    Private Sub frm_CatalogoDeEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub

    Private Sub dgrid_Empleado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_Empleado.CellClick
        actualizando = True
        If e.RowIndex < dgrid_Empleado.RowCount - 1 Then

            txtNumeroEmpleado.Text = dgrid_Empleado.CurrentRow.Cells.Item(1).Value
            txtNombre.Text = dgrid_Empleado.CurrentRow.Cells.Item(2).Value
            txtApellidoP.Text = dgrid_Empleado.CurrentRow.Cells.Item(3).Value
            txtApellidoM.Text = dgrid_Empleado.CurrentRow.Cells.Item(4).Value
            txtRFC.Text = dgrid_Empleado.CurrentRow.Cells.Item(5).Value
            txtNumeroTarjeta.Text = dgrid_Empleado.CurrentRow.Cells.Item(6).Value


            btnAceptar.Text = "Actualizar"
            btnAceptar.BackColor = Color.DodgerBlue
        End If

        If e.ColumnIndex = 0 Then
            If txtNumeroEmpleado.Text <> "" Then
                Dim response As MsgBoxResult

                response = MsgBox("¿Estás seguro que quieres eliminar al usuario '" & txtNombre.Text & "'?", MsgBoxStyle.YesNo, "Confirmación")

                If response = MsgBoxResult.Yes Then
                    ConnectionModule.connection.NonQueryCommand("UPDATE Usuario SET activo = 0 WHERE idUsuario = " & txtNumeroEmpleado.Text)
                    ConnectionModule.connection.Clear(dgrid_Empleado)

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