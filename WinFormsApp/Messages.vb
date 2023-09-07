Public Class Messages
    Private Sub Messages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPart1.Text = "Be Happy."
        txtPart2.Text = "Be Positive."
        txtPart3.Text = "Be Sexy/Cute."
    End Sub

    Private Sub btnShowMessage_Click(sender As Object, e As EventArgs) Handles btnShowMessage.Click
        MessageBox.Show($"1. {txtPart1.Text}{vbCrLf}2. {txtPart2.Text}{vbCrLf}3. {txtPart3.Text}", txtTitle.Text, MessageBoxButtons.OKCancel)
    End Sub
End Class