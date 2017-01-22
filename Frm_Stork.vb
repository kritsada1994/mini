Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Stork
    Friend cn As New SqlConnection("Data Source=DESKTOP-7852U9S;Initial Catalog=ministore;Integrated Security=True")
    Friend cmd As New SqlCommand(sql, cn)
    Friend DA As New SqlDataAdapter
    Friend DS As New DataSet
    Friend sql As String
    Public Sub open_database()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub
    Friend Sub chang_datagrid_column()
        Dim new_text() As String = {"รหัส", "ชื่อสินค้า", "คงเหลือ", "หน่วย"}
        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            DataGridView1.Columns(i).HeaderText = new_text(i)
        Next
    End Sub

    Friend Sub change_datagrid_log()
        Dim new_text() As String = {"รหัส log", "รหัสสินค้า", "จำนวน", "งาน"}
        For i As Integer = 0 To DataGridView2.ColumnCount - 1
            DataGridView2.Columns(i).HeaderText = new_text(i)
        Next
    End Sub


    Friend Sub load_Table_product()
        open_database()
        sql = "select *from Table_stork"
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "Table")
        DataGridView1.DataSource = DS.Tables("table")
        chang_datagrid_column()
    End Sub
    Friend Sub keep_log(log_work As String)
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Dim product_id As String = DataGridView1.Item(0, i).Value
        Dim product_amount As Integer
        If log_work = "exit" Then
            product_amount = Num_exit.Value
        Else
            product_amount = Num_enter.Value
        End If
        open_database()
        sql = "insert into log_product(log_product_id, log_amount, log_work) values(" &
            "'" & product_id & "'," & product_amount & ",'" & log_work & "')"
        cmd = New SqlCommand(sql, cn)
        cmd.ExecuteNonQuery()

    End Sub

    Friend Sub load_log()
        open_database()
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Dim product_id As String = DataGridView1.Item(0, i).Value

        sql = "select * from log_product where log_product_id='" & product_id & "'"
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        DataGridView2.DataSource = DS.Tables("table")
        change_datagrid_log()
    End Sub
    Friend Sub alert_product()
        open_database()
        sql = "select * from Table_stork where product_amount<3"
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Datagrid_alert.DataSource = DS.Tables("table")
    End Sub

    Private Sub Frm_Stork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Table_product()
        alert_product()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Dim amount As Integer = DataGridView1.Item(2, i).Value
        Num_exit.Maximum = amount

        load_log()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        open_database()
        sql = "update Table_stork set Product_amount = Product_amount-" & Num_exit.Value & "where Product_id='" &
            DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & "'"
        cmd = New SqlCommand(sql, cn)
        If cmd.ExecuteNonQuery = 0 Then
            MessageBox.Show("ผิดพลาด")
        Else
            MessageBox .Show ("สำเร็จ")

            keep_log("exit")
            load_Table_product()
            alert_product()
        End If
    End Sub

    Private Sub Num_exit_ValueChanged(sender As Object, e As EventArgs) Handles Num_exit.ValueChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Num_exit.Value = Num_exit.Maximum

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        open_database()
        sql = "update Table_stork set Product_amount = Product_amount+" & Num_enter.Value & "where Product_id='" &
            DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & "'"
        cmd = New SqlCommand(sql, cn)
        If cmd.ExecuteNonQuery = 0 Then
            MessageBox.Show("ผิดพลาด")
        Else
            MessageBox.Show("สำเร็จ")

            keep_log("enter")
            load_Table_product()
            alert_product()
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btn03_Click(sender As Object, e As EventArgs) Handles btn03.Click
        Dim i As Integer = DataGridView2.CurrentRow.Index
        Dim log_work As String = DataGridView2.Item(3, i).Value
        Dim product_id As String = DataGridView2.Item(1, i).Value
        Dim log_id As String = DataGridView2.Item(0, i).Value
        Dim product_amount As Integer = DataGridView2.Item(2, i).Value

        If log_work = "exit" Then
            sql = "update Table_stork set Product_amount = Product_amount+" & product_amount & " where Product_id='" & product_id & "'"
        Else
            sql = "update Table_stork  set Product_amount = Product_amount-" & product_amount & " where Product_id='" & product_id & "'"
        End If


        cmd = New SqlCommand(sql, cn)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("สำเร็จ")
            sql = "delete from log_product where log_id ='" & log_id & "'"
            cmd = New SqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            load_Table_product()
            load_log()
            alert_product()
        Else
            MessageBox.Show(" ไม่สำเร็จ")
        End If
    End Sub

    Private Sub Datagrid_alert_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagrid_alert.CellContentClick

    End Sub
End Class