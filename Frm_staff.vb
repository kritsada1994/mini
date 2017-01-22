Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_staff

    Private Sub frm_staff_load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect() 'เรียก function เปิด data มาใช้งาน
        sql = "SELECT * FROM title" 'เรียกข้อมูลจากตารางคำนำหน้า
        cmd_dataTable() 'เรียก function cmd มาใช้
        Combo01.DataSource = DS.Tables("table") '
        Combo01.DisplayMember = "title_name" 'แสดงชื่อ
        Combo01.ValueMember = "title_id" 'เก็บค่า FK


        refresh_staff()
        auto_Number()

    End Sub

    'ประกาศส่วนหัวของตาราง
    Public Sub formatGrid()

        With DataGridView1

            .Columns(0).HeaderText = "รหัสพนักงาน"
            .Columns(1).HeaderText = "คำนำหน้า"
            .Columns(2).HeaderText = "ชื่อ-สกุล"
            .Columns(3).HeaderText = "ที่อยู่"
            .Columns(4).HeaderText = "เบอร์โทร"
            .Columns(5).HeaderText = "User"
            .Columns(7).HeaderText = "สถานะผู้ใช้"

            DataGridView1.Columns(6).Visible = False



            .Columns(0).Width = 150
            .Columns(1).Width = 100
            .Columns(2).Width = 150
            .Columns(3).Width = 250
            .Columns(4).Width = 100
            .Columns(5).Width = 90
            .Columns(7).Width = 150


        End With


    End Sub

    Private Sub refresh_staff()
        sql = "select Table_staff.staff_id,title.title_name,Table_staff.staff_name,staff_addr,staff_tel,username,password,user_type
        from  Table_staff,title
        where Table_staff.title_id = title.title_id"
        DataGridView1.DataSource = cmd_dataTable()
        formatGrid()

    End Sub
    'รันออโต้ ในช่องรหัสพนักงาน
    Private Sub auto_Number()
        sql = "select max(auto_id) from Table_staff"
        Try
            Dim numchar_id As String = "Em-" & (cmd_excuteScalar() + 1).ToString.PadLeft(3, "0")
            txt_staff_id.Text = numchar_id
            txt11.Text = cmd_excuteScalar() + 1
        Catch ex As Exception
            txt_staff_id.Text = "Em-001"
            txt11.Text = 1
        End Try
    End Sub


    Private Sub Adds_Click(sender As Object, e As EventArgs) Handles Adds.Click
        'เรียกค่าตัวแรกของตารางมาตรวจสอบข้อมูลซ้ำ
        Dim intNumRows As Integer
        sql = "Select count (*) from Table_staff where staff_id = '" & Me.txt_staff_id.Text & "'"
        cmd = New SqlCommand(sql, cn)
        intNumRows = cmd.ExecuteScalar() ' อ่านข้อมูลคอลัมน์แรกในตาราง
        If intNumRows > 0 Then
            MessageBox.Show("คุณกรอกข้อมูลซ้ำ")
        Else
            sql = "insert into Table_staff(staff_id,title_id,staff_name,staff_addr,staff_tel,username,password,auto_id)
            values(@id,@title,@name,@addr,@tel,@username,@password,@auto_id)"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", txt_staff_id.Text)
            cmd.Parameters.AddWithValue("@title", Combo01.SelectedValue)
            cmd.Parameters.AddWithValue("@name", txt_staff_name.Text)
            cmd.Parameters.AddWithValue("@addr", txt_staff_address.Text)
            cmd.Parameters.AddWithValue("@tel", txt_staff_tel.Text)
            cmd.Parameters.AddWithValue("@username", txt_user.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@auto_id", txt11.Text)

            If txt_staff_id.Text = "" Or Combo01.Text = "" Or txt_staff_name.Text = "" Or txt_staff_address.Text = "" Or txt_staff_tel.Text = "" Or txt_user.Text = "" Or txt_password.Text = "" Then
                MessageBox.Show("คุณกรอกข้อมูลไม่ครบ")
                Exit Sub
            ElseIf txt_staff_id.TextLength < 3 Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ 3 ตัว", "เกิดข้อผิดพลาด")
                txt_staff_id.Focus()
                Exit Sub
            ElseIf txt_staff_tel.TextLength < 10 Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ 10 ตัว", "เกิดข้อผิดพลาด")
                txt_staff_tel.Focus()
                Exit Sub
            End If
            Dim r As Integer = cmd.ExecuteNonQuery()
            If r <= 0 Then
                MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถเพิ่มข้อมูลได้")
            Else
                MessageBox.Show("บันทึกข้อมูลแล้ว")
                txt_staff_id.Text = ""
                Combo01.Text = ""
                txt_staff_name.Text = ""
                txt_staff_address.Text = ""
                txt_staff_tel.Text = ""
                txt_user.Text = ""
                txt_password.Text = ""
                txtpass1.Text = ""
                txtpass.Text = ""
                txtuser1.Text = ""
                Combo2.Text = ""
            End If
            End If

        txt_staff_id.Text = ""


        refresh_staff()
        auto_Number()
    End Sub
    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        sql = "Update Table_staff 
                Set title_id=@title,staff_name=@name,
                staff_addr=@addr,staff_tel=@tel, username=@username 
                where staff_id= @id "
        cmd = New SqlCommand(sql, cn)
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id", txt_staff_id.Text)
        cmd.Parameters.AddWithValue("@title", Combo01.SelectedValue)
        cmd.Parameters.AddWithValue("@name", txt_staff_name.Text)
        cmd.Parameters.AddWithValue("@addr", txt_staff_address.Text)
        cmd.Parameters.AddWithValue("@tel", txt_staff_tel.Text)
        cmd.Parameters.AddWithValue("@username", txt_user.Text)

        If txt_staff_id.Text = "" Or Combo01.Text = "" Or txt_staff_name.Text = "" Or txt_staff_address.Text = "" Or txt_staff_tel.Text = "" Or txt_user.Text = "" Or txt_password.Text = "" Then
            MessageBox.Show("คุณกรอกข้อมูลไม่ครบ")
        Else
            Dim r As Integer = cmd.ExecuteNonQuery()
            If txt_staff_id.TextLength < 3 Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ 3 ตัว", "เกิดข้อผิดพลาด")
                txt_staff_id.Focus()
            ElseIf txt_staff_tel.TextLength < 10 Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ 10 ตัว", "เกิดข้อผิดพลาด")
                txt_staff_tel.Focus()
                Exit Sub

            ElseIf r <= 0 Then
                MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
            Else
                MessageBox.Show("ข้อมูลถูกแก้ไขแล้ว")
                txt_staff_id.Text = ""
                Combo01.Text = ""
                txt_staff_name.Text = ""
                txt_staff_address.Text = ""
                txt_staff_tel.Text = ""
                txt_user.Text = ""
                txt_password.Text = ""
                txtpass1.Text = ""
                txtpass.Text = ""
                txtuser1.Text = ""
                Combo2.Text = ""
            End If
        End If
        refresh_staff()
        auto_Number()
    End Sub



    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim result As DialogResult =
            MessageBox.Show("ท่านต้องการลบข้อมูลจริงหรือไม่", "ยืนยันการลบ", MessageBoxButtons.OKCancel)
        If result = DialogResult.Cancel Then
            Exit Sub
        End If
        sql = "delete from Table_staff where staff_id = '" & txt_staff_id.Text & "'"
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("คุณยังไม่ได้บันทึกข้อมูล ไม่สามารถลบข้อมูลในส่วนนี้ได้")
        Else
            MessageBox.Show("ลบข้อมูลแล้ว")

            txt_staff_id.Text = ""
        Combo01.Text = ""
        txt_staff_name.Text = ""
        txt_staff_address.Text = ""
        txt_staff_tel.Text = ""
        txt_user.Text = ""
        txt_password.Text = ""
        txtpass1.Text = ""
        txtpass.Text = ""
        txtuser1.Text = ""
            Combo2.Text = ""
        End If
        refresh_staff()
        auto_Number()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim i As Integer = DataGridView1.CurrentRow.Index
        txt_staff_id.Text = DataGridView1.Item(0, i).Value
        Combo01.Text = DataGridView1.Item(1, i).Value
        txt_staff_name.Text = DataGridView1.Item(2, i).Value
        txt_staff_address.Text = DataGridView1.Item(3, i).Value
        txt_staff_tel.Text = DataGridView1.Item(4, i).Value
        txt_user.Text = DataGridView1.Item(5, i).Value
        txt_password.Text = DataGridView1.Item(6, i).Value
        Txtb2.Text = DataGridView1.Item(6, i).Value

        txtuser1.Text = DataGridView1.Item(5, i).Value


        DataGridView1.Columns(6).Visible = False


    End Sub

    Private Sub Edit1_Click(sender As Object, e As EventArgs) Handles Edit1.Click
        If txtpass1.Text <> Txtb2.Text Then
            MessageBox.Show("คุณกรอกรหัสผ่านเก่าผิดพลาด", "เกิดข้อผิดพลาด")
        Else
            sql = "update Table_staff
                   set password=@password
                   where staff_id=@id"
            cmd = New SqlCommand(sql, cn)
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@password", txtpass.Text)
            cmd.Parameters.AddWithValue("@id", txt_staff_id.Text)

            Dim r As Integer = cmd.ExecuteNonQuery()
            If r <= 0 Then
                MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
            Else
                MessageBox.Show("ข้อมูลถูกแก้ไขแล้ว")

            End If
        End If
        txt_staff_id.Text = ""
        Combo01.Text = ""
        txt_staff_name.Text = ""
        txt_staff_address.Text = ""
        txt_staff_tel.Text = ""
        txt_user.Text = ""
        txt_password.Text = ""
        txtpass1.Text = ""
        txtpass.Text = ""
        txtuser1.Text = ""
        Combo2.Text = ""
        refresh_staff()
    End Sub

    Private Sub Edit2_Click(sender As Object, e As EventArgs) Handles Edit2.Click
        sql = "update Table_staff
                   set user_type=@user_type
                   where staff_id=@id"
        cmd = New SqlCommand(sql, cn)
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@user_type", Combo2.Text)
        cmd.Parameters.AddWithValue("@id", txt_staff_id.Text)

        Dim r As Integer = cmd.ExecuteNonQuery()
        If r <= 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
        Else
            MessageBox.Show("ข้อมูลถูกแก้ไขแล้ว")

        End If
        txt_staff_id.Text = ""
        Combo01.Text = ""
        txt_staff_name.Text = ""
        txt_staff_address.Text = ""
        txt_staff_tel.Text = ""
        txt_user.Text = ""
        txt_password.Text = ""
        txtpass1.Text = ""
        txtpass.Text = ""
        txtuser1.Text = ""
        Combo2.Text = ""
        refresh_staff()
    End Sub



    Private Sub txt_staff_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_staff_id.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(txt_staff_id.Text)
                If a < 3 Then
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบ 3 ตัว", "เกิดข้อผิดพลาด")
                    txt_staff_id.Focus()
                Else
                    Combo01.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")
        End Select
    End Sub



    Private Sub txt_staff_tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_staff_tel.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 46, 48 To 57
                e.Handled = False
            Case 13
                Dim a As Integer = Len(txt_staff_tel.Text)
                If a < 10 Then
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบ 10 ตัว", "เกิดข้อผิดพลาด")
                    txt_staff_tel.Focus()
                Else
                    txt_staff_address.Focus()
                End If
            Case Else
                e.Handled = True
                MessageBox.Show("กรอกได้เฉพาะตัวเลข", "เกิดข้อผิดพลาด")
        End Select
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txt_staff_id_TextChanged(sender As Object, e As EventArgs) Handles txt_staff_id.TextChanged

    End Sub

    Private Sub txt_staff_tel_TextChanged(sender As Object, e As EventArgs) Handles txt_staff_tel.TextChanged

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

    Private Sub Combo01_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo01.SelectedIndexChanged

    End Sub

    Private Sub txtpass1_TextChanged(sender As Object, e As EventArgs) Handles txtpass1.TextChanged

    End Sub
End Class




