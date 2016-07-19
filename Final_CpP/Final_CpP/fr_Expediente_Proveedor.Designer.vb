<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_Expediente_Proveedor
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdsocioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SocnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdfacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacnoreferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacfechaemitidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vista1cppBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sae_cpp_finalDataSet3 = New Final_CpP.sae_cpp_finalDataSet3()
        Me.Vista1_cppTableAdapter = New Final_CpP.sae_cpp_finalDataSet3TableAdapters.vista1_cppTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista1cppBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sae_cpp_finalDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Expediente del Proveedor"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsocioDataGridViewTextBoxColumn, Me.SocnombreDataGridViewTextBoxColumn, Me.IdfacturaDataGridViewTextBoxColumn, Me.FacnoreferenciaDataGridViewTextBoxColumn, Me.FacfechaemitidaDataGridViewTextBoxColumn, Me.FactotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Vista1cppBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(42, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(654, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'IdsocioDataGridViewTextBoxColumn
        '
        Me.IdsocioDataGridViewTextBoxColumn.DataPropertyName = "id_socio"
        Me.IdsocioDataGridViewTextBoxColumn.HeaderText = "Clave"
        Me.IdsocioDataGridViewTextBoxColumn.Name = "IdsocioDataGridViewTextBoxColumn"
        '
        'SocnombreDataGridViewTextBoxColumn
        '
        Me.SocnombreDataGridViewTextBoxColumn.DataPropertyName = "soc_nombre"
        Me.SocnombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.SocnombreDataGridViewTextBoxColumn.Name = "SocnombreDataGridViewTextBoxColumn"
        '
        'IdfacturaDataGridViewTextBoxColumn
        '
        Me.IdfacturaDataGridViewTextBoxColumn.DataPropertyName = "id_factura"
        Me.IdfacturaDataGridViewTextBoxColumn.HeaderText = "No Factura"
        Me.IdfacturaDataGridViewTextBoxColumn.Name = "IdfacturaDataGridViewTextBoxColumn"
        '
        'FacnoreferenciaDataGridViewTextBoxColumn
        '
        Me.FacnoreferenciaDataGridViewTextBoxColumn.DataPropertyName = "fac_no_referencia"
        Me.FacnoreferenciaDataGridViewTextBoxColumn.HeaderText = "No. de Serie"
        Me.FacnoreferenciaDataGridViewTextBoxColumn.Name = "FacnoreferenciaDataGridViewTextBoxColumn"
        '
        'FacfechaemitidaDataGridViewTextBoxColumn
        '
        Me.FacfechaemitidaDataGridViewTextBoxColumn.DataPropertyName = "fac_fecha_emitida"
        Me.FacfechaemitidaDataGridViewTextBoxColumn.HeaderText = "Fecha Emitida"
        Me.FacfechaemitidaDataGridViewTextBoxColumn.Name = "FacfechaemitidaDataGridViewTextBoxColumn"
        '
        'FactotalDataGridViewTextBoxColumn
        '
        Me.FactotalDataGridViewTextBoxColumn.DataPropertyName = "fac_total"
        Me.FactotalDataGridViewTextBoxColumn.HeaderText = "Saldo Actual"
        Me.FactotalDataGridViewTextBoxColumn.Name = "FactotalDataGridViewTextBoxColumn"
        '
        'Vista1cppBindingSource
        '
        Me.Vista1cppBindingSource.DataMember = "vista1_cpp"
        Me.Vista1cppBindingSource.DataSource = Me.Sae_cpp_finalDataSet3
        '
        'Sae_cpp_finalDataSet3
        '
        Me.Sae_cpp_finalDataSet3.DataSetName = "sae_cpp_finalDataSet3"
        Me.Sae_cpp_finalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vista1_cppTableAdapter
        '
        Me.Vista1_cppTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(1, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(741, 84)
        Me.Label2.TabIndex = 2
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(587, 315)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(69, 47)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(662, 315)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(69, 47)
        Me.Salir.TabIndex = 4
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'fr_Expediente_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 399)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fr_Expediente_Proveedor"
        Me.Text = "Cuenta del Proveedor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista1cppBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sae_cpp_finalDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Sae_cpp_finalDataSet3 As sae_cpp_finalDataSet3
    Friend WithEvents Vista1cppBindingSource As BindingSource
    Friend WithEvents Vista1_cppTableAdapter As sae_cpp_finalDataSet3TableAdapters.vista1_cppTableAdapter
    Friend WithEvents IdsocioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SocnombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdfacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacnoreferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacfechaemitidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FactotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Salir As Button
End Class
