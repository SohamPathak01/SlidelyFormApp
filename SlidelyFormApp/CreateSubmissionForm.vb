Imports System.Net.Http

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub ViewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ButtonSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ButtonToggleStopwatch.PerformClick()
        End If
    End Sub


    Private Async Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Dim submission As New Submission With {
            .Name = TextBoxName.Text,
            .Email = TextBoxEmail.Text,
            .PhoneNum = TextBoxPhoneNum.Text,
            .GithubLink = TextBoxGithubLink.Text,
            .StopwatchTime = LabelStopwatch.Text
        }

        Dim response As HttpResponseMessage = Await ApiHelper.PostAsync("http://localhost:3000/submit", submission)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission successful!")
        Else
            MessageBox.Show("Error in submission.")
        End If
    End Sub

    Private Sub ButtonToggleStopwatch_Click(sender As Object, e As EventArgs) Handles ButtonToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch.Start()
        Timer1.Start()
    End Sub

    Private Sub LabelStopwatch_Click(sender As Object, e As EventArgs) Handles LabelStopwatch.Click

    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNum As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class
