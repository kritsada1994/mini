Public Class Frm_Main
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub GgToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgToolStripMenuItem.Click
        Dim mdiform As New Frm_Order
        mdiform.MdiParent = Me
        mdiform.Show()

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub การรบสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles การรบสนคาToolStripMenuItem.Click
        Dim mdiform As New Frm_Sale
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click
        Dim mdiform As New Frm_staff
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub ออกจากระบบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ออกจากระบบToolStripMenuItem.Click
        If MessageBox.Show("ยืนยันการออกจากระบบ", "ออกจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub สนคาToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles สนคาToolStripMenuItem1.Click
        Dim mdiform As New Frm_Product
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub หนวยนบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles หนวยนบToolStripMenuItem.Click
        Dim mdiform As New Frm_unit
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub คำนำหนาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles คำนำหนาToolStripMenuItem.Click
        Dim mdiform As New Frm_title
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub ประเภทสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ประเภทสนคาToolStripMenuItem.Click
        Dim mdiform As New Frm_type
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub จดสงซอToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles จดสงซอToolStripMenuItem.Click
        Dim mdiform As New Frm_break
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub คนหาสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles คนหาสนคาToolStripMenuItem.Click
        Dim mdiform As New Frm_search
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub

    Private Sub รบสนคาเขารานToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รบสนคาเขารานToolStripMenuItem.Click
        Dim mdiform As New Frm_Pstork
        mdiform.MdiParent = Me
        mdiform.Show()
    End Sub
End Class
