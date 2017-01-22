Public Class Frm_title
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'คลิกที่ตารางไปแสดงที่ textbox
        Dim p As Integer = DataGridView1.CurrentRow.Index
        txtID.Text = DataGridView1.Item(0, p).Value
        txt_name.Text = DataGridView1.Item(1, p).Value
    End Sub
    'กำหนดหัวตาราง
    Public Sub formatGrid()
        With DataGridView1
            .Columns(0).HeaderText = "รหัสคำนำหน้า"
            .Columns(1).HeaderText = "คำนำหน้า"

            .Columns(0).Width = 150
            .Columns(1).Width = 120
            DataGridView1.Columns(2).Visible = False

        End With
    End Sub

    Private Sub refresh_title_id()
        sql = "select * from title"
    End Sub

    Private Sub Frm_title_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_title()
        auto_Number()
    End Sub

    Private Sub auto_Number()
        sql = "select max(auto_id) from title"
        Try
            Dim numchar_id As String = "Tl-" & (cmd_excuteScalar() + 1).ToString.PadLeft(3, "0")
            txtID.Text = numchar_id
            txt_id.Text = cmd_excuteScalar() + 1
        Catch ex As Exception

            txtID.Text = "Tl-001"
            txt_id.Text = 1
        End Try
    End Sub

    Private Sub refresh_title()
        sql = "select * from title"
        DataGridView1.DataSource = cmd_dataTable()
        formatGrid()

    End Sub

    Private Sub Adds_Click(sender As Object, e As EventArgs) Handles Adds.Click
        sql = "INSERT INTO title(title_id,title_name,auto_id)
        VALUES(@id,@name,@auto_id)"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        cmd.Parameters.AddWithValue("@name", txt_name.Text)
        cmd.Parameters.AddWithValue("@auto_id", txt_id.Text)

        If txt_name.Text = "" Then
            MessageBox.Show("คุณกรอกข้อมูลไม่ครบ")
        Else
            Dim r As Integer = cmd.ExecuteNonQuery()
            If r <= 0 Then
                MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถเพิ่มข้อมูลได้")
                Exit Sub
            Else
                MessageBox.Show("บันทึกข้อมูลแล้ว")
            End If

        End If
        refresh_title()
        txt_name.Text = ""
        txtID.Text = ""

        auto_Number()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        sql = String.Format("update title set title_name='{0}' where title_id='{1}'  ", txt_name.Text, txtID.Text)
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
        Else
            MessageBox.Show("แก้ไขข้อมูลแล้ว")
        End If
        txt_name.Text = ""
        txtID.Text = ""

        refresh_title()
        auto_Number()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim result As DialogResult =
            MessageBox.Show("ท่านต้องการลบข้อมูลจริงหรือไม่", "ยืนยันการลบ", MessageBoxButtons.OKCancel)
        If result = DialogResult.Cancel Then
            Exit Sub
        End If
        sql = "delete from title where title_id = '" & txtID.Text & "'"
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด")
        Else
            MessageBox.Show("ลบข้อมูลแล้ว")
        End If
        txt_name.Text = ""
        txtID.Text = ""

        refresh_title()
        auto_Number()
    End Sub

    Private Sub Gb_Enter(sender As Object, e As EventArgs) Handles Gb.Enter

    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

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
End Class