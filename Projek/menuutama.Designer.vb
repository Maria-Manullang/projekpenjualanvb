<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuutama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuutama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BARANGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PELANGGANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PETUGASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PENJUALANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PEMBELIANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.TRANSAKSIToolStripMenuItem, Me.LAPORANToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(719, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGINToolStripMenuItem, Me.BARANGToolStripMenuItem, Me.PELANGGANToolStripMenuItem, Me.PETUGASToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'BARANGToolStripMenuItem
        '
        Me.BARANGToolStripMenuItem.Enabled = False
        Me.BARANGToolStripMenuItem.Name = "BARANGToolStripMenuItem"
        Me.BARANGToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BARANGToolStripMenuItem.Text = "BARANG"
        '
        'PELANGGANToolStripMenuItem
        '
        Me.PELANGGANToolStripMenuItem.Enabled = False
        Me.PELANGGANToolStripMenuItem.Name = "PELANGGANToolStripMenuItem"
        Me.PELANGGANToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PELANGGANToolStripMenuItem.Text = "PELANGGAN"
        '
        'PETUGASToolStripMenuItem
        '
        Me.PETUGASToolStripMenuItem.Enabled = False
        Me.PETUGASToolStripMenuItem.Name = "PETUGASToolStripMenuItem"
        Me.PETUGASToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PETUGASToolStripMenuItem.Text = "PETUGAS"
        '
        'TRANSAKSIToolStripMenuItem
        '
        Me.TRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PENJUALANToolStripMenuItem, Me.PEMBELIANToolStripMenuItem})
        Me.TRANSAKSIToolStripMenuItem.Name = "TRANSAKSIToolStripMenuItem"
        Me.TRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.TRANSAKSIToolStripMenuItem.Text = "TRANSAKSI"
        '
        'PENJUALANToolStripMenuItem
        '
        Me.PENJUALANToolStripMenuItem.Enabled = False
        Me.PENJUALANToolStripMenuItem.Name = "PENJUALANToolStripMenuItem"
        Me.PENJUALANToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PENJUALANToolStripMenuItem.Text = "PENJUALAN"
        '
        'PEMBELIANToolStripMenuItem
        '
        Me.PEMBELIANToolStripMenuItem.Enabled = False
        Me.PEMBELIANToolStripMenuItem.Name = "PEMBELIANToolStripMenuItem"
        Me.PEMBELIANToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PEMBELIANToolStripMenuItem.Text = "PEMBELIAN"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'menuutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(719, 344)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menuutama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menuutama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BARANGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PETUGASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PELANGGANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSAKSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENJUALANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PEMBELIANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
