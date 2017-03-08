<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsinhvien
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
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.lblmsv = New System.Windows.Forms.Label()
        Me.lbltensv = New System.Windows.Forms.Label()
        Me.lblgioitinh = New System.Windows.Forms.Label()
        Me.lblngaysinh = New System.Windows.Forms.Label()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.txtmasv = New System.Windows.Forms.TextBox()
        Me.txttensv = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtgioitinh = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.dtpngaysinh = New System.Windows.Forms.DateTimePicker()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.btntimkiem = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblmalop = New System.Windows.Forms.Label()
        Me.txtmalop = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(29, 228)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 1
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(154, 228)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 2
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(301, 228)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 3
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnthoat.Location = New System.Drawing.Point(428, 228)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 4
        Me.btnthoat.Text = "thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'lblmsv
        '
        Me.lblmsv.AutoSize = True
        Me.lblmsv.Location = New System.Drawing.Point(43, 25)
        Me.lblmsv.Name = "lblmsv"
        Me.lblmsv.Size = New System.Drawing.Size(70, 13)
        Me.lblmsv.TabIndex = 5
        Me.lblmsv.Text = "Mã Sinh Viên"
        '
        'lbltensv
        '
        Me.lbltensv.AutoSize = True
        Me.lbltensv.Location = New System.Drawing.Point(44, 53)
        Me.lbltensv.Name = "lbltensv"
        Me.lbltensv.Size = New System.Drawing.Size(26, 13)
        Me.lbltensv.TabIndex = 5
        Me.lbltensv.Text = "Tên"
        '
        'lblgioitinh
        '
        Me.lblgioitinh.AutoSize = True
        Me.lblgioitinh.Location = New System.Drawing.Point(43, 123)
        Me.lblgioitinh.Name = "lblgioitinh"
        Me.lblgioitinh.Size = New System.Drawing.Size(51, 13)
        Me.lblgioitinh.TabIndex = 5
        Me.lblgioitinh.Text = "Giới Tính"
        '
        'lblngaysinh
        '
        Me.lblngaysinh.AutoSize = True
        Me.lblngaysinh.Location = New System.Drawing.Point(309, 53)
        Me.lblngaysinh.Name = "lblngaysinh"
        Me.lblngaysinh.Size = New System.Drawing.Size(56, 13)
        Me.lblngaysinh.TabIndex = 5
        Me.lblngaysinh.Text = "Ngày Sinh"
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(43, 85)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(41, 13)
        Me.lbldiachi.TabIndex = 5
        Me.lbldiachi.Text = "Địa Chỉ"
        '
        'txtmasv
        '
        Me.txtmasv.Location = New System.Drawing.Point(143, 25)
        Me.txtmasv.Name = "txtmasv"
        Me.txtmasv.Size = New System.Drawing.Size(117, 20)
        Me.txtmasv.TabIndex = 6
        '
        'txttensv
        '
        Me.txttensv.Location = New System.Drawing.Point(143, 53)
        Me.txttensv.Name = "txttensv"
        Me.txttensv.Size = New System.Drawing.Size(117, 20)
        Me.txttensv.TabIndex = 6
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(143, 82)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(117, 20)
        Me.txtdiachi.TabIndex = 6
        '
        'txtgioitinh
        '
        Me.txtgioitinh.Location = New System.Drawing.Point(143, 116)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(117, 20)
        Me.txtgioitinh.TabIndex = 6
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(396, 25)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(117, 20)
        Me.txtsdt.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SĐT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mô Tả"
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(396, 85)
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(117, 20)
        Me.txtmota.TabIndex = 10
        '
        'dtpngaysinh
        '
        Me.dtpngaysinh.CustomFormat = ""
        Me.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpngaysinh.Location = New System.Drawing.Point(396, 53)
        Me.dtpngaysinh.Name = "dtpngaysinh"
        Me.dtpngaysinh.Size = New System.Drawing.Size(117, 20)
        Me.dtpngaysinh.TabIndex = 11
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(228, 170)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(202, 20)
        Me.txttimkiem.TabIndex = 14
        '
        'btntimkiem
        '
        Me.btntimkiem.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btntimkiem.Location = New System.Drawing.Point(125, 167)
        Me.btntimkiem.Name = "btntimkiem"
        Me.btntimkiem.Size = New System.Drawing.Size(75, 23)
        Me.btntimkiem.TabIndex = 15
        Me.btntimkiem.Text = "Tìm Kiếm"
        Me.btntimkiem.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(561, 120)
        Me.DataGridView1.TabIndex = 16
        '
        'lblmalop
        '
        Me.lblmalop.AutoSize = True
        Me.lblmalop.Location = New System.Drawing.Point(312, 122)
        Me.lblmalop.Name = "lblmalop"
        Me.lblmalop.Size = New System.Drawing.Size(43, 13)
        Me.lblmalop.TabIndex = 17
        Me.lblmalop.Text = "Mã Lớp"
        '
        'txtmalop
        '
        Me.txtmalop.Location = New System.Drawing.Point(396, 116)
        Me.txtmalop.Name = "txtmalop"
        Me.txtmalop.Size = New System.Drawing.Size(117, 20)
        Me.txtmalop.TabIndex = 18
        '
        'frmsinhvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 410)
        Me.Controls.Add(Me.txtmalop)
        Me.Controls.Add(Me.lblmalop)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btntimkiem)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.dtpngaysinh)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtgioitinh)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txttensv)
        Me.Controls.Add(Me.txtmasv)
        Me.Controls.Add(Me.lbldiachi)
        Me.Controls.Add(Me.lblngaysinh)
        Me.Controls.Add(Me.lblgioitinh)
        Me.Controls.Add(Me.lbltensv)
        Me.Controls.Add(Me.lblmsv)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Name = "frmsinhvien"
        Me.Text = "Bảng quản lý sinh viên"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents lblmsv As System.Windows.Forms.Label
    Friend WithEvents lbltensv As System.Windows.Forms.Label
    Friend WithEvents lblgioitinh As System.Windows.Forms.Label
    Friend WithEvents lblngaysinh As System.Windows.Forms.Label
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents txtmasv As System.Windows.Forms.TextBox
    Friend WithEvents txttensv As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtgioitinh As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents dtpngaysinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents btntimkiem As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblmalop As System.Windows.Forms.Label
    Friend WithEvents txtmalop As System.Windows.Forms.TextBox

End Class
