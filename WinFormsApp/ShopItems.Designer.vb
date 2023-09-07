<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        txtPrice = New TextBox()
        txtDescription = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        listView = New ListBox()
        btnClearList = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(txtDescription)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(66, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(445, 150)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Item Details"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(130, 100)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(309, 31)
        txtPrice.TabIndex = 3
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(130, 50)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(309, 31)
        txtDescription.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(75, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 25)
        Label2.TabIndex = 1
        Label2.Text = "Price"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 25)
        Label1.TabIndex = 0
        Label1.Text = "Description"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(73, 227)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 34)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Enabled = False
        btnUpdate.Location = New Point(239, 227)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 34)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(393, 227)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' listView
        ' 
        listView.FormattingEnabled = True
        listView.ItemHeight = 25
        listView.Location = New Point(576, 41)
        listView.Name = "listView"
        listView.Size = New Size(434, 404)
        listView.TabIndex = 4
        ' 
        ' btnClearList
        ' 
        btnClearList.Location = New Point(576, 469)
        btnClearList.Name = "btnClearList"
        btnClearList.Size = New Size(434, 34)
        btnClearList.TabIndex = 5
        btnClearList.Text = "Clear List"
        btnClearList.UseVisualStyleBackColor = True
        ' 
        ' ShopItems
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1038, 518)
        Controls.Add(btnClearList)
        Controls.Add(listView)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(GroupBox1)
        Name = "ShopItems"
        Text = "Shop Items"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents listView As ListBox
    Friend WithEvents btnClearList As Button
End Class
