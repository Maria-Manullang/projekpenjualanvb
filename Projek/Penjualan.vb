Imports MySql.Data.MySqlClient
Public Class Penjualan
    Private Sub Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampildatacomboboxbarang()
        Call tampildatacomboboxpetugas()
        Call tampildatacomboboxpelanggan()
        Call tampilpenjualan()
        Call aturDGV()
    End Sub
    Sub tampilpenjualan()
        Call koneksi()
        da = New MySqlDataAdapter("select*from tb_penjualan", conn)
        ds = New DataSet
        da.Fill(ds, "tb_penjualan")
        DataGridView1.DataSource = ds.Tables("tb_penjualan")
        DataGridView1.ReadOnly = True
    End Sub
    
    Sub tampildatacomboboxbarang()
        Call koneksi()
        Dim str As String
        str = "select kode_barang from tb_barang "
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                cbsbarang.Items.Add(rd("kode_barang"))
            Loop
        Else
        End If
    End Sub

    Sub tampildatacomboboxpetugas()
        Call koneksi()
        Dim str As String
        str = "select kode_petugas from tb_petugas"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                Cbxpetugas.Items.Add(rd("kode_petugas"))
            Loop
        Else
        End If
    End Sub

    Sub tampildatacomboboxpelanggan()
        Call koneksi()
        Dim str As String
        str = "select kode_pelanggan from tb_pelanggan"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                Cbxpelanggan.Items.Add(rd("kode_pelanggan"))
            Loop
        Else
        End If
    End Sub

    Sub aturDGV()
        Try
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 100
            DataGridView1.Columns(5).Width = 100
            DataGridView1.Columns(6).Width = 100
            DataGridView1.Columns(7).Width = 100
            DataGridView1.Columns(8).Width = 100
            DataGridView1.Columns(9).Width = 100

            DataGridView1.Columns(0).HeaderText = "Kode Penjualan"
            DataGridView1.Columns(1).HeaderText = "Kode Barang"
            DataGridView1.Columns(2).HeaderText = "Nama Barang"
            DataGridView1.Columns(3).HeaderText = "Harga"
            DataGridView1.Columns(4).HeaderText = "Kode Petugas"
            DataGridView1.Columns(5).HeaderText = "Nama Petugas"
            DataGridView1.Columns(6).HeaderText = "Kode Pelanggan"
            DataGridView1.Columns(7).HeaderText = "Nama Pelanggan"
            DataGridView1.Columns(8).HeaderText = "Jumlah"
            DataGridView1.Columns(9).HeaderText = "Total"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnproses.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into tb_penjualan values ('" & Txtkodepenjualan.Text & "','" & cbsbarang.Text & "', '" & Txtnamabarang.Text & "', '" & Txthargabarang.Text & "','" & Cbxpetugas.Text & "','" & Txtnamapetugas.Text & "','" & Cbxpelanggan.Text & "','" & Txtnamapelanggan.Text & "','" & Txtjumlah.Text & "','" & Txttotal.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Penjualan Berhasil Ditambahkan", MsgBoxStyle.Information, "Sukses")
        Catch ex As Exception
            MsgBox("Data Penjualan Tidak Berhasil Ditambahkan", MsgBoxStyle.Critical, "Gagal")
        End Try
        Call tampildatacomboboxbarang()
        Call tampildatacomboboxpetugas()
        Call tampildatacomboboxpelanggan()
        Call tampilpenjualan()
        Call aturDGV()
    End Sub

    Private Sub ComboBoxbarang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbsbarang.SelectedIndexChanged
        Call koneksi()
        Dim str As String
        str = "select * from tb_barang where kode_barang='" & cbsbarang.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Txtnamabarang.Text = rd!nama_barang
            Txthargabarang.Text = rd!harga

        End If
    End Sub
    Private Sub Cbxpetugas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbxpetugas.SelectedIndexChanged
        Call koneksi()
        Dim str As String
        str = "select*from tb_petugas where kode_petugas='" & Cbxpetugas.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Txtnamapetugas.Text = rd!nama_petugas
        End If
    End Sub

    Private Sub Cbxpelanggan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbxpelanggan.SelectedIndexChanged
        Call koneksi()
        Dim str As String
        str = "select*from tb_pelanggan where kode_pelanggan='" & Cbxpelanggan.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Txtnamapelanggan.Text = rd!nama_pelanggan
        End If
    End Sub

    Private Sub Txtjumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtjumlah.TextChanged
        Txttotal.Text = Txthargabarang.Text * Txtjumlah.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbatal.Click
        Txtkodepenjualan.Clear()
        cbsbarang.Text = ""
        Txtnamabarang.Clear()
        Txthargabarang.Text = 0
        Cbxpetugas.Text = ""
        Cbxpelanggan.Text = ""
        Txttotal.Text = 0
        Txtnamapelanggan.Clear()
        Txtnamapetugas.Clear()
        Txtjumlah.Text = 0


    End Sub

    
    Private Sub Btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnkeluar.Click
        Me.Close()
        menuutama.Show()

    End Sub
End Class