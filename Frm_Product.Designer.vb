<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Product
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_break = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_sale = New System.Windows.Forms.TextBox()
        Me.txt88 = New System.Windows.Forms.TextBox()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Adds = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Cb3 = New System.Windows.Forms.ComboBox()
        Me.Cb1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cb2 = New System.Windows.Forms.ComboBox()
        Me.Txt_n = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Cost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt55 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.txt_break)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txt_amount)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txt_sale)
        Me.Panel1.Controls.Add(Me.txt88)
        Me.Panel1.Controls.Add(Me.Edit)
        Me.Panel1.Controls.Add(Me.Adds)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Delete)
        Me.Panel1.Controls.Add(Me.Cb3)
        Me.Panel1.Controls.Add(Me.Cb1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Cb2)
        Me.Panel1.Controls.Add(Me.Txt_n)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txt_Cost)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel1.Location = New System.Drawing.Point(53, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1252, 496)
        Me.Panel1.TabIndex = 9
        '
        'txt_break
        '
        Me.txt_break.Location = New System.Drawing.Point(594, 95)
        Me.txt_break.Name = "txt_break"
        Me.txt_break.Size = New System.Drawing.Size(245, 36)
        Me.txt_break.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(491, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 26)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "ผู้ค้าส่ง"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(208, 136)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(245, 36)
        Me.txt_amount.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(85, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 29)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "จำนวนที่ซื้อมา"
        '
        'txt_sale
        '
        Me.txt_sale.Location = New System.Drawing.Point(594, 178)
        Me.txt_sale.MaxLength = 7
        Me.txt_sale.Name = "txt_sale"
        Me.txt_sale.Size = New System.Drawing.Size(161, 36)
        Me.txt_sale.TabIndex = 9
        '
        'txt88
        '
        Me.txt88.Location = New System.Drawing.Point(208, 54)
        Me.txt88.Name = "txt88"
        Me.txt88.ReadOnly = True
        Me.txt88.Size = New System.Drawing.Size(245, 36)
        Me.txt88.TabIndex = 1
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.Yellow
        Me.Edit.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Edit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Edit.Location = New System.Drawing.Point(919, 95)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(107, 36)
        Me.Edit.TabIndex = 11
        Me.Edit.Text = "แก้ไขข้อมูล"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Adds
        '
        Me.Adds.BackColor = System.Drawing.Color.Blue
        Me.Adds.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Adds.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Adds.Location = New System.Drawing.Point(919, 49)
        Me.Adds.Name = "Adds"
        Me.Adds.Size = New System.Drawing.Size(107, 36)
        Me.Adds.TabIndex = 10
        Me.Adds.Text = "เพิ่มข้อมูล"
        Me.Adds.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 265)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1224, 219)
        Me.DataGridView1.TabIndex = 44
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.Red
        Me.Delete.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Delete.Location = New System.Drawing.Point(919, 138)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(107, 36)
        Me.Delete.TabIndex = 12
        Me.Delete.Text = "ลบข้อมูล"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Cb3
        '
        Me.Cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb3.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cb3.FormattingEnabled = True
        Me.Cb3.Location = New System.Drawing.Point(208, 178)
        Me.Cb3.Name = "Cb3"
        Me.Cb3.Size = New System.Drawing.Size(245, 37)
        Me.Cb3.TabIndex = 4
        '
        'Cb1
        '
        Me.Cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb1.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cb1.FormattingEnabled = True
        Me.Cb1.Location = New System.Drawing.Point(209, 219)
        Me.Cb1.Name = "Cb1"
        Me.Cb1.Size = New System.Drawing.Size(245, 37)
        Me.Cb1.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(773, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "บาท"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(773, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 29)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "บาท"
        '
        'Cb2
        '
        Me.Cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb2.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cb2.FormattingEnabled = True
        Me.Cb2.Location = New System.Drawing.Point(594, 52)
        Me.Cb2.Name = "Cb2"
        Me.Cb2.Size = New System.Drawing.Size(245, 37)
        Me.Cb2.TabIndex = 6
        '
        'Txt_n
        '
        Me.Txt_n.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_n.Location = New System.Drawing.Point(208, 94)
        Me.Txt_n.Name = "Txt_n"
        Me.Txt_n.Size = New System.Drawing.Size(245, 36)
        Me.Txt_n.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(373, 222)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 29)
        Me.Label15.TabIndex = 37
        '
        'txt_Cost
        '
        Me.txt_Cost.Font = New System.Drawing.Font("Angsana New", 14.25!)
        Me.txt_Cost.Location = New System.Drawing.Point(594, 137)
        Me.txt_Cost.MaxLength = 7
        Me.txt_Cost.Name = "txt_Cost"
        Me.txt_Cost.Size = New System.Drawing.Size(161, 33)
        Me.txt_Cost.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(491, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 26)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "ราคาขาย :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(489, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 26)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "ราคาทุน :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(85, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 26)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "ชื่อสินค้า :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(85, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "หน่วยนับ  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(489, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "จุดสั่งซื้อ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(85, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสินค้า :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(85, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ประเภทสินค้า :"
        '
        'txt55
        '
        Me.txt55.Location = New System.Drawing.Point(309, 46)
        Me.txt55.Name = "txt55"
        Me.txt55.ReadOnly = True
        Me.txt55.Size = New System.Drawing.Size(179, 20)
        Me.txt55.TabIndex = 46
        Me.txt55.Visible = False
        '
        'Frm_Product
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1317, 780)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt55)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_Cost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Delete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Adds As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cb3 As ComboBox
    Friend WithEvents Cb1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Cb2 As ComboBox
    Friend WithEvents Txt_n As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt55 As TextBox
    Friend WithEvents txt88 As TextBox
    Friend WithEvents txt_sale As TextBox
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_break As TextBox
    Friend WithEvents Label11 As Label
End Class
