<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_buscar_Factura_cpp
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblreferencia = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Sae_cpp_finalDataSet1 = New Final_CpP.sae_cpp_finalDataSet1()
        Me.Vista1cppBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vista1_cppTableAdapter = New Final_CpP.sae_cpp_finalDataSet1TableAdapters.vista1_cppTableAdapter()
        Me.IdsocioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SocnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdfacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacnoreferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacfechaemitidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Sae_cpp_finalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista1cppBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsocioDataGridViewTextBoxColumn, Me.SocnombreDataGridViewTextBoxColumn, Me.IdfacturaDataGridViewTextBoxColumn, Me.FacnoreferenciaDataGridViewTextBoxColumn, Me.FacfechaemitidaDataGridViewTextBoxColumn, Me.FactotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Vista1cppBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(648, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSaldo)
        Me.GroupBox1.Controls.Add(Me.lblreferencia)
        Me.GroupBox1.Controls.Add(Me.lblid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(786, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 204)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Seleccionados"
        '
        'lblSaldo
        '
        Me.lblSaldo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblSaldo.Location = New System.Drawing.Point(153, 123)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(226, 27)
        Me.lblSaldo.TabIndex = 5
        '
        'lblreferencia
        '
        Me.lblreferencia.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblreferencia.Location = New System.Drawing.Point(153, 80)
        Me.lblreferencia.Name = "lblreferencia"
        Me.lblreferencia.Size = New System.Drawing.Size(226, 27)
        Me.lblreferencia.TabIndex = 4
        '
        'lblid
        '
        Me.lblid.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblid.Location = New System.Drawing.Point(151, 32)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(228, 27)
        Me.lblid.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Saldo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No de Referencia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(12, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1212, 87)
        Me.Label4.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(1011, 322)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 64)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(1117, 322)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 64)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Sae_cpp_finalDataSet1
        '
        Me.Sae_cpp_finalDataSet1.DataSetName = "sae_cpp_finalDataSet1"
        Me.Sae_cpp_finalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vista1cppBindingSource
        '
        Me.Vista1cppBindingSource.DataMember = "vista1_cpp"
        Me.Vista1cppBindingSource.DataSource = Me.Sae_cpp_finalDataSet1
        '
        'Vista1_cppTableAdapter
        '
        Me.Vista1_cppTableAdapter.ClearBeforeFill = True
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
        Me.FacnoreferenciaDataGridViewTextBoxColumn.HeaderText = "No. Serie de Factura"
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
        'fr_buscar_Factura_cpp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 489)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "fr_buscar_Factura_cpp"
        Me.Text = "Buscar Factura del Proveedor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Sae_cpp_finalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista1cppBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblreferencia As Label
    Friend WithEvents lblid As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Sae_cpp_finalDataSet1 As sae_cpp_finalDataSet1
    Friend WithEvents Vista1cppBindingSource As BindingSource
    Friend WithEvents Vista1_cppTableAdapter As sae_cpp_finalDataSet1TableAdapters.vista1_cppTableAdapter
    Friend WithEvents IdsocioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SocnombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdfacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacnoreferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacfechaemitidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FactotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
