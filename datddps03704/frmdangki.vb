Public Class frmdangki
    Private _dataaccess As New DataBaseAccess
    'dinh nghia ham them sinh vien vao csdl
    Private Function InsertTaiKhoan() As Boolean
        Dim sqlQuery As String = "INSERT User Sinhvien (username, password)"
        sqlQuery += String.Format("VALUES (N'{0}',N'{1}')", _
                                  txtusername.Text, txtmatkhau.Text)
        Return _dataaccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'dinh nghia ham kiem tra gia tri truoc khi them tai khoan vao database
    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtusername.Text) OrElse String.IsNullOrEmpty(txtmatkhau.Text))

    End Function

    Private Sub btndangki_Click(sender As Object, e As EventArgs) Handles btndangki.Click
        If IsEmpty() Then 'thực hiện kiểm tra dữ liệu trước khi thực hiện
            MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK)
        Else
            If InsertTaiKhoan() Then 'neu insert thanh cong 
                MessageBox.Show("Thêm tài khoản thành công", "Thông Báo", MessageBoxButtons.OK)
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            Else
                MessageBox.Show("Lỗi thêm tài khoản", "Lỗi", MessageBoxButtons.OK)
            End If
            Me.Close()
        End If
    End Sub
End Class