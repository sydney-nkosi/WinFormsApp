Imports System.DirectoryServices

Public Class ShopItems
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        listView.Items.Add($"{txtDescription.Text}{ControlChars.Tab}{ControlChars.Tab}{txtPrice.Text}")
        txtDescription.Clear()
        txtPrice.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            listView.Items.Remove(listView.SelectedItem)
            MessageBox.Show("Item deleted.", "Confirmation", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub listView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listView.SelectedIndexChanged
        txtDescription.Text = listView.SelectedItem
        txtPrice.Text = listView.SelectedItem
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        listView.Items.Clear()
    End Sub
End Class