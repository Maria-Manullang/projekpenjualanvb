Imports MySql.Data.MySqlClient
Public Class Pelanggan
    Sub tampilpelanggan()
        Call koneksi()
        da = New MySqlDataAdapter("select kode_pelanggan, nama_pelanggan, alamat, nomor_hp from tb_pelanggan", conn)
        ds = New DataSet
        da.Fill(ds, "tb_pelanggan")
        DataGridView1.DataSource = ds.Tables("tb_pelanggan")
    End Sub
    Sub aturDGV()
        Try
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 100

            DataGridView1.Columns(0).HeaderText = "Kode Pelanggan"
            DataGridView1.Columns(1).HeaderText = "Nama Pelanggan"
            DataGridView1.Columns(2).HeaderText = "Alamat"
            DataGridView1.Columns(3).HeaderText = "Nomor HP"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Pelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilpelanggan()
        Call aturDGV()
    End Sub
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Txtkode.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Txtalamat.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Txtnomor.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub Btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btntambah.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into tb_pelanggan values ('" & Txtkode.Text & "','" & Txtnama.Text & "', '" & Txtalamat.Text & "', '" & Txtnomor.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Pelanggan Berhasil Ditambahkan", MsgBoxStyle.Information, "Sukses")
        Catch ex As Exception
            MsgBox("Data Barang Tidak Berhasil Ditambahkan, Kode barang sudah ada", MsgBoxStyle.Critical, "Gagal")
        End Try
        Call tampilpelanggan()
        Call aturDGV()
    End Sub

    Private Sub Btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnubah.Click
        Call koneksi()
        Try
            Dim str As String
            str = "update tb_pelanggan set nama_pelanggan = '" & Txtnama.Text & "',alamat = '" & Txtalamat.Text & "',nomor_HP = '" & Txtnomor.Text & "' where kode_pelanggan = '" & Txtkode.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Pelanggan Berhasil Diubah", MsgBoxStyle.Information, "Sukses")
        Catch ex As Exception
            MsgBox("Data Pelanggan Tidak Berhasil Diubah, Kode barang sudah ada", MsgBoxStyle.Critical, "Gagal")
        End Try
        Call aturDGV()
        Call tampilpelanggan()
    End Sub

    Private Sub Btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnhapus.Click
        Call koneksi()
        Try
            Dim str As String
            str = "delete from tb_pelanggan where kode_pelanggan = '" & Txtkode.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Pelanggan Berhasil Dihapus.")
        Catch ex As Exception
            MessageBox.Show("Data Pelanggan Gagal Dihapus.")
        End Try
        Call aturDGV()
        Call tampilpelanggan()
    End Sub

    Private Sub Btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnkeluar.Click
        Me.Close()
        menuutama.Show()
    End Sub

End Class