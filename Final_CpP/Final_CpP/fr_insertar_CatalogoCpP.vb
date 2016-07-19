Public Class fr_insertar_CatalogoCpP

    Dim conec As Conexion = New Conexion()

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim agregar As String = " insert into tbl_sae_catFormapago values  ('" + txtNombre.Text + "','" + txttipo.Text + ")'"

        If (conec.Insertar(agregar)) Then
            MessageBox.Show("Datos Agregados Correctamente")
        Else
            MessageBox.Show("Error al Agregar Datos")

        End If
    End Sub
End Class