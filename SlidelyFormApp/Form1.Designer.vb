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
        Me.ButtonViewSubmissions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonViewSubmissions.ForeColor = System.Drawing.Color.Black
        Me.ButtonViewSubmissions.Location = New System.Drawing.Point(303, 114)
        Me.ButtonViewSubmissions.Name = "ButtonViewSubmissions"
        Me.ButtonViewSubmissions.Size = New System.Drawing.Size(354, 50)
        Me.ButtonViewSubmissions.TabIndex = 0
        Me.ButtonViewSubmissions.Text = "View Submissions (ctrl+V)"
        Me.ButtonViewSubmissions.UseVisualStyleBackColor = False
        '
        'ButtonCreateSubmission
        '
        Me.ButtonCreateSubmission.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonCreateSubmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonCreateSubmission.Location = New System.Drawing.Point(303, 234)
        Me.ButtonCreateSubmission.Name = "ButtonCreateSubmission"
        Me.ButtonCreateSubmission.Size = New System.Drawing.Size(354, 50)
        Me.ButtonCreateSubmission.TabIndex = 1
        Me.ButtonCreateSubmission.Text = "Create New Submission (ctrl+N)"
        Me.ButtonCreateSubmission.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(924, 400)
        Me.Controls.Add(Me.ButtonCreateSubmission)
        Me.Controls.Add(Me.ButtonViewSubmissions)
        Me.Name = "Form1"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonViewSubmissions As Button
    Friend WithEvents ButtonCreateSubmission As Button
End Class
