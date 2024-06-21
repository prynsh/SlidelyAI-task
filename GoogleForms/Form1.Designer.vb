<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnStartPause = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHubLink = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGitHubLink = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(250, 190)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(55, 16)
        Me.lblStopwatch.TabIndex = 0
        Me.lblStopwatch.Text = "00:00:00"
        '
        'btnStartPause
        '
        Me.btnStartPause.BackColor = System.Drawing.Color.Gold
        Me.btnStartPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartPause.Location = New System.Drawing.Point(50, 185)
        Me.btnStartPause.Name = "btnStartPause"
        Me.btnStartPause.Size = New System.Drawing.Size(180, 23)
        Me.btnStartPause.TabIndex = 1
        Me.btnStartPause.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnStartPause.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSubmit.Location = New System.Drawing.Point(53, 230)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(277, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 22)
        Me.txtName.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 60)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 22)
        Me.txtEmail.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(150, 100)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 22)
        Me.txtPhone.TabIndex = 5
        '
        'txtGitHubLink
        '
        Me.txtGitHubLink.Location = New System.Drawing.Point(150, 140)
        Me.txtGitHubLink.Name = "txtGitHubLink"
        Me.txtGitHubLink.Size = New System.Drawing.Size(200, 22)
        Me.txtGitHubLink.TabIndex = 6
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
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.btnStartPause)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGitHubLink)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblGitHubLink)
        Me.Name = "Form1"
        Me.Text = "John Doe, Slidely Task 2 - Create Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnStartPause As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents Timer1 As Timer
End Class
