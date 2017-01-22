Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_Order

    Friend cn As New SqlConnection("Data Source=DESKTOP-7852U9S;Initial Catalog=ministore;Integrated Security=True")
    Friend cmd As New SqlCommand
    Friend DA As New SqlDataAdapter
    Friend DS As New DataSet
    Friend sql As String
    Public Sub open_database()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub

    Private Sub Frm_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        open_database()
        sql = "select *from Table_stork"
        DA = New SqlDataAdapter(sql, cn)
        cmd =New SqlCommand 
        DS = New DataSet
        DA.Fill(DS, "Table")

        DataGridView2.DataSource = DS.Tables("table")
    End Sub
    Public Function cmd_dataTable()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "Table")
        Return DS.Tables("Table")
    End Function
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick


    End Sub

    Private Sub searching()
        sql = String.Format(" select * from  Table_stork where Product_id like '%{0}%' or Product_name like '%{0}%'",
                          Txtb01.Text)
        DataGridView2.DataSource = cmd_dataTable()
    End Sub

    Private Sub Txtb01_TextChanged(sender As Object, e As EventArgs) Handles Txtb01.TextChanged
        searching()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btn01_Click(sender As Object, e As EventArgs) Handles btn01.Click
        searching()
    End Sub
End Class