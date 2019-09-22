<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txtkodepenjualan = New System.Windows.Forms.TextBox
        Me.Txtjumlah = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cbsbarang = New System.Windows.Forms.ComboBox
        Me.Cbxpetugas = New System.Windows.Forms.ComboBox
        Me.Cbxpelanggan = New System.Windows.Forms.ComboBox
        Me.Btnproses = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txttotal = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Txtnamabarang = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Txthargabarang = New System.Windows.Forms.TextBox
        Me.Btnbatal = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Txtnamapetugas = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Txtnamapelanggan = New System.Windows.Forms.TextBox
        Me.Btnkeluar = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENJUALAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Penjualan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kode Petugas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kode Pelanggan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah"
        '
        'Txtkodepenjualan
        '
        Me.Txtkodepenjualan.Location = New System.Drawing.Point(201, 56)
        Me.Txtkodepenjualan.Name = "Txtkodepenjualan"
        Me.Txtkodepenjualan.Size = New System.Drawing.Size(121, 20)
        Me.Txtkodepenjualan.TabIndex = 6
        '
        'Txtjumlah
        '
        Me.Txtjumlah.Location = New System.Drawing.Point(201, 278)
        Me.Txtjumlah.Name = "Txtjumlah"
        Me.Txtjumlah.Size = New System.Drawing.Size(121, 20)
        Me.Txtjumlah.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 389)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(495, 173)
        Me.DataGridView1.TabIndex = 11
        '
        'cbsbarang
        '
        Me.cbsbarang.FormattingEnabled = True
        Me.cbsbarang.Location = New System.Drawing.Point(201, 82)
        Me.cbsbarang.Name = "cbsbarang"
        Me.cbsbarang.Size = New System.Drawing.Size(121, 21)
        Me.cbsbarang.TabIndex = 12
        '
        'Cbxpetugas
        '
        Me.Cbxpetugas.FormattingEnabled = True
        Me.Cbxpetugas.Location = New System.Drawing.Point(201, 166)
        Me.Cbxpetugas.Name = "Cbxpetugas"
        Me.Cbxpetugas.Size = New System.Drawing.Size(121, 21)
        Me.Cbxpetugas.TabIndex = 13
        '
        'Cbxpelanggan
        '
        Me.Cbxpelanggan.FormattingEnabled = True
        Me.Cbxpelanggan.Location = New System.Drawing.Point(201, 224)
        Me.Cbxpelanggan.Name = "Cbxpelanggan"
        Me.Cbxpelanggan.Size = New System.Drawing.Size(121, 21)
        Me.Cbxpelanggan.TabIndex = 14
        '
        'Btnproses
        '
        Me.Btnproses.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnproses.Location = New System.Drawing.Point(201, 341)
        Me.Btnproses.Name = "Btnproses"
        Me.Btnproses.Size = New System.Drawing.Size(75, 22)
        Me.Btnproses.TabIndex = 15
        Me.Btnproses.Text = "Proses"
        Me.Btnproses.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(71, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Total"
        '
        'Txttotal
        '
        Me.Txttotal.Location = New System.Drawing.Point(201, 304)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.Size = New System.Drawing.Size(192, 20)
        Me.Txttotal.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Nama Barang"
        '
        'Txtnamabarang
        '
        Me.Txtnamabarang.Location = New System.Drawing.Point(201, 110)
        Me.Txtnamabarang.Name = "Txtnamabarang"
        Me.Txtnamabarang.Size = New System.Drawing.Size(192, 20)
        Me.Txtnamabarang.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(71, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Harga"
        '
        'Txthargabarang
        '
        Me.Txthargabarang.Location = New System.Drawing.Point(201, 140)
        Me.Txthargabarang.Name = "Txthargabarang"
        Me.Txthargabarang.Size = New System.Drawing.Size(192, 20)
        Me.Txthargabarang.TabIndex = 21
        '
        'Btnbatal
        '
        Me.Btnbatal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnbatal.Location = New System.Drawing.Point(292, 341)
        Me.Btnbatal.Name = "Btnbatal"
        Me.Btnbatal.Size = New System.Drawing.Size(75, 22)
        Me.Btnbatal.TabIndex = 22
        Me.Btnbatal.Text = "Batal"
        Me.Btnbatal.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Nama Petugas"
        '
        'Txtnamapetugas
        '
        Me.Txtnamapetugas.Location = New System.Drawing.Point(201, 198)
        Me.Txtnamapetugas.Name = "Txtnamapetugas"
        Me.Txtnamapetugas.Size = New System.Drawing.Size(192, 20)
        Me.Txtnamapetugas.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(71, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Nama Pelanggan"
        '
        'Txtnamapelanggan
        '
        Me.Txtnamapelanggan.Location = New System.Drawing.Point(201, 252)
        Me.Txtnamapelanggan.Name = "Txtnamapelanggan"
        Me.Txtnamapelanggan.Size = New System.Drawing.Size(192, 20)
        Me.Txtnamapelanggan.TabIndex = 26
        '
        'Btnkeluar
        '
        Me.Btnkeluar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnkeluar.Location = New System.Drawing.Point(382, 341)
        Me.Btnkeluar.Name = "Btnkeluar"
        Me.Btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.Btnkeluar.TabIndex = 27
        Me.Btnkeluar.Text = "Keluar"
        Me.Btnkeluar.UseVisualStyleBackColor = False
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(546, 551)
        Me.Controls.Add(Me.Btnkeluar)
        Me.Controls.Add(Me.Txtnamapelanggan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Txtnamapetugas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Btnbatal)
        Me.Controls.Add(Me.Txthargabarang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txtnamabarang)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txttotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btnproses)
        Me.Controls.Add(Me.Cbxpelanggan)
        Me.Controls.Add(Me.Cbxpetugas)
        Me.Controls.Add(Me.cbsbarang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Txtjumlah)
        Me.Controls.Add(Me.Txtkodepenjualan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txtkodepenjualan As System.Windows.Forms.TextBox
    Friend WithEvents Txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbsbarang As System.Windows.Forms.ComboBox
    Friend WithEvents Cbxpetugas As System.Windows.Forms.ComboBox
    Friend WithEvents Cbxpelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents Btnproses As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txtnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txthargabarang As System.Windows.Forms.TextBox
    Friend WithEvents Btnbatal As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txtnamapetugas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txtnamapelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Btnkeluar As System.Windows.Forms.Button
End Class
