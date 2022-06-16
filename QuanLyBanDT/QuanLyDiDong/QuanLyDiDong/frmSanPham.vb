Imports System.Data.SqlClient
Public Class frmSanPham
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
        txtTenSP.Enabled = b
        txtDonGia.Enabled = b
        txtRom.Enabled = b
        txtSoLuong.Enabled = b
        txtThoiGianBH.Enabled = b
        txtXuatXu.Enabled = b
        cboRam.Enabled = b
        txtMaSanPham.Enabled = b
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Kt = True
        SetControl(False)
        txtMaSanPham.Clear()
        txtMaSanPham.Clear()
        txtDonGia.Clear()
        txtRom.Clear()
        txtSoLuong.Clear()
        txtTenSP.Clear()
        txtThoiGianBH.Clear()
        txtXuatXu.Clear()
        cboRam.Text = ""
        SetLock(True)
        txtMaSanPham.Text = "Auto"
        txtMaSanPham.Enabled = False

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaSanPham.Text = "" Then
            MessageBox.Show("Bạn chưa chọn bản ghi cần sửa")
            Exit Sub
        End If
        Kt = False
        SetControl(False)
        SetLock(True)
        txtMaSanPham.Enabled = False
    End Sub


    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Kn.KetNoi()
        Try
            If (Kt = True) Then
                If cboTenHSX.Text = "" Or cboTenHSX.Text = "None" Then
                    MessageBox.Show("Nhập thiếu hãng sản xuất", "Thông báo")
                ElseIf txtTenSP.Text = "" Or txtDonGia.Text = "" Or txtRom.Text = "" Or cboRam.Text = "" Or txtSoLuong.Text = "" Or txtXuatXu.Text = "" Or txtThoiGianBH.Text = "" Then
                    MessageBox.Show("Nhập thiếu thông tin", "Thông báo")
                Else
                    Dim TenHSX As String = cboTenHSX.Text
                    Dim Lenh As String = "select MaHangSX from HangSX where TenHangSX = N'" + cboTenHSX.Text + "'"
                    Cmd = New SqlCommand(Lenh, Kn.Conn)
                    Reader = Cmd.ExecuteReader()
                    If Reader.Read Then
                        Dim MaHSX As String = Reader.GetString(0)
                        Dim LenhInsert As String = "insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'" + txtTenSP.Text + "', '" + MaHSX + "', " + txtDonGia.Text + " , '" + cboRam.Text + "', '" + txtRom.Text + "', " + txtSoLuong.Text + " , N'" + txtXuatXu.Text + "', '" + txtThoiGianBH.Text + "')"
                        Reader.Close()
                        Kn.NonQuery(LenhInsert)
                        MessageBox.Show("Thêm thành công", "Thông báo")
                        SanPham() ' Load lại dữ liệu
                        txtMaSanPham.Clear()
                        txtDonGia.Clear()
                        txtRom.Clear()
                        txtSoLuong.Clear()
                        txtTenSP.Clear()
                        txtThoiGianBH.Clear()
                        txtXuatXu.Clear()
                        cboRam.Text = ""
                    Else
                        MessageBox.Show("Tên hãng sản xuất không có trong hệ thống", "Thông báo")

                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If (Kt = False) Then
            Try
                Dim TenHSX As String = cboTenHSX.Text
                Dim Lenh As String = "select MaHangSX from HangSX where TenHangSX = N'" + cboTenHSX.Text + "'"
                Cmd = New SqlCommand(Lenh, Kn.Conn)
                Reader = Cmd.ExecuteReader()
                If Reader.Read Then
                    Dim MaHSX As String = Reader.GetString(0)
                    Reader.Close()
                    Dim LenhUpdate As String = "Update SanPham set MaHangSX = '" + MaHSX + "', TenSP = '" + txtTenSP.Text + "', DonGia = '" + txtDonGia.Text + "', Ram = '" + cboRam.Text + "', Rom = '" + txtRom.Text + "', SoLuong = '" + txtSoLuong.Text + "', XuatXu = '" + txtXuatXu.Text + "', ThoiGianBH = '" + txtThoiGianBH.Text + "' where MaSP = '" + txtMaSanPham.Text + "'"
                    Kn.NonQuery(LenhUpdate)
                    MessageBox.Show("Cập nhật thành công", "Thông báo")
                    SanPham() 'LoadLoaiDuLieu


                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Kn.DongKetNoi()
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        SetControl(True)
        SetLock(False)
        txtMaSanPham.Clear()
        txtDonGia.Clear()
        txtRom.Clear()
        txtSoLuong.Clear()
        txtTenSP.Clear()
        txtThoiGianBH.Clear()
        txtXuatXu.Clear()
        cboRam.Text = ""
    End Sub

    Public Sub CanChinh()
        'Thay đổi độ rộng của cột
        dgvSanPham.Columns(0).Width = 120
        dgvSanPham.Columns(1).Width = 150
        dgvSanPham.Columns(2).Width = 100
        dgvSanPham.Columns(3).Width = 100
        dgvSanPham.Columns(4).Width = 60
        dgvSanPham.Columns(5).Width = 70
        dgvSanPham.Columns(6).Width = 50
        dgvSanPham.Columns(7).Width = 70
        dgvSanPham.Columns(8).Width = 80

    End Sub

    Private Sub SanPham()
        Try
            Dim Query As String = "select MaSP as N'Mã sản phẩm', TenSP as N'Tên sản phẩm', MaHangSX as N'Mã hãng SX', DonGia as N'Đơn giá', Ram, Rom, SoLuong as N'Số lượng', XuatXu as N'Xuất xứ', ThoiGianBH as N'Thời gian BH' from SanPham"
            dgvSanPham.DataSource = Kn.DoDuLieu(Query) 'Đổ dữ liệu vào bảng
            CanChinh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TenHangSX()
        Kn.KetNoi()
        Try
            Query = "select TenHangSX from HangSX"
            Cmd = New SqlCommand(Query, Kn.Conn)
            Reader = Cmd.ExecuteReader()

            While Reader.Read
                cboTenHSX.Items.Add(Reader.GetString(0))
            End While
            Reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Kn.DongKetNoi()
    End Sub

    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kn.KetNoi()
        SanPham()
        TenHangSX()
        cboTenHSX.Items.Insert(0, "None")
        cboRam.Items.Add("3G")
        cboRam.Items.Add("4G")
        cboRam.Items.Add("6G")
        cboRam.Items.Add("8G")
        cboRam.Items.Add("12G")
        SetLock(False)
        SetControl(True)
        Kn.DongKetNoi()
    End Sub


    Private Sub cboTenHSX_Leave(sender As Object, e As EventArgs) Handles cboTenHSX.Leave
        Kn.KetNoi()
        Try
            If cboTenHSX.Text = "" Then
                SanPham()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Kn.DongKetNoi()
    End Sub

    Private Sub dgvSanPham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellContentClick
        txtMaSanPham.Text = dgvSanPham.CurrentRow.Cells(0).Value.ToString()
        txtTenSP.Text = dgvSanPham.CurrentRow.Cells(1).Value.ToString()
        txtDonGia.Text = dgvSanPham.CurrentRow.Cells(3).Value.ToString()
        cboRam.Text = dgvSanPham.CurrentRow.Cells(4).Value.ToString()
        txtRom.Text = dgvSanPham.CurrentRow.Cells(5).Value.ToString()
        txtSoLuong.Text = dgvSanPham.CurrentRow.Cells(6).Value.ToString()
        txtXuatXu.Text = dgvSanPham.CurrentRow.Cells(7).Value.ToString()
        txtThoiGianBH.Text = dgvSanPham.CurrentRow.Cells(8).Value.ToString()
        Kn.KetNoi()
        Try
            Dim Lenh As String = dgvSanPham.CurrentRow.Cells(2).Value.ToString()
            Reader.Close()
            Dim Query As String = "Select TenHangSX from HangSX where MaHangSX = '" + Lenh + "'"
            Cmd = New SqlCommand(Query, Kn.Conn)
            Reader = Cmd.ExecuteReader
            If Reader.Read Then
                cboTenHSX.Text = Reader.GetString(0)

            End If
            Reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Kn.DongKetNoi()


    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Try
            Kn.KetNoi()
            Reader.Close()
            txtMaSanPham.Clear()
            txtDonGia.Clear()
            txtRom.Clear()
            txtSoLuong.Clear()
            txtTenSP.Clear()
            txtThoiGianBH.Clear()
            txtXuatXu.Clear()
            cboRam.Text = ""
            Query = "select MaSP as N'Mã sản phẩm', TenSP as N'Tên sản phẩm', SP.MaHangSX as N'Mã hãng SX', DonGia as N'Đơn giá', Ram, Rom, SoLuong as N'Số lượng', XuatXu as N'Xuất xứ', ThoiGianBH as N'Thời gian BH' from SanPham SP inner join HangSX SX on SP.MaHangSX = SX.MaHangSX 
    where TenHangSX = N'" + cboTenHSX.Text + "'"
            If cboTenHSX.Text = "None" Then
                txtMaSanPham.Clear()
                txtDonGia.Clear()
                txtRom.Clear()
                txtSoLuong.Clear()
                txtTenSP.Clear()
                txtThoiGianBH.Clear()
                txtXuatXu.Clear()
                cboRam.Text = ""

                SanPham()
            Else
                dgvSanPham.DataSource = Kn.DoDuLieu(Query)
                CanChinh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Kn.DongKetNoi()
    End Sub

    Private Sub txtSoLuong_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoLuong.KeyPress
        If Asc(e.KeyChar) <> 8 Then  ' Chỉ được nhâp số trên bàn phím
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtThoiGianBH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtThoiGianBH.KeyPress
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

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Kn.KetNoi()
        Try
            Dim Lenh As String = "Select * from SanPham where MaSP = '" + txtMaSanPham.Text + "'"
            Cmd = New SqlCommand(Lenh, Kn.Conn)
            Reader = Cmd.ExecuteReader

            If txtMaSanPham.Text = "" Then
                MessageBox.Show("Bạn chưa chọn sản phẩm cần xoá", "Thông báo")
            ElseIf Reader.Read Then
                Query = "Delete from SanPham where MaSP = '" + txtMaSanPham.Text + "'"
                If MessageBox.Show("Bạn có chắc chắn muốn xoá", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    Reader.Close()
                    Kn.NonQuery(Query)
                    MessageBox.Show("Xoá thành công", "Thông báo")
                    SanPham()  'Load lại dữ liệu
                    txtMaSanPham.Clear()
                    txtDonGia.Clear()
                    txtRom.Clear()
                    txtSoLuong.Clear()
                    txtTenSP.Clear()
                    txtThoiGianBH.Clear()
                    txtXuatXu.Clear()
                    cboRam.Text = ""
                End If
            Else
                MessageBox.Show("Mã sản phẩm không có trong hệ thống ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Kn.DongKetNoi()
    End Sub
End Class