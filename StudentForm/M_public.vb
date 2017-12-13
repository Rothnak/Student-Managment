Imports MySql.Data.MySqlClient

Module M_public
    Public UserLogin As String
    Public Sub ConnecttoDB()
        Dim mySQLConn = New MySqlConnection
        mySQLConn.ConnectionString = My.Settings.Conn
        Try
            mySQLConn.Open()
            MsgBox("Connect Successfully!!!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mySQLConn.Dispose()

        End Try
    End Sub

End Module
