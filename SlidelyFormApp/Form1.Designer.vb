<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1

    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonViewSubmissions = New System.Windows.Forms.Button()
        Me.ButtonCreateSubmission = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonViewSubmissions
        '
        Me.ButtonViewSubmissions.BackColor = System.Drawing.Color.Khaki
        Me.ButtonViewSubmissions.ForeColor = System.Drawing.Color.Black
        Me.ButtonViewSubmissions.Location = New System.Drawing.Point(12, 12)
        Me.ButtonViewSubmissions.Name = "ButtonViewSubmissions"
        Me.ButtonViewSubmissions.Size = New System.Drawing.Size(260, 50)
        Me.ButtonViewSubmissions.TabIndex = 0
        Me.ButtonViewSubmissions.Text = "View Submissions (ctrl+V)"
        Me.ButtonViewSubmissions.UseVisualStyleBackColor = False
        '
        'ButtonCreateSubmission
        '
        Me.ButtonCreateSubmission.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonCreateSubmission.Location = New System.Drawing.Point(12, 68)
        Me.ButtonCreateSubmission.Name = "ButtonCreateSubmission"
        Me.ButtonCreateSubmission.Size = New System.Drawing.Size(260, 50)
        Me.ButtonCreateSubmission.TabIndex = 1
        Me.ButtonCreateSubmission.Text = "Create New Submission"
        Me.ButtonCreateSubmission.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(284, 131)
        Me.Controls.Add(Me.ButtonCreateSubmission)
        Me.Controls.Add(Me.ButtonViewSubmissions)
        Me.Name = "Form1"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonViewSubmissions As Button
    Friend WithEvents ButtonCreateSubmission As Button
End Class
