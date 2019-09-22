<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txtuser = New System.Windows.Forms.TextBox
        Me.Txtpass = New System.Windows.Forms.TextBox
        Me.Btnlogin = New System.Windows.Forms.Button
        Me.Btncancel = New System.Windows.Forms.Button
        Me.Cbshow = New System.Windows.Forms.CheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Txtuser
        '
        Me.Txtuser.Location = New System.Drawing.Point(232, 46)
        Me.Txtuser.Name = "Txtuser"
        Me.Txtuser.Size = New System.Drawing.Size(169, 20)
        Me.Txtuser.TabIndex = 2
        '
        'Txtpass
        '
        Me.Txtpass.Location = New System.Drawing.Point(232, 88)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpass.Size = New System.Drawing.Size(169, 20)
        Me.Txtpass.TabIndex = 4
        '
        'Btnlogin
        '
        Me.Btnlogin.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnlogin.Location = New System.Drawing.Point(232, 162)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.Btnlogin.TabIndex = 5
        Me.Btnlogin.Text = "LOGIN"
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'Btncancel
        '
        Me.Btncancel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btncancel.Location = New System.Drawing.Point(326, 162)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(75, 23)
        Me.Btncancel.TabIndex = 6
        Me.Btncancel.Text = "CANCEL"
        Me.Btncancel.UseVisualStyleBackColor = False
        '
        'Cbshow
        '
        Me.Cbshow.AutoSize = True
        Me.Cbshow.Location = New System.Drawing.Point(232, 114)
        Me.Cbshow.Name = "Cbshow"
        Me.Cbshow.Size = New System.Drawing.Size(102, 17)
        Me.Cbshow.TabIndex = 7
        Me.Cbshow.Text = "Show Password"
        Me.Cbshow.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(430, 220)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cbshow)
        Me.Controls.Add(Me.Btncancel)
        Me.Controls.Add(Me.Btnlogin)
        Me.Controls.Add(Me.Txtpass)
        Me.Controls.Add(Me.Txtuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Btnlogin As System.Windows.Forms.Button
    Friend WithEvents Btncancel As System.Windows.Forms.Button
    Friend WithEvents Cbshow As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
