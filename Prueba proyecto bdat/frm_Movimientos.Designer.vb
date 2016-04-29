<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Movimientos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("jeje")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("gaga")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("tytyty")
        Me.header = New System.Windows.Forms.Label()
        Me.headerColor = New System.Windows.Forms.Label()
        Me.tarjetaLabel = New System.Windows.Forms.Label()
        Me.tarjetaTextbox = New System.Windows.Forms.TextBox()
        Me.EmpleadoTextbox = New System.Windows.Forms.TextBox()
        Me.EmpleadoLabel = New System.Windows.Forms.Label()
        Me.GroupPredefinido = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupPersonalizado = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.fechaInicioLabel = New System.Windows.Forms.Label()
        Me.fechaFinLabel = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupPredefinido.SuspendLayout()
        Me.GroupPersonalizado.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Maroon
        Me.header.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.header.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.White
        Me.header.Location = New System.Drawing.Point(12, 9)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(108, 20)
        Me.header.TabIndex = 0
        Me.header.Text = "Crono-Vales"
        '
        'headerColor
        '
        Me.headerColor.BackColor = System.Drawing.Color.Maroon
        Me.headerColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.headerColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.headerColor.Location = New System.Drawing.Point(-12, -7)
        Me.headerColor.Name = "headerColor"
        Me.headerColor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.headerColor.Size = New System.Drawing.Size(801, 45)
        Me.headerColor.TabIndex = 1
        '
        'tarjetaLabel
        '
        Me.tarjetaLabel.AutoSize = True
        Me.tarjetaLabel.Location = New System.Drawing.Point(13, 42)
        Me.tarjetaLabel.Name = "tarjetaLabel"
        Me.tarjetaLabel.Size = New System.Drawing.Size(40, 13)
        Me.tarjetaLabel.TabIndex = 2
        Me.tarjetaLabel.Text = "Tarjeta"
        '
        'tarjetaTextbox
        '
        Me.tarjetaTextbox.Location = New System.Drawing.Point(16, 59)
        Me.tarjetaTextbox.Name = "tarjetaTextbox"
        Me.tarjetaTextbox.Size = New System.Drawing.Size(226, 20)
        Me.tarjetaTextbox.TabIndex = 3
        '
        'EmpleadoTextbox
        '
        Me.EmpleadoTextbox.Location = New System.Drawing.Point(16, 98)
        Me.EmpleadoTextbox.Name = "EmpleadoTextbox"
        Me.EmpleadoTextbox.Size = New System.Drawing.Size(226, 20)
        Me.EmpleadoTextbox.TabIndex = 5
        '
        'EmpleadoLabel
        '
        Me.EmpleadoLabel.AutoSize = True
        Me.EmpleadoLabel.Location = New System.Drawing.Point(13, 82)
        Me.EmpleadoLabel.Name = "EmpleadoLabel"
        Me.EmpleadoLabel.Size = New System.Drawing.Size(54, 13)
        Me.EmpleadoLabel.TabIndex = 4
        Me.EmpleadoLabel.Text = "Empleado"
        '
        'GroupPredefinido
        '
        Me.GroupPredefinido.Controls.Add(Me.RadioButton3)
        Me.GroupPredefinido.Controls.Add(Me.RadioButton2)
        Me.GroupPredefinido.Controls.Add(Me.RadioButton1)
        Me.GroupPredefinido.Location = New System.Drawing.Point(16, 124)
        Me.GroupPredefinido.Name = "GroupPredefinido"
        Me.GroupPredefinido.Size = New System.Drawing.Size(226, 94)
        Me.GroupPredefinido.TabIndex = 6
        Me.GroupPredefinido.TabStop = False
        Me.GroupPredefinido.Text = "Rango predefinido"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Hace un día"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 43)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Hace 7 días"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(7, 66)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(88, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Hace un mes"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupPersonalizado
        '
        Me.GroupPersonalizado.Controls.Add(Me.DateTimePicker2)
        Me.GroupPersonalizado.Controls.Add(Me.fechaFinLabel)
        Me.GroupPersonalizado.Controls.Add(Me.fechaInicioLabel)
        Me.GroupPersonalizado.Controls.Add(Me.DateTimePicker1)
        Me.GroupPersonalizado.Location = New System.Drawing.Point(16, 224)
        Me.GroupPersonalizado.Name = "GroupPersonalizado"
        Me.GroupPersonalizado.Size = New System.Drawing.Size(226, 111)
        Me.GroupPersonalizado.TabIndex = 7
        Me.GroupPersonalizado.TabStop = False
        Me.GroupPersonalizado.Text = "Rango personalizado"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(213, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'fechaInicioLabel
        '
        Me.fechaInicioLabel.AutoSize = True
        Me.fechaInicioLabel.Location = New System.Drawing.Point(7, 21)
        Me.fechaInicioLabel.Name = "fechaInicioLabel"
        Me.fechaInicioLabel.Size = New System.Drawing.Size(64, 13)
        Me.fechaInicioLabel.TabIndex = 1
        Me.fechaInicioLabel.Text = "Fecha inicio"
        '
        'fechaFinLabel
        '
        Me.fechaFinLabel.AutoSize = True
        Me.fechaFinLabel.Location = New System.Drawing.Point(7, 63)
        Me.fechaFinLabel.Name = "fechaFinLabel"
        Me.fechaFinLabel.Size = New System.Drawing.Size(51, 13)
        Me.fechaFinLabel.TabIndex = 2
        Me.fechaFinLabel.Text = "Fecha fin"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(7, 79)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(213, 20)
        Me.DateTimePicker2.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ListView1.Location = New System.Drawing.Point(248, 59)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(527, 276)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 152
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 267
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 146
        '
        'frm_Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 349)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupPersonalizado)
        Me.Controls.Add(Me.GroupPredefinido)
        Me.Controls.Add(Me.EmpleadoTextbox)
        Me.Controls.Add(Me.EmpleadoLabel)
        Me.Controls.Add(Me.tarjetaTextbox)
        Me.Controls.Add(Me.tarjetaLabel)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.headerColor)
        Me.Name = "frm_Movimientos"
        Me.Text = "frm_Movimientos"
        Me.GroupPredefinido.ResumeLayout(False)
        Me.GroupPredefinido.PerformLayout()
        Me.GroupPersonalizado.ResumeLayout(False)
        Me.GroupPersonalizado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As Label
    Friend WithEvents headerColor As Label
    Friend WithEvents tarjetaLabel As Label
    Friend WithEvents tarjetaTextbox As TextBox
    Friend WithEvents EmpleadoTextbox As TextBox
    Friend WithEvents EmpleadoLabel As Label
    Friend WithEvents GroupPredefinido As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupPersonalizado As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents fechaFinLabel As Label
    Friend WithEvents fechaInicioLabel As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
