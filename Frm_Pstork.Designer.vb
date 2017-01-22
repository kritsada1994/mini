<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pstork
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txt_name1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Adds = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(121, 18)
        Me.txt_search.MaxLength = 6
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(174, 36)
        Me.txt_search.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ค้นหาสินค้า"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.txt_name1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Delete)
        Me.Panel1.Controls.Add(Me.Adds)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cb1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_search)
        Me.Panel1.Location = New System.Drawing.Point(187, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 147)
        Me.Panel1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(756, 57)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 36)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "พิมพ์งาน"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(756, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "เพิ่มสินค้าใหม่"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(554, 63)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(180, 36)
        Me.TextBox3.TabIndex = 5
        '
        'txt_name1
        '
        Me.txt_name1.Location = New System.Drawing.Point(434, 63)
        Me.txt_name1.Name = "txt_name1"
        Me.txt_name1.Size = New System.Drawing.Size(114, 36)
        Me.txt_name1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ผู้บันทึก "
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.SystemColors.Control
        Me.Delete.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Delete.Location = New System.Drawing.Point(880, 57)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(116, 36)
        Me.Delete.TabIndex = 10
        Me.Delete.Text = "ลบรายการนี้"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Adds
        '
        Me.Adds.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Adds.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Adds.Location = New System.Drawing.Point(880, 15)
        Me.Adds.Name = "Adds"
        Me.Adds.Size = New System.Drawing.Size(118, 36)
        Me.Adds.TabIndex = 8
        Me.Adds.Text = "เพิ่มข้อมูล"
        Me.Adds.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, 60)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 36)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = " ณ วันที่"
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(434, 19)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(174, 37)
        Me.cb1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(339, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ประเภทสินค้า"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(187, 251)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1021, 236)
        Me.DataGridView1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 511)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "รายการสินค้าทั้งหมด"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(317, 508)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(134, 36)
        Me.TextBox4.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(457, 511)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 29)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "รายการ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(938, 507)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 29)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "รวมมูลค่าคงคลัง"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(1047, 504)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(161, 36)
        Me.TextBox5.TabIndex = 8
        '
        'Frm_Pstork
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1301, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Name = "Frm_Pstork"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "สต็อกสินค้าคงเหลือ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txt_name1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Delete As Button
    Friend WithEvents Adds As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
End Class
