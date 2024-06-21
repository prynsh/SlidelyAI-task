Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1
    Private stopwatch As New Stopwatch()
    Private WithEvents Timer As New Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "John Doe, Slidely Task 2 - Create Submission"
        Timer.Interval = 1000 ' Update every second
        Me.KeyPreview = True
    End Sub

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GitHubLink As String
        Public Property StopwatchTime As String
    End Class

    Private Sub btnStartPause_Click(sender As Object, e As EventArgs) Handles btnStartPause.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            Timer.Stop()
        Else
            stopwatch.Start()
            Timer.Start()
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission() With {
        .Name = txtName.Text,
        .Email = txtEmail.Text,
        .Phone = txtPhone.Text,
        .GitHubLink = txtGitHubLink.Text,
        .StopwatchTime = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    }
        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful")
                Else
                    Dim errorContent As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show("Error submitting form: " & response.ReasonPhrase & " - " & errorContent)
                End If
            Catch ex As Exception
                MessageBox.Show("Exception: " & ex.Message)
            End Try
        End Using
    End Sub




    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnStartPause.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub
End Class
