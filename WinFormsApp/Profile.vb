Public Class Profile
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim name As String
        Dim surname As String
        Dim gender As String

        name = txtName.Text
        surname = txtSurname.Text
        gender = txtGender.Text

        MsgBox($"Hello {name} {surname} it is good to know you are a {gender}.")


    End Sub
End Class