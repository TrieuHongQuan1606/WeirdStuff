Imports System.Data.SqlClient
Public Class frmDoiMatKhau

    Public cmd As SqlCommand
    Public Reader As SqlDataReader
    Public Kn As New KetNoi()

    Private Sub btnDoiMK_Click(sender As Object, e As EventArgs) Handles btnDoiMK.Click
        Kn.KetNoi()
        If txtMatKhau.Text <> frmDangNhap.txtMatKhau.Text Then
            MessageBox.Show("Bạn nhập lại mật khẩu cũ chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMatKhau.Focus()
            Exit Sub
        End If
        If txtMatKhauMoi.Text = "" Or txtNhapLai.Text = "" Then
            MsgBox("Bạn nhập chưa đủ mật khẩu mới")
            txtMatKhauMoi.Focus()
            Exit Sub
        End If
        If txtMatKhauMoi.Text <> txtNhapLai.Text Then
            MsgBox("Bạn nhập mật khẩu mới không giống nhau")
            txtNhapLai.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Bạn có muốn đổi mật khẩu không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then

            Dim Query As String = "Update NguoiDung  set MatKhau = '" + txtMatKhauMoi.Text + "' where TaiKhoan = '" + txtTaiKhoan.Text + "'"
            Kn.NonQuery(Query)

            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo")
            txtMatKhau.Clear()
            txtMatKhauMoi.Clear()
            txtNhapLai.Clear()

        End If
        Kn.DongKetNoi()
    End Sub

    Private Sub frmDoiMatKhau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTaiKhoan.Text = frmDangNhap.txtTaiKhoan.Text
        txtTaiKhoan.Enabled = False
        txtMatKhau.PasswordChar = "*"
        txtMatKhauMoi.PasswordChar = "*"
        txtNhapLai.PasswordChar = "*"
    End Sub
End Class