<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoiMatKhau
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
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnDoiMK = New System.Windows.Forms.Button()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMatKhauMoi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNhapLai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(374, 348)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(138, 44)
        Me.btnThoat.TabIndex = 13
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnDoiMK
        '
        Me.btnDoiMK.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoiMK.Location = New System.Drawing.Point(193, 348)
        Me.btnDoiMK.Name = "btnDoiMK"
        Me.btnDoiMK.Size = New System.Drawing.Size(138, 44)
        Me.btnDoiMK.TabIndex = 12
        Me.btnDoiMK.Text = "Đổi mật khẩu"
        Me.btnDoiMK.UseVisualStyleBackColor = True
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatKhau.Location = New System.Drawing.Point(330, 194)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(182, 30)
        Me.txtMatKhau.TabIndex = 11
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaiKhoan.Location = New System.Drawing.Point(330, 150)
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(182, 30)
        Me.txtTaiKhoan.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mật khẩu cũ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tài khoản"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(259, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ĐỔI MẬT KHẨU"
        '
        'txtMatKhauMoi
        '
        Me.txtMatKhauMoi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatKhauMoi.Location = New System.Drawing.Point(330, 236)
        Me.txtMatKhauMoi.Name = "txtMatKhauMoi"
        Me.txtMatKhauMoi.Size = New System.Drawing.Size(182, 30)
        Me.txtMatKhauMoi.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Mật khẩu mới"
        '
        'txtNhapLai
        '
        Me.txtNhapLai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNhapLai.Location = New System.Drawing.Point(330, 276)
        Me.txtNhapLai.Name = "txtNhapLai"
        Me.txtNhapLai.Size = New System.Drawing.Size(182, 30)
        Me.txtNhapLai.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(188, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Nhập lại"
        '
        'frmDoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 499)
        Me.Controls.Add(Me.txtNhapLai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMatKhauMoi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDoiMK)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTaiKhoan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDoiMatKhau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDoiMatKhau"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnThoat As Button
    Friend WithEvents btnDoiMK As Button
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents txtTaiKhoan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMatKhauMoi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNhapLai As TextBox
    Friend WithEvents Label5 As Label
End Class
