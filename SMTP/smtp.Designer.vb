<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class smtp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtSender = New TextBox()
        txtReceiver = New TextBox()
        lblSender = New Label()
        lblReceiver = New Label()
        txtMsg = New TextBox()
        lblMessage = New Label()
        btnSend = New Button()
        lblLogIn = New Button()
        txtSubject = New TextBox()
        lblSubject = New Label()
        SuspendLayout()
        ' 
        ' txtSender
        ' 
        txtSender.Location = New Point(128, 55)
        txtSender.Name = "txtSender"
        txtSender.Size = New Size(422, 35)
        txtSender.TabIndex = 1
        ' 
        ' txtReceiver
        ' 
        txtReceiver.Location = New Point(128, 108)
        txtReceiver.Name = "txtReceiver"
        txtReceiver.Size = New Size(422, 35)
        txtReceiver.TabIndex = 2
        ' 
        ' lblSender
        ' 
        lblSender.AutoSize = True
        lblSender.Location = New Point(24, 58)
        lblSender.Name = "lblSender"
        lblSender.Size = New Size(77, 30)
        lblSender.TabIndex = 1
        lblSender.Text = "Sender"
        ' 
        ' lblReceiver
        ' 
        lblReceiver.AutoSize = True
        lblReceiver.Location = New Point(24, 111)
        lblReceiver.Name = "lblReceiver"
        lblReceiver.Size = New Size(90, 30)
        lblReceiver.TabIndex = 1
        lblReceiver.Text = "Receiver"
        ' 
        ' txtMsg
        ' 
        txtMsg.Location = New Point(128, 234)
        txtMsg.Multiline = True
        txtMsg.Name = "txtMsg"
        txtMsg.Size = New Size(525, 197)
        txtMsg.TabIndex = 4
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Location = New Point(24, 234)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(95, 30)
        lblMessage.TabIndex = 1
        lblMessage.Text = "Message"
        ' 
        ' btnSend
        ' 
        btnSend.Location = New Point(670, 274)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(118, 50)
        btnSend.TabIndex = 5
        btnSend.Text = "Send"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' lblLogIn
        ' 
        lblLogIn.Location = New Point(694, 26)
        lblLogIn.Name = "lblLogIn"
        lblLogIn.Size = New Size(94, 49)
        lblLogIn.TabIndex = 6
        lblLogIn.Text = "Log in"
        lblLogIn.UseVisualStyleBackColor = True
        ' 
        ' txtSubject
        ' 
        txtSubject.Location = New Point(128, 165)
        txtSubject.Name = "txtSubject"
        txtSubject.Size = New Size(422, 35)
        txtSubject.TabIndex = 3
        ' 
        ' lblSubject
        ' 
        lblSubject.AutoSize = True
        lblSubject.Location = New Point(24, 168)
        lblSubject.Name = "lblSubject"
        lblSubject.Size = New Size(81, 30)
        lblSubject.TabIndex = 1
        lblSubject.Text = "Subject"
        lblSubject.TextAlign = ContentAlignment.TopCenter
        ' 
        ' smtp
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblLogIn)
        Controls.Add(btnSend)
        Controls.Add(lblMessage)
        Controls.Add(lblSubject)
        Controls.Add(lblReceiver)
        Controls.Add(txtMsg)
        Controls.Add(txtSubject)
        Controls.Add(lblSender)
        Controls.Add(txtReceiver)
        Controls.Add(txtSender)
        MaximizeBox = False
        Name = "smtp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SMTP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSender As TextBox
    Friend WithEvents txtReceiver As TextBox
    Friend WithEvents lblSender As Label
    Friend WithEvents lblReceiver As Label
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents lblLogIn As Button
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents lblSubject As Label
End Class
