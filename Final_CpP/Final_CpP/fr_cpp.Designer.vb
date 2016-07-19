<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_cpp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fr_cpp))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCatalogo = New System.Windows.Forms.Button()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcatNombre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblnombreproveedor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSaldototal = New System.Windows.Forms.TextBox()
        Me.txtmontopagar = New System.Windows.Forms.TextBox()
        Me.txtcantidadtotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtdia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdocumento = New System.Windows.Forms.TextBox()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.txtid_Factura = New System.Windows.Forms.TextBox()
        Me.fechapago = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Labe = New System.Windows.Forms.Label()
        Me.fecha_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.richTexto = New System.Windows.Forms.RichTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCatalogo)
        Me.GroupBox1.Controls.Add(Me.btnProveedor)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblcatNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtConcepto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblnombreproveedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidProveedor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del proveedor:"
        '
        'btnCatalogo
        '
        Me.btnCatalogo.Image = CType(resources.GetObject("btnCatalogo.Image"), System.Drawing.Image)
        Me.btnCatalogo.Location = New System.Drawing.Point(222, 88)
        Me.btnCatalogo.Name = "btnCatalogo"
        Me.btnCatalogo.Size = New System.Drawing.Size(28, 28)
        Me.btnCatalogo.TabIndex = 11
        Me.btnCatalogo.UseVisualStyleBackColor = True
        '
        'btnProveedor
        '
        Me.btnProveedor.Image = CType(resources.GetObject("btnProveedor.Image"), System.Drawing.Image)
        Me.btnProveedor.Location = New System.Drawing.Point(197, 26)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(28, 28)
        Me.btnProveedor.TabIndex = 10
        Me.btnProveedor.UseVisualStyleBackColor = True
        '
        'lblTipo
        '
        Me.lblTipo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipo.Location = New System.Drawing.Point(686, 72)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(217, 25)
        Me.lblTipo.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(641, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tipo:"
        '
        'lblcatNombre
        '
        Me.lblcatNombre.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblcatNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcatNombre.Location = New System.Drawing.Point(438, 79)
        Me.lblcatNombre.Name = "lblcatNombre"
        Me.lblcatNombre.Size = New System.Drawing.Size(186, 25)
        Me.lblcatNombre.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nombre de concepto:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(129, 88)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(87, 25)
        Me.txtConcepto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Concepto:"
        '
        'lblnombreproveedor
        '
        Me.lblnombreproveedor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblnombreproveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnombreproveedor.Location = New System.Drawing.Point(365, 26)
        Me.lblnombreproveedor.Name = "lblnombreproveedor"
        Me.lblnombreproveedor.Size = New System.Drawing.Size(538, 25)
        Me.lblnombreproveedor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'txtidProveedor
        '
        Me.txtidProveedor.Location = New System.Drawing.Point(104, 26)
        Me.txtidProveedor.Name = "txtidProveedor"
        Me.txtidProveedor.Size = New System.Drawing.Size(87, 25)
        Me.txtidProveedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSaldototal)
        Me.GroupBox2.Controls.Add(Me.txtmontopagar)
        Me.GroupBox2.Controls.Add(Me.txtcantidadtotal)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtdia)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtdocumento)
        Me.GroupBox2.Controls.Add(Me.btnFactura)
        Me.GroupBox2.Controls.Add(Me.txtid_Factura)
        Me.GroupBox2.Controls.Add(Me.fechapago)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Labe)
        Me.GroupBox2.Controls.Add(Me.fecha_vencimiento)
        Me.GroupBox2.Controls.Add(Me.lblReferencia)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(914, 314)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txtSaldototal
        '
        Me.txtSaldototal.Location = New System.Drawing.Point(659, 213)
        Me.txtSaldototal.Name = "txtSaldototal"
        Me.txtSaldototal.Size = New System.Drawing.Size(188, 25)
        Me.txtSaldototal.TabIndex = 27
        '
        'txtmontopagar
        '
        Me.txtmontopagar.Location = New System.Drawing.Point(659, 173)
        Me.txtmontopagar.Name = "txtmontopagar"
        Me.txtmontopagar.Size = New System.Drawing.Size(188, 25)
        Me.txtmontopagar.TabIndex = 26
        '
        'txtcantidadtotal
        '
        Me.txtcantidadtotal.Location = New System.Drawing.Point(660, 130)
        Me.txtcantidadtotal.Name = "txtcantidadtotal"
        Me.txtcantidadtotal.Size = New System.Drawing.Size(187, 25)
        Me.txtcantidadtotal.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(540, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Saldo Existente:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(547, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Monto a Pagar:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(552, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Saldo Total:"
        '
        'txtdia
        '
        Me.txtdia.Location = New System.Drawing.Point(197, 199)
        Me.txtdia.Name = "txtdia"
        Me.txtdia.Size = New System.Drawing.Size(210, 25)
        Me.txtdia.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Dias de Vencimiento:"
        '
        'txtdocumento
        '
        Me.txtdocumento.Location = New System.Drawing.Point(197, 93)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.Size = New System.Drawing.Size(196, 25)
        Me.txtdocumento.TabIndex = 19
        '
        'btnFactura
        '
        Me.btnFactura.Image = CType(resources.GetObject("btnFactura.Image"), System.Drawing.Image)
        Me.btnFactura.Location = New System.Drawing.Point(365, 41)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(28, 28)
        Me.btnFactura.TabIndex = 12
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'txtid_Factura
        '
        Me.txtid_Factura.Location = New System.Drawing.Point(197, 43)
        Me.txtid_Factura.Name = "txtid_Factura"
        Me.txtid_Factura.Size = New System.Drawing.Size(162, 25)
        Me.txtid_Factura.TabIndex = 12
        '
        'fechapago
        '
        Me.fechapago.Location = New System.Drawing.Point(594, 46)
        Me.fechapago.Name = "fechapago"
        Me.fechapago.Size = New System.Drawing.Size(278, 25)
        Me.fechapago.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(435, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Fecha de Pago"
        '
        'Labe
        '
        Me.Labe.AutoSize = True
        Me.Labe.Location = New System.Drawing.Point(35, 263)
        Me.Labe.Name = "Labe"
        Me.Labe.Size = New System.Drawing.Size(156, 17)
        Me.Labe.TabIndex = 16
        Me.Labe.Text = "Fecha de Vencimiento:"
        '
        'fecha_vencimiento
        '
        Me.fecha_vencimiento.Location = New System.Drawing.Point(197, 257)
        Me.fecha_vencimiento.Name = "fecha_vencimiento"
        Me.fecha_vencimiento.Size = New System.Drawing.Size(281, 25)
        Me.fecha_vencimiento.TabIndex = 15
        '
        'lblReferencia
        '
        Me.lblReferencia.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblReferencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReferencia.Location = New System.Drawing.Point(197, 142)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(196, 25)
        Me.lblReferencia.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "No. Documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "No. Factura:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "No. Referencia:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Location = New System.Drawing.Point(20, 550)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1239, 103)
        Me.Label14.TabIndex = 2
        '
        'btnInsertar
        '
        Me.btnInsertar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInsertar.Image = CType(resources.GetObject("btnInsertar.Image"), System.Drawing.Image)
        Me.btnInsertar.Location = New System.Drawing.Point(953, 569)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(62, 59)
        Me.btnInsertar.TabIndex = 3
        Me.btnInsertar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(1023, 569)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(65, 59)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1170, 569)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 59)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label15.Location = New System.Drawing.Point(962, 631)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Guardar"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label16.Location = New System.Drawing.Point(1036, 631)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Eliminar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label17.Location = New System.Drawing.Point(1177, 631)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Regresar"
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
        Me.btnReporte.Location = New System.Drawing.Point(1094, 569)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(70, 59)
        Me.btnReporte.TabIndex = 31
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label18.Location = New System.Drawing.Point(1108, 631)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Reporte"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.richTexto)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(953, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 302)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Observaciones:"
        '
        'richTexto
        '
        Me.richTexto.Location = New System.Drawing.Point(30, 80)
        Me.richTexto.Name = "richTexto"
        Me.richTexto.Size = New System.Drawing.Size(194, 216)
        Me.richTexto.TabIndex = 0
        Me.richTexto.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(36, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(164, 16)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Ingrese alguna observacion"
        '
        'fr_cpp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 733)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "fr_cpp"
        Me.Text = "Cuentas por Pagar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcatNombre As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConcepto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblnombreproveedor As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidProveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCatalogo As Button
    Friend WithEvents btnProveedor As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSaldototal As TextBox
    Friend WithEvents txtmontopagar As TextBox
    Friend WithEvents txtcantidadtotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtdia As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtdocumento As TextBox
    Friend WithEvents btnFactura As Button
    Friend WithEvents txtid_Factura As TextBox
    Friend WithEvents fechapago As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Labe As Label
    Friend WithEvents fecha_vencimiento As DateTimePicker
    Friend WithEvents lblReferencia As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnReporte As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents richTexto As RichTextBox
End Class
