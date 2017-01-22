Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public cn As New SqlConnection("Data Source=DESKTOP-7852U9S;Initial Catalog=ministore;Integrated Security=True")
    Public cmd As New SqlCommand
    Public DA As SqlDataAdapter
    Public DS As DataSet
    Public DR As SqlDataReader
    Public BindingStr As BindingSource
    Public reader As SqlDataReader
    Public sql As String
    Public Sub connect()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub
    Public Function cmd_excuteNonQuery()
        connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery
    End Function
    Public Function cmd_dataTable()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "Table")
        Return DS.Tables("Table")
    End Function
    Public Sub cmd_database_to_object(obj As Object)
        connect()
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader
        obj.Items.Clear()
        While DR.Read
            obj.Items.Add(DR(0))
        End While
        DR.Close()
    End Sub
    Public Function cmd_excuteScalar()
        connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar()
    End Function
End Module