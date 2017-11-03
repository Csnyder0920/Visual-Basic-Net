Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
    lblSetup.Visible = True
End Sub

Private Sub btnPunchLine_Click(sender As Object, e As EventArgs) Handles btnPunchLine.Click
    lblPunchLine.Visible = True
End Sub

Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    Me.Close()
End Sub
End Class
