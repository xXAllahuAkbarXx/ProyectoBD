﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CatalogoDeEmpleado
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtApellidoM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellidoP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dgrid_Empleado = New System.Windows.Forms.DataGridView()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidoPaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidoMaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tarjetaVales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNumeroEmpleado = New System.Windows.Forms.Label()
        Me.lblNumeroTarjeta = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrid_Empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(480, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtApellidoM)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtApellidoP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 87)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nombre completo"
        '
        'txtApellidoM
        '
        Me.txtApellidoM.Location = New System.Drawing.Point(277, 41)
        Me.txtApellidoM.MaxLength = 50
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidoM.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Apellido materno"
        '
        'txtApellidoP
        '
        Me.txtApellidoP.Location = New System.Drawing.Point(155, 41)
        Me.txtApellidoP.MaxLength = 50
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidoP.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apellido paterno"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(13, 41)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(115, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "RFC"
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(47, 186)
        Me.txtRFC.MaxLength = 50
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(242, 20)
        Me.txtRFC.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(480, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Número de tarjeta"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAceptar.Location = New System.Drawing.Point(573, 184)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Agregar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.Location = New System.Drawing.Point(483, 184)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'dgrid_Empleado
        '
        Me.dgrid_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid_Empleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.nombreEmpleado, Me.apellidoPaterno, Me.apellidoMaterno, Me.RFC, Me.tarjetaVales, Me.borrar})
        Me.dgrid_Empleado.Location = New System.Drawing.Point(12, 233)
        Me.dgrid_Empleado.Name = "dgrid_Empleado"
        Me.dgrid_Empleado.Size = New System.Drawing.Size(664, 261)
        Me.dgrid_Empleado.TabIndex = 6
        Me.dgrid_Empleado.TabStop = False
        '
        'idEmpleado
        '
        Me.idEmpleado.DataPropertyName = "idEmpleado"
        Me.idEmpleado.HeaderText = "ID"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.Visible = False
        '
        'nombreEmpleado
        '
        Me.nombreEmpleado.DataPropertyName = "nombreEmpleado"
        Me.nombreEmpleado.HeaderText = "Nombre"
        Me.nombreEmpleado.Name = "nombreEmpleado"
        '
        'apellidoPaterno
        '
        Me.apellidoPaterno.DataPropertyName = "apellidoPaterno"
        Me.apellidoPaterno.HeaderText = "Apellido P."
        Me.apellidoPaterno.Name = "apellidoPaterno"
        '
        'apellidoMaterno
        '
        Me.apellidoMaterno.DataPropertyName = "apellidoMaterno"
        Me.apellidoMaterno.HeaderText = "Apellido M."
        Me.apellidoMaterno.Name = "apellidoMaterno"
        '
        'RFC
        '
        Me.RFC.DataPropertyName = "RFC"
        Me.RFC.HeaderText = "RFC"
        Me.RFC.Name = "RFC"
        '
        'tarjetaVales
        '
        Me.tarjetaVales.DataPropertyName = "tarjetaVales"
        Me.tarjetaVales.HeaderText = "Tarjeta"
        Me.tarjetaVales.MaxInputLength = 37000
        Me.tarjetaVales.Name = "tarjetaVales"
        Me.tarjetaVales.Width = 120
        '
        'borrar
        '
        Me.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.borrar.HeaderText = "Borrar"
        Me.borrar.Name = "borrar"
        Me.borrar.ReadOnly = True
        Me.borrar.Text = "Borrar"
        Me.borrar.ToolTipText = "Borrar"
        Me.borrar.UseColumnTextForButtonValue = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(6, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Crono-Vales"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Location = New System.Drawing.Point(-6, -3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(694, 64)
        Me.Label8.TabIndex = 16
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.FormattingEnabled = True
        Me.cmbEmpresa.Location = New System.Drawing.Point(527, 21)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpresa.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(524, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Empresa"
        '
        'lblNumeroEmpleado
        '
        Me.lblNumeroEmpleado.Location = New System.Drawing.Point(483, 94)
        Me.lblNumeroEmpleado.Name = "lblNumeroEmpleado"
        Me.lblNumeroEmpleado.Size = New System.Drawing.Size(100, 18)
        Me.lblNumeroEmpleado.TabIndex = 20
        '
        'lblNumeroTarjeta
        '
        Me.lblNumeroTarjeta.Location = New System.Drawing.Point(483, 138)
        Me.lblNumeroTarjeta.Name = "lblNumeroTarjeta"
        Me.lblNumeroTarjeta.Size = New System.Drawing.Size(135, 18)
        Me.lblNumeroTarjeta.TabIndex = 21
        '
        'frm_CatalogoDeEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 501)
        Me.Controls.Add(Me.lblNumeroTarjeta)
        Me.Controls.Add(Me.lblNumeroEmpleado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbEmpresa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgrid_Empleado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frm_CatalogoDeEmpleado"
        Me.Text = "Empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgrid_Empleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtApellidoM As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellidoP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dgrid_Empleado As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbEmpresa As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents apellidoPaterno As DataGridViewTextBoxColumn
    Friend WithEvents apellidoMaterno As DataGridViewTextBoxColumn
    Friend WithEvents RFC As DataGridViewTextBoxColumn
    Friend WithEvents tarjetaVales As DataGridViewTextBoxColumn
    Friend WithEvents borrar As DataGridViewButtonColumn
    Friend WithEvents lblNumeroEmpleado As Label
    Friend WithEvents lblNumeroTarjeta As Label
End Class
