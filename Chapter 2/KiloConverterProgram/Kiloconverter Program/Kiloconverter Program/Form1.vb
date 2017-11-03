Public Class Form1
    Private Sub btnInches_Click(sender As Object, e As EventArgs) Handles btnInches.Click
        ' Display the conversion to inches.
        lblMessage.Text = "1 Kilometer = 39,970 Inches"
    End Sub

    Private Sub btnFeet_Click(sender As Object, e As EventArgs) Handles btnFeet.Click
        'Display the conversion to Feet.
        lblMessage.Text = "1 Kilometer = 3,281 Feet"
    End Sub

    Private Sub Yards_Click(sender As Object, e As EventArgs) Handles btnYards.Click
        'Display the conversion to yards.
        lblMessage.Text = "1 Kilometer = 1,093.6 Yards"
    End Sub

    Private Sub btnMiles_Click(sender As Object, e As EventArgs) Handles btnMiles.Click
        'Display the conversion to Miles.
        lblMessage.Text = "1 Kilometer = 0.6214 Miles"
    End Sub

    Private Sub btnExitFile_Click(sender As Object, e As EventArgs) Handles btnExitFile.Click
        'End the application.
        Me.Close()
    End Sub
End Class