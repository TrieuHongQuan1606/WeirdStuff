Imports System.Data.SqlClient
Public Class frmQuanLyTaiKhoan
    Public Kn As New KetNoi()
    Public Cmd As SqlCommand
    Public Reader As SqlDataReader
    Dim Kt As Boolean
    Dim Query As String

    Private Sub dgvNguoiDung_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNguoiDung.CellContentClick
        Dim r As Integer = dgvNguoiDung.CurrentCell.RowIndex
        txtTaiKhoan.Text = dgvNguoiDung.Rows(r).Cells(0).Value.ToString()
        txtMatKhau.Text = dgvNguoiDung.Rows(r).Cells(1).Value.ToString()
    End Sub
    Public Sub SetControl(b As Boolean)
        btnThem.Enabled = b
        btnSua.Enabled = b
        btnXoa.Enabled = b
        btnLuu.Enabled = Not b

        btnHuy.Enabled = Not b

    End Sub

    Public Sub SetLock(b As Boolean)
        txtTaiKhoan.Enabled = b
        txtMatKhau.Enabled = b
    End Sub

    Public Sub CanChinh()
        dgvNguoiDung.Columns(0).Width = 130
        dgvNguoiDung.Columns(1).Width = 130
    End Sub

    Public Sub NguoiDung()
        Query = "Select TaiKhoan as N'Tài khoản', MatKhau as N'Mật khẩu' from NguoiDung"
        dgvNguoiDung.DataSource = Kn.DoDuLieu(Query)
        CanChinh()
    End Sub

    Private Sub frmQuanLyTaiKhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kn.KetNoi()
        SetControl(True)
        SetLock(False)
        NguoiDung()
        Kn.DongKetNoi()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Kt = True
        SetControl(False)
        txtTaiKhoan.Clear()
        txtMatKhau.Clear()
        SetLock(True)
        txtTaiKhoan.Focus()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Kt = False
        If txtTaiKhoan.Text = "" Then
            MessageBox.Show("Bạn chưa chọn tài khoản cần sửa")
            Exit Sub
        End If
        SetControl(False)
        SetLock(True)
        txtTaiKhoan.Enabled = False
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Kn.KetNoi()
        Try
            If txtTaiKhoan.Text = "" Then
                MessageBox.Show("Bạn chưa chọn tài khoản cần xoá", "Thông báo")
            Else
                Query = "Delete from NguoiDung where TaiKhoan = '" + txtTaiKhoan.Text + "'"
                If MessageBox.Show("Bạn có chắc chắn muốn xoá", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Kn.NonQuery(Query)
                    MessageBox.Show("Xoá thành công", "Thông báo")
                    NguoiDung()  'Load lại dữ liệu
                    txtTaiKhoan.Clear()
                    txtMatKhau.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Kn.DongKetNoi()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Kn.KetNoi()
        Try
            If (Kt = True) Then
                If txtTaiKhoan.Text = "" Then
                    MsgBox("Nhập thiếu tài khoản")
                ElseIf txtMatKhau.Text = "" Then
                    MsgBox("Nhập thiếu mật khẩu")
                Else
                    Query = "insert into NguoiDung values('" + txtTaiKhoan.Text + "', '" + txtMatKhau.Text + "')"
                    Kn.NonQuery(Query)
                    MsgBox("Thêm thành công")
                    txtTaiKhoan.Clear()
                    txtMatKhau.Clear()
                    NguoiDung()

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If (Kt = False) Then
            Try
                Dim LenhUpdate As String = "Update NguoiDung set MatKhau = '" + txtMatKhau.Text + "' where TaiKhoan = '" + txtTaiKhoan.Text + "' "
                Kn.NonQuery(LenhUpdate)
                MsgBox("Cập nhật thành công")
                NguoiDung() 'Load lại dữ liệu

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        Kn.DongKetNoi()
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        SetControl(True)
        SetLock(False)
        txtTaiKhoan.Clear()
        txtMatKhau.Clear()
    End Sub
End Class