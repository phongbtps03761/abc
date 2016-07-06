<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmthemsv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmthemsv))
        Me.lblthemms = New System.Windows.Forms.Label()
        Me.lblthemten = New System.Windows.Forms.Label()
        Me.lblthemsdt = New System.Windows.Forms.Label()
        Me.lblthemdc = New System.Windows.Forms.Label()
        Me.lblthemml = New System.Windows.Forms.Label()
        Me.txtthemms = New System.Windows.Forms.TextBox()
        Me.txtthemten = New System.Windows.Forms.TextBox()
        Me.txtthemsdt = New System.Windows.Forms.TextBox()
        Me.txtthemdc = New System.Windows.Forms.TextBox()
        Me.txtthemml = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnhuy = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblthemms
        '
        Me.lblthemms.AutoSize = True
        Me.lblthemms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblthemms.Location = New System.Drawing.Point(42, 162)
        Me.lblthemms.Name = "lblthemms"
        Me.lblthemms.Size = New System.Drawing.Size(94, 15)
        Me.lblthemms.TabIndex = 0
        Me.lblthemms.Text = "Mã Sinh viên:"
        '
        'lblthemten
        '
        Me.lblthemten.AutoSize = True
        Me.lblthemten.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblthemten.Location = New System.Drawing.Point(38, 207)
        Me.lblthemten.Name = "lblthemten"
        Me.lblthemten.Size = New System.Drawing.Size(98, 15)
        Me.lblthemten.TabIndex = 0
        Me.lblthemten.Text = "Tên Sinh viên:"
        '
        'lblthemsdt
        '
        Me.lblthemsdt.AutoSize = True
        Me.lblthemsdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblthemsdt.Location = New System.Drawing.Point(40, 255)
        Me.lblthemsdt.Name = "lblthemsdt"
        Me.lblthemsdt.Size = New System.Drawing.Size(96, 15)
        Me.lblthemsdt.TabIndex = 0
        Me.lblthemsdt.Text = "Số điện thoại:"
        '
        'lblthemdc
        '
        Me.lblthemdc.AutoSize = True
        Me.lblthemdc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblthemdc.Location = New System.Drawing.Point(40, 297)
        Me.lblthemdc.Name = "lblthemdc"
        Me.lblthemdc.Size = New System.Drawing.Size(56, 15)
        Me.lblthemdc.TabIndex = 0
        Me.lblthemdc.Text = "Địa chỉ:"
        '
        'lblthemml
        '
        Me.lblthemml.AutoSize = True
        Me.lblthemml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblthemml.Location = New System.Drawing.Point(42, 113)
        Me.lblthemml.Name = "lblthemml"
        Me.lblthemml.Size = New System.Drawing.Size(55, 15)
        Me.lblthemml.TabIndex = 0
        Me.lblthemml.Text = "Mã lớp:"
        '
        'txtthemms
        '
        Me.txtthemms.Location = New System.Drawing.Point(142, 157)
        Me.txtthemms.Multiline = True
        Me.txtthemms.Name = "txtthemms"
        Me.txtthemms.Size = New System.Drawing.Size(137, 27)
        Me.txtthemms.TabIndex = 1
        '
        'txtthemten
        '
        Me.txtthemten.Location = New System.Drawing.Point(142, 202)
        Me.txtthemten.Multiline = True
        Me.txtthemten.Name = "txtthemten"
        Me.txtthemten.Size = New System.Drawing.Size(137, 29)
        Me.txtthemten.TabIndex = 2
        '
        'txtthemsdt
        '
        Me.txtthemsdt.Location = New System.Drawing.Point(142, 250)
        Me.txtthemsdt.Multiline = True
        Me.txtthemsdt.Name = "txtthemsdt"
        Me.txtthemsdt.Size = New System.Drawing.Size(137, 29)
        Me.txtthemsdt.TabIndex = 3
        '
        'txtthemdc
        '
        Me.txtthemdc.Location = New System.Drawing.Point(142, 292)
        Me.txtthemdc.Multiline = True
        Me.txtthemdc.Name = "txtthemdc"
        Me.txtthemdc.Size = New System.Drawing.Size(137, 29)
        Me.txtthemdc.TabIndex = 4
        '
        'txtthemml
        '
        Me.txtthemml.Location = New System.Drawing.Point(144, 112)
        Me.txtthemml.Multiline = True
        Me.txtthemml.Name = "txtthemml"
        Me.txtthemml.Size = New System.Drawing.Size(137, 29)
        Me.txtthemml.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.datddps03704.My.Resources.Resources.PW_welcome_sign_shutterstock
        Me.PictureBox1.Location = New System.Drawing.Point(46, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(45, 341)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(99, 36)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnhuy
        '
        Me.btnhuy.Location = New System.Drawing.Point(190, 341)
        Me.btnhuy.Name = "btnhuy"
        Me.btnhuy.Size = New System.Drawing.Size(91, 35)
        Me.btnhuy.TabIndex = 6
        Me.btnhuy.Text = "Hủy"
        Me.btnhuy.UseVisualStyleBackColor = True
        '
        'frmthemsv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(327, 390)
        Me.Controls.Add(Me.btnhuy)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtthemml)
        Me.Controls.Add(Me.txtthemdc)
        Me.Controls.Add(Me.txtthemsdt)
        Me.Controls.Add(Me.txtthemten)
        Me.Controls.Add(Me.txtthemms)
        Me.Controls.Add(Me.lblthemml)
        Me.Controls.Add(Me.lblthemdc)
        Me.Controls.Add(Me.lblthemsdt)
        Me.Controls.Add(Me.lblthemten)
        Me.Controls.Add(Me.lblthemms)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmthemsv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm sinh viên"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblthemms As System.Windows.Forms.Label
    Friend WithEvents lblthemten As System.Windows.Forms.Label
    Friend WithEvents lblthemsdt As System.Windows.Forms.Label
    Friend WithEvents lblthemdc As System.Windows.Forms.Label
    Friend WithEvents lblthemml As System.Windows.Forms.Label
    Friend WithEvents txtthemms As System.Windows.Forms.TextBox
    Friend WithEvents txtthemten As System.Windows.Forms.TextBox
    Friend WithEvents txtthemsdt As System.Windows.Forms.TextBox
    Friend WithEvents txtthemdc As System.Windows.Forms.TextBox
    Friend WithEvents txtthemml As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnhuy As System.Windows.Forms.Button
End Class
