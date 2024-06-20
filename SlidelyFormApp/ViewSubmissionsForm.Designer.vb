<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelPhoneNum = New System.Windows.Forms.Label()
        Me.LabelGithubLink = New System.Windows.Forms.Label()
        Me.LabelStopwatchTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.BackColor = System.Drawing.Color.Khaki
        Me.ButtonPrevious.Location = New System.Drawing.Point(15, 337)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(203, 49)
        Me.ButtonPrevious.TabIndex = 0
        Me.ButtonPrevious.Text = "Previous (ctrl+P)"
        Me.ButtonPrevious.UseVisualStyleBackColor = False
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonNext.Location = New System.Drawing.Point(392, 337)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(181, 49)
        Me.ButtonNext.TabIndex = 1
        Me.ButtonNext.Text = "Next (ctrl+N)"
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LabelName.Location = New System.Drawing.Point(24, 49)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(88, 29)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Name:"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LabelEmail.Location = New System.Drawing.Point(22, 99)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(85, 29)
        Me.LabelEmail.TabIndex = 3
        Me.LabelEmail.Text = "Email:"
        '
        'LabelPhoneNum
        '
        Me.LabelPhoneNum.AutoSize = True
        Me.LabelPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LabelPhoneNum.Location = New System.Drawing.Point(20, 148)
        Me.LabelPhoneNum.Name = "LabelPhoneNum"
        Me.LabelPhoneNum.Size = New System.Drawing.Size(190, 29)
        Me.LabelPhoneNum.TabIndex = 4
        Me.LabelPhoneNum.Text = "Phone Number:"
        '
        'LabelGithubLink
        '
        Me.LabelGithubLink.AutoSize = True
        Me.LabelGithubLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LabelGithubLink.Location = New System.Drawing.Point(18, 202)
        Me.LabelGithubLink.Name = "LabelGithubLink"
        Me.LabelGithubLink.Size = New System.Drawing.Size(152, 29)
        Me.LabelGithubLink.TabIndex = 5
        Me.LabelGithubLink.Text = "GitHub Link:"
        '
        'LabelStopwatchTime
        '
        Me.LabelStopwatchTime.AutoSize = True
        Me.LabelStopwatchTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LabelStopwatchTime.Location = New System.Drawing.Point(16, 258)
        Me.LabelStopwatchTime.Name = "LabelStopwatchTime"
        Me.LabelStopwatchTime.Size = New System.Drawing.Size(202, 29)
        Me.LabelStopwatchTime.TabIndex = 6
        Me.LabelStopwatchTime.Text = "Stopwatch Time:"
        '
        'ViewSubmissionsForm
        '
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(643, 467)
        Me.Controls.Add(Me.LabelStopwatchTime)
        Me.Controls.Add(Me.LabelGithubLink)
        Me.Controls.Add(Me.LabelPhoneNum)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPhoneNum As Label
    Friend WithEvents LabelGithubLink As Label
    Friend WithEvents LabelStopwatchTime As Label
End Class
