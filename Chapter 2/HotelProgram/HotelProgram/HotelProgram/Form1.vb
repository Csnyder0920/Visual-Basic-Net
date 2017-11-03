Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Header.Click

    End Sub

    Private Sub Directions_Click(sender As Object, e As EventArgs) Handles Directions.Click
        lblDirections.Visible = False
        DisplayDirections.Visible = True
        Directions.Visible = False
    End Sub

    Private Sub DisplayDirections_Click(sender As Object, e As EventArgs) Handles DisplayDirections.Click
        lblDirections.Visible = True
        DisplayDirections.Visible = False
        Directions.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
