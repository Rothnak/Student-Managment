Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmReport

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class