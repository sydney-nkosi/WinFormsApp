<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Messages
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
        Label1 = New Label()
        txtTitle = New TextBox()
        txtPart1 = New TextBox()
        Label2 = New Label()
        txtPart2 = New TextBox()
        Label3 = New Label()
        txtPart3 = New TextBox()
        Label4 = New Label()
        btnShowMessage = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 25)
        Label1.TabIndex = 0
        Label1.Text = "Title for Mesage"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(196, 52)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(456, 31)
        txtTitle.TabIndex = 1
        ' 
        ' txtPart1
        ' 
        txtPart1.Location = New Point(196, 146)
        txtPart1.Name = "txtPart1"
        txtPart1.Size = New Size(456, 31)
        txtPart1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(101, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 25)
        Label2.TabIndex = 2
        Label2.Text = "Part 1"
        ' 
        ' txtPart2
        ' 
        txtPart2.Location = New Point(196, 215)
        txtPart2.Name = "txtPart2"
        txtPart2.Size = New Size(456, 31)
        txtPart2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(101, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 25)
        Label3.TabIndex = 4
        Label3.Text = "Part 2"
        ' 
        ' txtPart3
        ' 
        txtPart3.Location = New Point(196, 290)
        txtPart3.Name = "txtPart3"
        txtPart3.Size = New Size(456, 31)
        txtPart3.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(101, 290)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 25)
        Label4.TabIndex = 6
        Label4.Text = "Part 3"
        ' 
        ' btnShowMessage
        ' 
        btnShowMessage.Location = New Point(197, 361)
        btnShowMessage.Name = "btnShowMessage"
        btnShowMessage.Size = New Size(455, 34)
        btnShowMessage.TabIndex = 8
        btnShowMessage.Text = "Show Message"
        btnShowMessage.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(334, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(180, 25)
        Label5.TabIndex = 9
        Label5.Text = "Parts Of the Message"
        ' 
        ' Messages
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(btnShowMessage)
        Controls.Add(txtPart3)
        Controls.Add(Label4)
        Controls.Add(txtPart2)
        Controls.Add(Label3)
        Controls.Add(txtPart1)
        Controls.Add(Label2)
        Controls.Add(txtTitle)
        Controls.Add(Label1)
        Name = "Messages"
        Text = "Messages"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtPart1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPart2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPart3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnShowMessage As Button
    Friend WithEvents Label5 As Label
End Class
