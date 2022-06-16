Imports System.Data.SqlClient

Public Class KetNoi
    Dim Ket_Noi As String = "Data Source=DESKTOP-HV6D350\VANH21SQLEXPRESS;Initial Catalog=QuanLyDienThoai;Integrated Security=True"
    Public Conn As New SqlConnection(Ket_Noi)
    Public Apdapter As SqlDataAdapter
    Public Cmd As SqlCommand

    Public Sub KetNoi()
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Public Function DoDuLieu(Lenh As String) As DataTable
        Dim data As New DataTable
        Apdapter = New SqlDataAdapter(Lenh, Conn)
        Apdapter.Fill(data)
        Return Data
    End Function
    Public Function NonQuery(lenh As String) As SqlCommand
        Cmd = New SqlCommand(lenh, Conn)
        Cmd.ExecuteNonQuery()
        Return Cmd
    End Function
    Public Sub DongKetNoi()
        Conn.Close()
    End Sub

End Class
