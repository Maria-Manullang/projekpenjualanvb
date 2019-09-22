<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pelanggan
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Txtkode = New System.Windows.Forms.TextBox
        Me.Txtnama = New System.Windows.Forms.TextBox
        Me.Txtalamat = New System.Windows.Forms.TextBox
        Me.Txtnomor = New System.Windows.Forms.TextBox
        Me.Btntambah = New System.Windows.Forms.Button
        Me.Btnubah = New System.Windows.Forms.Button
        Me.Btnhapus = New System.Windows.Forms.Button
        Me.Btnkeluar = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA PELANGGAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pelanggan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nomor HP"
        '
        'Txtkode
        '
        Me.Txtkode.Location = New System.Drawing.Point(218, 61)
        Me.Txtkode.Name = "Txtkode"
        Me.Txtkode.Size = New System.Drawing.Size(202, 20)
        Me.Txtkode.TabIndex = 5
        '
        'Txtnama
        '
        Me.Txtnama.Location = New System.Drawing.Point(218, 88)
        Me.Txtnama.Name = "Txtnama"
        Me.Txtnama.Size = New System.Drawing.Size(202, 20)
        Me.Txtnama.TabIndex = 6
        '
        'Txtalamat
        '
        Me.Txtalamat.Location = New System.Drawing.Point(218, 115)
        Me.Txtalamat.Multiline = True
        Me.Txtalamat.Name = "Txtalamat"
        Me.Txtalamat.Size = New System.Drawing.Size(202, 39)
        Me.Txtalamat.TabIndex = 7
        '
        'Txtnomor
        '
        Me.Txtnomor.Location = New System.Drawing.Point(218, 160)
        Me.Txtnomor.Name = "Txtnomor"
        Me.Txtnomor.Size = New System.Drawing.Size(202, 20)
        Me.Txtnomor.TabIndex = 8
        '
        'Btntambah
        '
        Me.Btntambah.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btntambah.Location = New System.Drawing.Point(82, 187)
        Me.Btntambah.Name = "Btntambah"
        Me.Btntambah.Size = New System.Drawing.Size(75, 23)
        Me.Btntambah.TabIndex = 9
        Me.Btntambah.Text = "Tambah"
        Me.Btntambah.UseVisualStyleBackColor = False
        '
        'Btnubah
        '
        Me.Btnubah.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnubah.Location = New System.Drawing.Point(168, 186)
        Me.Btnubah.Name = "Btnubah"
        Me.Btnubah.Size = New System.Drawing.Size(75, 23)
        Me.Btnubah.TabIndex = 10
        Me.Btnubah.Text = "Ubah"
        Me.Btnubah.UseVisualStyleBackColor = False
        '
        'Btnhapus
        '
        Me.Btnhapus.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnhapus.Location = New System.Drawing.Point(250, 187)
        Me.Btnhapus.Name = "Btnhapus"
        Me.Btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.Btnhapus.TabIndex = 11
        Me.Btnhapus.Text = "Hapus"
        Me.Btnhapus.UseVisualStyleBackColor = False
        '
        'Btnkeluar
        '
        Me.Btnkeluar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnkeluar.Location = New System.Drawing.Point(345, 186)
        Me.Btnkeluar.Name = "Btnkeluar"
        Me.Btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.Btnkeluar.TabIndex = 12
        Me.Btnkeluar.Text = "Keluar"
        Me.Btnkeluar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 229)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(497, 183)
        Me.DataGridView1.TabIndex = 13
        '
        'Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(547, 424)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btnkeluar)
        Me.Controls.Add(Me.Btnhapus)
        Me.Controls.Add(Me.Btnubah)
        Me.Controls.Add(Me.Btntambah)
        Me.Controls.Add(Me.Txtnomor)
        Me.Controls.Add(Me.Txtalamat)
        Me.Controls.Add(Me.Txtnama)
        Me.Controls.Add(Me.Txtkode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pelanggan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Txtnomor As System.Windows.Forms.TextBox
    Friend WithEvents Btntambah As System.Windows.Forms.Button
    Friend WithEvents Btnubah As System.Windows.Forms.Button
    Friend WithEvents Btnhapus As System.Windows.Forms.Button
    Friend WithEvents Btnkeluar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
