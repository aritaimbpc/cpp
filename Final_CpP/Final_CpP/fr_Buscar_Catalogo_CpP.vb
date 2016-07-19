Public Class fr_Buscar_Catalogo_CpP
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        lblid.Text = dgv.Cells(0).Value.ToString()
        lblnombre.Text = dgv.Cells(1).Value.ToString()
        lblTipo.Text = dgv.Cells(2).Value.ToString()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()

    End Sub

    Private Sub fr_Buscar_Catalogo_CpP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sae_cpp_finalDataSet.tbl_sae_catFormapago' Puede moverla o quitarla según sea necesario.
        Me.Tbl_sae_catFormapagoTableAdapter.Fill(Me.Sae_cpp_finalDataSet.tbl_sae_catFormapago)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub
End Class