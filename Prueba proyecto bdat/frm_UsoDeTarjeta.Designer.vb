<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UsoDeTarjeta
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chartTarjetaComercios = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Entrar = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        CType(Me.chartTarjetaComercios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartTarjetaComercios
        '
        Me.chartTarjetaComercios.BackColor = System.Drawing.SystemColors.Control
        ChartArea1.Name = "ChartArea1"
        Me.chartTarjetaComercios.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartTarjetaComercios.Legends.Add(Legend1)
        Me.chartTarjetaComercios.Location = New System.Drawing.Point(12, 123)
        Me.chartTarjetaComercios.Name = "chartTarjetaComercios"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.IsValueShownAsLabel = True
        Series1.LabelFormat = "#'%'"
        Series1.Legend = "Legend1"
        Series1.Name = "Comercios"
        Series1.XValueMember = "nombreEmpresa"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.chartTarjetaComercios.Series.Add(Series1)
        Me.chartTarjetaComercios.Size = New System.Drawing.Size(464, 372)
        Me.chartTarjetaComercios.TabIndex = 0
        Me.chartTarjetaComercios.Text = "Uso de tarjeta por comercios"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(165, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Crono-Vales"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(-2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 64)
        Me.Label1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Uso de la tarjeta por comercio"
        '
        'btn_Entrar
        '
        Me.btn_Entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Entrar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Entrar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Entrar.Location = New System.Drawing.Point(389, 431)
        Me.btn_Entrar.Name = "btn_Entrar"
        Me.btn_Entrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Entrar.TabIndex = 19
        Me.btn_Entrar.Text = "Menu"
        Me.btn_Entrar.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Salir.Location = New System.Drawing.Point(389, 460)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_Salir.TabIndex = 20
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'frm_UsoDeTarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 507)
        Me.Controls.Add(Me.btn_Salir)
        Me.Controls.Add(Me.btn_Entrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chartTarjetaComercios)
        Me.Name = "frm_UsoDeTarjeta"
        Me.Text = "Uso de tarjeta"
        CType(Me.chartTarjetaComercios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chartTarjetaComercios As DataVisualization.Charting.Chart
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Entrar As Button
    Friend WithEvents btn_Salir As Button
End Class
