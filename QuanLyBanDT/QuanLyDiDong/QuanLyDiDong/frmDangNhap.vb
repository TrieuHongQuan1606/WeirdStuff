Imports System.Data.SqlClient
Public Class frmDangNhap
    Public reader As SqlDataReader
    Public Cmd As SqlCommand
    Dim query As String
    Public Kn As New KetNoi()

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Kn.KetNoi()
        query = "Select * from NguoiDung where TaiKhoan = '" + txtTaiKhoan.Text + "' and MatKhau = '" + txtMatKhau.Text + "'"
        Cmd = New SqlCommand(query, Kn.Conn)
        reader = Cmd.ExecuteReader
        If reader.Read() Then  ' Kiểm tra xem có đúng bản ghi không
            frmMain.Show()
            'txtTaiKhoan.Clear()
            'txtTaiKhoan.Focus()
            'txtMatKhau.Clear()


            Me.Hide()

        Else
            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Kn.DongKetNoi()
    End Sub


    Private Sub txtTaiKhoan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTaiKhoan.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then    ' Kiểm ra xem có nhập vào từ bán phím không
        Else                                        ' Có thì mở ô nhập mật khẩu
            txtMatKhau.Enabled = True
        End If
    End Sub

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMatKhau.Enabled = False
        txtMatKhau.PasswordChar = "*"
    End Sub

    Private Sub txtTaiKhoan_Leave(sender As Object, e As EventArgs) Handles txtTaiKhoan.Leave
        If txtTaiKhoan.Text = "" Then
            txtMatKhau.Enabled = False  ' Kiểm tra khi rời đi ô tài khoản có trống khong
            ' Có thì đóng ô mật khẩu
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        End
    End Sub

    Private Sub txtTaiKhoan_TextChanged(sender As Object, e As EventArgs) Handles txtTaiKhoan.TextChanged

    End Sub

    Private Sub txtMatKhau_TextChanged(sender As Object, e As EventArgs) Handles txtMatKhau.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class