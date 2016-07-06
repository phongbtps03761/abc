Public Class frmchitiet
    'khai báo biến nhận kq trả về của login
    Private _loginresult As DialogResult

    'khai báo biến truy xuất database từ databasse access
    Private _dataaccess As New DataBaseAccess

    'kiem tra du liệu đang load
    Private _dangload As Boolean = False

    'dinh nghia thu tục load dữ liệu từ bảng lớp vào combo:
    Private Sub loaddataOncombobox()
        Dim sqlQuery As String = "select [Malop], [Tenlop] from [dbo].[Lop]"
        Dim dtable As DataTable = _dataaccess.GetDataTable(sqlQuery)
        Me.cmblop.DataSource = dtable
        Me.cmblop.ValueMember = "Malop"
        Me.cmblop.DisplayMember = "Tenlop"

    End Sub
    'dinh nghĩa load dữ liệu vào gridview
    Private Sub loaddataongridview(Malop As String)
        Dim sqlQuery As String = _
            String.Format("select MSSV, TenSV, SDT, Diachi, Malop from Sinhvien WHERE Malop = '{0}'", Malop)
        Dim dtable As DataTable = _dataaccess.GetDataTable(sqlQuery)
        Me.dgvsinhvien.DataSource = dtable
        With Me.dgvsinhvien
            .Columns(0).HeaderText = "MSSV"
            .Columns(1).HeaderText = "TenSV"
            .Columns(2).HeaderText = "SDT"
            .Columns(3).HeaderText = "Diachi"
            .Columns(4).HeaderText = "Malop"

        End With
    End Sub


    Private Sub frmchitiet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dangload = True 'dang load
        loaddataOncombobox()
        loaddataongridview(Me.cmblop.SelectedValue)
        _dangload = False 'load xong

    End Sub

    Private Sub cmblop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblop.SelectedIndexChanged
        If Not _dangload Then 'neu load xong
            loaddataongridview(Me.cmblop.SelectedValue)
        End If


        If _loginresult <> Windows.Forms.DialogResult.OK Then
            Me.Close() 'đóng form chi tiết nếu nhấn cancle
        End If
    End Sub

    'tim kiem tuong tu
    Private Sub timsinhvien(Malop As String, value As String)
        Dim sqlQuery As String = _
            String.Format("SELECT MSSV,TenSV,SDT,Diachi FROM dbo.Sinhvien WHERE Malop = '{0}'", Malop)
        If Me.cmbtim.SelectedIndex = 0 Then  'tim kiem MSSV
            sqlQuery += String.Format(" AND MSSV LIKE '{0}%'", value)
        ElseIf Me.cmbtim.SelectedIndex = 1 Then   'tim kiem tên sv
            sqlQuery += String.Format(" AND TenSV LIKE '{0}%'", value)
        End If
        Dim dTable As DataTable = _dataaccess.GetDataTable(sqlQuery)
        Me.dgvsinhvien.DataSource = dTable
        With Me.dgvsinhvien
            .Columns(0).HeaderText = "MSSV"
            .Columns(1).HeaderText = "TenSV"
            .Columns(2).HeaderText = "SDT"
            .Columns(3).HeaderText = "Diachi"
        End With
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txttim.TextChanged
        timsinhvien(Me.cmblop.SelectedValue, Me.txttim.Text)
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim frm As New frmthemsv(False)
        frm.txtthemml.Text = Me.cmblop.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then 'bat dau load du lieu
            loaddataongridview(Me.cmblop.SelectedValue)
        End If
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim frm As New frmthemsv(True)
        frm.txtthemml.Text = Me.cmblop.SelectedValue
        frm.txtthemms.ReadOnly = True  'Chi cho phep doc
        With Me.dgvsinhvien
            frm.txtthemms.Text = .Rows(.CurrentCell.RowIndex).Cells("MSSV").Value
            frm.txtthemten.Text = .Rows(.CurrentCell.RowIndex).Cells("TenSV").Value
            frm.txtthemsdt.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
            frm.txtthemdc.Text = .Rows(.CurrentCell.RowIndex).Cells("Diachi").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then 'Sua du lieu thanh cong thi load du lieu vao dgv
            loaddataongridview(Me.cmblop.SelectedValue)
        End If
    End Sub


    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        ' khai bao bien de lay MSSV ma dang can xoa tren dgv
        Dim MSSV As String = Me.dgvsinhvien.Rows(Me.dgvsinhvien.CurrentCell.RowIndex).Cells("MSSV").Value

        'Khai bao cau lenh Query de xoa
        Dim sqlQuery As String = String.Format("DELETE Sinhvien WHERE MSSV = '{0}'", MSSV)
        Dim xlb As MsgBoxResult
        xlb = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này không", "Thông Báo", MessageBoxButtons.OKCancel)
        If xlb = MsgBoxResult.Ok Then
            'thuc hien xoa
            If _dataaccess.ExecuteNoneQuery(sqlQuery) Then 'xoa thanh cong thi thong bao
                MessageBox.Show("Xóa dữ liệu thành công!")
                'Load lai du lieu tren dgv
                loaddataongridview(Me.cmblop.SelectedValue)
            Else
                MessageBox.Show("Lỗi xóa dữ liệu!", "Lỗi", MessageBoxButtons.OK)
            End If
        Else
            If xlb = MsgBoxResult.Cancel Then

            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim frm As New frmdangnhap
        frm.ShowDialog()
        _loginresult = frm.DialogResult
    End Sub

    'xuất ra file excel
    Private Sub btnxuat_Click(sender As Object, e As EventArgs) Handles btnxuat.Click
        Dim xlapp As Microsoft.Office.Interop.Excel.Application 'khai báo ứng dụng này là excel 
        Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook 'khai báo tệp excel
        Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet 'khai báo sheet
        Dim misvalue As Object = System.Reflection.Missing.Value
        Dim D As Integer
        Dim A As Integer

        xlapp = New Microsoft.Office.Interop.Excel.Application
        xlworkbook = xlapp.Workbooks.Add(misvalue)
        xlworksheet = xlworkbook.Sheets("sheet1")

        For D = 0 To dgvsinhvien.RowCount - 1 'đếm hàng trong gridview để xuất ra
            For A = 0 To dgvsinhvien.ColumnCount - 1 'đếm cột trong gridview
                For k As Integer = 1 To dgvsinhvien.Columns.Count
                    xlworksheet.Cells(1, k) = dgvsinhvien.Columns(k - 1).HeaderText
                    xlworksheet.Cells(D + 2, A + 1) = dgvsinhvien(A, D).Value.ToString()
                Next
            Next

        Next
        xlworksheet.SaveAs("C:\intel\dulieu.xlsx") 'đường dẫn và tên file lưu
        xlworkbook.Close()
        xlapp.Quit()

        MsgBox("Bạn có thể tìm file Excel theo đường dẫn sau: C:\intel\dulieu.xlsx")
        Dim res As MsgBoxResult
        res = MsgBox("Tải dữ liệu xong, bạn có muốn mở file Excel?", MsgBoxStyle.YesNo)
        If (res = MsgBoxResult.Yes) Then
            Process.Start("C:\intel\dulieu.xlsx")

        End If
    End Sub

    Private Sub lbltimkiem_Click(sender As Object, e As EventArgs) Handles lbltimkiem.Click

    End Sub
End Class