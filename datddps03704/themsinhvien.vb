Public Class frmthemsv
    'khai bao bien truy xuat database tu lop dtbaccess
    Private _dataaccess As New DataBaseAccess

    'khai bao bien dang sua hay them
    Private _isedit As Boolean = False
    Public Sub New(isedit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isedit = isedit

    End Sub


    'dinh nghia ham them sinh vien vao csdl
    Private Function themsv() As Boolean
        Dim sqlQuery As String = "INSERT INTO Sinhvien (MSSV, TenSV, SDT, Diachi, Malop)"
        sqlQuery += String.Format("VALUES (N'{0}',N'{1}','{2}',N'{3}',N'{4}')", _
                                  txtthemms.Text, txtthemten.Text, txtthemsdt.Text, txtthemdc.Text, txtthemml.Text)
        Return _dataaccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'dinh nghia ham sửa dữ liệu
    Private Function suasinhvien() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE Sinhvien SET TenSV = N'{0}', SDT ='{1}', Diachi = N'{2}' WHERE MSSV = N'{3}' ", _
                                               Me.txtthemten.Text, Me.txtthemsdt.Text, Me.txtthemdc.Text, Me.txtthemms.Text)
        Return _dataaccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtthemms.Text) OrElse String.IsNullOrEmpty(txtthemten.Text) OrElse _
                String.IsNullOrEmpty(txtthemsdt.Text) OrElse String.IsNullOrEmpty(txtthemdc.Text) OrElse _
                String.IsNullOrEmpty(txtthemml.Text))

    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then 'thực hiện kiểm tra dữ liệu trước khi thực hiện
            MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK)
        Else
            If _isedit Then 'nếu là sửa thì gọi hàm suasinhvien 
                If suasinhvien() Then 'sửa thành công thì báo thành công
                    MessageBox.Show("Sửa sinh viên thành công", "Thông Báo", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else 'neu co loi khi sua thi bao loi
                    MessageBox.Show("Lỗi sữa dữ liệu", "Lỗi", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If

            Else  'neu khong phai sửa thì gọi hàm themsv
                If themsv() Then 'thêm thành công thì báo thành công
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Lỗi Sửa dữ liệu", "Lỗi", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

        End If
    End Sub

    Private Sub btnhuy_Click(sender As Object, e As EventArgs) Handles btnhuy.Click
        Me.Close()
    End Sub

    Private Sub frmthemsv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtthemml.Enabled = False
    End Sub
End Class