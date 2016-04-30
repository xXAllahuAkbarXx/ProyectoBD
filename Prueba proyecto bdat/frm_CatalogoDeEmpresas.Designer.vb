<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CatalogoDeEmpresas
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
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dgrid_Empresa = New System.Windows.Forms.DataGridView()
        Me.idComercio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RCF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpInicioDeOperaciones = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gboxDomicilio = New System.Windows.Forms.GroupBox()
        Me.txtCp = New System.Windows.Forms.TextBox()
        Me.CodigoP = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbMunicipio = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgrid_Empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxDomicilio.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Location = New System.Drawing.Point(12, 92)
        Me.lblRFC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(35, 17)
        Me.lblRFC.TabIndex = 0
        Me.lblRFC.Text = "RFC"
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(16, 112)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(267, 22)
        Me.txtRFC.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(304, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Razon social"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(306, 112)
        Me.txtRazonSocial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(267, 22)
        Me.txtRazonSocial.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 151)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(122, 17)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre comercial"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(16, 171)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(189, 22)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 402)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID"
        Me.Label2.Visible = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(51, 398)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(65, 22)
        Me.txtID.TabIndex = 7
        Me.txtID.Visible = False
        '
        'dgrid_Empresa
        '
        Me.dgrid_Empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid_Empresa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idComercio, Me.RCF, Me.RazonSocial, Me.Nombre})
        Me.dgrid_Empresa.Location = New System.Drawing.Point(17, 439)
        Me.dgrid_Empresa.Margin = New System.Windows.Forms.Padding(4)
        Me.dgrid_Empresa.Name = "dgrid_Empresa"
        Me.dgrid_Empresa.Size = New System.Drawing.Size(560, 272)
        Me.dgrid_Empresa.TabIndex = 8
        '
        'idComercio
        '
        Me.idComercio.DataPropertyName = "idComercio"
        Me.idComercio.HeaderText = "ID"
        Me.idComercio.Name = "idComercio"
        Me.idComercio.ReadOnly = True
        Me.idComercio.Visible = False
        '
        'RCF
        '
        Me.RCF.DataPropertyName = "rfc"
        Me.RCF.HeaderText = "RFC"
        Me.RCF.Name = "RCF"
        Me.RCF.Width = 120
        '
        'RazonSocial
        '
        Me.RazonSocial.DataPropertyName = "razonSocial"
        Me.RazonSocial.HeaderText = "Razon Social"
        Me.RazonSocial.Name = "RazonSocial"
        Me.RazonSocial.Width = 135
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 120
        '
        'dtpInicioDeOperaciones
        '
        Me.dtpInicioDeOperaciones.CustomFormat = "yyyy-MM-dd"
        Me.dtpInicioDeOperaciones.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInicioDeOperaciones.Location = New System.Drawing.Point(308, 171)
        Me.dtpInicioDeOperaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpInicioDeOperaciones.Name = "dtpInicioDeOperaciones"
        Me.dtpInicioDeOperaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpInicioDeOperaciones.Size = New System.Drawing.Size(265, 22)
        Me.dtpInicioDeOperaciones.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Inicio de operaciones"
        '
        'gboxDomicilio
        '
        Me.gboxDomicilio.Controls.Add(Me.txtCp)
        Me.gboxDomicilio.Controls.Add(Me.CodigoP)
        Me.gboxDomicilio.Controls.Add(Me.cbEstado)
        Me.gboxDomicilio.Controls.Add(Me.Label8)
        Me.gboxDomicilio.Controls.Add(Me.cbMunicipio)
        Me.gboxDomicilio.Controls.Add(Me.Label7)
        Me.gboxDomicilio.Controls.Add(Me.txtColonia)
        Me.gboxDomicilio.Controls.Add(Me.Label6)
        Me.gboxDomicilio.Controls.Add(Me.txtNumero)
        Me.gboxDomicilio.Controls.Add(Me.Label5)
        Me.gboxDomicilio.Controls.Add(Me.txtCalle)
        Me.gboxDomicilio.Controls.Add(Me.Label4)
        Me.gboxDomicilio.Location = New System.Drawing.Point(17, 215)
        Me.gboxDomicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.gboxDomicilio.Name = "gboxDomicilio"
        Me.gboxDomicilio.Padding = New System.Windows.Forms.Padding(4)
        Me.gboxDomicilio.Size = New System.Drawing.Size(559, 164)
        Me.gboxDomicilio.TabIndex = 5
        Me.gboxDomicilio.TabStop = False
        Me.gboxDomicilio.Text = "Domicilio"
        '
        'txtCp
        '
        Me.txtCp.Location = New System.Drawing.Point(75, 126)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(100, 22)
        Me.txtCp.TabIndex = 12
        '
        'CodigoP
        '
        Me.CodigoP.AutoSize = True
        Me.CodigoP.Location = New System.Drawing.Point(18, 129)
        Me.CodigoP.Name = "CodigoP"
        Me.CodigoP.Size = New System.Drawing.Size(34, 17)
        Me.CodigoP.TabIndex = 11
        Me.CodigoP.Text = "C.P."
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(75, 76)
        Me.cbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(191, 24)
        Me.cbEstado.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 83)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Estado"
        '
        'cbMunicipio
        '
        Me.cbMunicipio.FormattingEnabled = True
        Me.cbMunicipio.Location = New System.Drawing.Point(368, 79)
        Me.cbMunicipio.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMunicipio.Name = "cbMunicipio"
        Me.cbMunicipio.Size = New System.Drawing.Size(180, 24)
        Me.cbMunicipio.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(291, 83)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Municipio"
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(416, 30)
        Me.txtColonia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(132, 22)
        Me.txtColonia.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Colonia"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(285, 30)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(57, 22)
        Me.txtNumero.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Número"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(61, 30)
        Me.txtCalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(148, 22)
        Me.txtCalle.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Calle"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.Location = New System.Drawing.Point(478, 398)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 28)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.Location = New System.Drawing.Point(350, 398)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(11, 23)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 31)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Crono-Vales"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Maroon
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(846, 78)
        Me.Label10.TabIndex = 17
        '
        'frm_CatalogoDeEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 724)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.gboxDomicilio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpInicioDeOperaciones)
        Me.Controls.Add(Me.dgrid_Empresa)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.lblRFC)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_CatalogoDeEmpresas"
        Me.Text = "Empresas"
        CType(Me.dgrid_Empresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxDomicilio.ResumeLayout(False)
        Me.gboxDomicilio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRFC As Label
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents dgrid_Empresa As DataGridView
    Friend WithEvents idComercio As DataGridViewTextBoxColumn
    Friend WithEvents RCF As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents dtpInicioDeOperaciones As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents gboxDomicilio As GroupBox
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbMunicipio As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtCp As System.Windows.Forms.TextBox
    Friend WithEvents CodigoP As System.Windows.Forms.Label
End Class
