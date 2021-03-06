﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms



Public Class Conexion

    Public conexion As SqlConnection = New SqlConnection("Data Source=localhost;Initial Catalog=sae_cpp_final;Integrated Security=True")

    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand



    Public Sub Conectar()
        Try
            conexion.Open()
            MessageBox.Show("Se conecto a base de Datos")
        Catch ex As Exception
            MessageBox.Show("Error en la conexion")
        Finally
            conexion.Close()

        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    'METODO PARA INSERTAR
    Function Insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    ' METODO PARA ELIMINAR

    Function Eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim elimina As String = " delete from " + tabla + "where" + condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If

    End Function

    'METODO PARA ACTUALIZAR

    Function Actualizar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim actualiza As String = "update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function







End Class
