Public Class Form2
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form title
        Me.Text = "Main Menu"

        ' Set KeyPreview to true to capture key events at the form level
        Me.KeyPreview = True
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ' Open the form to view submissions (assuming it exists and is named ViewSubmissionsForm)
        Dim viewSubmissionsForm As New viewSubmissions()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        ' Open the form to create a new submission (assuming it exists and is named SubmissionForm)
        Dim submissionForm As New Form1()
        submissionForm.Show()
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateNewSubmission.PerformClick()
        End If
    End Sub
End Class
