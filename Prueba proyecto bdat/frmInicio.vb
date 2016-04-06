Imports System.Data.SqlClient

Public Class frmInicio

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsuario.ForeColor = Color.Gray
        TxtUsuario.Text = "Usuario"
        TxtContrasena.ForeColor = Color.Gray
        TxtContrasena.Text = "Contraseña"
        TAB()
    End Sub

    Private Sub TextBox_GotFocus(sender As Object, e As EventArgs) Handles TxtUsuario.Enter, TxtContrasena.Enter

        Select Case (sender.GetHashCode)
            Case (TxtUsuario.GetHashCode)
                If TxtUsuario.Text = "Usuario" Then
                    TxtUsuario.ForeColor = Color.Black
                    TxtUsuario.Text = ""
                End If
            Case (TxtContrasena.GetHashCode)
                If TxtContrasena.Text = "Contraseña" Then
                    TxtContrasena.ForeColor = Color.Black
                    TxtContrasena.Text = ""
                    TxtContrasena.PasswordChar = "*"

                End If
        End Select
    End Sub

    Private Sub TextBox_LostFocus(sender As Object, e As EventArgs) Handles TxtUsuario.Leave, TxtContrasena.Leave


        Select Case (sender.GetHashCode)
            Case (TxtUsuario.GetHashCode)
                If TxtUsuario.Text = Nothing Then
                    TxtUsuario.ForeColor = Color.Gray
                    TxtUsuario.Text = "Usuario"
                End If
            Case (TxtContrasena.GetHashCode)
                If TxtContrasena.Text = Nothing Then
                    TxtContrasena.ForeColor = Color.Gray
                    TxtContrasena.Text = "Contraseña"
                    TxtContrasena.PasswordChar = Nothing
                End If
        End Select
    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        Me.Hide()
        frm_CatalogoDeUsuarios.Show()
    End Sub
End Class
