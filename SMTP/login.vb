Imports System.Runtime.CompilerServices

Public Class login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim LoginID = txtLogin.Text
        Dim LoginPassword = txtPassword.Text

        Me.Hide()
        smtp.Show()

    End Sub

    'Move focus on enter key


    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtMsg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub


End Class