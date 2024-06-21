Imports System.Net.Http
Imports Newtonsoft.Json

Public Class viewSubmissions
    Public Sub New()
        InitializeComponent()
    End Sub

    Private currentIndex As Integer = 0

    Private Async Sub viewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "John Doe, Slidely Task 2 - View Submissions"
        Me.KeyPreview = True ' Enable key preview for form-level key events
        Await FetchAndDisplaySubmissionAsync(currentIndex)
    End Sub

    Private Async Function FetchAndDisplaySubmissionAsync(index As Integer) As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(json)
                DisplaySubmission(submission)
            Else
                MessageBox.Show("Error fetching submission")
            End If
        End Using
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        If submission IsNot Nothing Then
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGitHubLink.Text = submission.GitHubLink
            lblStopwatchTime.Text = submission.StopwatchTime
        Else
            MessageBox.Show("No submission data available")
        End If
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await FetchAndDisplaySubmissionAsync(currentIndex)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await FetchAndDisplaySubmissionAsync(currentIndex)
    End Sub

    Private Async Sub viewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            Await btnPrevious.PerformClickAsync()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Await btnNext.PerformClickAsync()
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class

Module ControlExtensions
    <System.Runtime.CompilerServices.Extension()>
    Public Async Function PerformClickAsync(button As Button) As Task
        button.PerformClick()
    End Function
End Module
