


Public Class studentlist

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        frmStudentRigitster.ShowDialog()
    End Sub

    Private Sub studentlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtcurrentuser.Text = UserLogin
    End Sub


    Private Sub lvUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvUser.SelectedIndexChanged

    End Sub
End Class