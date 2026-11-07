Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub btnBookRoom_Click(sender As Object, e As EventArgs) Handles btnBookRoom.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnRoomSearch_Click(sender As Object, e As EventArgs) Handles btnRoomSearch.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub btnCustomerView_Click(sender As Object, e As EventArgs) Handles btnCustomerView.Click
        TabControl1.SelectedIndex = 4
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        TabControl1.SelectedIndex = 5
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
        Form1.txtUsername.Clear()
        Form1.txtPassword.Clear()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub
End Class