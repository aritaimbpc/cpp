<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_buscar_proveedor
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdsocioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SocnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdfacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacnoreferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacfechaemitidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vista1cppBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sae_cpp_finalDataSet2 = New Final_CpP.sae_cpp_finalDataSet2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Vista1_cppTableAdapter = New Final_CpP.sae_cpp_finalDataSet2TableAdapters.vista1_cppTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista1cppBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sae_cpp_finalDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsocioDataGridViewTextBoxColumn, Me.SocnombreDataGridViewTextBoxColumn, Me.IdfacturaDataGridViewTextBoxColumn, Me.FacnoreferenciaDataGridViewTextBoxColumn, Me.FacfechaemitidaDataGridViewTextBoxColumn, Me.FactotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Vista1cppBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(38, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(641, 150)
        Me.DataGridView1.TabIndex = 0
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
        Me.SocnombreDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.SocnombreDataGridViewTextBoxColumn.Name = "SocnombreDataGridViewTextBoxColumn"
        '
        'IdfacturaDataGridViewTextBoxColumn
        '
        Me.IdfacturaDataGridViewTextBoxColumn.DataPropertyName = "id_factura"
        Me.IdfacturaDataGridViewTextBoxColumn.HeaderText = "No. Factura"
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
        Me.FacfechaemitidaDataGridViewTextBoxColumn.HeaderText = "Fecha de Realizacion"
        Me.FacfechaemitidaDataGridViewTextBoxColumn.Name = "FacfechaemitidaDataGridViewTextBoxColumn"
        '
        'FactotalDataGridViewTextBoxColumn
        '
        Me.FactotalDataGridViewTextBoxColumn.DataPropertyName = "fac_total"
        Me.FactotalDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.FactotalDataGridViewTextBoxColumn.Name = "FactotalDataGridViewTextBoxColumn"
        '
        'Vista1cppBindingSource
        '
        Me.Vista1cppBindingSource.DataMember = "vista1_cpp"
        Me.Vista1cppBindingSource.DataSource = Me.Sae_cpp_finalDataSet2
        '
        'Sae_cpp_finalDataSet2
        '
        Me.Sae_cpp_finalDataSet2.DataSetName = "sae_cpp_finalDataSet2"
        Me.Sae_cpp_finalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblnombre)
        Me.GroupBox1.Controls.Add(Me.lblid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(698, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 150)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Seleccionados"
        '
        'lblnombre
        '
        Me.lblnombre.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblnombre.Location = New System.Drawing.Point(93, 69)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(253, 26)
        Me.lblnombre.TabIndex = 3
        '
        'lblid
        '
        Me.lblid.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblid.Location = New System.Drawing.Point(93, 28)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(253, 26)
        Me.lblid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(35, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1039, 82)
        Me.Label4.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(890, 335)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 53)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(985, 335)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 53)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Vista1_cppTableAdapter
        '
        Me.Vista1_cppTableAdapter.ClearBeforeFill = True
        '
        'fr_buscar_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 419)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "fr_buscar_proveedor"
        Me.Text = "Buscar Proveedor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista1cppBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sae_cpp_finalDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblid As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Sae_cpp_finalDataSet2 As sae_cpp_finalDataSet2
    Friend WithEvents Vista1cppBindingSource As BindingSource
    Friend WithEvents Vista1_cppTableAdapter As sae_cpp_finalDataSet2TableAdapters.vista1_cppTableAdapter
    Friend WithEvents IdsocioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SocnombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdfacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacnoreferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacfechaemitidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FactotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
