
Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmdangnhap
    'khai báo biến toàn cục để kết nối CSDL
    Private _connectionstring As String = ConfigurationSettings.AppSettings("MyconnectionString")
    Private conn As SqlConnection
    Private da As SqlDataAdapter

    'dinh nghĩa hàm lấy dữ liệu đổ vào bảng
    Private Function getDataTable(sqlQuery As String) As DataTable
        Dim dtable As New DataTable
        'khởi tạo biến conn
        conn = New SqlConnection(_connectionstring)

        'khởi tạo biến da
        da = New SqlDataAdapter(sqlQuery, conn)
        Try
            'mở connection
            conn.Open()

            'đổ dữ liệu vào dtable
            da.Fill(dtable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Lỗi") 'thông báo lỗi nếu có lỗi xảy ra
        Finally
            conn.Close() 'đóng connection

        End Try
        Return dtable
    End Function

    'định nghĩa hàm kiểm tra username và password
    Private Function checklogin(user As String, pass As String)
        Dim sqlQuery As String = String.Format("select * from [dbo].[user] where [username] = '{0}' and [password] = '{1}'", user, pass)
        Dim dtable As DataTable = getDataTable(sqlQuery)
        Return dtable.Rows.Count > 0
    End Function
    'định nghĩa hàm kiểm tra user pass có trống không
    Private Function isempty() As Boolean
        'hàm trả về true nếu username hoặc mật khẩu trống
        Return String.IsNullOrEmpty(Me.txttendangnhap.Text) OrElse String.IsNullOrEmpty(Me.txtmatkhau.Text)
    End Function


    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        'kiểm tra username và pass có nhập hay không
        If isempty() Then
            MessageBox.Show("Tên đăng nhập và mật khẩu không được trống!")
        Else
            If checklogin(Me.txttendangnhap.Text.ToLower, Me.txtmatkhau.Text.ToLower) Then 'đăng nhập thành công
                Me.DialogResult = Windows.Forms.DialogResult.OK
                MessageBox.Show("Đăng nhập thành công")
                Me.Close()
            Else 'trường hợp sai tk mk
                MessageBox.Show("Tài khoảng hoặc mật khẩu không đúng")

            End If
        End If
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndangki.Click
        Dim frm As New frmdangki
        frm.ShowDialog()
    End Sub
End Class
