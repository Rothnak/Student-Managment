Public Class frmclass

    Private Sub btnMoring_Click(sender As Object, e As EventArgs)
        frmclassmornig.Show()

    End Sub

    Private Sub frmclass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnclassevening.FlatStyle = False
        Me.btnclassafternoon.FlatStyle = False
        Me.btnclassmorning.FlatStyle = False

    End Sub

    Private Sub btnclassmorning_Click(sender As Object, e As EventArgs) Handles btnclassmorning.Click
        frmclassmornig.Show()

    End Sub

    Private Sub btnclassafternoon_Click(sender As Object, e As EventArgs) Handles btnclassafternoon.Click
        frmclassafternoon.Show()

    End Sub

    Private Sub btnclassevening_Click(sender As Object, e As EventArgs) Handles btnclassevening.Click
        frmclassevening.Show()

    End Sub
End Class