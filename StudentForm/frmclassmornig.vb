Imports MySql.Data.MySqlClient
Public Class frmclassmornig
    Private Property dr As MySqlDataReader
    Private Sub frmclassmornig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "SELECT st.student_id,st.fname,st.lname,st.Gender,st.DOB,st.Phone,st.Address,cur.course_name,sh.shift_name,st.Years,st.Payment,st.Image FROM tbl_student as st INNER JOIN tbl_course as cur ON st.course=cur.course_id INNER JOIN tbl_shift as sh ON sh.shift_id=st.shift WHERE shift_id = 1 "

            Dim list As ListViewItem
            Dim Command = New MySqlCommand(Query, MysqlConn)
            dr = Command.ExecuteReader
            Do While dr.Read = True
                list = New ListViewItem(dr(0).ToString)
                list.SubItems.Add(dr(1))
                list.SubItems.Add(dr(2))
                list.SubItems.Add(dr(3))
                list.SubItems.Add(dr(4))
                list.SubItems.Add(dr(5))
                list.SubItems.Add(dr(6))
                list.SubItems.Add(dr(7))
                list.SubItems.Add(dr(8))
                list.SubItems.Add(dr(9))
                list.SubItems.Add(dr(10))
                list.SubItems.Add(dr(11))
                lvclassmorning.Items.Add(list)

            Loop
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class