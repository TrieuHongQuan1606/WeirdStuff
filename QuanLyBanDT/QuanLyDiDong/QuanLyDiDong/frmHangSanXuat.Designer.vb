<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHangSanXuat
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
        Me.txtMaHangSX = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTenHangSX = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvHangSanXuat = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvHangSanXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaHangSX)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtTenHangSX)
        Me.GroupBox1.Controls.Add(Me.txtDiaChi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 170)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin"
        '
        'txtMaHangSX
        '
        Me.txtMaHangSX.Location = New System.Drawing.Point(134, 31)
        Me.txtMaHangSX.Name = "txtMaHangSX"
        Me.txtMaHangSX.Size = New System.Drawing.Size(101, 27)
        Me.txtMaHangSX.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Tên hãng SX"
        '
        'txtTenHangSX
        '
        Me.txtTenHangSX.Location = New System.Drawing.Point(134, 70)
        Me.txtTenHangSX.Name = "txtTenHangSX"
        Me.txtTenHangSX.Size = New System.Drawing.Size(101, 27)
        Me.txtTenHangSX.TabIndex = 17
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(134, 106)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(177, 27)
        Me.txtDiaChi.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Địa chỉ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã hãng SX"
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(862, 318)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(84, 34)
        Me.btnHuy.TabIndex = 14
        Me.btnHuy.Text = "Huỷ"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(862, 237)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(84, 34)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(862, 278)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(84, 34)
        Me.btnLuu.TabIndex = 12
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(862, 197)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(84, 34)
        Me.btnSua.TabIndex = 11
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(862, 158)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(84, 34)
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvHangSanXuat
        '
        Me.dgvHangSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHangSanXuat.Location = New System.Drawing.Point(378, 158)
        Me.dgvHangSanXuat.Name = "dgvHangSanXuat"
        Me.dgvHangSanXuat.RowHeadersWidth = 51
        Me.dgvHangSanXuat.RowTemplate.Height = 24
        Me.dgvHangSanXuat.Size = New System.Drawing.Size(468, 234)
        Me.dgvHangSanXuat.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(322, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 35)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "QUẢN LÝ HÃNG SẢN XUẤT"
        '
        'frmHangSanXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 452)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvHangSanXuat)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmHangSanXuat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHangSanXuat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvHangSanXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTenHangSX As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnHuy As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvHangSanXuat As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaHangSX As TextBox
    Friend WithEvents txtDiaChi As TextBox
End Class
