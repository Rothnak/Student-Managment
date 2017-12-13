Public Class frmStudentRigitster
    Dim UrsImagePath As String

    Private Sub Clear()
        Me.txtstudentid.Text = studentlist.lvUser.Items.Count + 1
        Me.txtfname.Text = ""
        Me.txtlname.Text = ""
        Me.txtdob.Text = ""
        Me.cbogender.Text = ""
        Me.txtaddress.Text = ""
        Me.txtphonenumber.Text = ""
        Me.userimage.Image = Nothing
        Me.lbimage.Text = "No Image"

        Me.txtfname.Focus()

    End Sub

    Private Sub txtstudentid_TextChanged(sender As Object, e As EventArgs) Handles txtstudentid.TextChanged

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click

        Call Clear()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim i As Integer = studentlist.lvUser.Items.Count
        studentlist.lvUser.Items.Add(Me.txtstudentid.Text)
        studentlist.lvUser.Items(i).SubItems.Add(Me.txtfname.Text)
        studentlist.lvUser.Items(i).SubItems.Add(Me.txtlname.Text)
        studentlist.lvUser.Items(i).SubItems.Add(Me.cbogender.Text)
        studentlist.lvUser.Items(i).SubItems.Add(Me.txtdob.Text)
        studentlist.lvUser.Items(i).SubItems.Add(Me.txtaddress.Text)
        studentlist.lvUser.Items(i).SubItems.Add(Me.txtphonenumber.Text)
        Call Clear()

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
        Clear()
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
End Class