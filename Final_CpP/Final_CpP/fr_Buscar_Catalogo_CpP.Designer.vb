<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_Buscar_Catalogo_CpP
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
        Me.IdcatformapagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtfdescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtftipopagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblsaecatFormapagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sae_cpp_finalDataSet = New Final_CpP.sae_cpp_finalDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Tbl_sae_catFormapagoTableAdapter = New Final_CpP.sae_cpp_finalDataSetTableAdapters.tbl_sae_catFormapagoTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsaecatFormapagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sae_cpp_finalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcatformapagoDataGridViewTextBoxColumn, Me.CtfdescripcionDataGridViewTextBoxColumn, Me.CtftipopagoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblsaecatFormapagoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(52, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'IdcatformapagoDataGridViewTextBoxColumn
        '
        Me.IdcatformapagoDataGridViewTextBoxColumn.DataPropertyName = "id_catformapago"
        Me.IdcatformapagoDataGridViewTextBoxColumn.HeaderText = "Clave"
        Me.IdcatformapagoDataGridViewTextBoxColumn.Name = "IdcatformapagoDataGridViewTextBoxColumn"
        Me.IdcatformapagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CtfdescripcionDataGridViewTextBoxColumn
        '
        Me.CtfdescripcionDataGridViewTextBoxColumn.DataPropertyName = "ctf_descripcion"
        Me.CtfdescripcionDataGridViewTextBoxColumn.HeaderText = "Descripciòn"
        Me.CtfdescripcionDataGridViewTextBoxColumn.Name = "CtfdescripcionDataGridViewTextBoxColumn"
        '
        'CtftipopagoDataGridViewTextBoxColumn
        '
        Me.CtftipopagoDataGridViewTextBoxColumn.DataPropertyName = "ctf_tipopago"
        Me.CtftipopagoDataGridViewTextBoxColumn.HeaderText = "Tipo de Pago"
        Me.CtftipopagoDataGridViewTextBoxColumn.Name = "CtftipopagoDataGridViewTextBoxColumn"
        '
        'TblsaecatFormapagoBindingSource
        '
        Me.TblsaecatFormapagoBindingSource.DataMember = "tbl_sae_catFormapago"
        Me.TblsaecatFormapagoBindingSource.DataSource = Me.Sae_cpp_finalDataSet
        '
        'Sae_cpp_finalDataSet
        '
        Me.Sae_cpp_finalDataSet.DataSetName = "sae_cpp_finalDataSet"
        Me.Sae_cpp_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.lblid)
        Me.GroupBox1.Controls.Add(Me.lblnombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(503, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 202)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Seleccionados"
        '
        'lblTipo
        '
        Me.lblTipo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipo.Location = New System.Drawing.Point(171, 123)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(237, 24)
        Me.lblTipo.TabIndex = 7
        '
        'lblid
        '
        Me.lblid.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblid.Location = New System.Drawing.Point(171, 30)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(237, 24)
        Me.lblid.TabIndex = 6
        '
        'lblnombre
        '
        Me.lblnombre.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblnombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnombre.Location = New System.Drawing.Point(171, 76)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(237, 24)
        Me.lblnombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo de Pago:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(12, 359)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(950, 92)
        Me.Label4.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(757, 379)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(82, 60)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(859, 379)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(82, 60)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Tbl_sae_catFormapagoTableAdapter
        '
        Me.Tbl_sae_catFormapagoTableAdapter.ClearBeforeFill = True
        '
        'fr_Buscar_Catalogo_CpP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 475)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "fr_Buscar_Catalogo_CpP"
        Me.Text = "Catalogo de Formas de Pago"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsaecatFormapagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sae_cpp_finalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblid As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Sae_cpp_finalDataSet As sae_cpp_finalDataSet
    Friend WithEvents TblsaecatFormapagoBindingSource As BindingSource
    Friend WithEvents Tbl_sae_catFormapagoTableAdapter As sae_cpp_finalDataSetTableAdapters.tbl_sae_catFormapagoTableAdapter
    Friend WithEvents IdcatformapagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CtfdescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CtftipopagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
