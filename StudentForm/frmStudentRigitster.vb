Public Class frmStudentRigitster
    Dim UrsImagePath As String

    Private Property DateTimePicker As String

    Private Sub Clear()
        Me.txtstudentid.Text = studentlist.lvUser.Items.Count + 1
        Me.txtfname.Text = ""
        Me.txtlname.Text = ""
        Me.txtdob.Text = ""
        Me.cbogender.Text = ""
        Me.txtaddress.Text = ""
        Me.txtphonenumber.Text = ""
        Me.cboclass.Text = ""
        Me.cbocourse.Text = ""
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
        studentlist.lvUser.Items(i).SubItems.Add(Me.cbocourse.Text)
        studentlist.lvUser.Items(i).SubItems.Add(Me.cboclass.Text)
        If Me.cbocourse.Text = "ICT" Then
            Dim a As Integer = frmlvICT.lvICT.Items.Count
            frmlvICT.lvICT.Items.Add(Me.txtstudentid.Text)
            frmlvICT.lvICT.Items(a).SubItems.Add(Me.txtfname.Text)
            frmlvICT.lvICT.Items(a).SubItems.Add(Me.txtlname.Text)
            frmlvICT.lvICT.Items(a).SubItems.Add(Me.cbogender.Text)
            frmlvICT.lvICT.Items(a).SubItems.Add(Me.txtdob.Text)
            frmlvICT.lvICT.Items(a).SubItems.Add(Me.txtaddress.Text)
            frmlvICT.lvICT.Items(a).SubItems.Add(Me.txtphonenumber.Text)
            frmlvICT.lvICT.Items(a).SubItems.Add(Me.cbocourse.Text)
            frmlvICT.lvICT.Items(a).SubItems.Add(Me.cboclass.Text)
        End If
        If Me.cboclass.Text = "Morning" Then
            Dim b As Integer = frmclassmornig.lvclassmoring.Items.Count
            frmclassmornig.lvclassmoring.Items.Add(Me.txtstudentid.Text)
            frmclassmornig.lvclassmoring.Items(b).SubItems.Add(Me.txtfname.Text)
            frmclassmornig.lvclassmoring.Items(b).SubItems.Add(Me.txtlname.Text)
            frmclassmornig.lvclassmoring.Items(b).SubItems.Add(Me.cbogender.Text)
            frmclassmornig.lvclassmoring.Items(b).SubItems.Add(Me.txtdob.Text)
            frmclassmornig.lvclassmoring.Items(b).SubItems.Add(Me.txtaddress.Text)
            frmclassmornig.lvclassmoring.Items(b).SubItems.Add(Me.txtphonenumber.Text)
            frmclassmornig.lvclassmoring.Items(b).SubItems.Add(Me.cbocourse.Text)
            frmclassmornig.lvclassmoring.Items(b).SubItems.Add(Me.cboclass.Text)
        End If

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

    Private Sub txtdob_TextChanged(sender As Object, e As EventArgs) Handles txtdob.TextChanged

    End Sub
End Class