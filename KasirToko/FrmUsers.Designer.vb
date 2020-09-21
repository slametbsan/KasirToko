<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsers
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
        Me.DgvUsers = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBaru = New System.Windows.Forms.Button()
        Me.CbAdmin = New System.Windows.Forms.CheckBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvUsers
        '
        Me.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsers.Location = New System.Drawing.Point(300, 13)
        Me.DgvUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvUsers.MultiSelect = False
        Me.DgvUsers.Name = "DgvUsers"
        Me.DgvUsers.ReadOnly = True
        Me.DgvUsers.RowHeadersVisible = False
        Me.DgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUsers.Size = New System.Drawing.Size(360, 208)
        Me.DgvUsers.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnEdit)
        Me.GroupBox1.Controls.Add(Me.BtnTutup)
        Me.GroupBox1.Controls.Add(Me.BtnHapus)
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Controls.Add(Me.BtnBaru)
        Me.GroupBox1.Controls.Add(Me.CbAdmin)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.TxtUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 216)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(90, 126)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 31)
        Me.BtnEdit.TabIndex = 8
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(202, 163)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(70, 31)
        Me.BtnTutup.TabIndex = 7
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(90, 163)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 31)
        Me.BtnHapus.TabIndex = 6
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(9, 163)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.BtnSimpan.TabIndex = 5
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnBaru
        '
        Me.BtnBaru.Location = New System.Drawing.Point(9, 126)
        Me.BtnBaru.Name = "BtnBaru"
        Me.BtnBaru.Size = New System.Drawing.Size(75, 31)
        Me.BtnBaru.TabIndex = 4
        Me.BtnBaru.Text = "Baru"
        Me.BtnBaru.UseVisualStyleBackColor = True
        '
        'CbAdmin
        '
        Me.CbAdmin.AutoSize = True
        Me.CbAdmin.Location = New System.Drawing.Point(89, 78)
        Me.CbAdmin.Name = "CbAdmin"
        Me.CbAdmin.Size = New System.Drawing.Size(68, 22)
        Me.CbAdmin.TabIndex = 2
        Me.CbAdmin.Text = "Admin"
        Me.CbAdmin.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(89, 48)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(183, 24)
        Me.TxtPassword.TabIndex = 3
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(89, 17)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(183, 24)
        Me.TxtUsername.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'FrmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 240)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvUsers)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsers"
        Me.Text = "Data Users"
        CType(Me.DgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvUsers As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnTutup As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnBaru As Button
    Friend WithEvents CbAdmin As CheckBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEdit As Button
End Class
