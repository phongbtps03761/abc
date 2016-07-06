<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangki
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
        Me.lbluusername = New System.Windows.Forms.Label()
        Me.lblmatkhau = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.btndangki = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lbluusername
        '
        Me.lbluusername.AutoSize = true
        Me.lbluusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.lbluusername.Location = New System.Drawing.Point(27, 108)
        Me.lbluusername.Name = "lbluusername"
        Me.lbluusername.Size = New System.Drawing.Size(93, 15)
        Me.lbluusername.TabIndex = 0
        Me.lbluusername.Text = "Tên đăng nhập:"
        '
        'lblmatkhau
        '
        Me.lblmatkhau.AutoSize = true
        Me.lblmatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163,Byte))
        Me.lblmatkhau.Location = New System.Drawing.Point(59, 152)
        Me.lblmatkhau.Name = "lblmatkhau"
        Me.lblmatkhau.Size = New System.Drawing.Size(61, 15)
        Me.lblmatkhau.TabIndex = 1
        Me.lblmatkhau.Text = "Mật khẩu:"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(136, 104)
        Me.txtusername.Multiline = true
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(158, 23)
        Me.txtusername.TabIndex = 1
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Location = New System.Drawing.Point(136, 148)
        Me.txtmatkhau.Multiline = True
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmatkhau.Size = New System.Drawing.Size(158, 23)
        Me.txtmatkhau.TabIndex = 2
        '
        'btndangki
        '
        Me.btndangki.Location = New System.Drawing.Point(34, 186)
        Me.btndangki.Name = "btndangki"
        Me.btndangki.Size = New System.Drawing.Size(86, 29)
        Me.btndangki.TabIndex = 3
        Me.btndangki.Text = "OK"
        Me.btndangki.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Location = New System.Drawing.Point(172, 186)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(86, 29)
        Me.btnhuy.TabIndex = 4
        Me.btnhuy.Text = "Hủy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.datddps03704.My.Resources.Resources._22969483_register_here_en_no_sign_or_icon_Membership_registration_sticker__Stock_Photo
        Me.PictureBox1.Location = New System.Drawing.Point(20, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmdangki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(315, 219)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btndangki)
        Me.Controls.Add(Me.txtmatkhau)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblmatkhau)
        Me.Controls.Add(Me.lbluusername)
        Me.Name = "frmdangki"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng ký"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lbluusername As System.Windows.Forms.Label
    Friend WithEvents lblmatkhau As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents btndangki As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
