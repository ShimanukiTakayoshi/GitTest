Public Class frmGitStudy

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        lblRump.BackColor = Color.Red
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        lblRump.BackColor = Color.Green
    End Sub

    Private Sub btnYellow_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        lblRump.BackColor = Color.Yellow
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Application.Exit()
    End Sub
End Class
