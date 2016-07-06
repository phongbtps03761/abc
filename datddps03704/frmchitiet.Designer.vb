<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchitiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmchitiet))
        Me.lbltimkiem = New System.Windows.Forms.Label()
        Me.txttim = New System.Windows.Forms.TextBox()
        Me.dgvsinhvien = New System.Windows.Forms.DataGridView()
        Me.cmblop = New System.Windows.Forms.ComboBox()
        Me.lbllop = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnxuat = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.cmbtim = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvsinhvien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltimkiem
        '
        Me.lbltimkiem.AutoSize = True
        Me.lbltimkiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbltimkiem.Location = New System.Drawing.Point(12, 35)
        Me.lbltimkiem.Name = "lbltimkiem"
        Me.lbltimkiem.Size = New System.Drawing.Size(61, 13)
        Me.lbltimkiem.TabIndex = 0
        Me.lbltimkiem.Text = "Tìm kiếm:"
        '
        'txttim
        '
        Me.txttim.Location = New System.Drawing.Point(250, 27)
        Me.txttim.Multiline = True
        Me.txttim.Name = "txttim"
        Me.txttim.Size = New System.Drawing.Size(358, 21)
        Me.txttim.TabIndex = 2
        '
        'dgvsinhvien
        '
        Me.dgvsinhvien.AllowUserToAddRows = False
        Me.dgvsinhvien.AllowUserToDeleteRows = False
        Me.dgvsinhvien.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsinhvien.Location = New System.Drawing.Point(12, 124)
        Me.dgvsinhvien.Name = "dgvsinhvien"
        Me.dgvsinhvien.ReadOnly = True
        Me.dgvsinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsinhvien.Size = New System.Drawing.Size(535, 346)
        Me.dgvsinhvien.TabIndex = 3
        '
        'cmblop
        '
        Me.cmblop.FormattingEnabled = True
        Me.cmblop.Location = New System.Drawing.Point(103, 78)
        Me.cmblop.Name = "cmblop"
        Me.cmblop.Size = New System.Drawing.Size(122, 21)
        Me.cmblop.TabIndex = 4
        '
        'lbllop
        '
        Me.lbllop.AutoSize = True
        Me.lbllop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbllop.Location = New System.Drawing.Point(12, 81)
        Me.lbllop.Name = "lbllop"
        Me.lbllop.Size = New System.Drawing.Size(32, 13)
        Me.lbllop.TabIndex = 5
        Me.lbllop.Text = "Lớp:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnxuat)
        Me.GroupBox1.Controls.Add(Me.btnthem)
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnsua)
        Me.GroupBox1.Location = New System.Drawing.Point(574, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(102, 346)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chức năng:"
        '
        'btnxuat
        '
        Me.btnxuat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnxuat.Image = Global.datddps03704.My.Resources.Resources.Graphicloads_Filetype_Excel_xls
        Me.btnxuat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnxuat.Location = New System.Drawing.Point(8, 221)
        Me.btnxuat.Name = "btnxuat"
        Me.btnxuat.Size = New System.Drawing.Size(87, 49)
        Me.btnxuat.TabIndex = 8
        Me.btnxuat.Text = "Excel"
        Me.btnxuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnxuat.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnthem.Image = Global.datddps03704.My.Resources.Resources.icon
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnthem.Location = New System.Drawing.Point(7, 19)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(88, 51)
        Me.btnthem.TabIndex = 5
        Me.btnthem.Text = "Thêm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnxoa.Image = Global.datddps03704.My.Resources.Resources.delete
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnxoa.Location = New System.Drawing.Point(7, 85)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(88, 51)
        Me.btnxoa.TabIndex = 6
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button2.Image = Global.datddps03704.My.Resources.Resources.red_cross_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(8, 289)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 51)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Thoát"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnsua.Image = Global.datddps03704.My.Resources.Resources._141222387454
        Me.btnsua.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsua.Location = New System.Drawing.Point(7, 152)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(88, 51)
        Me.btnsua.TabIndex = 7
        Me.btnsua.Text = "Sửa"
        Me.btnsua.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'cmbtim
        '
        Me.cmbtim.FormattingEnabled = True
        Me.cmbtim.Items.AddRange(New Object() {"MSSV", "TenSV"})
        Me.cmbtim.Location = New System.Drawing.Point(104, 27)
        Me.cmbtim.Name = "cmbtim"
        Me.cmbtim.Size = New System.Drawing.Size(121, 21)
        Me.cmbtim.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Button1.Image = Global.datddps03704.My.Resources.Resources.a
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(614, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Tìm"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmchitiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(689, 482)
        Me.Controls.Add(Me.cmbtim)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbllop)
        Me.Controls.Add(Me.cmblop)
        Me.Controls.Add(Me.dgvsinhvien)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttim)
        Me.Controls.Add(Me.lbltimkiem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmchitiet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin"
        CType(Me.dgvsinhvien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltimkiem As System.Windows.Forms.Label
    Friend WithEvents txttim As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvsinhvien As System.Windows.Forms.DataGridView
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents cmblop As System.Windows.Forms.ComboBox
    Friend WithEvents lbllop As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbtim As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnxuat As System.Windows.Forms.Button
End Class
