Public Class fr_buscar_Factura_cpp
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()

    End Sub

    Private Sub fr_buscar_Factura_cpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sae_cpp_finalDataSet1.vista1_cpp' Puede moverla o quitarla según sea necesario.
        Me.Vista1_cppTableAdapter.Fill(Me.Sae_cpp_finalDataSet1.vista1_cpp)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        lblid.Text = dgv.Cells(0).Value.ToString()
        lblreferencia.Text = dgv.Cells(1).Value.ToString()
        lblSaldo.Text = dgv.Cells(2).Value.ToString()

    End Sub
End Class