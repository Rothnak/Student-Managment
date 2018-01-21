Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions


Public Class studentlist

    Private Property dr As MySqlDataReader
    Dim READER As MySqlDataReader
  

    Private Sub studentlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "SELECT st.student_id,st.fname,st.lname,st.Gender,st.DOB,st.Phone,st.Address,cur.course_name,sh.shift_name,st.Years,st.Payment,st.Image FROM tbl_student as st INNER JOIN tbl_course as cur ON st.course=cur.course_id INNER JOIN tbl_shift as sh ON sh.shift_id=st.shift WHERE student_id like '%' "

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
                lvUser.Items.Add(list)

             Loop
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Me.txtcurrentuser.Text = UserLogin
    End Sub


    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        frmStudentRigitster.ShowDialog()
    End Sub

    Private Sub lvUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvUser.SelectedIndexChanged

    End Sub
    Sub updatestu(ByVal id As Integer)
        ConnectDB()
        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "SELECT st.student_id,st.fname,st.lname,st.Gender,st.DOB,st.Phone,st.Address,cur.course_name,sh.shift_name,st.Years,st.Payment,st.Image FROM tbl_student as st INNER JOIN tbl_course as cur ON st.course=cur.course_id INNER JOIN tbl_shift as sh ON sh.shift_id=st.shift WHERE student_id=" & id


            Dim Command = New MySqlCommand(Query, MysqlConn)
            dr = Command.ExecuteReader
            Do While dr.Read = True
                frm_update.txtstudentid.Text = (dr(0))
                frm_update.txtfname.Text = (dr(1))
                frm_update.txtlname.Text = (dr(2))
                frm_update.cbogender.Text = (dr(3))
                frm_update.txtdob.Text = (dr(4))
                frm_update.txtphonenumber.Text = (dr(5))
                frm_update.txtaddress.Text = (dr(6))
                frm_update.cbocourse.Text = (dr(7))
                frm_update.cboshift.Text = (dr(8))
                frm_update.cboyear.Text = dr(9)
                frm_update.cbopayment.Text = dr(10)
                frm_update.Show()
            Loop
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        Dim i As Integer
        For i = 0 To lvUser.Items.Count - 1
            If lvUser.Items(i).Selected Then

                Dim id As String = lvUser.Items(i).SubItems(0).ToString

                id = Regex.Replace(id, "[^0-9]", "")
                updatestu(id)

            End If
        Next


    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim A As Integer = 0
        For A = 0 To Me.lvUser.Items.Count
            If lvUser.Items(A).Selected = True Then
                Dim msgb As String = MsgBox("Do You want to remove?(Y/N)", vbYesNo)
                If msgb = vbYes Then
                    lvUser.Items(A).Remove()
                End If
                Exit For

            End If

        Next
    End Sub
    Private Sub lvUser_DoubleClick(sender As Object, e As EventArgs) Handles lvUser.DoubleClick
        'Call DataEdit()
    End Sub
    '    Sub DataEdit()
    '        Dim v As Integer
    '        For v = 0 To Me.lvUser.Items.Count - 1
    '            If lvUser.Items(v).Selected = True Then
    '                frmStudentRigitster.txtstudentid.Text = lvUser.Items(v).Text
    '                frmStudentRigitster.txtfname.Text = lvUser.Items(v).SubItems(1).Text
    '                frmStudentRigitster.txtlname.Text = lvUser.Items(v).SubItems(2).Text
    '                frmStudentRigitster.cbogender.Text = lvUser.Items(v).SubItems(3).Text
    '                frmStudentRigitster.txtdob.Text = lvUser.Items(v).SubItems(4).Text
    '                frmStudentRigitster.txtaddress.Text = lvUser.Items(v).SubItems(5).Text
    '                frmStudentRigitster.txtphonenumber.Text = lvUser.Items(v).SubItems(6).Text
    '                frmStudentRigitster.cbocourse.Text = lvUser.Items(v).SubItems(7).Text
    '                frmStudentRigitster.cboclass.Text = lvUser.Items(v).SubItems(8).Text
    '                frmStudentRigitster.Show()
    '            End If

    '        Next v

    '    End Sub

End Class