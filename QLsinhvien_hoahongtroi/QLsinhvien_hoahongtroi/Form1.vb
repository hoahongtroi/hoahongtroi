Imports System.Data
Imports System.Data.SqlClient
Public Class frmsinhvien
    Private con As SqlConnection
    Private Sub ketnoi()
        Dim cn As String = "Data Source=PC26;Initial Catalog=QuanLySinhVien;Integrated Security=True"
        Try
            con = New SqlConnection(cn)
            con.Open()
            MessageBox.Show("Kết nối thành công ! ahihi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                            )
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning
                            )
        End Try
    End Sub
    Private Sub lblgioitinh_Click(sender As Object, e As EventArgs) Handles lblgioitinh.Click

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketnoi()
        Dim dt As New DataTable
        dt = LayDulieu()
        DataGridView1.DataSource = dt
        txtmasv.DataBindings.Clear()
        txttensv.DataBindings.Clear()
        txtdiachi.DataBindings.Clear()
        txtgioitinh.DataBindings.Clear()
        txtsdt.DataBindings.Clear()
        dtpngaysinh.DataBindings.Clear()
        txtmalop.DataBindings.Clear()
        txtmota.DataBindings.Clear()

        txtmasv.DataBindings.Add("text", dt, "MSSV")
        txttensv.DataBindings.Add("text", dt, "TenSV")
        txtdiachi.DataBindings.Add("text", dt, "DiaChi")
        txtgioitinh.DataBindings.Add("text", dt, "GioiTinh")
        txtsdt.DataBindings.Add("text", dt, "SDT")
        dtpngaysinh.DataBindings.Add("text", dt, "NgaySinh")
        txtmalop.DataBindings.Add("text", dt, "MALOP")
        txtmota.DataBindings.Add("text", dt, "Mota")
    End Sub
    Public Function LayDulieu() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select * from TB_SinhVien", con)
        da.Fill(dt)
        Return dt
    End Function

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim sql As String = "INSERT INTO TB_SinhVien (MSSV, TenSV, DiaChi, GioiTinh, SDT, NgaySinh, MALOP, MoTa) VALUES('" & txtmasv.Text & "',N'" & txttensv.Text & "',N'" & txtdiachi.Text & "','" & txtgioitinh.Text & "','" & txtsdt.Text & "','" & dtpngaysinh.Text & "','" & txtmalop.Text & "','" & txtmota.Text & "')"
        Dim cmd As New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        'Load du lieu
        Dim dt As New DataTable
        dt = LayDulieu()
        DataGridView1.DataSource = dt
        txtmasv.DataBindings.Clear()
        txttensv.DataBindings.Clear()
        txtdiachi.DataBindings.Clear()
        txtgioitinh.DataBindings.Clear()
        txtsdt.DataBindings.Clear()
        dtpngaysinh.DataBindings.Clear()
        txtmalop.DataBindings.Clear()
        txtmota.DataBindings.Clear()
        txtmasv.DataBindings.Add("text", dt, "MSSV")
        txttensv.DataBindings.Add("text", dt, "TenSV")
        txtdiachi.DataBindings.Add("text", dt, "DiaChi")
        txtgioitinh.DataBindings.Add("text", dt, "GioiTinh")
        txtsdt.DataBindings.Add("text", dt, "SDT")
        dtpngaysinh.DataBindings.Add("text", dt, "NgaySinh")
        txtmalop.DataBindings.Add("text", dt, "MALOP")
        txtmota.DataBindings.Add("text", dt, "MoTa")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim masv As String = txtmasv.Text
        Dim sql As String = "delete from TB_SinhVien where MSSV='" & masv & "'"
        Dim cmd As New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        'Load du lieu
        Dim dt As New DataTable
        dt = LayDulieu()
        DataGridView1.DataSource = dt
        txtmasv.DataBindings.Clear()
        txttensv.DataBindings.Clear()
        txtdiachi.DataBindings.Clear()
        txtgioitinh.DataBindings.Clear()
        txtsdt.DataBindings.Clear()
        dtpngaysinh.DataBindings.Clear()
        txtmalop.DataBindings.Clear()
        txtmota.DataBindings.Clear()
        txtmasv.DataBindings.Add("text", dt, "MSSV")
        txttensv.DataBindings.Add("text", dt, "TenSV")
        txtdiachi.DataBindings.Add("text", dt, "DiaChi")
        txtgioitinh.DataBindings.Add("text", dt, "GioiTinh")
        txtsdt.DataBindings.Add("text", dt, "SDT")
        dtpngaysinh.DataBindings.Add("text", dt, "NgaySinh")
        txtmalop.DataBindings.Add("text", dt, "MALOP")
        txtmota.DataBindings.Add("text", dt, "MoTa")
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim masv As String = txtmasv.Text
        Dim tensv As String = txttensv.Text
        Dim diachi As String = txtdiachi.Text
        Dim gioitinh As String = txtgioitinh.Text
        Dim sdt As String = txtsdt.Text
        Dim ngaysinh As String = dtpngaysinh.Text
        Dim malop As String = txtmalop.Text
        Dim mota As String = txtmota.Text
        Dim sql As String = "update TB_SinhVien set TenSV=N'" & tensv & "', DiaChi=N'" & diachi & "', SDT='" & sdt & "', NgaySinh='" & ngaysinh & "', MALOP='" & malop & "', MoTa='" & mota & "' where MSSV='" & masv & "'"
        Dim cmd As New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        dt = LayDulieu()
        DataGridView1.DataSource = dt
        txtmasv.DataBindings.Clear()
        txttensv.DataBindings.Clear()
        txtdiachi.DataBindings.Clear()
        txtgioitinh.DataBindings.Clear()
        txtsdt.DataBindings.Clear()
        dtpngaysinh.DataBindings.Clear()
        txtmalop.DataBindings.Clear()
        txtmota.DataBindings.Clear()
        txtmasv.DataBindings.Add("text", dt, "MSSV")
        txttensv.DataBindings.Add("text", dt, "TenSV")
        txtdiachi.DataBindings.Add("text", dt, "DiaChi")
        txtgioitinh.DataBindings.Add("text", dt, "GioiTinh")
        txtsdt.DataBindings.Add("text", dt, "SDT")
        dtpngaysinh.DataBindings.Add("text", dt, "NgaySinh")
        txtmalop.DataBindings.Add("text", dt, "MALOP")
        txtmota.DataBindings.Add("text", dt, "MoTa")
    End Sub

    Private Sub btntimkiem_Click(sender As Object, e As EventArgs) Handles btntimkiem.Click
        Dim sql As String = "select * from TB_SinhVien where diachi like  '%" & txttimkiem.Text & "%'"

        'load du lieu
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand(sql, con)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        txtmasv.DataBindings.Clear()
        txttensv.DataBindings.Clear()
        txtdiachi.DataBindings.Clear()
        txtgioitinh.DataBindings.Clear()
        txtsdt.DataBindings.Clear()
        dtpngaysinh.DataBindings.Clear()
        txtmalop.DataBindings.Clear()
        txtmota.DataBindings.Clear()
        txtmasv.DataBindings.Add("text", dt, "MSSV")
        txttensv.DataBindings.Add("text", dt, "TenSV")
        txtdiachi.DataBindings.Add("text", dt, "DiaChi")
        txtgioitinh.DataBindings.Add("text", dt, "GioiTinh")
        txtsdt.DataBindings.Add("text", dt, "SDT")
        dtpngaysinh.DataBindings.Add("text", dt, "NgaySinh")
        txtmalop.DataBindings.Add("text", dt, "MALOP")
        txtmota.DataBindings.Add("text", dt, "MoTa")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txttimkiem.TextChanged

    End Sub
End Class

