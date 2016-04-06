Imports System.Data.SqlClient

Public Class Connection
    'Dim connectionString As New String("Data Source=ELOYPC\SQLEXPRESS; Initial Catalog=EjemploBD; User Id=sa; Password=homecoming96; Connection Lifetime=60; Max Pool Size=50; Min Pool Size=3")
    'Dim conexion As New SqlConnection(connectionString)
    Dim connection As SqlConnection
    Dim command As New SqlCommand
    Dim dataSet As New DataSet
    Dim dataReader As SqlDataReader

    Public Sub New(ByVal connectionString)
        connection = New SqlConnection(connectionString)
    End Sub

    Public Function ReaderCommand(ByVal commandText As String, ByVal tables As String)

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
