<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyTaiKhoan
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
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvNguoiDung = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtTaiKhoan)
        Me.GroupBox1.Controls.Add(Me.txtMatKhau)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 138)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Tài khoản"
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Location = New System.Drawing.Point(93, 37)
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(118, 27)
        Me.txtTaiKhoan.TabIndex = 17
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(93, 73)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(118, 27)
        Me.txtMatKhau.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mật khẩu"
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(562, 285)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(84, 34)
        Me.btnHuy.TabIndex = 22
        Me.btnHuy.Text = "Huỷ"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(562, 204)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(84, 34)
        Me.btnXoa.TabIndex = 21
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(562, 245)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(84, 34)
        Me.btnLuu.TabIndex = 20
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(562, 164)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(84, 34)
        Me.btnSua.TabIndex = 19
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(562, 125)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(84, 34)
        Me.btnThem.TabIndex = 18
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvNguoiDung
        '
        Me.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNguoiDung.Location = New System.Drawing.Point(242, 125)
        Me.dgvNguoiDung.Name = "dgvNguoiDung"
        Me.dgvNguoiDung.RowHeadersWidth = 51
        Me.dgvNguoiDung.RowTemplate.Height = 24
        Me.dgvNguoiDung.Size = New System.Drawing.Size(304, 204)
        Me.dgvNguoiDung.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(244, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "QUẢN LÝ TÀI KHOẢN"
        '
        'frmQuanLyTaiKhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 399)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvNguoiDung)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmQuanLyTaiKhoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQuanLyTaiKhoan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTaiKhoan As TextBox
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHuy As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvNguoiDung As DataGridView
    Friend WithEvents Label1 As Label
End Class
