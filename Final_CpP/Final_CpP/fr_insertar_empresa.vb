Public Class fr_insertar_empresa
    Dim conexion As Conexion = New Conexion()

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        Dim agregar As String = " insert into tbl_sae_empresa  ('" + txtnombre.Text + "','" + txtdireccion.Text + "','" + txtTelefono.Text + "','" + txtcorreo.Text + "')"

        If (conexion.Insertar(agregar)) Then
            MessageBox.Show("datos Agregados Correctamente")
        Else
            MessageBox.Show("error al agregar Datos")
        End If

    End Sub
End Class