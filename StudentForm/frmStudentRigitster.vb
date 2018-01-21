Imports MySql.Data.MySqlClient

Public Class frmStudentRigitster
    Dim READER As MySqlDataReader
    Dim UrsImagePath As String

    Private Property dr As MySqlDataReader
    Dim course_id As Integer = 0
    Dim shift_id As Integer = 0
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Me.txtstudentid.Text = studentlist.lvUser.Items.Count + 1
        Me.txtfname.Focus()
    End Sub
    Private Sub Clear()
        Me.txtstudentid.Text = studentlist.lvUser.Items.Count + 1
        Me.txtfname.Text = ""
        Me.txtlname.Text = ""
        Me.txtdob.Text = ""
        Me.cbogender.Text = ""
        Me.txtaddress.Text = ""
        Me.txtphonenumber.Text = ""
        Me.cbocourse.Text = ""
        Me.cboyear.Text = ""
        Me.cboshift.Text = ""
        Me.cbopayment.Text = ""
        Me.userimage.Image = Nothing
        Me.lbimage.Text = "No Image"

        Me.txtfname.Focus()

    End Sub

    Private Sub txtstudentid_TextChanged(sender As Object, e As EventArgs) Handles txtstudentid.TextChanged

    End Sub
    Sub showLV()
        ConnectDB()
        studentlist.lvUser.Items.Clear()
        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "SELECT st.student_id,st.fname,st.lname,st.Gender,st.Address,st.DOB,cur.course_name,st.Years,sh.shift_name,st.Phone,st.Payment,st.Image FROM tbl_student as st INNER JOIN tbl_course as cur ON st.course=cur.course_id INNER JOIN tbl_shift as sh ON sh.shift_id=st.shift WHERE cur.course_id =" & course_id

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

                studentlist.lvUser.Items.Add(list)
            Loop
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
  
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        ConnectDB()

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "INSERT INTO tbl_student ( fname, lname, Gender, Address, DOB, course, Years, shift, Phone, Payment, Image) values ('" & txtfname.Text & "','" & txtlname.Text & "','" & cbogender.Text & "','" & txtaddress.Text & "','" & txtdob.Text & "','" & course_id & "','" & cboyear.Text & "','" & shift_id & "','" & txtphonenumber.Text & "','" & cbopayment.Text & "','" & lbimage.Text & "')"

            Dim Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader
            MessageBox.Show("Data Saved")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        Call Clear()

    End Sub
    Private Sub cbocourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocourse.SelectedIndexChanged
        course_id = getID_From_Combo("SELECT course_id FROM tbl_course WHERE course_name='" & cbocourse.Text & "'")
    End Sub
    Private Sub cboshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboshift.SelectedIndexChanged
        shift_id = getID_From_Combo("SELECT shift_id FROM tbl_shift WHERE shift_name='" & cboshift.Text & "'")
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            userimage.Image = Image.FromFile(OpenFile.FileName)
            UrsImagePath = OpenFile.FileName
            lbimage.Text = System.IO.Path.GetFileName(OpenFile.FileName)

        End If
    End Sub

    Private Sub frmStudentRigitster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddData2Combo(cbocourse, "SELECT course_name from tbl_course")
        AddData2Combo(cboshift, "SELECT shift_name from tbl_shift")
        AddData2Combo(cboyear, "SELECT years from tbl_years")
        Me.txtstudentid.Text = studentlist.lvUser.Items.Count + 1
        Me.txtfname.Focus()
        Me.txtcurrentuser.Text = UserLogin

    End Sub

    Private Sub txtcurrentuser_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub txtcurrenuser_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcurrentuser_Click_1(sender As Object, e As EventArgs) Handles txtcurrentuser.Click

    End Sub

    Private Sub userimage_Click(sender As Object, e As EventArgs) Handles userimage.Click

    End Sub

    Private Sub lbimage_Click(sender As Object, e As EventArgs) Handles lbimage.Click

    End Sub

    Private Sub btncapture_Click(sender As Object, e As EventArgs) Handles btncapture.Click
        lbimage.Text = ""
        Camara.ShowDialog()
        If lbimage.Text <> "" Then
            Me.userimage.Image = Image.FromFile(lbimage.Text)

        End If
    End Sub

    Private Sub txtdob_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub cboyear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboyear.SelectedIndexChanged

    End Sub

End Class