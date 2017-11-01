Public Class Form1

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        ' Display the french word for One.
        MessageBox.Show("un")
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        ' Display the French word for Two.
        MessageBox.Show("duex")
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        ' Display the French word for Three.
        MessageBox.Show("trois")
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        ' Display the French word for Four.
        MessageBox.Show("quatre")
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        ' Display the French word for Five.
        MessageBox.Show("cinq")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the Form
        Me.Close()
    End Sub
End Class
