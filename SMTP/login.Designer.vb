<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        lblLogin = New Label()
        lblPassword = New Label()
        txtLogin = New TextBox()
        txtPassword = New TextBox()
        btnlogin = New Button()
        SuspendLayout()
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Location = New Point(83, 46)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(64, 30)
        lblLogin.TabIndex = 0
        lblLogin.Text = "Login"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(83, 122)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(99, 30)
        lblPassword.TabIndex = 0
        lblPassword.Text = "Password"
        ' 
        ' txtLogin
        ' 
        txtLogin.Location = New Point(207, 41)
        txtLogin.Name = "txtLogin"
        txtLogin.Size = New Size(248, 35)
        txtLogin.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(207, 117)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(248, 35)
        txtPassword.TabIndex = 2
        ' 
        ' btnlogin
        ' 
        btnlogin.Location = New Point(243, 185)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(179, 39)
        btnlogin.TabIndex = 3
        btnlogin.Text = "Log In"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(576, 236)
        Controls.Add(btnlogin)
        Controls.Add(txtPassword)
        Controls.Add(txtLogin)
        Controls.Add(lblPassword)
        Controls.Add(lblLogin)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnlogin As Button
End Class
