Imports System.Net.Mail

Public Class smtp
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            'save the login gmail credentials from login form
            Dim loginID = login.txtLogin.Text
            Dim loginPass = login.txtPassword.Text


            ' Create a new MailMessage object
            Dim mail As New MailMessage()
            mail.From = New MailAddress(txtSender.Text)
            mail.To.Add(txtReceiver.Text)
            mail.Subject = txtSubject.Text
            mail.Body = txtMsg.Text

            ' Configure the SMTP client for Gmail
            Dim smtpClient As New SmtpClient("smtp.gmail.com")
            smtpClient.Port = 587
            smtpClient.Credentials = New Net.NetworkCredential(loginID, loginPass)
            smtpClient.EnableSsl = True

            ' Send the email
            smtpClient.Send(mail)

            ' Show a message box when the email is successfully sent
            MessageBox.Show("Email sent successfully!")

        Catch ex As Exception
            ' Show an error message if something goes wrong
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles lblLogIn.Click
        login.Show()
    End Sub

    Private Sub smtp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSender.Text = login.txtLogin.Text

    End Sub


    Private Sub txtSender_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSender.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtReceiver.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtReceiver_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReceiver.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSubject.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtSubject_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSubject.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtReceiver.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtMsg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMsg.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtReceiver.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    'Private Sub txtSend_KeyDown(sender As Object, e As KeyEventArgs) Handles .KeyDown
    'If e.KeyCode = Keys.Enter Then
    '       txtReceiver.Focus()
    '       e.SuppressKeyPress = True
    'End If
    'End Sub
End Class
