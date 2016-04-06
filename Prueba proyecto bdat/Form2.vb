Imports System.Data.SqlClient

Public Class FormCatUsu

    Private Sub CargarGridUsuario()
        Me.DataGridUsuario.DataSource = ConnectionModule.connection.ReaderCommand("SELECT IDusuario, Correo, Nombre, Telefono FROM Usuario WHERE Activo = 1", "Usuario").Tables("Usuario")
    End Sub

    Private Sub LimpiarCampos()
        TxtID.Text = ""
        TxtCorreo.Text = ""
        TxtNombre.Text = ""
        TxtTel.Text = ""
        TxtContra.Text = ""
    End Sub

    Private Sub FormCatUsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGridUsuario()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtID.Text = "" Then
            Call ConnectionModule.connection.NonQueryCommand("INSERT INTO Usuario (Nombre,Correo,Contrasena,Telefono) VALUES ('" & TxtNombre.Text & "','" & TxtCorreo.Text & "','" & TxtContra.Text & "','" & TxtTel.Text & "')")
        Else
            Call ConnectionModule.connection.NonQueryCommand("UPDATE Usuario SET Nombre = '" + TxtNombre.Text + "', Correo = '" + TxtCorreo.Text + "', Telefono = '" + TxtTel.Text + "' WHERE '" + TxtID.Text + "' = IDusuario")
        End If

        BtnAceptar.Text = "Agregar"
        LimpiarCampos()
        Call ConnectionModule.connection.Clear(DataGridUsuario)
        CargarGridUsuario()
    End Sub

    Private Sub DataGridUsuario_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridUsuario.CellClick
        TxtID.Text = DataGridUsuario.CurrentRow.Cells.Item(1).Value
        TxtCorreo.Text = DataGridUsuario.CurrentRow.Cells.Item(2).Value
        TxtNombre.Text = DataGridUsuario.CurrentRow.Cells.Item(3).Value
        TxtTel.Text = DataGridUsuario.CurrentRow.Cells.Item(4).Value
        BtnAceptar.Text = "Actualizar"


        If e.ColumnIndex = 0 Then
            If TxtID.Text <> "" Then
                Dim response As MsgBoxResult

                response = MsgBox("¿Estás seguro que quieres eliminar al usuario '" & TxtNombre.Text & "'?", MsgBoxStyle.YesNo, "Confirmación")

                If response = MsgBoxResult.Yes Then
                    'Conectar.Comandos("UPDATE Usuario SET Activo = 0 WHERE IDusuario = " & TxtID.Text, "Usuario", 0)
                    'Conectar.Limpiar(DataGridUsuario)
                    Call ConnectionModule.connection.NonQueryCommand("UPDATE Usuario SET Activo = 0 WHERE IDusuario = " & TxtID.Text)
                    Call ConnectionModule.connection.Clear(DataGridUsuario)
                    LimpiarCampos()
                    CargarGridUsuario()
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarCampos()
        BtnAceptar.Text = "Agregar"

    End Sub

    Private Sub DataGridUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUsuario.CellContentClick

    End Sub
End Class