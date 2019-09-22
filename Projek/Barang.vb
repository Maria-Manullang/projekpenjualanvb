Imports MySql.Data.MySqlClient
Public Class Barang
    Sub tampilbarang()
        Call koneksi()
        da = New MySqlDataAdapter("select kode_barang, nama_barang, harga from tb_barang", conn)
        ds = New DataSet
        da.Fill(ds, "tb_barang")
        DataGridView1.DataSource = ds.Tables("tb_barang")
    End Sub
    Sub aturDGV()
        Try
            DataGridView1.Columns(0).Width = 70
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 100

            DataGridView1.Columns(0).HeaderText = "Kode Barang"
            DataGridView1.Columns(1).HeaderText = "Nama Barang"
            DataGridView1.Columns(2).HeaderText = "Harga"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilbarang()
        Call aturDGV()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Txtkode.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Txtharga.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub Btntamah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btntambah.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into tb_barang values ('" & Txtkode.Text & "','" & Txtnama.Text & "', '" & Txtharga.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Barang Berhasil Ditambahkan", MsgBoxStyle.Information, "Sukses")
        Catch ex As Exception
            MsgBox("Data Barang Tidak Berhasil Ditambahkan, Kode barang sudah ada", MsgBoxStyle.Critical, "Gagal")
        End Try
        Call tampilbarang()
        Call aturDGV()
    End Sub

    Private Sub Btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnubah.Click
        Call koneksi()
        Try
            Dim str As String
            str = "update tb_barang set nama_barang = '" & Txtnama.Text & "',harga = '" & Txtharga.Text & "' where kode_barang = '" & Txtkode.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Barang Berhasil Diubah", MsgBoxStyle.Information, "Sukses")
        Catch ex As Exception
            MsgBox("Data Barang Tidak Berhasil Diubah, Kode barang sudah ada", MsgBoxStyle.Critical, "Gagal")
        End Try
        Call aturDGV()
        Call tampilbarang()
    End Sub

    Private Sub Btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnhapus.Click
        Call koneksi()
        Try
            Dim str As String
            str = "delete from tb_barang where kode_barang = '" & Txtkode.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Barang Berhasil Dihapus.")
        Catch ex As Exception
            MessageBox.Show("Data Barang Gagal Dihapus.")
        End Try
        Call aturDGV()
        Call tampilbarang()
    End Sub

    Private Sub Btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnkeluar.Click
        Me.Close()
        menuutama.Show()
    End Sub
End Class