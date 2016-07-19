Public Class fr_buscar_proveedor
    Dim regresar As fr_cpp = New fr_cpp
    'Public regresar As fr_cpp

    Public idpro As Int16
    Public pronombre As String




    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()

    End Sub

    Private Sub fr_buscar_proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sae_cpp_finalDataSet2.vista1_cpp' Puede moverla o quitarla según sea necesario.
        Me.Vista1_cppTableAdapter.Fill(Me.Sae_cpp_finalDataSet2.vista1_cpp)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        lblid.Text = dgv.Cells(0).Value.ToString()
        lblnombre.Text = dgv.Cells(1).Value.ToString()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        idpro = lblid.Text
        nombrepro = lblnombre.Text
        regresar.Show()








    End Sub





End Class