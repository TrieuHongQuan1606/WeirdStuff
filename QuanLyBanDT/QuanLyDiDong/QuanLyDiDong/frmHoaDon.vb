Imports System.Data.SqlClient
Public Class frmHoaDon

    Public Kn As New KetNoi()
    Public Cmd As SqlCommand
    Public Reader As SqlDataReader
    Dim Kt As Boolean
    Dim Query As String

    Private Sub dgvHoaDon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellContentClick
        Dim r As Integer = dgvHoaDon.CurrentCell.RowIndex
        txtMaHD.Text = dgvHoaDon.Rows(r).Cells(0).Value.ToString()
        txtMaKH.Text = dgvHoaDon.Rows(r).Cells(1).Value.ToString()
        mtbNgayLapHD.Text = dgvHoaDon.Rows(r).Cells(2).Value.ToString()
        cboPTthanhToan.Text = dgvHoaDon.Rows(r).Cells(3).Value.ToString()
    End Sub

    Public Sub SetControl(b As Boolean)
        btnThem.Enabled = b
        btnSua.Enabled = b
        btnXoa.Enabled = b
        btnLuu.Enabled = Not b

        btnHuy.Enabled = Not b

    End Sub

    Public Sub SetLock(b As Boolean)
        txtMaHD.Enabled = b
        txtMaKH.Enabled = b
        cboPTthanhToan.Enabled = b
        mtbNgayLapHD.Enabled = b
    End Sub

    Public Sub CanChinh()
        dgvHoaDon.Columns(0).Width = 100
        dgvHoaDon.Columns(1).Width = 120
        dgvHoaDon.Columns(2).Width = 130
        dgvHoaDon.Columns(3).Width = 120
    End Sub

    Public Sub HoaDon()

        Query = "Select MaHD as N'Mã hoá đơn', MaKH as N'Mã khách hàng', NgayLapHD as N'Ngày lập hoá đơn', PTthanhToan as N'PT thanh toán' from HoaDon"
        dgvHoaDon.DataSource = Kn.DoDuLieu(Query)
        CanChinh()
    End Sub

    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kn.KetNoi()
        HoaDon()
        SetControl(True)
        SetLock(False)
        cboPTthanhToan.Items.Add("CK")
        cboPTthanhToan.Items.Add("TM")
        Kn.DongKetNoi()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Kt = True
        SetControl(False)
        txtMaHD.Clear()
        txtMaKH.Clear()
        mtbNgayLapHD.Clear()

        cboPTthanhToan.Text = ""
        SetLock(True)
        txtMaHD.Text = "Auto"
        txtMaHD.Enabled = False
        txtMaKH.Focus()


    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Kt = False
        If txtMaHD.Text = "" Then
            MessageBox.Show("Bạn chưa chọn bản ghi cần sửa")
            Exit Sub
        End If
        SetControl(False)
        SetLock(True)
        txtMaHD.Enabled = False
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Kn.KetNoi()
        Try
            If (Kt = True) Then
                If txtMaKH.Text = "" Then
                    MsgBox("Nhập thiếu mã khách hàng")
                ElseIf cboPTthanhToan.Text = "" Then
                    MsgBox("Nhập thiếu PT thanh toán")
                Else
                    Query = "insert into HoaDon(MaKH, NgayLapHD, PTthanhToan) values('" + txtMaKH.Text + "', Convert(date , '" + mtbNgayLapHD.Text + "', 103), N'" + cboPTthanhToan.Text + "')"
                    'Hàm Convert để chuyển thành dd/mm/yyyy

                    Kn.NonQuery(Query)
                    MsgBox("Thêm thành công")
                    txtMaKH.Clear()
                    cboPTthanhToan.Text = ""
                    HoaDon()

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If (Kt = False) Then
            Try
                Dim LenhUpdate As String = "Update HoaDon set MaKH = '" + txtMaKH.Text + "',NgayLapHD = Convert(date , '" + mtbNgayLapHD.Text + "', 103), PTthanhToan = '" + cboPTthanhToan.Text + "' where MaHD = '" + txtMaHD.Text + "' "
                Kn.NonQuery(LenhUpdate)
                MsgBox("Cập nhật thành công")
                HoaDon()

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
        txtMaHD.Clear()
        cboPTthanhToan.Text = ""
        mtbNgayLapHD.Clear()

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Kn.KetNoi()
        Try
            If txtMaHD.Text = "" Then
                MessageBox.Show("Bạn chưa chọn sản phẩm cần xoá", "Thông báo")
            Else
                Query = "Delete from HoaDon where MaHD = '" + txtMaHD.Text + "'"
                If MessageBox.Show("Bạn có chắc chắn muốn xoá", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Kn.NonQuery(Query)
                    MessageBox.Show("Xoá thành công", "Thông báo")
                    HoaDon()  'Load lại dữ liệu
                    txtMaHD.Clear()
                    txtMaKH.Clear()
                    cboPTthanhToan.Text = ""
                    mtbNgayLapHD.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Kn.DongKetNoi()
    End Sub
End Class