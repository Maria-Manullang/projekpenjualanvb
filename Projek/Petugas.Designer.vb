<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PETUGAS
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
        Me.Btntambah = New System.Windows.Forms.Button
        Me.Btnubah = New System.Windows.Forms.Button
        Me.Btnhapus = New System.Windows.Forms.Button
        Me.Btnkeluar = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Txtkode = New System.Windows.Forms.TextBox
        Me.Txtnama = New System.Windows.Forms.TextBox
        Me.Txtalamat = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PETUGAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Petugas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Petugas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Btntambah
        '
        Me.Btntambah.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btntambah.Location = New System.Drawing.Point(109, 243)
        Me.Btntambah.Name = "Btntambah"
        Me.Btntambah.Size = New System.Drawing.Size(75, 23)
        Me.Btntambah.TabIndex = 4
        Me.Btntambah.Text = "Tambah"
        Me.Btntambah.UseVisualStyleBackColor = False
        '
        'Btnubah
        '
        Me.Btnubah.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnubah.Location = New System.Drawing.Point(197, 243)
        Me.Btnubah.Name = "Btnubah"
        Me.Btnubah.Size = New System.Drawing.Size(75, 23)
        Me.Btnubah.TabIndex = 5
        Me.Btnubah.Text = "Ubah"
        Me.Btnubah.UseVisualStyleBackColor = False
        '
        'Btnhapus
        '
        Me.Btnhapus.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnhapus.Location = New System.Drawing.Point(289, 243)
        Me.Btnhapus.Name = "Btnhapus"
        Me.Btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.Btnhapus.TabIndex = 6
        Me.Btnhapus.Text = "Hapus"
        Me.Btnhapus.UseVisualStyleBackColor = False
        '
        'Btnkeluar
        '
        Me.Btnkeluar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnkeluar.Location = New System.Drawing.Point(370, 243)
        Me.Btnkeluar.Name = "Btnkeluar"
        Me.Btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.Btnkeluar.TabIndex = 7
        Me.Btnkeluar.Text = "Keluar"
        Me.Btnkeluar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(39, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(477, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'Txtkode
        '
        Me.Txtkode.Location = New System.Drawing.Point(241, 69)
        Me.Txtkode.Name = "Txtkode"
        Me.Txtkode.Size = New System.Drawing.Size(203, 20)
        Me.Txtkode.TabIndex = 9
        '
        'Txtnama
        '
        Me.Txtnama.Location = New System.Drawing.Point(241, 105)
        Me.Txtnama.Name = "Txtnama"
        Me.Txtnama.Size = New System.Drawing.Size(204, 20)
        Me.Txtnama.TabIndex = 10
        '
        'Txtalamat
        '
        Me.Txtalamat.Location = New System.Drawing.Point(241, 140)
        Me.Txtalamat.Multiline = True
        Me.Txtalamat.Name = "Txtalamat"
        Me.Txtalamat.Size = New System.Drawing.Size(203, 44)
        Me.Txtalamat.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tanggal Lahir"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(241, 197)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'PETUGAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(545, 446)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txtalamat)
        Me.Controls.Add(Me.Txtnama)
        Me.Controls.Add(Me.Txtkode)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btnkeluar)
        Me.Controls.Add(Me.Btnhapus)
        Me.Controls.Add(Me.Btnubah)
        Me.Controls.Add(Me.Btntambah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PETUGAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PETUGAS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Btntambah As System.Windows.Forms.Button
    Friend WithEvents Btnubah As System.Windows.Forms.Button
    Friend WithEvents Btnhapus As System.Windows.Forms.Button
    Friend WithEvents Btnkeluar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
