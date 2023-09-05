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
        txtGender = New TextBox()
        txtSurname = New TextBox()
        btnDisplay = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(97, 88)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Location = New Point(83, 136)
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
        txtName.Location = New Point(179, 89)
        txtName.Name = "txtName"
        txtName.Size = New Size(178, 23)
        txtName.TabIndex = 3
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(179, 173)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(178, 23)
        txtGender.TabIndex = 5
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(179, 128)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(178, 23)
        txtSurname.TabIndex = 4
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Location = New Point(180, 226)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(177, 23)
        btnDisplay.TabIndex = 6
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 369)
        Controls.Add(btnDisplay)
        Controls.Add(txtSurname)
        Controls.Add(txtGender)
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
End Class
