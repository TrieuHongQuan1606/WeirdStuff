<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSanPham
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSanPham = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMaSanPham = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtRom = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.cboRam = New System.Windows.Forms.ComboBox()
        Me.txtThoiGianBH = New System.Windows.Forms.TextBox()
        Me.txtXuatXu = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.cboTenHSX = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(390, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ SẢN PHẨM"
        '
        'dgvSanPham
        '
        Me.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanPham.Location = New System.Drawing.Point(367, 125)
        Me.dgvSanPham.Name = "dgvSanPham"
        Me.dgvSanPham.RowHeadersWidth = 51
        Me.dgvSanPham.RowTemplate.Height = 24
        Me.dgvSanPham.Size = New System.Drawing.Size(613, 371)
        Me.dgvSanPham.TabIndex = 1
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(986, 125)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(84, 34)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(986, 164)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(84, 34)
        Me.btnSua.TabIndex = 3
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(986, 245)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(84, 34)
        Me.btnLuu.TabIndex = 4
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(986, 204)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(84, 34)
        Me.btnXoa.TabIndex = 5
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(986, 285)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(84, 34)
        Me.btnHuy.TabIndex = 6
        Me.btnHuy.Text = "Huỷ"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtMaSanPham)
        Me.GroupBox1.Controls.Add(Me.btnTimKiem)
        Me.GroupBox1.Controls.Add(Me.txtRom)
        Me.GroupBox1.Controls.Add(Me.txtSoLuong)
        Me.GroupBox1.Controls.Add(Me.cboRam)
        Me.GroupBox1.Controls.Add(Me.txtThoiGianBH)
        Me.GroupBox1.Controls.Add(Me.txtXuatXu)
        Me.GroupBox1.Controls.Add(Me.txtDonGia)
        Me.GroupBox1.Controls.Add(Me.txtTenSP)
        Me.GroupBox1.Controls.Add(Me.cboTenHSX)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 379)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Mã sản phẩm"
        '
        'txtMaSanPham
        '
        Me.txtMaSanPham.Location = New System.Drawing.Point(134, 70)
        Me.txtMaSanPham.Name = "txtMaSanPham"
        Me.txtMaSanPham.Size = New System.Drawing.Size(101, 27)
        Me.txtMaSanPham.TabIndex = 17
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(291, 33)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(58, 27)
        Me.btnTimKiem.TabIndex = 18
        Me.btnTimKiem.Text = "Tìm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtRom
        '
        Me.txtRom.Location = New System.Drawing.Point(134, 213)
        Me.txtRom.Name = "txtRom"
        Me.txtRom.Size = New System.Drawing.Size(101, 27)
        Me.txtRom.TabIndex = 16
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(134, 248)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(101, 27)
        Me.txtSoLuong.TabIndex = 15
        '
        'cboRam
        '
        Me.cboRam.FormattingEnabled = True
        Me.cboRam.Location = New System.Drawing.Point(134, 179)
        Me.cboRam.Name = "cboRam"
        Me.cboRam.Size = New System.Drawing.Size(101, 27)
        Me.cboRam.TabIndex = 14
        '
        'txtThoiGianBH
        '
        Me.txtThoiGianBH.Location = New System.Drawing.Point(134, 323)
        Me.txtThoiGianBH.Name = "txtThoiGianBH"
        Me.txtThoiGianBH.Size = New System.Drawing.Size(101, 27)
        Me.txtThoiGianBH.TabIndex = 13
        '
        'txtXuatXu
        '
        Me.txtXuatXu.Location = New System.Drawing.Point(134, 285)
        Me.txtXuatXu.Name = "txtXuatXu"
        Me.txtXuatXu.Size = New System.Drawing.Size(101, 27)
        Me.txtXuatXu.TabIndex = 12
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(134, 140)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(101, 27)
        Me.txtDonGia.TabIndex = 10
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(134, 106)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(177, 27)
        Me.txtTenSP.TabIndex = 9
        '
        'cboTenHSX
        '
        Me.cboTenHSX.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTenHSX.FormattingEnabled = True
        Me.cboTenHSX.Location = New System.Drawing.Point(134, 35)
        Me.cboTenHSX.Name = "cboTenHSX"
        Me.cboTenHSX.Size = New System.Drawing.Size(151, 27)
        Me.cboTenHSX.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(14, 326)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 19)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Thời gian bảo hành"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Xuất xứ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Số lượng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Rom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ram"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Đơn giá"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên sản phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên hãng sản xuất"
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 522)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvSanPham)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSanPham"
        CType(Me.dgvSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnHuy As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents cboTenHSX As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRom As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents cboRam As ComboBox
    Friend WithEvents txtThoiGianBH As TextBox
    Friend WithEvents txtXuatXu As TextBox
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents txtMaSanPham As TextBox
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents Label10 As Label
End Class
