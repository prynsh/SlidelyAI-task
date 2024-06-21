<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewSubmissions
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
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHubLink = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGitHubLink = New System.Windows.Forms.Label()
        Me.lblStopwatchTime = New System.Windows.Forms.Label()
        Me.txtStopwatchTime = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Gold
        Me.btnPrevious.Location = New System.Drawing.Point(50, 250)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(138, 23)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "Previous(CTRL+P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnNext.Location = New System.Drawing.Point(206, 250)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(144, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next(CTRL+N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 22)
        Me.txtName.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 60)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 22)
        Me.txtEmail.TabIndex = 3
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(150, 100)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 22)
        Me.txtPhone.TabIndex = 4
        '
        'txtGitHubLink
        '
        Me.txtGitHubLink.Location = New System.Drawing.Point(150, 140)
        Me.txtGitHubLink.Name = "txtGitHubLink"
        Me.txtGitHubLink.Size = New System.Drawing.Size(200, 22)
        Me.txtGitHubLink.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(50, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 16)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(50, 60)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(44, 16)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(50, 100)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(100, 16)
        Me.lblPhone.TabIndex = 9
        Me.lblPhone.Text = "Phone Number:"
        '
        'lblGitHubLink
        '
        Me.lblGitHubLink.AutoSize = True
        Me.lblGitHubLink.Location = New System.Drawing.Point(50, 140)
        Me.lblGitHubLink.Name = "lblGitHubLink"
        Me.lblGitHubLink.Size = New System.Drawing.Size(78, 16)
        Me.lblGitHubLink.TabIndex = 10
        Me.lblGitHubLink.Text = "GitHub Link:"
        '
        'lblStopwatchTime
        '
        Me.lblStopwatchTime.AutoSize = True
        Me.lblStopwatchTime.Location = New System.Drawing.Point(50, 180)
        Me.lblStopwatchTime.Name = "lblStopwatchTime"
        Me.lblStopwatchTime.Size = New System.Drawing.Size(106, 16)
        Me.lblStopwatchTime.TabIndex = 11
        Me.lblStopwatchTime.Text = "Stopwatch Time:"
        '
        'txtStopwatchTime
        '
        Me.txtStopwatchTime.Location = New System.Drawing.Point(150, 180)
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.Size = New System.Drawing.Size(200, 22)
        Me.txtStopwatchTime.TabIndex = 6
        '
        'viewSubmissions
        '
        Me.ClientSize = New System.Drawing.Size(874, 518)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGitHubLink)
        Me.Controls.Add(Me.txtStopwatchTime)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblGitHubLink)
        Me.Controls.Add(Me.lblStopwatchTime)
        Me.Name = "viewSubmissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents lblStopwatchTime As Label
End Class
