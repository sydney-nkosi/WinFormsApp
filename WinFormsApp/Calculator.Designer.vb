<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Multiply = New Button()
        Subtract = New Button()
        Addition = New Button()
        Division = New Button()
        PlusMinus = New Button()
        Button0 = New Button()
        Comma = New Button()
        Equals = New Button()
        InputTextBox = New TextBox()
        OutputLabel = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(85, 153)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 25)
        Button1.TabIndex = 0
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(190, 153)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(78, 25)
        Button2.TabIndex = 1
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(299, 153)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(78, 25)
        Button3.TabIndex = 2
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(85, 115)
        Button4.Margin = New Padding(2)
        Button4.Name = "Button4"
        Button4.Size = New Size(78, 25)
        Button4.TabIndex = 3
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(190, 115)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(78, 25)
        Button5.TabIndex = 4
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(299, 115)
        Button6.Margin = New Padding(2)
        Button6.Name = "Button6"
        Button6.Size = New Size(78, 25)
        Button6.TabIndex = 5
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(85, 81)
        Button7.Margin = New Padding(2)
        Button7.Name = "Button7"
        Button7.Size = New Size(78, 25)
        Button7.TabIndex = 6
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(190, 81)
        Button8.Margin = New Padding(2)
        Button8.Name = "Button8"
        Button8.Size = New Size(78, 25)
        Button8.TabIndex = 7
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(299, 81)
        Button9.Margin = New Padding(2)
        Button9.Name = "Button9"
        Button9.Size = New Size(78, 25)
        Button9.TabIndex = 8
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Multiply
        ' 
        Multiply.Location = New Point(404, 81)
        Multiply.Margin = New Padding(2)
        Multiply.Name = "Multiply"
        Multiply.Size = New Size(78, 25)
        Multiply.TabIndex = 11
        Multiply.Text = "*"
        Multiply.UseVisualStyleBackColor = True
        ' 
        ' Subtract
        ' 
        Subtract.Location = New Point(404, 115)
        Subtract.Margin = New Padding(2)
        Subtract.Name = "Subtract"
        Subtract.Size = New Size(78, 25)
        Subtract.TabIndex = 10
        Subtract.Text = "-"
        Subtract.UseVisualStyleBackColor = True
        ' 
        ' Addition
        ' 
        Addition.Location = New Point(404, 153)
        Addition.Margin = New Padding(2)
        Addition.Name = "Addition"
        Addition.Size = New Size(78, 25)
        Addition.TabIndex = 9
        Addition.Text = "+"
        Addition.UseVisualStyleBackColor = True
        ' 
        ' Division
        ' 
        Division.Location = New Point(404, 192)
        Division.Margin = New Padding(2)
        Division.Name = "Division"
        Division.Size = New Size(78, 25)
        Division.TabIndex = 15
        Division.Text = "/"
        Division.UseVisualStyleBackColor = True
        ' 
        ' PlusMinus
        ' 
        PlusMinus.Location = New Point(299, 192)
        PlusMinus.Margin = New Padding(2)
        PlusMinus.Name = "PlusMinus"
        PlusMinus.Size = New Size(78, 25)
        PlusMinus.TabIndex = 14
        PlusMinus.Text = "+/-"
        PlusMinus.UseVisualStyleBackColor = True
        ' 
        ' Button0
        ' 
        Button0.Location = New Point(190, 192)
        Button0.Margin = New Padding(2)
        Button0.Name = "Button0"
        Button0.Size = New Size(78, 25)
        Button0.TabIndex = 13
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = True
        ' 
        ' Comma
        ' 
        Comma.Location = New Point(85, 192)
        Comma.Margin = New Padding(2)
        Comma.Name = "Comma"
        Comma.Size = New Size(78, 25)
        Comma.TabIndex = 12
        Comma.Text = ","
        Comma.UseVisualStyleBackColor = True
        ' 
        ' Equals
        ' 
        Equals.Location = New Point(86, 230)
        Equals.Name = "Equals"
        Equals.Size = New Size(396, 25)
        Equals.TabIndex = 16
        Equals.Text = "="
        Equals.UseVisualStyleBackColor = True
        ' 
        ' InputTextBox
        ' 
        InputTextBox.Location = New Point(85, 45)
        InputTextBox.Name = "InputTextBox"
        InputTextBox.Size = New Size(397, 23)
        InputTextBox.TabIndex = 17
        ' 
        ' OutputLabel
        ' 
        OutputLabel.AutoSize = True
        OutputLabel.Location = New Point(434, 19)
        OutputLabel.Name = "OutputLabel"
        OutputLabel.Size = New Size(0, 15)
        OutputLabel.TabIndex = 18
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 270)
        Controls.Add(OutputLabel)
        Controls.Add(InputTextBox)
        Controls.Add(Equals)
        Controls.Add(Division)
        Controls.Add(PlusMinus)
        Controls.Add(Button0)
        Controls.Add(Comma)
        Controls.Add(Multiply)
        Controls.Add(Subtract)
        Controls.Add(Addition)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Margin = New Padding(2)
        Name = "Calculator"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Multiply As Button
    Friend WithEvents Subtract As Button
    Friend WithEvents Addition As Button
    Friend WithEvents Division As Button
    Friend WithEvents PlusMinus As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Comma As Button
    Friend WithEvents Equals As Button
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents OutputLabel As Label
End Class
