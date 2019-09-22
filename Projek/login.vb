Imports MySql.Data.MySqlClient
Public Class login

    Private Sub Cbshow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbshow.CheckedChanged
        If Cbshow.Checked = True Then
            Txtpass.PasswordChar = ""
        Else
            Txtpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        Call koneksi()
        Dim myAdapter As New MySqlDataAdapter
        Dim sqlQuery = "SELECT*FROM tb_login where username='" + Txtuser.Text + "'and password='" + Txtpass.Text + "'"
        Dim myCommand As New MySqlCommand
        myCommand.Connection = conn
        myCommand.CommandText = sqlQuery
        myAdapter.SelectCommand = myCommand
        Dim myData As MySqlDataReader
        myData = myCommand.ExecuteReader


        If Txtuser.Text = "" Then
            MsgBox("username belum diisi!! ", MsgBoxStyle.Exclamation, "Periksa Data")
        ElseIf Txtpass.Text = "" Then
            MsgBox("password belum diisi!! ", MsgBoxStyle.Exclamation, "Periksa Data")
        ElseIf myData.HasRows = 0 Then
            MsgBox("username atau password salah!! ", MsgBoxStyle.Critical, "Error Login")
        Else
            MsgBox("Login berhasil, Selamat datang " & Txtuser.Text & "!", MsgBoxStyle.Information, "Successfull Login")
            menuutama.Show()
            menuutama.PELANGGANToolStripMenuItem.Enabled = True
            menuutama.BARANGToolStripMenuItem.Enabled = True
            menuutama.PETUGASToolStripMenuItem.Enabled = True
            menuutama.BARANGToolStripMenuItem.Enabled = True
            menuutama.PENJUALANToolStripMenuItem.Enabled = True
            menuutama.PEMBELIANToolStripMenuItem.Enabled = True
            menuutama.LOGINToolStripMenuItem.Text = "LOGOUT"

            Me.Hide()
        End If


    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        Me.Close()
    End Sub
End Class
