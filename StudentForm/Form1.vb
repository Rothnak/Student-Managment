Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Login
    Dim passchar As Boolean = False
    Sub login()

        Try
            MysqlConn.Open()
            Dim SQLStr As String = "SELECT * from tbl_login where username='" & txtusername.Text & "' and password='" & textpwd.Text & "'"
            Dim Command = New MySqlCommand(SQLStr, MysqlConn)
            Dim dr As MySqlDataReader
            dr = Command.ExecuteReader
            Dim user As String
            Dim pass As String
            If dr.HasRows Then
                While dr.Read()
                    user = dr(1)
                    pass = dr(2)

                    If user = txtusername.Text And pass = textpwd.Text Then
                        'MsgBox("Open form")
                        frmMain.Show()
                        Me.txtusername.Text = ""
                        Me.textpwd.Text = ""
                        Me.Hide()
                    End If
                End While
            Else
                MsgBox("You Are Wrong, Please Try Again!...")
                Me.txtusername.Focus()
                Me.txtusername.Text = ""
                Me.textpwd.Text = ""

            End If
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Dim a As String = MsgBox("Do you want to close?", vbYesNo)
        If a = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.btnlogin.Enabled = False
        Me.AllowTransparency = True
        Me.TransparencyKey = BackColor
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
            ConnectDB()
            login()

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

        'If Me.txtusername.Text = "admin" And Me.textpwd.Text = "admin" Then
        '    UserLogin = Me.txtusername.Text
        '    frmMain.Show()



        'Else
        '    MsgBox("You are wrong, Please Input again", vbCritical)
        '    Me.txtusername.Text = ""
        '    Me.textpwd.Text = ""

        '    Me.txtusername.Focus()
        'End If
        ConnectDB()
        login()




    End Sub
    Private Sub btnlogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnlogin.KeyPress

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If passchar = True Then
            Me.textpwd.PasswordChar = "*"
        Else
            Me.textpwd.PasswordChar = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ConnectDB()
    End Sub
End Class
