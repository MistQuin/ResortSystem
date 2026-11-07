Imports System.Windows

Public Class Form1
    Public adminUser As String = "admin"
    Public adminPass As String = "password"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Login"
        Me.StartPosition = FormStartPosition.CenterScreen
        txtPassword.UseSystemPasswordChar = True
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If adminPass = txtPassword.Text And adminUser = txtUsername.Text Then
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
