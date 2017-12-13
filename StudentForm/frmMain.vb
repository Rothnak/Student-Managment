Public Class frmMain

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        frmStudentRigitster.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnstudentlist.Click
        studentlist.Show()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtcurrentuser.Text = UserLogin
        Login.Hide()






    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncourse_Click(sender As Object, e As EventArgs) Handles btncourse.Click
        frmcourse.Show()

    End Sub

    Private Sub btnetc_Click(sender As Object, e As EventArgs) Handles btnetc.Click
        frmetc.Show()

    End Sub

    Private Sub btnclass_Click(sender As Object, e As EventArgs) Handles btnclass.Click
        frmclass.Show()

    End Sub

    Private Sub btnsubject_Click(sender As Object, e As EventArgs) Handles btnsubject.Click
        frmsubject.Show()

    End Sub
End Class