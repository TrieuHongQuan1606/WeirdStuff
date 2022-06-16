Imports System.Data.SqlClient

Public Class frmHangSanXuat
    Dim Kt As Boolean
    Public Kn As New KetNoi()
    Public Cmd As SqlCommand
    Public Reader As SqlDataReader
    Dim query As String

    Public Sub CanChinh()
        dgvHangSanXuat.Columns(0).Width = 120
        dgvHangSanXuat.Columns(1).Width = 150
        dgvHangSanXuat.Columns(2).Width = 150
    End Sub
    Public Sub SetControl(b As Boolean)
        btnThem.Enabled = b
        btnSua.Enabled = b
        btnXoa.Enabled = b
        btnLuu.Enabled = Not b

        btnHuy.Enabled = Not b

    End Sub

    Public Sub SetLock(b As Boolean)
        txtMaHangSX.Enabled = b
        txtTenHangSX.Enabled = b
        txtDiaChi.Enabled = b
    End Sub

    Public Sub HangSanXuat()
        query = "Select MaHangSX as N'Mã hãng SX', TenHangSX as N'Tên hãng SX', DiaChi as N'Địa chỉ' from HangSX"
        dgvHangSanXuat.DataSource = Kn.DoDuLieu(query)
        CanChinh()

    End Sub

    Private Sub frmHangSanXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kn.KetNoi()
        HangSanXuat()
        SetControl(True)
        SetLock(False)
        Kn.DongKetNoi()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Kt = True
        SetControl(False)
        txtMaHangSX.Clear()
        txtTenHangSX.Clear()
        txtDiaChi.Clear()
        SetLock(True)
        txtMaHangSX.Focus()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Kt = False
        If txtMaHangSX.Text = "" Then
            MessageBox.Show("Bạn chưa chọn bản ghi cần sửa")
            Exit Sub
        End If
        SetControl(False)
        SetLock(True)
        txtMaHangSX.Enabled = False
    End Sub

    Private Sub dgvHangSanXuat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHangSanXuat.CellContentClick
        Dim r As Integer = dgvHangSanXuat.CurrentCell.RowIndex
        txtMaHangSX.Text = dgvHangSanXuat.Rows(r).Cells(0).Value.ToString()
        txtTenHangSX.Text = dgvHangSanXuat.Rows(r).Cells(1).Value.ToString()
        txtDiaChi.Text = dgvHangSanXuat.Rows(r).Cells(2).Value.ToString()
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        SetControl(True)
        SetLock(False)
        txtMaHangSX.Clear()
        txtTenHangSX.Clear()
        txtDiaChi.Clear()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Kn.KetNoi()
        Try
            If txtMaHangSX.Text = "" Then
                MessageBox.Show("Bạn chưa chọn sản phẩm cần xoá", "Thông báo")
            Else
                query = "Delete from HangSX where MaHangSX = '" + txtMaHangSX.Text + "'"
                If MessageBox.Show("Bạn có chắc chắn muốn xoá", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Kn.NonQuery(query)
                    MessageBox.Show("Xoá thành công", "Thông báo")
                    HangSanXuat()  'Load lại dữ liệu
                    txtMaHangSX.Clear()
                    txtTenHangSX.Clear()
                    txtDiaChi.Clear()
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
                If txtMaHangSX.Text = "" Then
                    MsgBox("Nhập thiếu mã hãng SX")
                ElseIf txtTenHangSX.Text = "" Then
                    MsgBox("Nhập thiếu tên hãng SX")
                Else
                    query = "insert into HangSX values('" + txtMaHangSX.Text + "', N'" + txtTenHangSX.Text + "', N'" + txtDiaChi.Text + "')"

                    Kn.NonQuery(query)
                    MsgBox("Thêm thành công")
                    HangSanXuat()
                    txtMaHangSX.Clear()
                    txtTenHangSX.Clear()
                    txtDiaChi.Clear()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If (Kt = False) Then
            Try
                Dim LenhUpdate As String = "Update HangSX set TenHangSX = '" + txtTenHangSX.Text + "', DiaChi = '" + txtDiaChi.Text + "' where MaHangSX = '" + txtMaHangSX.Text + "' "
                Kn.NonQuery(LenhUpdate)
                MsgBox("Cập nhật thành công")
                HangSanXuat()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        Kn.DongKetNoi()
    End Sub
End Class