<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_staff))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_staff_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_staff_address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Combo01 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Adds = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_staff_id = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_staff_tel = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt11 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtpass1 = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Txtb2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Edit1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Edit2 = New System.Windows.Forms.Button()
        Me.Combo2 = New System.Windows.Forms.ComboBox()
        Me.txtuser1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txt_staff_name
        '
        resources.ApplyResources(Me.txt_staff_name, "txt_staff_name")
        Me.txt_staff_name.Name = "txt_staff_name"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txt_staff_address
        '
        resources.ApplyResources(Me.txt_staff_address, "txt_staff_address")
        Me.txt_staff_address.Name = "txt_staff_address"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Combo01
        '
        Me.Combo01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.Combo01, "Combo01")
        Me.Combo01.FormattingEnabled = True
        Me.Combo01.Items.AddRange(New Object() {resources.GetString("Combo01.Items"), resources.GetString("Combo01.Items1"), resources.GetString("Combo01.Items2")})
        Me.Combo01.Name = "Combo01"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.Delete, "Delete")
        Me.Delete.Name = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Adds
        '
        Me.Adds.BackColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.Adds, "Adds")
        Me.Adds.Name = "Adds"
        Me.Adds.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.Yellow
        resources.ApplyResources(Me.Edit, "Edit")
        Me.Edit.Name = "Edit"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.txt_staff_id)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txt_staff_tel)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txt_user)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_password)
        Me.Panel1.Controls.Add(Me.Combo01)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Delete)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Adds)
        Me.Panel1.Controls.Add(Me.Edit)
        Me.Panel1.Controls.Add(Me.txt_staff_address)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_staff_name)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'txt_staff_id
        '
        resources.ApplyResources(Me.txt_staff_id, "txt_staff_id")
        Me.txt_staff_id.Name = "txt_staff_id"
        Me.txt_staff_id.ReadOnly = True
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Name = "Label15"
        '
        'txt_staff_tel
        '
        resources.ApplyResources(Me.txt_staff_tel, "txt_staff_tel")
        Me.txt_staff_tel.Name = "txt_staff_tel"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Name = "Label12"
        '
        'txt_user
        '
        resources.ApplyResources(Me.txt_user, "txt_user")
        Me.txt_user.Name = "txt_user"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txt_password
        '
        resources.ApplyResources(Me.txt_password, "txt_password")
        Me.txt_password.Name = "txt_password"
        '
        'txt11
        '
        resources.ApplyResources(Me.txt11, "txt11")
        Me.txt11.Name = "txt11"
        Me.txt11.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtpass1)
        Me.Panel2.Controls.Add(Me.txtpass)
        Me.Panel2.Controls.Add(Me.Txtb2)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Edit1)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'txtpass1
        '
        resources.ApplyResources(Me.txtpass1, "txtpass1")
        Me.txtpass1.Name = "txtpass1"
        '
        'txtpass
        '
        resources.ApplyResources(Me.txtpass, "txtpass")
        Me.txtpass.Name = "txtpass"
        '
        'Txtb2
        '
        resources.ApplyResources(Me.Txtb2, "Txtb2")
        Me.Txtb2.Name = "Txtb2"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Name = "Label14"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Edit1
        '
        Me.Edit1.BackColor = System.Drawing.Color.Yellow
        resources.ApplyResources(Me.Edit1, "Edit1")
        Me.Edit1.Name = "Edit1"
        Me.Edit1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Edit2)
        Me.Panel3.Controls.Add(Me.Combo2)
        Me.Panel3.Controls.Add(Me.txtuser1)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Name = "Label13"
        '
        'Edit2
        '
        Me.Edit2.BackColor = System.Drawing.Color.Yellow
        resources.ApplyResources(Me.Edit2, "Edit2")
        Me.Edit2.Name = "Edit2"
        Me.Edit2.UseVisualStyleBackColor = False
        '
        'Combo2
        '
        Me.Combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.Combo2, "Combo2")
        Me.Combo2.FormattingEnabled = True
        Me.Combo2.Items.AddRange(New Object() {resources.GetString("Combo2.Items"), resources.GetString("Combo2.Items1")})
        Me.Combo2.Name = "Combo2"
        '
        'txtuser1
        '
        resources.ApplyResources(Me.txtuser1, "txtuser1")
        Me.txtuser1.Name = "txtuser1"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Frm_staff
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        resources.ApplyResources(Me, "$this")
        Me.ControlBox = False
        Me.Controls.Add(Me.txt11)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_staff"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_staff_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_staff_address As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Delete As Button
    Friend WithEvents Adds As Button
    Friend WithEvents Edit As Button
    Friend WithEvents Combo01 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Edit1 As Button
    Friend WithEvents Edit2 As Button
    Friend WithEvents Combo2 As ComboBox
    Friend WithEvents txtuser1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_staff_id As TextBox
    Friend WithEvents txt_staff_tel As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Txtb2 As TextBox
    Friend WithEvents txtpass1 As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txt11 As TextBox
End Class
