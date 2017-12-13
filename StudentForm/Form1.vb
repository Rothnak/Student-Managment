Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Dim a As String = MsgBox("Do you want to close?", vbYesNo)
        If a = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnlogin.Enabled = False
    End Sub

    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            MsgBox("Please Input Your Password")

            Me.textpwd.Focus()
        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub textpwd_KeyDown(sender As Object, e As KeyEventArgs) Handles textpwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtusername.Text = "admin" And Me.textpwd.Text = "admin" Then
                UserLogin = Me.txtusername.Text
                frmMain.Show()



            Else
                MsgBox("You are wrong, Please Input again", vbCritical)
                Me.txtusername.Text = ""
                Me.textpwd.Text = ""

                Me.txtusername.Focus()
            End If

        End If
    End Sub

    Private Sub textpwd_TextChanged(sender As Object, e As EventArgs) Handles textpwd.TextChanged
        If Me.textpwd.Text = "" Then
            Me.btnlogin.Enabled = False
        Else
            Me.btnlogin.Enabled = True
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
       
        If Me.txtusername.Text = "admin" And Me.textpwd.Text = "admin" Then
            UserLogin = Me.txtusername.Text
            frmMain.Show()



        Else
            MsgBox("You are wrong, Please Input again", vbCritical)
            Me.txtusername.Text = ""
            Me.textpwd.Text = ""

            Me.txtusername.Focus()
        End If

    End Sub

    Private Sub btnconnect_Click(sender As Object, e As EventArgs) Handles btnconnect.Click
        ConnecttoDB()


    End Sub

    Private Sub btnlogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnlogin.KeyPress

    End Sub
End Class
