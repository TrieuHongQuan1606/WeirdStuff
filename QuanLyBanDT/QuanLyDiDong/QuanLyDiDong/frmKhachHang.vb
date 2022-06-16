Imports System.Data.SqlClient
Public Class frmKhachHang
    Dim Kn As New KetNoi()
    Dim Kt As Boolean
    Public Reader As SqlDataReader
    Public Cmd As SqlCommand
    Dim Query As String

    Public Sub SetControl(b As Boolean)
        btnThem.Enabled = b
        btnSua.Enabled = b
        btnXoa.Enabled = b
        btnLuu.Enabled = Not b

        btnHuy.Enabled = Not b

    End Sub

    Public Sub SetLock(b As Boolean)
        txtMaKH.Enabled = b
        txtTenKH.Enabled = b

        txtDiaChi.Enabled = b
        txtSoDT.Enabled = b
        txtEmail.Enabled = b
        mtbNgaySinh.Enabled = b
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Kt = True
        SetControl(False)
        txtMaKH.Clear()
        txtTenKH.Clear()
        txtDiaChi.Clear()
        txtEmail.Clear()
        txtSoDT.Clear()
        mtbNgaySinh.Clear()
        SetLock(True)
        txtMaKH.Text = "Auto"
        txtMaKH.Enabled = False
        txtTenKH.Focus()

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaKH.Text = "" Then
            MessageBox.Show("Bạn chưa chọn khách hàng cần sửa")
            Exit Sub
        End If
        Kt = False
        SetControl(False)
        SetLock(True)
        txtMaKH.Enabled = False
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Kn.KetNoi()
        Try
            If txtMaKH.Text = "" Then
                MessageBox.Show("Bạn chưa chọn khách hàng cần xoá", "Thông báo")
            Else
                Query = "Delete from KhachHang where MaKH = '" + txtMaKH.Text + "'"
                If MessageBox.Show("Bạn có chắc chắn muốn xoá", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Kn.NonQuery(Query)
                    MessageBox.Show("Xoá thành công", "Thông báo")
                    KhachHang()  'Load lại dữ liệu
                    txtMaKH.Clear()
                    txtTenKH.Clear()
                    txtDiaChi.Clear()
                    txtEmail.Clear()
                    txtSoDT.Clear()
                    mtbNgaySinh.Clear()
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
                If txtTenKH.Text = "" Then
                    MsgBox("Nhập thiếu tên khách hàng")
                ElseIf txtSoDT.Text = "" Then
                    MsgBox("Nhập thiếu số điẹn thoại")
                ElseIf mtbNgaySinh.Text = "" Then
                    MsgBox("Nhập thiếu ngày sinh")
                Else
                    Query = "insert into KhachHang(TenKH, DiaChi, SoDT, NgaySinh, Email) values(N'" + txtTenKH.Text + "', N'" + txtDiaChi.Text + "', '" + txtSoDT.Text + "', Convert(date , '" + mtbNgaySinh.Text + "', 103), '" + txtEmail.Text + "')"
                    'Hàm Convert để chuyển thành dd/mm/yyyy

                    Kn.NonQuery(Query)
                    MsgBox("Thêm thành công")
                    KhachHang()
                    txtMaKH.Clear()
                    txtTenKH.Clear()
                    txtDiaChi.Clear()
                    txtSoDT.Clear()
                    txtEmail.Clear()
                    mtbNgaySinh.Clear()

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If (Kt = False) Then
            Try
                Dim LenhUpdate As String = "Update KhachHang set TenKH = N'" + txtTenKH.Text + "' ,DiaChi = N'" + txtDiaChi.Text + "', SoDT = '" + txtSoDT.Text + "',NgaySinh = Convert(date , '" + mtbNgaySinh.Text + "', 103), Email = '" + txtEmail.Text + "'  where MaKH = '" + txtMaKH.Text + "' "
                Kn.NonQuery(LenhUpdate)
                MsgBox("Cập nhật thành công")
                KhachHang()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        Kn.DongKetNoi()
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        SetControl(True)
        SetLock(False)
        txtMaKH.Clear()
        txtTenKH.Clear()
        txtDiaChi.Clear()
        txtEmail.Clear()
        txtSoDT.Clear()
        mtbNgaySinh.Clear()
    End Sub


    Public Sub CanChinh()
        dgvKhachHang.Columns(0).Width = 100
        dgvKhachHang.Columns(1).Width = 120
        dgvKhachHang.Columns(2).Width = 130
        dgvKhachHang.Columns(3).Width = 120
        dgvKhachHang.Columns(4).Width = 120
        dgvKhachHang.Columns(5).Width = 120

    End Sub

    Public Sub KhachHang()

        Query = "Select MaKH as N'Mã khách hàng', TenKH as N'Tên khách hàng', DiaChi as N'Địa chỉ', SoDT as N'Số điện thoại', NgaySinh as N'Ngày sinh', Email from KhachHang"
        dgvKhachHang.DataSource = Kn.DoDuLieu(Query)
        CanChinh()
    End Sub

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kn.KetNoi()
        KhachHang()
        SetControl(True)
        SetLock(False)
        txtMaKH.Enabled = True
        Kn.DongKetNoi()
    End Sub

    Private Sub dgvKhachHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhachHang.CellContentClick
        Dim r As Integer = dgvKhachHang.CurrentCell.RowIndex
        txtMaKH.Text = dgvKhachHang.Rows(r).Cells(0).Value.ToString()
        txtTenKH.Text = dgvKhachHang.Rows(r).Cells(1).Value.ToString()
        txtDiaChi.Text = dgvKhachHang.Rows(r).Cells(2).Value.ToString()
        txtSoDT.Text = dgvKhachHang.Rows(r).Cells(3).Value.ToString()
        mtbNgaySinh.Text = dgvKhachHang.Rows(r).Cells(4).Value.ToString()
        txtEmail.Text = dgvKhachHang.Rows(r).Cells(5).Value.ToString()

    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Kn.KetNoi()
        Try
            txtTenKH.Clear()
            txtDiaChi.Clear()
            txtEmail.Clear()
            txtSoDT.Clear()
            mtbNgaySinh.Clear()
            Query = "Select MaKH as N'Mã khách hàng', TenKH as N'Tên khách hàng', DiaChi as N'Địa chỉ', SoDT as N'Số điện thoại', NgaySinh as N'Ngày sinh', Email from KhachHang where MaKH like '" + txtMaKH.Text + "%'"
            dgvKhachHang.DataSource = Kn.DoDuLieu(Query)
            CanChinh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Kn.DongKetNoi()
    End Sub

    Private Sub txtMaKH_Leave(sender As Object, e As EventArgs) Handles txtMaKH.Leave
        If txtMaKH.Text = "Auto" Or txtMaKH.Text = "" Then
            KhachHang()
        End If
    End Sub
End Class