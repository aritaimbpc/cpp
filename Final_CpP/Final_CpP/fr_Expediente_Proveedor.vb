Public Class fr_Expediente_Proveedor

    Dim conexion As Conexion = New Conexion()


    Private Sub fr_Expediente_Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Sae_cpp_finalDataSet3.vista1_cpp' Puede moverla o quitarla según sea necesario.
        Me.Vista1_cppTableAdapter.Fill(Me.Sae_cpp_finalDataSet3.vista1_cpp)

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click



    End Sub
    Public Sub Mostrar()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class