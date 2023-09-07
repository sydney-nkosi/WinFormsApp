<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataTypeCheck
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
        txtMark = New TextBox()
        Label1 = New Label()
        btnResults = New Button()
        SuspendLayout()
        ' 
        ' txtMark
        ' 
        txtMark.Location = New Point(222, 134)
        txtMark.Name = "txtMark"
        txtMark.Size = New Size(220, 31)
        txtMark.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(103, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter Mark"
        ' 
        ' btnResults
        ' 
        btnResults.Location = New Point(229, 208)
        btnResults.Name = "btnResults"
        btnResults.Size = New Size(213, 34)
        btnResults.TabIndex = 2
        btnResults.Text = "Show Results"
        btnResults.UseVisualStyleBackColor = True
        ' 
        ' DataTypeCheck
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnResults)
        Controls.Add(Label1)
        Controls.Add(txtMark)
        Name = "DataTypeCheck"
        Text = "DataTypeCheck"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtMark As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnResults As Button
End Class
