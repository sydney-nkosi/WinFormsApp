Public Class DataTypeCheck
    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        Dim score As Integer

        If IsNumeric(txtMark.Text) Then
            score = Integer.Parse(txtMark.Text)
        Else
            MsgBox("Please enter a number.")
            Exit Sub
        End If

        If score < 0 And score > 100 Then
            MsgBox("Invalid mark.")
        ElseIf score < 50 Then
            MsgBox("Failed")
        ElseIf score >= 50 And score < 75 Then
            MsgBox("Passed")
        ElseIf score >= 75 Then
            MsgBox("Passed with distiction")
        End If
    End Sub
End Class