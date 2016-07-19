Public Class fr_cpp

    Dim conexion As Conexion = New Conexion()
    Dim prove As fr_buscar_proveedor
    ' Dim fac As fr_buscar_Factura_cpp = New fr_buscar_Factura_cpp
    'Dim cat As fr_catalogoFormaPago_cpp = New fr_catalogoFormaPago_cpp


    ' VARIABLES PARA INICIALIZAR EL NUEVO COMPONENTE

    Dim nombrepro As String

    Sub fr_cpp(ByVal proveid As Integer, ByVal provenombre As String)
        InitializeComponent()

        prove.idpro = proveid
        prove.pronombre = provenombre


    End Sub




    Private Sub btnCatalogo_Click(sender As Object, e As EventArgs) Handles btnCatalogo.Click
        Dim catalogo As New fr_Buscar_Catalogo_CpP
        catalogo.Show()

    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        Dim pro As New fr_buscar_proveedor
        pro.Show()

    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        Dim fac As New fr_buscar_Factura_cpp
        fac.Show()

    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim act_idprove As Integer
        Dim act_nombrepro As String

        act_idprove = prove.idpro
        act_nombrepro = prove.pronombre
        txtidProveedor.Text = act_idprove
        lblnombreproveedor.Text = act_nombrepro



        Dim agregar As String = " insert into tbl_sae_cpp values ('" + txtdocumento.Text + "','" + fechapago.Text + "','" + fecha_vencimiento.Text + "','" + txtdia.Text + txtmontopagar.Text + "','" + txtcantidadtotal.Text + "','" + txtConcepto.Text + "','" + txtid_Factura.Text + "','" + richTexto.Text + "')"

        If (conexion.Insertar(agregar)) Then
            MessageBox.Show("datos Agregados Correctamente")
        Else
            MessageBox.Show("error al agregar Datos")
        End If





    End Sub

    Dim codigo As Integer

    Private Sub fr_cpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



End Class