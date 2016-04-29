<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Menu))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_Usuario = New System.Windows.Forms.PictureBox()
        Me.btn_Empleado = New System.Windows.Forms.PictureBox()
        Me.btn_Empresa = New System.Windows.Forms.PictureBox()
        Me.btn_Comercio = New System.Windows.Forms.PictureBox()
        Me.btn_Deposito = New System.Windows.Forms.PictureBox()
        Me.btn_Cargo = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.btn_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Comercio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Deposito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(-1, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(635, 64)
        Me.Label3.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(235, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Crono-Vales"
        '
        'btn_Usuario
        '
        Me.btn_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_Usuario.Image = CType(resources.GetObject("btn_Usuario.Image"), System.Drawing.Image)
        Me.btn_Usuario.Location = New System.Drawing.Point(42, 102)
        Me.btn_Usuario.Name = "btn_Usuario"
        Me.btn_Usuario.Size = New System.Drawing.Size(164, 166)
        Me.btn_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Usuario.TabIndex = 17
        Me.btn_Usuario.TabStop = False
        '
        'btn_Empleado
        '
        Me.btn_Empleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_Empleado.Image = CType(resources.GetObject("btn_Empleado.Image"), System.Drawing.Image)
        Me.btn_Empleado.Location = New System.Drawing.Point(42, 298)
        Me.btn_Empleado.Name = "btn_Empleado"
        Me.btn_Empleado.Size = New System.Drawing.Size(354, 162)
        Me.btn_Empleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Empleado.TabIndex = 18
        Me.btn_Empleado.TabStop = False
        '
        'btn_Empresa
        '
        Me.btn_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_Empresa.Image = CType(resources.GetObject("btn_Empresa.Image"), System.Drawing.Image)
        Me.btn_Empresa.Location = New System.Drawing.Point(230, 102)
        Me.btn_Empresa.Name = "btn_Empresa"
        Me.btn_Empresa.Size = New System.Drawing.Size(166, 166)
        Me.btn_Empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Empresa.TabIndex = 19
        Me.btn_Empresa.TabStop = False
        '
        'btn_Comercio
        '
        Me.btn_Comercio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_Comercio.Image = CType(resources.GetObject("btn_Comercio.Image"), System.Drawing.Image)
        Me.btn_Comercio.Location = New System.Drawing.Point(421, 102)
        Me.btn_Comercio.Name = "btn_Comercio"
        Me.btn_Comercio.Size = New System.Drawing.Size(167, 166)
        Me.btn_Comercio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Comercio.TabIndex = 20
        Me.btn_Comercio.TabStop = False
        '
        'btn_Deposito
        '
        Me.btn_Deposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_Deposito.Image = CType(resources.GetObject("btn_Deposito.Image"), System.Drawing.Image)
        Me.btn_Deposito.Location = New System.Drawing.Point(421, 298)
        Me.btn_Deposito.Name = "btn_Deposito"
        Me.btn_Deposito.Size = New System.Drawing.Size(78, 78)
        Me.btn_Deposito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Deposito.TabIndex = 21
        Me.btn_Deposito.TabStop = False
        '
        'btn_Cargo
        '
        Me.btn_Cargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_Cargo.Image = CType(resources.GetObject("btn_Cargo.Image"), System.Drawing.Image)
        Me.btn_Cargo.Location = New System.Drawing.Point(510, 298)
        Me.btn_Cargo.Name = "btn_Cargo"
        Me.btn_Cargo.Size = New System.Drawing.Size(78, 78)
        Me.btn_Cargo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cargo.TabIndex = 22
        Me.btn_Cargo.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(421, 382)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(78, 78)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 23
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(510, 382)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(78, 35)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 24
        Me.PictureBox8.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Tomato
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(510, 382)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 35)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Reporte comercios"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Tomato
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(510, 425)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 35)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Reporte empleados"
        '
        'frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 497)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.btn_Cargo)
        Me.Controls.Add(Me.btn_Deposito)
        Me.Controls.Add(Me.btn_Comercio)
        Me.Controls.Add(Me.btn_Empresa)
        Me.Controls.Add(Me.btn_Empleado)
        Me.Controls.Add(Me.btn_Usuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frm_Menu"
        Me.Text = "Menu"
        CType(Me.btn_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Empleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Empresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Comercio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Deposito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_Usuario As PictureBox
    Friend WithEvents btn_Empleado As PictureBox
    Friend WithEvents btn_Empresa As PictureBox
    Friend WithEvents btn_Comercio As PictureBox
    Friend WithEvents btn_Deposito As PictureBox
    Friend WithEvents btn_Cargo As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
