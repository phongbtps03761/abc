<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdangnhap))
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.txttendangnhap = New System.Windows.Forms.TextBox()
        Me.lblmatkhau = New System.Windows.Forms.Label()
        Me.lbltendangnhap = New System.Windows.Forms.Label()
        Me.btndangki = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Location = New System.Drawing.Point(212, 183)
        Me.txtmatkhau.Multiline = True
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmatkhau.Size = New System.Drawing.Size(287, 23)
        Me.txtmatkhau.TabIndex = 2
        '
        'txttendangnhap
        '
        Me.txttendangnhap.Location = New System.Drawing.Point(212, 131)
        Me.txttendangnhap.Multiline = True
        Me.txttendangnhap.Name = "txttendangnhap"
        Me.txttendangnhap.Size = New System.Drawing.Size(287, 23)
        Me.txttendangnhap.TabIndex = 1
        '
        'lblmatkhau
        '
        Me.lblmatkhau.AutoSize = True
        Me.lblmatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblmatkhau.Location = New System.Drawing.Point(209, 162)
        Me.lblmatkhau.Name = "lblmatkhau"
        Me.lblmatkhau.Size = New System.Drawing.Size(64, 13)
        Me.lblmatkhau.TabIndex = 3
        Me.lblmatkhau.Text = "Mật khẩu:"
        '
        'lbltendangnhap
        '
        Me.lbltendangnhap.AutoSize = True
        Me.lbltendangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbltendangnhap.Location = New System.Drawing.Point(209, 108)
        Me.lbltendangnhap.Name = "lbltendangnhap"
        Me.lbltendangnhap.Size = New System.Drawing.Size(98, 13)
        Me.lbltendangnhap.TabIndex = 3
        Me.lbltendangnhap.Text = "Tên đăng nhập:"
        '
        'btndangki
        '
        Me.btndangki.Image = Global.datddps03704.My.Resources.Resources.register_icon
        Me.btndangki.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndangki.Location = New System.Drawing.Point(408, 231)
        Me.btndangki.Name = "btndangki"
        Me.btndangki.Size = New System.Drawing.Size(91, 57)
        Me.btndangki.TabIndex = 5
        Me.btndangki.Text = "Đăng Kí"
        Me.btndangki.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndangki.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Image = Global.datddps03704.My.Resources.Resources.red_cross_icon
        Me.btnthoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnthoat.Location = New System.Drawing.Point(309, 231)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(91, 57)
        Me.btnthoat.TabIndex = 4
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btndangnhap
        '
        Me.btndangnhap.Image = Global.datddps03704.My.Resources.Resources.Custom_Icon_Design_Flatastic_9_Login
        Me.btndangnhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndangnhap.Location = New System.Drawing.Point(212, 231)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(91, 57)
        Me.btndangnhap.TabIndex = 3
        Me.btndangnhap.Text = "Đăng nhập"
        Me.btndangnhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.datddps03704.My.Resources.Resources.Logo_FPT_Polytechnic
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(487, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.datddps03704.My.Resources.Resources._12661889_823062037839022_8556146090345489580_n
        Me.PictureBox1.Location = New System.Drawing.Point(12, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(511, 306)
        Me.Controls.Add(Me.lbltendangnhap)
        Me.Controls.Add(Me.lblmatkhau)
        Me.Controls.Add(Me.btndangki)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txttendangnhap)
        Me.Controls.Add(Me.txtmatkhau)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmdangnhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents txttendangnhap As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents lblmatkhau As System.Windows.Forms.Label
    Friend WithEvents lbltendangnhap As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btndangki As System.Windows.Forms.Button

End Class
