Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private currentSubmission As Submission

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub ViewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ButtonPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ButtonNext.PerformClick()
        End If
    End Sub

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Dim response As HttpResponseMessage = Await ApiHelper.GetAsync($"http://localhost:3000/read?index={index}")
        If response.IsSuccessStatusCode Then
            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
            Dim submissions As List(Of Submission) = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
            If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
                currentSubmission = submissions(0)
                DisplaySubmission()
            Else
                MessageBox.Show("No submission found.")
            End If
        Else
            MessageBox.Show("Error retrieving submissions.")
        End If
    End Function

    Private Sub DisplaySubmission()
        If currentSubmission IsNot Nothing Then
            LabelName.Text = "Name: "
            TextBoxName.Text = currentSubmission.Name
            LabelEmail.Text = "Email: "
            TextBoxEmail.Text = currentSubmission.Email
            LabelPhoneNum.Text = "Phone Number: "
            TextBoxNo.Text = currentSubmission.PhoneNum
            LabelGithubLink.Text = "GitHub Link: "
            TextBoxGH.Text = currentSubmission.GithubLink
            LabelStopwatchTime.Text = "Stopwatch Time: "
            TextBoxST.Text = currentSubmission.StopwatchTime
        End If
    End Sub

    Private Async Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        currentIndex += 1
        Await LoadSubmission(currentIndex)
    End Sub
End Class
