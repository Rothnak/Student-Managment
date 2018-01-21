Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Module M_public
    Public OptCourse As Integer
    Public optCourseName As String
    Private Property dr As MySqlDataReader
    Public MysqlConn As New MySqlConnection

    Public user_type, UserName, user_email As String
    Public UserLogin As String
    Public Sub ConnectDB()

        MysqlConn.ConnectionString = ("server=localhost;user id=root;password=;database=student_management")
        Try
            MysqlConn.Open()
            '  MessageBox.Show("Connection to Database has been opened.")
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Public Function getID_From_Combo(ByVal SQLStr As String) As Integer
        ConnectDB()
        Dim getID As Integer
        Try
            MysqlConn.Open()

            Dim Command = New MySqlCommand(SQLStr, MysqlConn)
            dr = Command.ExecuteReader
            Do While dr.Read = True
                getID = dr(0)
            Loop
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        Return getID

    End Function

    Public Sub getTextName(ByVal SQLStr As String)

        ConnectDB()

        Try
            MysqlConn.Open()

            Dim Command = New MySqlCommand(SQLStr, MysqlConn)
            dr = Command.ExecuteReader
            Do While dr.Read = True
                optCourseName = dr(0)
            Loop
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


    End Sub

    ' Add Data to Combo
    Public Sub AddData2Combo(ByVal CboName As ComboBox, ByVal SQLStr As String)
        ConnectDB()
        CboName.Items.Clear()
        Try
            MysqlConn.Open()

            Dim Command = New MySqlCommand(SQLStr, MysqlConn)
            dr = Command.ExecuteReader
            Do While dr.Read = True
                'getID = dr(0)
                CboName.Items.Add(dr(0))
            Loop
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    
End Module
