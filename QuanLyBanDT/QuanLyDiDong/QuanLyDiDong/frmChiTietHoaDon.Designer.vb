<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietHoaDon
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
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMaSanPham = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvChiTietHoaDon = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvChiTietHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaHD)
        Me.GroupBox1.Controls.Add(Me.txtDonGia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtMaSanPham)
        Me.GroupBox1.Controls.Add(Me.txtSoLuong)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 189)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin"
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(134, 31)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(101, 27)
        Me.txtMaHD.TabIndex = 22
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(134, 143)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(101, 27)
        Me.txtDonGia.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Đơn giá"
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
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(134, 106)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(101, 27)
        Me.txtSoLuong.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Số lượng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã hoá đơn"
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(785, 279)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(84, 34)
        Me.btnHuy.TabIndex = 14
        Me.btnHuy.Text = "Huỷ"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(785, 198)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(84, 34)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(785, 239)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(84, 34)
        Me.btnLuu.TabIndex = 12
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(785, 158)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(84, 34)
        Me.btnSua.TabIndex = 11
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(785, 119)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(84, 34)
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvChiTietHoaDon
        '
        Me.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietHoaDon.Location = New System.Drawing.Point(291, 119)
        Me.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon"
        Me.dgvChiTietHoaDon.RowHeadersWidth = 51
        Me.dgvChiTietHoaDon.RowTemplate.Height = 24
        Me.dgvChiTietHoaDon.Size = New System.Drawing.Size(478, 270)
        Me.dgvChiTietHoaDon.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(300, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 32)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CHI TIẾT HOÁ ĐƠN"
        '
        'frmChiTietHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 452)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvChiTietHoaDon)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmChiTietHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChiTietHoaDon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvChiTietHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMaSanPham As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnHuy As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvChiTietHoaDon As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaHD As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents Label4 As Label
End Class
