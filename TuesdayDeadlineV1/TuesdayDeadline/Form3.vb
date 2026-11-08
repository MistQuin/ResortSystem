Public Class Form3

    ' ================= DATA (stored in lists) =================
    Dim rooms As New List(Of Room)
    Dim bookings As New List(Of Booking)
    Dim occupants As New List(Of Customer)   ' occupants of the booking being made
    Dim nextBookingId As Integer = 1001
    Dim selectedBookingId As Integer = 0     ' booking clicked in the Bookings table
    Dim isReady As Boolean = False           ' becomes True when the form is done loading

    Const EXTRA_FEE As Integer = 500         ' extra person per night
    Const MAX_PEOPLE As Integer = 7

    ' ================= FORM LOAD =================
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed

        ' tables
        SetupTable(dgvShow, {"Name", "Age", "Sex", "Minor", "Fee"})
        SetupTable(dgvRoomShow, {"Room", "Type", "Capacity", "Features", "Price/night"})
        SetupTable(dgvBillingRoom, {"ID", "Guest", "Room", "Stay", "Pax", "Total", "Status"})

        ' Book Room page
        cmbSex.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSex.Items.Add("Male")
        cmbSex.Items.Add("Female")
        cmbSex.SelectedIndex = 0
        cmbAvailableRoom.DropDownStyle = ComboBoxStyle.DropDownList
        dtpBirthday.MaxDate = Date.Today
        dtpCheckin.MinDate = Date.Today
        dtpCheckout.MinDate = Date.Today.AddDays(1)
        dtpCheckin.Value = Date.Today
        dtpCheckout.Value = Date.Today.AddDays(1)

        ' Room Search page
        cmbType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbType.Items.Add("Any")
        cmbType.Items.Add("Single")
        cmbType.Items.Add("Double")
        cmbType.Items.Add("Family")
        cmbType.SelectedIndex = 0
        nudMin.Maximum = MAX_PEOPLE
        nudMax.Maximum = 1000000
        nudMax.Increment = 100
        radAvailable.AutoCheck = False      ' we turn it on/off ourselves (see radAvailable_Click)
        dtpStart.Value = Date.Today
        dtpEnd.Value = Date.Today.AddDays(1)

        ' Billing page
        cmbApprovedBooking.DropDownStyle = ComboBoxStyle.DropDownList
        nudAmount.Maximum = 10000000
        nudAmount.Increment = 100

        AddSampleData()

        isReady = True
        RefreshHome()
        LoadAvailableRooms()
        RunRoomSearch()
        LoadBookingsGrid()
        ShowBooking()
        LoadApprovedBookings()
        lblCustomerView.Text = "Enter your booking ID and click View my booking."
    End Sub

    ' ================= NAVIGATION =================
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

    ' refresh a page every time its tab is opened
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If Not isReady Then Return
        If TabControl1.SelectedIndex = 0 Then RefreshHome()
        If TabControl1.SelectedIndex = 1 Then LoadAvailableRooms()
        If TabControl1.SelectedIndex = 2 Then RunRoomSearch()
        If TabControl1.SelectedIndex = 3 Then LoadBookingsGrid()
        If TabControl1.SelectedIndex = 5 Then LoadApprovedBookings()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub

    ' ================= SAMPLE DATA =================
    Private Sub AddSampleData()
        ' rooms: number, type, capacity, price per night, features
        rooms.Add(New Room("101", "Single", 1, 1500, "Aircon, Single bed, TV"))
        rooms.Add(New Room("102", "Single", 1, 1500, "Aircon, Single bed, Garden view"))
        rooms.Add(New Room("103", "Single", 1, 1600, "Aircon, Single bed, Desk"))
        rooms.Add(New Room("201", "Double", 2, 2500, "Aircon, Double bed, TV, Mini fridge"))
        rooms.Add(New Room("202", "Double", 2, 2500, "Aircon, Double bed, Sea view"))
        rooms.Add(New Room("203", "Double", 2, 2800, "Aircon, Double bed, Sea view, Mini bar"))
        rooms.Add(New Room("301", "Family", 5, 4500, "Aircon, 2 beds, TV, Kitchenette"))
        rooms.Add(New Room("302", "Family", 5, 5000, "Aircon, 2 beds, Sea view, Balcony"))

        ' sample booking 1 (Approved)
        Dim list1 As New List(Of Customer)
        list1.Add(New Customer("Maria Santos", Date.Today.AddYears(-36), "Female", "San Fernando, Pampanga"))
        list1.Add(New Customer("Leo Santos", Date.Today.AddYears(-4), "Male", "San Fernando, Pampanga"))
        CreateBooking(FindRoom("201"), list1, Date.Today, Date.Today.AddDays(2), "Approved")

        ' sample booking 2 (Pending)
        Dim list2 As New List(Of Customer)
        list2.Add(New Customer("Juan Dela Cruz", Date.Today.AddYears(-28), "Male", "Angeles City"))
        CreateBooking(FindRoom("101"), list2, Date.Today.AddDays(1), Date.Today.AddDays(3), "Pending")
    End Sub

    ' ================= HELPER FUNCTIONS =================
    Private Sub SetupTable(g As DataGridView, headers() As String)
        g.Columns.Clear()
        For Each h As String In headers
            g.Columns.Add(h, h)
        Next
        g.ReadOnly = True
        g.AllowUserToAddRows = False
        g.RowHeadersVisible = False
        g.MultiSelect = False
        g.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Function Peso(amount As Integer) As String
        Return "P" & amount.ToString("N0")
    End Function

    Private Function FindRoom(number As String) As Room
        For Each r As Room In rooms
            If r.Number = number Then Return r
        Next
        Return Nothing
    End Function

    Private Function FindBooking(id As Integer) As Booking
        For Each b As Booking In bookings
            If b.Id = id Then Return b
        Next
        Return Nothing
    End Function

    ' a room is free if no Pending/Approved booking overlaps the dates
    Private Function IsRoomFree(r As Room, checkIn As Date, checkOut As Date) As Boolean
        For Each b As Booking In bookings
            If b.RoomNumber = r.Number AndAlso (b.Status = "Pending" OrElse b.Status = "Approved") Then
                If checkIn < b.CheckOut AndAlso checkOut > b.CheckIn Then Return False
            End If
        Next
        Return True
    End Function

    ' children aged 7 and below are free, so only count the paying guests
    Private Function CountPaying(list As List(Of Customer)) As Integer
        Dim count As Integer = 0
        For Each c As Customer In list
            If c.GetAge() > 7 Then count += 1
        Next
        Return count
    End Function

    Private Function CountNights(checkIn As Date, checkOut As Date) As Integer
        Dim nights As Integer = CInt((checkOut.Date - checkIn.Date).TotalDays)
        If nights < 1 Then nights = 1
        Return nights
    End Function

    ' people over the room capacity pay extra
    Private Function CountExtra(r As Room, list As List(Of Customer)) As Integer
        Dim extra As Integer = CountPaying(list) - r.Capacity
        If extra < 0 Then extra = 0
        Return extra
    End Function

    ' make a booking, compute its price, and save it in the list
    Private Function CreateBooking(r As Room, list As List(Of Customer), checkIn As Date, checkOut As Date, status As String) As Booking
        Dim b As New Booking
        b.Id = nextBookingId
        nextBookingId += 1
        b.RoomNumber = r.Number
        b.Occupants = New List(Of Customer)(list)
        b.CheckIn = checkIn
        b.CheckOut = checkOut
        b.Status = status
        b.Nights = CountNights(checkIn, checkOut)
        b.ExtraPersons = CountExtra(r, list)
        b.Total = (b.Nights * r.PricePerNight) + (b.ExtraPersons * EXTRA_FEE * b.Nights)
        bookings.Add(b)
        Return b
    End Function

    ' the booking text used in Bookings, Customer View and Billing
    Private Function GetDetails(b As Booking, showMoney As Boolean) As String
        Dim r As Room = FindRoom(b.RoomNumber)
        Dim s As String = "Booking #" & b.Id & "   Status: " & b.Status & vbCrLf
        s &= "Room: " & r.Number & " (" & r.RoomType & ", capacity " & r.Capacity & ")" & vbCrLf
        s &= "Features: " & r.Features & vbCrLf
        s &= "Stay: " & b.CheckIn.ToString("yyyy-MM-dd") & " to " & b.CheckOut.ToString("yyyy-MM-dd") & " (" & b.Nights & " night/s)" & vbCrLf
        s &= "Occupants:" & vbCrLf
        For Each o As Customer In b.Occupants
            s &= "  - " & o.Name & ", " & o.GetAge() & " y/o, " & o.Sex
            If o.GetAge() < 18 Then s &= " [Minor]"
            If o.GetAge() <= 7 Then s &= " [Free]"
            s &= vbCrLf
        Next
        s &= "Address: " & b.Occupants(0).Address
        If showMoney Then
            s &= vbCrLf & "-----------------------------" & vbCrLf
            s &= "Room charge: " & b.Nights & " x " & Peso(r.PricePerNight) & " = " & Peso(b.Nights * r.PricePerNight) & vbCrLf
            s &= "Extra persons: " & b.ExtraPersons & " x P500 x " & b.Nights & " = " & Peso(b.ExtraPersons * EXTRA_FEE * b.Nights) & vbCrLf
            s &= "TOTAL: " & Peso(b.Total)
        End If
        Return s
    End Function

    ' ================= HOME =================
    ' guests and occupied rooms come from the Approved bookings
    Private Sub RefreshHome()
        Dim guests, males, females, children, elders, occupiedRooms As Integer

        For Each b As Booking In bookings
            If b.Status = "Approved" Then
                For Each o As Customer In b.Occupants
                    guests += 1
                    If o.Sex = "Male" Then males += 1
                    If o.Sex = "Female" Then females += 1
                    If o.GetAge() < 18 Then children += 1
                    If o.GetAge() >= 60 Then elders += 1
                Next
            End If
        Next

        For Each r As Room In rooms
            For Each b As Booking In bookings
                If b.RoomNumber = r.Number AndAlso b.Status = "Approved" Then
                    occupiedRooms += 1
                    Exit For
                End If
            Next
        Next

        lblGuest.Text = guests.ToString()
        lblMales.Text = males.ToString()
        lblFemales.Text = females.ToString()
        lblChildren.Text = children.ToString()
        lblElderies.Text = elders.ToString()
        lblTotalRooms.Text = rooms.Count.ToString()
        lblOccupiedRooms.Text = occupiedRooms.ToString()
        lblAvailableRooms.Text = (rooms.Count - occupiedRooms).ToString()
    End Sub

    ' ================= BOOK ROOM =================
    Private Sub btnAddOccupant_Click(sender As Object, e As EventArgs) Handles btnAddOccupant.Click
        If txtName.Text.Trim() = "" OrElse txtAddress.Text.Trim() = "" Then
            MessageBox.Show("Please fill in the name and address.")
            Return
        End If
        If occupants.Count >= MAX_PEOPLE Then
            MessageBox.Show("A room can hold up to 7 people only.")
            Return
        End If

        Dim c As New Customer(txtName.Text.Trim(), dtpBirthday.Value.Date, cmbSex.Text, txtAddress.Text.Trim())

        ' the first occupant is the primary guest and must be an adult
        If occupants.Count = 0 AndAlso c.GetAge() < 18 Then
            MessageBox.Show("The first occupant (primary guest) must be 18 or older.")
            Return
        End If

        occupants.Add(c)
        txtName.Clear()
        txtName.Focus()
        ShowOccupants()
        UpdateSummary()
    End Sub

    ' double-click a row in the occupants table to remove that person
    Private Sub dgvShow_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShow.CellDoubleClick
        If e.RowIndex < 0 Then Return
        If MessageBox.Show("Remove " & occupants(e.RowIndex).Name & "?", "Remove", MessageBoxButtons.YesNo) = DialogResult.No Then Return
        If e.RowIndex = 0 AndAlso occupants.Count > 1 AndAlso occupants(1).GetAge() < 18 Then
            MessageBox.Show("Remove the other occupants first. The primary guest must be 18 or older.")
            Return
        End If
        occupants.RemoveAt(e.RowIndex)
        ShowOccupants()
        UpdateSummary()
    End Sub

    Private Sub ShowOccupants()
        dgvShow.Rows.Clear()
        For i As Integer = 0 To occupants.Count - 1
            Dim o As Customer = occupants(i)
            Dim name As String = o.Name
            If i = 0 Then name &= " (primary)"
            Dim minor As String = "False"
            If o.GetAge() < 18 Then minor = "True"
            Dim fee As String = "Regular"
            If o.GetAge() <= 7 Then fee = "Free"
            dgvShow.Rows.Add(name, o.GetAge(), o.Sex, minor, fee)
        Next
    End Sub

    Private Sub dtpCheckin_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckin.ValueChanged
        If Not isReady Then Return
        ' check-out must be at least 1 day after check-in
        If dtpCheckout.Value.Date <= dtpCheckin.Value.Date Then
            dtpCheckout.Value = dtpCheckin.Value.Date.AddDays(1)
        End If
        LoadAvailableRooms()
    End Sub

    Private Sub dtpCheckout_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckout.ValueChanged
        If Not isReady Then Return
        LoadAvailableRooms()
    End Sub

    Private Sub cmbAvailableRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAvailableRoom.SelectedIndexChanged
        If Not isReady Then Return
        UpdateSummary()
    End Sub

    ' fill the room combo box with the rooms that are free on the chosen dates
    Private Sub LoadAvailableRooms()
        cmbAvailableRoom.Items.Clear()
        For Each r As Room In rooms
            If IsRoomFree(r, dtpCheckin.Value.Date, dtpCheckout.Value.Date) Then
                cmbAvailableRoom.Items.Add(r)
            End If
        Next
        If cmbAvailableRoom.Items.Count > 0 Then cmbAvailableRoom.SelectedIndex = 0
        UpdateSummary()
    End Sub

    Private Sub UpdateSummary()
        Dim r As Room = TryCast(cmbAvailableRoom.SelectedItem, Room)
        If r Is Nothing OrElse occupants.Count = 0 Then
            lblSummary.Text = "Add occupants and pick an available room to see the price."
            Return
        End If

        Dim nights As Integer = CountNights(dtpCheckin.Value, dtpCheckout.Value)
        Dim extra As Integer = CountExtra(r, occupants)
        Dim roomCharge As Integer = nights * r.PricePerNight
        Dim extraCharge As Integer = extra * EXTRA_FEE * nights

        lblSummary.Text = "Nights: " & nights & "   Occupants: " & occupants.Count & vbCrLf &
                          "Room: " & Peso(roomCharge) & "   Extra persons: " & extra & " x P500 x " & nights & " = " & Peso(extraCharge) & vbCrLf &
                          "TOTAL: " & Peso(roomCharge + extraCharge)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim r As Room = TryCast(cmbAvailableRoom.SelectedItem, Room)

        If occupants.Count = 0 Then
            MessageBox.Show("Add at least one occupant.")
            Return
        End If
        If r Is Nothing Then
            MessageBox.Show("No available room selected.")
            Return
        End If
        If dtpCheckout.Value.Date <= dtpCheckin.Value.Date Then
            MessageBox.Show("Check-out must be after check-in.")
            Return
        End If

        Dim b As Booking = CreateBooking(r, occupants, dtpCheckin.Value.Date, dtpCheckout.Value.Date, "Pending")

        occupants.Clear()
        txtName.Clear()
        txtAddress.Clear()
        ShowOccupants()
        LoadAvailableRooms()
        RefreshHome()
        MessageBox.Show("Request submitted. Booking ID: " & b.Id & " (" & Peso(b.Total) & "). Awaiting approval.")
    End Sub

    ' ================= ROOM SEARCH =================
    ' a RadioButton cannot be un-checked by clicking, so we switch it ourselves
    Private Sub radAvailable_Click(sender As Object, e As EventArgs) Handles radAvailable.Click
        radAvailable.Checked = Not radAvailable.Checked
        RunRoomSearch()
    End Sub

    ' any filter that changes runs the search again
    Private Sub Filter_Changed(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged, nudMin.ValueChanged,
            nudMax.ValueChanged, txtFeature.TextChanged, dtpStart.ValueChanged, dtpEnd.ValueChanged
        RunRoomSearch()
    End Sub

    Private Sub RunRoomSearch()
        If Not isReady Then Return
        If dtpEnd.Value.Date <= dtpStart.Value.Date Then
            dtpEnd.Value = dtpStart.Value.Date.AddDays(1)
        End If

        dgvRoomShow.Rows.Clear()
        For Each r As Room In rooms
            Dim show As Boolean = True

            If cmbType.Text <> "Any" AndAlso r.RoomType <> cmbType.Text Then show = False
            If r.Capacity < nudMin.Value Then show = False
            If nudMax.Value > 0 AndAlso r.PricePerNight > nudMax.Value Then show = False
            If txtFeature.Text.Trim() <> "" Then
                If Not r.Features.ToLower().Contains(txtFeature.Text.Trim().ToLower()) Then show = False
            End If
            If radAvailable.Checked Then
                If Not IsRoomFree(r, dtpStart.Value.Date, dtpEnd.Value.Date) Then show = False
            End If

            If show Then
                dgvRoomShow.Rows.Add(r.Number, r.RoomType, r.Capacity, r.Features, Peso(r.PricePerNight))
            End If
        Next
    End Sub

    ' ================= BOOKINGS (details + approval) =================
    Private Sub LoadBookingsGrid()
        dgvBillingRoom.Rows.Clear()
        ' newest booking first
        For i As Integer = bookings.Count - 1 To 0 Step -1
            Dim b As Booking = bookings(i)
            dgvBillingRoom.Rows.Add(b.Id, b.Occupants(0).Name, b.RoomNumber,
                                    b.CheckIn.ToString("MMM dd") & " to " & b.CheckOut.ToString("MMM dd"),
                                    b.Occupants.Count, Peso(b.Total), b.Status)
        Next

        ' highlight the selected booking again
        dgvBillingRoom.ClearSelection()
        For Each row As DataGridViewRow In dgvBillingRoom.Rows
            If CInt(row.Cells(0).Value) = selectedBookingId Then row.Selected = True
        Next
    End Sub

    ' clicking a row selects that booking
    Private Sub dgvBillingRoom_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBillingRoom.CellClick
        If e.RowIndex < 0 Then Return
        selectedBookingId = CInt(dgvBillingRoom.Rows(e.RowIndex).Cells(0).Value)
        ShowBooking()
    End Sub

    ' Approve/Reject show only for Pending. Go to Billing shows only for Approved.
    Private Sub ShowBooking()
        Dim b As Booking = FindBooking(selectedBookingId)

        btnApprove.Visible = False
        btnReject.Visible = False
        btnGoBilling.Visible = False

        If b Is Nothing Then
            lblSummary1.Text = "Select a booking to see its details."
            Return
        End If

        If b.Status = "Pending" Then
            btnApprove.Visible = True
            btnReject.Visible = True
        End If
        If b.Status = "Approved" Then
            btnGoBilling.Visible = True
        End If
        lblSummary1.Text = GetDetails(b, True)
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        SetStatus("Approved")
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        SetStatus("Rejected")
    End Sub

    Private Sub SetStatus(newStatus As String)
        Dim b As Booking = FindBooking(selectedBookingId)
        If b Is Nothing Then Return
        b.Status = newStatus
        LoadBookingsGrid()
        ShowBooking()
        RefreshHome()
        MessageBox.Show("Booking #" & b.Id & " is now " & newStatus & ".")
    End Sub

    Private Sub btnGoBilling_Click(sender As Object, e As EventArgs) Handles btnGoBilling.Click
        TabControl1.SelectedIndex = 5      ' this also loads the approved bookings

        ' pick the booking we came from
        For i As Integer = 0 To cmbApprovedBooking.Items.Count - 1
            Dim b As Booking = DirectCast(cmbApprovedBooking.Items(i), Booking)
            If b.Id = selectedBookingId Then cmbApprovedBooking.SelectedIndex = i
        Next
    End Sub

    ' ================= CUSTOMER VIEW =================
    Private Sub btnViewBooking_Click(sender As Object, e As EventArgs) Handles btnViewBooking.Click
        Dim id As Integer
        If Not Integer.TryParse(txtBookingID.Text.Trim(), id) Then
            lblCustomerView.Text = "Please enter a valid booking ID (numbers only)."
            Return
        End If

        Dim b As Booking = FindBooking(id)
        If b Is Nothing Then
            lblCustomerView.Text = "No booking found with that ID."
            Return
        End If

        Dim s As String = GetDetails(b, False) & vbCrLf & "Estimated total: " & Peso(b.Total)
        If b.Status = "Pending" Then s &= vbCrLf & vbCrLf & "Your request is awaiting approval by the resort."
        If b.Status = "Rejected" Then s &= vbCrLf & vbCrLf & "Sorry, your request was not approved."
        lblCustomerView.Text = s
    End Sub

    ' ================= BILLING AND PAYMENT =================
    Private Sub LoadApprovedBookings()
        cmbApprovedBooking.Items.Clear()
        For Each b As Booking In bookings
            If b.Status = "Approved" Then cmbApprovedBooking.Items.Add(b)
        Next
        If cmbApprovedBooking.Items.Count > 0 Then cmbApprovedBooking.SelectedIndex = 0
        ShowBilling()
    End Sub

    Private Sub cmbApprovedBooking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbApprovedBooking.SelectedIndexChanged
        If Not isReady Then Return
        ShowBilling()
    End Sub

    Private Sub ShowBilling()
        Dim b As Booking = TryCast(cmbApprovedBooking.SelectedItem, Booking)

        If b Is Nothing Then
            lblBillingSummary.Text = "No approved bookings awaiting checkout."
            nudAmount.Value = 0
            lblChange.Text = "P0"
            btnPay.Enabled = False
            btnQR.Enabled = False
            Return
        End If

        btnPay.Enabled = True
        btnQR.Enabled = True
        lblBillingSummary.Text = GetDetails(b, True)
        nudAmount.Value = b.Total
        UpdateChange()
    End Sub

    Private Sub nudAmount_ValueChanged(sender As Object, e As EventArgs) Handles nudAmount.ValueChanged
        If Not isReady Then Return
        UpdateChange()
    End Sub

    ' live change
    Private Sub UpdateChange()
        Dim b As Booking = TryCast(cmbApprovedBooking.SelectedItem, Booking)
        If b Is Nothing Then
            lblChange.Text = "P0"
            Return
        End If

        Dim difference As Integer = CInt(nudAmount.Value) - b.Total
        If difference >= 0 Then
            lblChange.Text = Peso(difference)
        Else
            lblChange.Text = Peso(-difference)
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim b As Booking = TryCast(cmbApprovedBooking.SelectedItem, Booking)
        If b Is Nothing Then Return

        If nudAmount.Value < b.Total Then
            MessageBox.Show("Payment is less than the total bill.")
            Return
        End If

        Dim change As Integer = CInt(nudAmount.Value) - b.Total
        b.Status = "Completed"
        MessageBox.Show("Paid. Booking #" & b.Id & " checked out." & vbCrLf & "Change: " & Peso(change))

        LoadApprovedBookings()
        LoadBookingsGrid()
        ShowBooking()
        RefreshHome()
    End Sub

    ' fake online payment using message boxes
    Private Sub btnQR_Click(sender As Object, e As EventArgs) Handles btnQR.Click
        Dim b As Booking = TryCast(cmbApprovedBooking.SelectedItem, Booking)
        If b Is Nothing Then
            MessageBox.Show("Select an approved booking first.")
            Return
        End If

        MessageBox.Show("QR code generated for Booking #" & b.Id & vbCrLf &
                        "Guest: " & b.Occupants(0).Name & vbCrLf &
                        "Amount: " & Peso(b.Total) & vbCrLf & vbCrLf &
                        "Scanning QR code... redirecting to online payment (GCash demo).")

        MessageBox.Show("Online payment successful (demo)." & vbCrLf & "Amount paid: " & Peso(b.Total))

        nudAmount.Value = b.Total
    End Sub
End Class


' ================= CLASSES (keep these below the Form3 class) =================
Public Class Customer
    Public Name As String
    Public Birthday As Date
    Public Sex As String
    Public Address As String

    Public Sub New(n As String, b As Date, s As String, a As String)
        Name = n
        Birthday = b
        Sex = s
        Address = a
    End Sub

    ' age from the birthday
    Public Function GetAge() As Integer
        Dim age As Integer = Date.Today.Year - Birthday.Year
        If Birthday.Date > Date.Today.AddYears(-age) Then age -= 1
        Return age
    End Function
End Class

Public Class Room
    Public Number As String
    Public RoomType As String
    Public Capacity As Integer
    Public PricePerNight As Integer
    Public Features As String

    Public Sub New(n As String, t As String, c As Integer, p As Integer, f As String)
        Number = n
        RoomType = t
        Capacity = c
        PricePerNight = p
        Features = f
    End Sub

    ' text shown in the Available Room combo box
    Public Overrides Function ToString() As String
        Return Number & " | " & RoomType & " | cap " & Capacity & " | P" & PricePerNight.ToString("N0")
    End Function
End Class

Public Class Booking
    Public Id As Integer
    Public RoomNumber As String
    Public Occupants As New List(Of Customer)
    Public CheckIn As Date
    Public CheckOut As Date
    Public Status As String          ' Pending, Approved, Rejected or Completed
    Public Nights As Integer
    Public ExtraPersons As Integer
    Public Total As Integer

    ' text shown in the Approved Booking combo box
    Public Overrides Function ToString() As String
        Return "#" & Id & " - " & Occupants(0).Name & " - Room " & RoomNumber
    End Function
End Class