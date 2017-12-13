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
End Class