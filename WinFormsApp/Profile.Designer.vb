<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        lblName = New Label()
        lblSurname = New Label()
        lblGender = New Label()
        txtName = New TextBox()
        txtSurname = New TextBox()
        btnDisplay = New Button()
        listGender = New ListBox()
        txtTribe = New TextBox()
        txtYearOfBirth = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(97, 22)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Location = New Point(83, 67)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(54, 15)
        lblSurname.TabIndex = 1
        lblSurname.Text = "Surname"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(92, 181)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(45, 15)
        lblGender.TabIndex = 2
        lblGender.Text = "Gender"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(179, 23)
        txtName.Name = "txtName"
        txtName.Size = New Size(178, 23)
        txtName.TabIndex = 3
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(179, 62)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(178, 23)
        txtSurname.TabIndex = 4
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Location = New Point(179, 300)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(177, 23)
        btnDisplay.TabIndex = 6
        btnDisplay.Text = "Your Small Bio"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' listGender
        ' 
        listGender.FormattingEnabled = True
        listGender.ItemHeight = 15
        listGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        listGender.Location = New Point(179, 181)
        listGender.Name = "listGender"
        listGender.Size = New Size(178, 94)
        listGender.TabIndex = 7
        ' 
        ' txtTribe
        ' 
        txtTribe.Location = New Point(179, 140)
        txtTribe.Name = "txtTribe"
        txtTribe.Size = New Size(178, 23)
        txtTribe.TabIndex = 11
        ' 
        ' txtYearOfBirth
        ' 
        txtYearOfBirth.Location = New Point(179, 101)
        txtYearOfBirth.Name = "txtYearOfBirth"
        txtYearOfBirth.Size = New Size(178, 23)
        txtYearOfBirth.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(83, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 9
        Label1.Text = "Tribe"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 8
        Label2.Text = "Year of Birth"
        ' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 369)
        Controls.Add(txtTribe)
        Controls.Add(txtYearOfBirth)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(listGender)
        Controls.Add(btnDisplay)
        Controls.Add(txtSurname)
        Controls.Add(txtName)
        Controls.Add(lblGender)
        Controls.Add(lblSurname)
        Controls.Add(lblName)
        Name = "Profile"
        Text = "Profile"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents listGender As ListBox
    Friend WithEvents txtTribe As TextBox
    Friend WithEvents txtYearOfBirth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
