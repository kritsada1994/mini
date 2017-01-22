Public Class Frm_type
    Private Sub Frm_type_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_Table_type()
        auto_Number()
    End Sub
    Private Sub auto_Number()
        sql = "select max(auto_id) from Table_type"
        Try
            Dim numchar_id As String = "Ty-" & (cmd_excuteScalar() + 1).ToString.PadLeft(3, "0")
            txtID.Text = numchar_id
            txt_auto.Text = cmd_excuteScalar() + 1
        Catch ex As Exception

            txtID.Text = "Ty-001"
            txt_auto.Text = 1
        End Try
    End Sub
    Private Sub refresh_Table_type()
        sql = "select * from Table_type"
        DataGridView1.DataSource = cmd_dataTable()
        formatGrid()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'คลิกที่ตารางไปแสดงที่ textbox
        Dim p As Integer = DataGridView1.CurrentRow.Index
        txtID.Text = DataGridView1.Item(0, p).Value
        txt_type.Text = DataGridView1.Item(1, p).Value
    End Sub
    'กำหนดหัวตาราง
    Public Sub formatGrid()
        With DataGridView1
            .Columns(0).HeaderText = "รหัสสินค้า"
            .Columns(1).HeaderText = "ประเภทสินค้า"

            .Columns(0).Width = 150
            .Columns(1).Width = 120
            DataGridView1.Columns(2).Visible = False

        End With
    End Sub

    Private Sub Adds_Click(sender As Object, e As EventArgs) Handles Adds.Click
        sql = "INSERT INTO Table_type(Type_id,Type_name,auto_id)
        VALUES(@id,@name,@auto_id)"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        cmd.Parameters.AddWithValue("@name", txt_type.Text)
        cmd.Parameters.AddWithValue("@auto_id", txt_auto.Text)

        If txt_type.Text = "" Then
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
        refresh_Table_type()
        txt_type.Text = ""
        txtID.Text = ""

        auto_Number()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        sql = String.Format("update Table_type set Type_name='{0}' where Type_id='{1}'  ", txt_type.Text, txtID.Text)
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
        Else
            MessageBox.Show("แก้ไขข้อมูลแล้ว")
        End If
        txt_type.Text = ""
        txtID.Text = ""

        refresh_Table_type()
        auto_Number()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim result As DialogResult =
            MessageBox.Show("ท่านต้องการลบข้อมูลจริงหรือไม่", "ยืนยันการลบ", MessageBoxButtons.OKCancel)
        If result = DialogResult.Cancel Then
            Exit Sub
        End If
        sql = "delete from Table_type where Type_id = '" & txtID.Text & "'"
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด")
        Else
            MessageBox.Show("ลบข้อมูลแล้ว")
        End If
        txt_type.Text = ""
        txtID.Text = ""

        refresh_Table_type()
        auto_Number()
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
