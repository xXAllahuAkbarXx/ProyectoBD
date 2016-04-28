Imports System.Data.SqlClient

Public Class Connection
    Dim connection As SqlConnection
    Dim command As New SqlCommand
    Dim dataSet As New DataSet
    Dim dataReader As SqlDataReader

    Public Sub New(ByVal connectionString)
        connection = New SqlConnection(connectionString)
    End Sub

    Public Function ReaderCommand(ByVal commandText As String, ByVal tables As String) As DataSet

        command.Connection = connection
        command.CommandText = commandText
        connection.Open()

        dataReader = command.ExecuteReader()
        dataSet.Load(dataReader, LoadOption.PreserveChanges, tables)
        dataReader.Close()
        connection.Close()

        Return dataSet
    End Function

    Public Function NonQueryCommand(ByVal commandText As String)

        command.Connection = connection
        command.CommandText = commandText
        connection.Open()

        Dim rowsAffected = command.ExecuteNonQuery()

        connection.Close()

        Return rowsAffected
    End Function

    Public Sub Clear(ByVal Form As DataGridView)

        Dim dataTable As DataTable
        dataTable = CType(Form.DataSource, DataTable)
        dataTable.Rows.Clear()

    End Sub

End Class
