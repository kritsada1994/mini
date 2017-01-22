Public Class Frm_search
    Private Sub Frm_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_Table_search()
        auto_Number()
    End Sub
    Private Sub auto_Number()
        sql = "select max(auto_id) from Table_search"
        Try
            Dim numchar_id As String = "Ty-" & (cmd_excuteScalar() + 1).ToString.PadLeft(3, "0")
            txtID.Text = numchar_id
            txt_auto.Text = cmd_excuteScalar() + 1
        Catch ex As Exception

            txtID.Text = "Ty-001"
            txt_auto.Text = 1
        End Try
    End Sub
    Private Sub refresh_Table_search()
        sql = "select * from Table_type"
        DataGridView1.DataSource = cmd_dataTable()
        formatGrid()

    End Sub
    'กำหนดหัวตาราง
    Public Sub formatGrid()
        With DataGridView1
            .Columns(0).HeaderText = "รหัสสินค้า"
            .Columns(1).HeaderText = "ชื่อสินค้า"
            .Columns(2).HeaderText = "ประเภทสินค้า"

            .Columns(0).Width = 150
            .Columns(1).Width = 120
            .Columns(2).Width = 120
            DataGridView1.Columns(2).Visible = False

        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'คลิกที่ตารางไปแสดงที่ textbox
        Dim p As Integer = DataGridView1.CurrentRow.Index
        txtID.Text = DataGridView1.Item(0, p).Value
        Txt_name.Text = DataGridView1.Item(1, p).Value
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

