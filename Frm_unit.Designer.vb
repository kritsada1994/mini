<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_unit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Adds = New System.Windows.Forms.Button()
        Me.Gb = New System.Windows.Forms.GroupBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt22 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(260, 257)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(422, 352)
        Me.DataGridView1.TabIndex = 7
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Edit.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Edit.Location = New System.Drawing.Point(158, 150)
        Me.Edit.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(84, 35)
        Me.Edit.TabIndex = 6
        Me.Edit.Text = "แก้ไข"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Delete.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Delete.Location = New System.Drawing.Point(265, 150)
        Me.Delete.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(90, 35)
        Me.Delete.TabIndex = 5
        Me.Delete.Text = "ลบ"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Adds
        '
        Me.Adds.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Adds.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Adds.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Adds.Location = New System.Drawing.Point(43, 150)
        Me.Adds.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Adds.Name = "Adds"
        Me.Adds.Size = New System.Drawing.Size(91, 35)
        Me.Adds.TabIndex = 4
        Me.Adds.Text = "เพิ่ม"
        Me.Adds.UseVisualStyleBackColor = False
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.Edit)
        Me.Gb.Controls.Add(Me.Delete)
        Me.Gb.Controls.Add(Me.Adds)
        Me.Gb.Controls.Add(Me.txt_name)
        Me.Gb.Controls.Add(Me.Label1)
        Me.Gb.Controls.Add(Me.txtID)
        Me.Gb.Controls.Add(Me.Label2)
        Me.Gb.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Gb.Location = New System.Drawing.Point(260, 34)
        Me.Gb.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Gb.Name = "Gb"
        Me.Gb.Padding = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Gb.Size = New System.Drawing.Size(422, 211)
        Me.Gb.TabIndex = 6
        Me.Gb.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_name.Location = New System.Drawing.Point(138, 83)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(180, 33)
        Me.txt_name.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสหน่วยนับ :"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtID.Location = New System.Drawing.Point(138, 42)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(180, 33)
        Me.txtID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "หน่วยนับ :"
        '
        'txt22
        '
        Me.txt22.Location = New System.Drawing.Point(776, 83)
        Me.txt22.Name = "txt22"
        Me.txt22.Size = New System.Drawing.Size(100, 20)
        Me.txt22.TabIndex = 7
        Me.txt22.Visible = False
        '
        'Frm_unit
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(946, 606)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt22)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Gb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_unit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "unit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Edit As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Adds As Button
    Friend WithEvents Gb As GroupBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt22 As TextBox
End Class
