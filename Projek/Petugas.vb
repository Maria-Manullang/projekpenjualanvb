Imports MySql.Data.MySqlClient
Public Class PETUGAS
    Sub tampilpetugas()
        Call koneksi()
        da = New MySqlDataAdapter("select kode_petugas,nama_petugas,alamat_petugas,Tanggal_lahir from tb_petugas", conn)
        ds = New DataSet
        da.Fill(ds, "tb_petugas")
        DataGridView1.DataSource = ds.Tables("tb_petugas")
    End Sub
    Sub aturDGV()
        Try
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 100

            DataGridView1.Columns(0).HeaderText = "Kode Petugas"
            DataGridView1.Columns(1).HeaderText = "Nama Petugas"
            DataGridView1.Columns(2).HeaderText = "Alamat"
            DataGridView1.Columns(3).HeaderText = "Tanggal Lahir"
        Catch ex As Exception
        End Try

    End Sub

    Private Sub PETUGAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilpetugas()
        Call aturDGV()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Txtkode.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Txtalamat.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        DateTimePicker1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub Btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btntambah.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into tb_petugas values ('" & Txtkode.Text & "','" & Txtnama.Text & "', '" & Txtalamat.Text & "', '" & DateTimePicker1.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Petugas Berhasil Ditambahkan", MsgBoxStyle.Information, "Sukses")
        Catch ex As Exception
            MsgBox("Data Barang Tidak Berhasil Ditambahkan, Kode barang sudah ada", MsgBoxStyle.Critical, "Gagal")
        End Try
        Call tampilpetugas()
        Call aturDGV()
    End Sub

    Private Sub Btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnubah.Click
        Call koneksi()
        Try
            Dim str As String
            str = "update tb_petugas set nama_petugas = '" & Txtnama.Text & "',alamat_petugas = '" & Txtalamat.Text & "',Tanggal_lahir = '" & DateTimePicker1.Text & "' where kode_petugas = '" & Txtkode.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Petugas Berhasil Diubah", MsgBoxStyle.Information, "Sukses")
        Catch ex As Exception
            MsgBox("Data Petugas Tidak Berhasil Diubah, Kode pelanggan sudah ada", MsgBoxStyle.Critical, "Gagal")
        End Try
        Call aturDGV()
        Call tampilpetugas()
    End Sub

    Private Sub Btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnhapus.Click
        Call koneksi()
        Try
            Dim str As String
            str = "delete from tb_petugas where kode_petugas = '" & Txtkode.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Petugas Berhasil Dihapus.")
        Catch ex As Exception
            MessageBox.Show("Data Petugas Gagal Dihapus.")
        End Try
        Call aturDGV()
        Call tampilpetugas()
    End Sub

    Private Sub Btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnkeluar.Click
        Me.Close()
        menuutama.Show()
    End Sub
End Class