Public Class Calculator

    Dim choosenSign As String
    Dim firstNumber As Decimal
    Dim secondNumber As Decimal
    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtBox.Text += "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtBox.Text += "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtBox.Text += "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtBox.Text += "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtBox.Text += "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtBox.Text += "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtBox.Text += "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtBox.Text += "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtBox.Text += "9"
    End Sub

    Private Sub Comma_Click(sender As Object, e As EventArgs) Handles Comma.Click
        If txtBox.Text.Count = 0 Then
            txtBox.Text += "0,"
        Else
            txtBox.Text += "0"
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If txtBox.Text.Count > 0 Then
            txtBox.Text += "0"
        End If
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        choosenSign = "*"
        SignClicked()
    End Sub

    Private Sub Subtract_Click(sender As Object, e As EventArgs) Handles Subtract.Click
        choosenSign = "-"
        SignClicked()
    End Sub

    Private Sub Addition_Click(sender As Object, e As EventArgs) Handles Addition.Click
        choosenSign = "+"
        SignClicked()
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click
        choosenSign = "/"
        SignClicked()
    End Sub

    Private Sub SignClicked()
        lblOutput.Text = txtBox.Text
        firstNumber = Decimal.Parse(txtBox.Text)
        txtBox.Clear()
    End Sub

    Private Sub Equals_Click(sender As Object, e As EventArgs) Handles Equals.Click
        Dim results As String
        If txtBox.Text <> "" Then
            secondNumber = Decimal.Parse(txtBox.Text)
            Select Case choosenSign
                Case "*"
                    results = firstNumber * secondNumber
                Case "-"
                    results = firstNumber - secondNumber
                Case "+"
                    results = firstNumber + secondNumber
                Case "/"
                    If secondNumber = 0.0 Then
                        results = "Division By 0 Not Allowed."
                    Else
                        results = firstNumber / secondNumber
                    End If
                Case Else
                    results = "Invalid Operation."
            End Select
        End If

        If results <> "Invalid Operation." Then
            lblOutput.Text += $" {choosenSign} {secondNumber}"
            txtBox.Text = results
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = ""
        txtBox.Clear()
    End Sub
End Class
