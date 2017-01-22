Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_Pstork
    Friend cn As New SqlConnection("Data Source=DESKTOP-7852U9S;Initial Catalog=ministore;Integrated Security=True")
    Friend cmd As New SqlCommand
    Friend DA As New SqlDataAdapter
    Friend DS As New DataSet
    Friend sql As String
    Private Sub Frm_Pstork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        open_database()
        sql = "select *from Table_inventory"
        DA = New SqlDataAdapter(sql, cn)
        cmd = New SqlCommand
        DS = New DataSet
        DA.Fill(DS, "Table")

        DataGridView1.DataSource = DS.Tables("table")
    End Sub
    Public Sub open_database()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub
    Public Function cmd_dataTable()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "Table")
        Return DS.Tables("Table")
    End Function
    Private Sub searching()
        sql = String.Format(" select * from  Table_inventory where Product_id like '%{0}%' or product_name like '%{0}%'",
                          txt_search.Text)
        DataGridView1.DataSource = cmd_dataTable()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        searching()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'คลิกที่ตารางไปแสดงที่ textbox
        Dim p As Integer = DataGridView1.CurrentRow.Index
        cb1.Text = DataGridView1.Item(0, p).Value
        txt_name1.Text = DataGridView1.Item(1, p).Value
        formatGrid()
    End Sub
    Public Sub formatGrid()

        With DataGridView1

            .Columns(0).HeaderText = "รหัสสินค้า"
            .Columns(1).HeaderText = "ชื่อสินค้า"
            .Columns(2).HeaderText = "ราคาขาย"
            .Columns(3).HeaderText = "ราคาส่ง"
            .Columns(4).HeaderText = "สินค้าใกล้หมด"
            .Columns(5).HeaderText = "ราคาทุน"
            .Columns(6).HeaderText = "สินค้าคงคลัง"



            DataGridView1.Columns(9).Visible = False


            .Columns(0).Width = 100
            .Columns(1).Width = 150
            .Columns(2).Width = 130
            .Columns(3).Width = 100
            .Columns(4).Width = 200
            .Columns(5).Width = 150
            .Columns(6).Width = 150
            .Columns(7).Width = 100


        End With


    End Sub
    Private Sub refresh_Table_product()
        sql = "select Table_inventory.Product_id,product_name,Table_product.product_name,product_amount,product_unit,product_type,product_wholesaler,product_breakevenpoint,product_cost,product_sale
        from  Table_product,Table_stork
        where Table_product.Product_id = Table_stork.Product_id"
        DataGridView1.DataSource = cmd_dataTable()
        formatGrid()

    End Sub
End Class