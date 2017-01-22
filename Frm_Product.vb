Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_Product
    Private Sub Frm_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect() 'เรียก function เปิด data มาใช้งาน
        sql = "SELECT * FROM Table_unit" 'เรียกข้อมูลจากตาราง
        cmd_dataTable() 'เรียก function cmd มาใช้
        Cb3.DataSource = DS.Tables("table") '
        Cb3.DisplayMember = "unit_name" 'แสดงชื่อ
        Cb3.ValueMember = "unit_id" 'เก็บค่า FK

        sql = "SELECT * FROM Table_type" 'เรียกข้อมูลจากตาราง
        cmd_dataTable() 'เรียก function cmd มาใช้
        Cb1.DataSource = DS.Tables("table") '
        Cb1.DisplayMember = "Type_name" 'แสดงชื่อ
        Cb1.ValueMember = "Type_id" 'เก็บค่า FK


        sql = "SELECT * FROM Table_break" 'เรียกข้อมูลจากตาราง
        cmd_dataTable() 'เรียก function cmd มาใช้
        Cb2.DataSource = DS.Tables("table") '
        Cb2.DisplayMember = "Break_name" 'แสดงชื่อ
        Cb2.ValueMember = "Break_id" 'เก็บค่า FK

        refresh_product()
        auto_Number()
        formatGrid()
    End Sub


    Private Sub refresh_product()
        sql = "select * from Table_product"
        DataGridView1.DataSource = cmd_dataTable()
        formatGrid()
    End Sub
    Private Sub auto_Number()
        sql = "select max(auto_id) from Table_product"
        Try
            Dim numchar_id As String = "Pd-" & (cmd_excuteScalar() + 1).ToString.PadLeft(3, "0")
            txt88.Text = numchar_id
            txt55.Text = cmd_excuteScalar() + 1
        Catch ex As Exception
            txt88.Text = "Pd-001"
            txt55.Text = 1
        End Try
    End Sub
    Public Sub formatGrid()

        With DataGridView1

            .Columns(0).HeaderText = "รหัสสินค้า"
            .Columns(1).HeaderText = "ชื่อสินค้า"
            .Columns(2).HeaderText = "จำนวนที่ซื้อมา"
            .Columns(3).HeaderText = "หน่วยนับ"
            .Columns(4).HeaderText = "ประเภทสินค้า"
            .Columns(5).HeaderText = "ผู้ค้าส่ง"
            .Columns(6).HeaderText = "จุดสั่งซื้อ"
            .Columns(7).HeaderText = "ราคาขาย"
            .Columns(8).HeaderText = "ราคาทุน"


            DataGridView1.Columns(9).Visible = False


            .Columns(0).Width = 100
            .Columns(1).Width = 150
            .Columns(2).Width = 130
            .Columns(3).Width = 100
            .Columns(4).Width = 200
            .Columns(5).Width = 150
            .Columns(6).Width = 150
            .Columns(7).Width = 100
            .Columns(8).Width = 100
            .Columns(9).Width = 150

        End With


    End Sub
    Private Sub refresh_Table_product()
        sql = "select Table_product.Product_id,title.product_name,Table_product.product_name,product_amount,product_unit,product_type,product_wholesaler,product_breakevenpoint,product_cost,product_sale
        from  Table_product,Table_stork
        where Table_product.Product_id = Table_stork.Product_id"
        DataGridView1.DataSource = cmd_dataTable()
        formatGrid()

    End Sub

    Private Sub Adds_Click(sender As Object, e As EventArgs) Handles Adds.Click
        'เรียกค่าตัวแรกของตารางมาตรวจสอบข้อมูลซ้ำ
        Dim intNumRows As Integer
        sql = "Select count (*) from Table_product where Product_id = '" & Me.txt88.Text & "'"
        cmd = New SqlCommand(sql, cn)
        intNumRows = cmd.ExecuteScalar() ' อ่านข้อมูลคอลัมน์แรกในตาราง
        If intNumRows > 0 Then
            MessageBox.Show("คุณกรอกข้อมูลซ้ำ")
        Else
            sql = "insert into Table_product(Product_id,product_name,product_amount,product_unit,product_type,product_wholesaler,product_breakevenpoint,product_cost,product_sale,auto_id)
            values(@id,@name,@amount,@unit,@type,@wholesaler,@breakevenpoint,@cost,@sale,@auto_id)"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", txt88.Text)
            cmd.Parameters.AddWithValue("@name", Txt_n.Text)
            cmd.Parameters.AddWithValue("@amount", txt_amount.Text)
            cmd.Parameters.AddWithValue("@unit", Cb3.SelectedValue)
            cmd.Parameters.AddWithValue("@type", Cb1.SelectedValue)
            cmd.Parameters.AddWithValue("@wholesaler", Cb2.SelectedValue)
            cmd.Parameters.AddWithValue("@breakevenpoint", txt_break.Text)
            cmd.Parameters.AddWithValue("@cost", txt_Cost.Text)
            cmd.Parameters.AddWithValue("@sale", txt_sale.Text)
            cmd.Parameters.AddWithValue("@auto_id", txt55.Text)

            If txt88.Text = "" Or Txt_n.Text = "" Or txt_amount.Text = "" Or Cb3.Text = "" Or Cb1.Text = "" Or Cb2.Text = "" Or txt_break.Text = "" Or txt_Cost.Text = "" Or txt_sale.Text = "" Then
                MessageBox.Show("คุณกรอกข้อมูลไม่ครบ")
                Exit Sub
            ElseIf txt_Cost.TextLength < 7 Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ ", "เกิดข้อผิดพลาด")
                txt88.Focus()
                Exit Sub
            ElseIf txt_sale.TextLength < 7 Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ ", "เกิดข้อผิดพลาด")
                txt_sale.Focus()
                Exit Sub
            End If
            Dim r As Integer = cmd.ExecuteNonQuery()
            If r <= 0 Then
                MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถเพิ่มข้อมูลได้")
            Else
                MessageBox.Show("บันทึกข้อมูลแล้ว")
                txt88.Text = ""
                Txt_n.Text = ""
                txt_amount.Text = ""
                Cb3.Text = ""
                Cb1.Text = ""
                Cb2.Text = ""
                txt_break.Text = ""
                txt_Cost.Text = ""
                txt_sale.Text = ""
                txt55.Text = ""

            End If
        End If

        txt88.Text = ""


        refresh_Table_product()
        auto_Number()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'คลิกที่ตารางไปแสดงที่ textbox
        Dim p As Integer = DataGridView1.CurrentRow.Index
        txt88.Text = DataGridView1.Item(0, p).Value
        Txt_n.Text = DataGridView1.Item(1, p).Value
        formatGrid()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

    End Sub

    Private Sub txt88_TextChanged(sender As Object, e As EventArgs) Handles txt88.TextChanged

    End Sub

    Private Sub txt88_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt88.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(txt88.Text)
                If a < 3 Then
                    MessageBox.Show("เกิดข้อผิดพลาด")
                    txt88.Focus()
                Else
                    Txt_n.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("เกิดข้อผิดพลาด")
        End Select
    End Sub

    Private Sub txt_Cost_TextChanged(sender As Object, e As EventArgs) Handles txt_Cost.TextChanged

    End Sub

    Private Sub txt_Cost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cost.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(txt_Cost.Text)
                If a < 3 Then
                    MessageBox.Show("เกิดข้อผิดพลาด")
                    txt_Cost.Focus()
                Else
                    txt_sale.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")
        End Select
    End Sub

    Private Sub txt_sale_TextChanged(sender As Object, e As EventArgs) Handles txt_sale.TextChanged

    End Sub

    Private Sub txt_sale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sale.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(txt_sale.Text)
                If a < 3 Then
                    MessageBox.Show("เกิดข้อผิดพลาด")
                    txt_sale.Focus()
                Else
                    Adds.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")
        End Select
    End Sub

    Private Sub txt_amount_TextChanged(sender As Object, e As EventArgs) Handles txt_amount.TextChanged

    End Sub

    Private Sub txt_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(txt_amount.Text)
                If a < 3 Then
                    MessageBox.Show("เกิดข้อผิดพลาด")
                    txt_amount.Focus()
                Else
                    Cb3.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")
        End Select
    End Sub
    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.Enter
                ProcessDialogKey(Keys.Tab)
            Case Keys.Escape
                ProcessDialogKey(Keys.Shift Or Keys.Tab)
        End Select
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    Private Sub txt_break_TextChanged(sender As Object, e As EventArgs) Handles txt_break.TextChanged

    End Sub

    Private Sub txt_break_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_break.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(txt_break.Text)
                If a < 3 Then
                    MessageBox.Show("เกิดข้อผิดพลาด")
                    txt_break.Focus()
                Else
                    txt_Cost.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")
        End Select
    End Sub

    Private Sub Cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb1.SelectedIndexChanged

    End Sub
End Class