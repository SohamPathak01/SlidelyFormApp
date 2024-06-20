<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonToggleStopwatch = New System.Windows.Forms.Button()
        Me.LabelStopwatch = New System.Windows.Forms.Label()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxPhoneNum = New System.Windows.Forms.TextBox()
        Me.TextBoxGithubLink = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonToggleStopwatch
        '
        Me.ButtonToggleStopwatch.BackColor = System.Drawing.Color.Khaki
        Me.ButtonToggleStopwatch.Location = New System.Drawing.Point(108, 311)
        Me.ButtonToggleStopwatch.Name = "ButtonToggleStopwatch"
        Me.ButtonToggleStopwatch.Size = New System.Drawing.Size(113, 39)
        Me.ButtonToggleStopwatch.TabIndex = 0
        Me.ButtonToggleStopwatch.Text = "Start/Stop (&T)"
        Me.ButtonToggleStopwatch.UseVisualStyleBackColor = False
        '
        'LabelStopwatch
        '
        Me.LabelStopwatch.AutoSize = True
        Me.LabelStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LabelStopwatch.Location = New System.Drawing.Point(512, 321)
        Me.LabelStopwatch.Name = "LabelStopwatch"
        Me.LabelStopwatch.Size = New System.Drawing.Size(111, 29)
        Me.LabelStopwatch.TabIndex = 1
        Me.LabelStopwatch.Text = "00:00:00"
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonSubmit.Location = New System.Drawing.Point(309, 388)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(123, 57)
        Me.ButtonSubmit.TabIndex = 2
        Me.ButtonSubmit.Text = "Submit (&S)"
        Me.ButtonSubmit.UseVisualStyleBackColor = False
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxName.Location = New System.Drawing.Point(400, 68)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(260, 26)
        Me.TextBoxName.TabIndex = 3
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxEmail.Location = New System.Drawing.Point(400, 121)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(260, 26)
        Me.TextBoxEmail.TabIndex = 4
        '
        'TextBoxPhoneNum
        '
        Me.TextBoxPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxPhoneNum.Location = New System.Drawing.Point(400, 169)
        Me.TextBoxPhoneNum.Name = "TextBoxPhoneNum"
        Me.TextBoxPhoneNum.Size = New System.Drawing.Size(260, 26)
        Me.TextBoxPhoneNum.TabIndex = 5
        '
        'TextBoxGithubLink
        '
        Me.TextBoxGithubLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxGithubLink.Location = New System.Drawing.Point(400, 236)
        Me.TextBoxGithubLink.Name = "TextBoxGithubLink"
        Me.TextBoxGithubLink.Size = New System.Drawing.Size(260, 26)
        Me.TextBoxGithubLink.TabIndex = 6
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(38, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(38, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(38, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "MobileNo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(38, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "GitHub"
        '
        'CreateSubmissionForm
        '
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(748, 552)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxGithubLink)
        Me.Controls.Add(Me.TextBoxPhoneNum)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.ButtonSubmit)
        Me.Controls.Add(Me.LabelStopwatch)
        Me.Controls.Add(Me.ButtonToggleStopwatch)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create New Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonToggleStopwatch As Button
    Friend WithEvents LabelStopwatch As Label
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPhoneNum As TextBox
    Friend WithEvents TextBoxGithubLink As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
