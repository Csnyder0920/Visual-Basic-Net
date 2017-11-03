Public Class Form1

    Private Sub btnShowGreeting_Click(sender As Object, e As EventArgs) Handles btnShowGreeting.Click
        Dim strName As String
        strName = txtUserName.Text
        lblGreeting.Text = txtUserName.Text
        lblGreeting.Text = "Hello " + strName
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
