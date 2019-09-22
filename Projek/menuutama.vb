Public Class menuutama

    Private Sub BARANGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BARANGToolStripMenuItem.Click
        Barang.Show()

    End Sub

    Private Sub PELANGGANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PELANGGANToolStripMenuItem.Click
        Pelanggan.Show()

    End Sub

    Private Sub PETUGASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PETUGASToolStripMenuItem.Click
        PETUGAS.Show()
    End Sub

    Private Sub PENJUALANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENJUALANToolStripMenuItem.Click
        Penjualan.Show()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINToolStripMenuItem.Click
        login.Show()
        If LOGINToolStripMenuItem.Text = "LOGOUT" Then
            login.Close()
            Dim pesantutup As String
            pesantutup = MsgBox("Are you sure?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "KONFIRMASI")
            If pesantutup = vbYes Then
                Me.Show()
            Else
                Exit Sub
            End If
            BARANGToolStripMenuItem.Enabled = False
            PELANGGANToolStripMenuItem.Enabled = False
            PETUGASToolStripMenuItem.Enabled = False
            PENJUALANToolStripMenuItem.Enabled = False
            PEMBELIANToolStripMenuItem.Enabled = False
            LOGINToolStripMenuItem.Text = "LOGIN"
        End If
    End Sub

    Private Sub FILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FILEToolStripMenuItem.Click

    End Sub
End Class