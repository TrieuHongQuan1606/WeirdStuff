<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvKhachHang = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSoDT = New System.Windows.Forms.TextBox()
        Me.mtbNgaySinh = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtbNgaySinh)
        Me.GroupBox1.Controls.Add(Me.txtSoDT)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtMaKH)
        Me.GroupBox1.Controls.Add(Me.btnTimKiem)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.txtTenKH)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 273)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Mã khách hàng"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(124, 33)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(101, 27)
        Me.txtMaKH.TabIndex = 17
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(231, 32)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(58, 27)
        Me.btnTimKiem.TabIndex = 18
        Me.btnTimKiem.Text = "Tìm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(124, 211)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(149, 27)
        Me.txtEmail.TabIndex = 15
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(124, 103)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(101, 27)
        Me.txtDiaChi.TabIndex = 10
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(124, 69)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(149, 27)
        Me.txtTenKH.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 19)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Ngày sinh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Số điện thoại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Địa chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên khách hàng"
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(981, 261)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(84, 34)
        Me.btnHuy.TabIndex = 14
        Me.btnHuy.Text = "Huỷ"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(981, 180)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(84, 34)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(981, 221)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(84, 34)
        Me.btnLuu.TabIndex = 12
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(981, 140)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(84, 34)
        Me.btnSua.TabIndex = 11
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(981, 101)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(84, 34)
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvKhachHang
        '
        Me.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKhachHang.Location = New System.Drawing.Point(352, 101)
        Me.dgvKhachHang.Name = "dgvKhachHang"
        Me.dgvKhachHang.RowHeadersWidth = 51
        Me.dgvKhachHang.RowTemplate.Height = 24
        Me.dgvKhachHang.Size = New System.Drawing.Size(613, 299)
        Me.dgvKhachHang.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(427, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 35)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "QUẢN LÝ KHÁCH HÀNG"
        '
        'txtSoDT
        '
        Me.txtSoDT.Location = New System.Drawing.Point(124, 139)
        Me.txtSoDT.Name = "txtSoDT"
        Me.txtSoDT.Size = New System.Drawing.Size(101, 27)
        Me.txtSoDT.TabIndex = 20
        '
        'mtbNgaySinh
        '
        Me.mtbNgaySinh.Location = New System.Drawing.Point(124, 175)
        Me.mtbNgaySinh.Mask = "00/00/0000"
        Me.mtbNgaySinh.Name = "mtbNgaySinh"
        Me.mtbNgaySinh.Size = New System.Drawing.Size(100, 27)
        Me.mtbNgaySinh.TabIndex = 21
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvKhachHang)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmKhachHang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHuy As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvKhachHang As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents mtbNgaySinh As MaskedTextBox
    Friend WithEvents txtSoDT As TextBox
End Class
