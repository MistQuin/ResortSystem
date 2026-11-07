Imports System.Windows

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.Text = ""
        Me.StartPosition = FormStartPosition.CenterScreen
        ProgressBar1.Value = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 2
        Else
            Timer1.Stop()
            Me.Hide()
            Form3.Show()
        End If
    End Sub
End Class