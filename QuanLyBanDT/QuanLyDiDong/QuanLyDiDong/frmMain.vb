Public Class frmMain
    Private Form As Form
    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        frmSanPham.MdiParent = Me  ' Dùng để mở form muốn hiển thị
        frmSanPham.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        frmDangNhap.Show()
        frmDangNhap.txtTaiKhoan.Clear()
        frmDangNhap.txtMatKhau.Clear()
        frmDangNhap.txtTaiKhoan.Focus()
        Me.Hide()
    End Sub

    Private Sub ĐổiMậtKhẩuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐổiMậtKhẩuToolStripMenuItem.Click
        frmDoiMatKhau.MdiParent = Me
        frmDoiMatKhau.Show()
    End Sub

    Private Sub QuảnLýTàiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýTàiToolStripMenuItem.Click
        frmQuanLyTaiKhoan.MdiParent = Me
        frmQuanLyTaiKhoan.Show()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frmHangSanXuat.MdiParent = Me
        frmHangSanXuat.Show()
    End Sub

    Private Sub HoáĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoáĐơnToolStripMenuItem.Click
        frmHoaDon.MdiParent = Me
        frmHoaDon.Show()
    End Sub

    Private Sub ChiTiếtHoáĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHoáĐơnToolStripMenuItem.Click
        frmChiTietHoaDon.MdiParent = Me
        frmChiTietHoaDon.Show()
    End Sub

    Private Sub KháchHàngToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem1.Click
        frmKhachHang.MdiParent = Me
        frmKhachHang.Show()
    End Sub
End Class
