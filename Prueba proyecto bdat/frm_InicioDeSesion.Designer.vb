<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_InicioDeSesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.btn_Entrar = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.lbl_Contraseña = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(94, 220)
        Me.txt_Usuario.MaxLength = 100
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(193, 20)
        Me.txt_Usuario.TabIndex = 1
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.Location = New System.Drawing.Point(94, 269)
        Me.txt_Contraseña.MaxLength = 200
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Contraseña.Size = New System.Drawing.Size(193, 20)
        Me.txt_Contraseña.TabIndex = 2
        '
        'btn_Entrar
        '
        Me.btn_Entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Entrar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Entrar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Entrar.Location = New System.Drawing.Point(212, 331)
        Me.btn_Entrar.Name = "btn_Entrar"
        Me.btn_Entrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Entrar.TabIndex = 3
        Me.btn_Entrar.Text = "Entrar"
        Me.btn_Entrar.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Salir.Location = New System.Drawing.Point(118, 331)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Salir.TabIndex = 4
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'lbl_Contraseña
        '
        Me.lbl_Contraseña.AutoSize = True
        Me.lbl_Contraseña.Location = New System.Drawing.Point(27, 272)
        Me.lbl_Contraseña.Name = "lbl_Contraseña"
        Me.lbl_Contraseña.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Contraseña.TabIndex = 0
        Me.lbl_Contraseña.Text = "Contraseña"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(27, 223)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Usuario.TabIndex = 0
        Me.lbl_Usuario.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 64)
        Me.Label1.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(12, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Crono-Vales"
        '
        'frm_InicioDeSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(313, 381)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Entrar)
        Me.Controls.Add(Me.txt_Contraseña)
        Me.Controls.Add(Me.lbl_Contraseña)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_InicioDeSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents txt_Contraseña As TextBox
    Friend WithEvents btn_Entrar As Button
    Friend WithEvents btn_Salir As Button
    Friend WithEvents lbl_Contraseña As Label
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class
