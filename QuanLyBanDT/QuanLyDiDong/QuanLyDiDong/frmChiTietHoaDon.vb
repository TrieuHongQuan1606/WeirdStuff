Imports System.Data.SqlClient
Public Class frmChiTietHoaDon

    Public Kn As New KetNoi()
    Public Cmd As SqlCommand
    Public Reader As SqlDataReader
    Dim Kt As Boolean
    Dim Query As String

    Public Sub SetControl(b As Boolean)
        btnThem.Enabled = b
        btnSua.Enabled = b
        btnXoa.Enabled = b
        btnLuu.Enabled = Not b

        btnHuy.Enabled = Not b

    End Sub

    Public Sub SetLock(b As Boolean)
        txtMaHD.Enabled = b
        txtMaSanPham.Enabled = b
        txtSoLuong.Enabled = b
        txtDonGia.Enabled = b
    End Sub

    Public Sub CanChinh()
        dgvChiTietHoaDon.Columns(0).Width = 100
        dgvChiTietHoaDon.Columns(1).Width = 120
        dgvChiTietHoaDon.Columns(2).Width = 90
        dgvChiTietHoaDon.Columns(3).Width = 120
    End Sub

    Public Sub CTHoaDon()

        Query = "Select MaHD as N'Mã hoá đơn', MaSP as N'Mã sản phẩm', SoLuong as N'Số lượng', DonGia as N'Đơn giá' from ChiTietHD"
        dgvChiTietHoaDon.DataSource = Kn.DoDuLieu(Query)
        CanChinh()
    End Sub
    Private Sub frmChiTietHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kn.KetNoi()
        CTHoaDon()
        SetControl(True)
        SetLock(False)
        Kn.DongKetNoi()
    End Sub

    Private Sub dgvChiTietHoaDon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChiTietHoaDon.CellContentClick
        Dim r As Integer = dgvChiTietHoaDon.CurrentCell.RowIndex
        txtMaHD.Text = dgvChiTietHoaDon.Rows(r).Cells(0).Value.ToString()
        txtMaSanPham.Text = dgvChiTietHoaDon.Rows(r).Cells(1).Value.ToString()
        txtSoLuong.Text = dgvChiTietHoaDon.Rows(r).Cells(2).Value.ToString()
        txtDonGia.Text = dgvChiTietHoaDon.Rows(r).Cells(3).Value.ToString()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Kt = True
        SetControl(False)
        txtMaHD.Clear()
        txtMaSanPham.Clear()
        txtSoLuong.Clear()
        txtDonGia.Clear()

        SetLock(True)
        txtMaHD.Focus()

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Kt = False
        If txtMaHD.Text = "" And txtMaSanPham.Text = "" Then
            MessageBox.Show("Bạn chưa chọn bản ghi cần sửa")
            Exit Sub
        End If
        SetControl(False)
        SetLock(True)
        txtMaHD.Enabled = False
        txtMaSanPham.Enabled = False
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        SetControl(True)
        SetLock(False)
        txtMaSanPham.Clear()
        txtMaHD.Clear()
        txtSoLuong.Clear()
        txtDonGia.Clear()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Kn.KetNoi()
        Try
            If txtMaHD.Text = "" And txtMaSanPham.Text = "" Then
                MessageBox.Show("Bạn chưa chọn bản ghi cần xoá", "Thông báo")
            Else
                Query = "Delete from ChiTietHD where MaHD = '" + txtMaHD.Text + "' and MaSP = '" + txtMaSanPham.Text + "' "
                If MessageBox.Show("Bạn có chắc chắn muốn xoá", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Kn.NonQuery(Query)
                    MessageBox.Show("Xoá thành công", "Thông báo")
                    CTHoaDon()  'Load lại dữ liệu
                    txtMaHD.Clear()
                    txtMaSanPham.Clear()
                    txtSoLuong.Clear()
                    txtDonGia.Clear()

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
                If txtMaHD.Text = "" Then
                    MsgBox("Nhập thiếu mã hoá đơn")
                ElseIf txtMaSanPham.Text = "" Then
                    MsgBox("Nhập thiếu PT mã sản phẩm")

                Else
                    Query = "insert into ChiTietHD values('" + txtMaHD.Text + "', '" + txtMaSanPham.Text + "', " + txtSoLuong.Text + " , " + txtDonGia.Text + " )"
                    Kn.NonQuery(Query)
                    MsgBox("Thêm thành công")
                    CTHoaDon()
                    txtMaHD.Clear()
                    txtMaSanPham.Clear()
                    txtSoLuong.Clear()
                    txtDonGia.Clear()


                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If (Kt = False) Then
            Try
                Dim LenhUpdate As String = "Update ChiTietHD set SoLuong = '" + txtSoLuong.Text + "',DonGia = '" + txtDonGia.Text + "' where MaHD = '" + txtMaHD.Text + "' and MaSP = '" + txtMaSanPham.Text + "'"
                Kn.NonQuery(LenhUpdate)
                MsgBox("Cập nhật thành công")
                CTHoaDon()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        Kn.DongKetNoi()
    End Sub

    Private Sub txtSoLuong_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuong.KeyPress
        If Asc(e.KeyChar) <> 8 Then  ' Chỉ được nhâp số trên bàn phím
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDonGia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDonGia.KeyPress
        If Asc(e.KeyChar) <> 8 Then  ' Chỉ được nhâp số trên bàn phím
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class