Public Class Profile
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim name As String
        Dim surname As String
        Dim gender As String
        Dim yearOfBirth As Integer
        Dim tribe As String

        name = txtName.Text
        surname = txtSurname.Text
        gender = listGender.SelectedItem.ToString.ToLower
        yearOfBirth = Integer.Parse(txtYearOfBirth.Text)
        tribe = txtTribe.Text.ToLower

        Dim greeting As String
        If tribe = "english" Then
            greeting = "Hello"
        ElseIf tribe = "sepedi" Or tribe = "tswana" Then
            greeting = "Dumela"
        ElseIf tribe = "isizulu" Or tribe = "zulu" Then
            greeting = "Sawubona"
        ElseIf tribe = "venda" Then
            greeting = "Ndaa!"
        ElseIf tribe = "tsonga" Then
            greeting = "Avuxeni"
        ElseIf tribe = "xhosa" Then
            greeting = "molo"
        Else
            greeting = ""
        End If

        Dim title As String
        If gender = "male" Then
            title = "gentleman"
        ElseIf gender = "female" Then
            title = "lady"
        Else
            title = "lady/gentleman"
        End If

        MsgBox($"{greeting} {name} {surname}. You are a {Date.Now.Year - yearOfBirth} year old {title} who speaks {tribe}.")

    End Sub

End Class