Public Class Frm_unit
    Private Sub Frm_unit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_Table_unit()
        auto_Number()
    End Sub
    Private Sub auto_Number()
        sql = "select max(auto_id) from Table_unit"
        Try
            Dim numchar_id As String = "Tl-" & (cmd_excuteScalar() + 1).ToString.PadLeft(3, "0")
            txtID.Text = numchar_id
            txt22.Text = cmd_excuteScalar() + 1
        Catch ex As Exception

            txtID.Text = "Tl-001"
            txt22.Text = 1
        End Try
    End Sub
    Private Sub refresh_Table_unit()
        sql = "select * from Table_unit"
        DataGridView1.DataSource = cmd_dataTable()
        formatGrid()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'คลิกที่ตารางไปแสดงที่ textbox
        Dim p As Integer = DataGridView1.CurrentRow.Index
        txtID.Text = DataGridView1.Item(0, p).Value
        txt_name.Text = DataGridView1.Item(1, p).Value
    End Sub
    'กำหนดหัวตาราง
    Public Sub formatGrid()
        With DataGridView1
            .Columns(0).HeaderText = "รหัสหน่วยนับ"
            .Columns(1).HeaderText = "หน่วยนับ"

            .Columns(0).Width = 150
            .Columns(1).Width = 120
            DataGridView1.Columns(2).Visible = False

        End With
    End Sub


    Private Sub Adds_Click(sender As Object, e As EventArgs) Handles Adds.Click
        sql = "INSERT INTO Table_unit(unit_id,unit_name,auto_id)
        VALUES(@id,@name,@auto_id)"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        cmd.Parameters.AddWithValue("@name", txt_name.Text)
        cmd.Parameters.AddWithValue("@auto_id", txt22.Text)

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
        refresh_Table_unit()
        txt_name.Text = ""
        txtID.Text = ""

        auto_Number()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        sql = String.Format("update Table_unit set unit_name='{0}' where unit_id='{1}'  ", txt_name.Text, txtID.Text)
        If cmd_excuteNonQuery() = 0 Then
            MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
        Else
            MessageBox.Show("แก้ไขข้อมูลแล้ว")
        End If
        txt_name.Text = ""
        txtID.Text = ""

        refresh_Table_unit()
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