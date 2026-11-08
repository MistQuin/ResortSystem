<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        btnLogout = New Button()
        btnBilling = New Button()
        btnCustomerView = New Button()
        btnBookings = New Button()
        btnRoomSearch = New Button()
        btnBookRoom = New Button()
        btnHome = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label30 = New Label()
        Panel3 = New Panel()
        Panel9 = New Panel()
        lblAvailableRooms = New Label()
        Label11 = New Label()
        Panel8 = New Panel()
        Label10 = New Label()
        lblOccupiedRooms = New Label()
        lblTotalRooms = New Label()
        Label9 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        Panel7 = New Panel()
        lblElderies = New Label()
        Label8 = New Label()
        Panel6 = New Panel()
        Label7 = New Label()
        lblChildren = New Label()
        Panel5 = New Panel()
        Label6 = New Label()
        lblFemales = New Label()
        Panel4 = New Panel()
        Label5 = New Label()
        lblMales = New Label()
        Label2 = New Label()
        lblGuest = New Label()
        Label3 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        Panel12 = New Panel()
        lblSummary = New Label()
        Label35 = New Label()
        btnSubmit = New Button()
        Panel11 = New Panel()
        Label34 = New Label()
        Label16 = New Label()
        dtpCheckin = New DateTimePicker()
        Label17 = New Label()
        cmbAvailableRoom = New ComboBox()
        dtpCheckout = New DateTimePicker()
        Label18 = New Label()
        Panel10 = New Panel()
        Label33 = New Label()
        Label12 = New Label()
        txtName = New TextBox()
        Label13 = New Label()
        cmbSex = New ComboBox()
        Label14 = New Label()
        dtpBirthday = New DateTimePicker()
        Label15 = New Label()
        txtAddress = New TextBox()
        btnAddOccupant = New Button()
        dgvShow = New DataGridView()
        Label32 = New Label()
        Label31 = New Label()
        TabPage3 = New TabPage()
        dgvRoomShow = New DataGridView()
        Panel13 = New Panel()
        Label39 = New Label()
        Label38 = New Label()
        cmbType = New ComboBox()
        dtpEnd = New DateTimePicker()
        Label22 = New Label()
        Label19 = New Label()
        nudMin = New NumericUpDown()
        dtpStart = New DateTimePicker()
        radAvailable = New RadioButton()
        nudMax = New NumericUpDown()
        txtFeature = New TextBox()
        Label20 = New Label()
        Label21 = New Label()
        Label37 = New Label()
        Label36 = New Label()
        TabPage4 = New TabPage()
        dgvBillingRoom = New DataGridView()
        lblSummary1 = New Label()
        btnGoBilling = New Button()
        btnReject = New Button()
        btnApprove = New Button()
        Label23 = New Label()
        TabPage5 = New TabPage()
        Panel15 = New Panel()
        lblCustomerView = New Label()
        Panel14 = New Panel()
        txtBookingID = New TextBox()
        Label25 = New Label()
        btnViewBooking = New Button()
        Label41 = New Label()
        Label40 = New Label()
        TabPage6 = New TabPage()
        Panel18 = New Panel()
        btnQR = New Button()
        Label46 = New Label()
        Panel17 = New Panel()
        Label45 = New Label()
        Label44 = New Label()
        Label43 = New Label()
        nudAmount = New NumericUpDown()
        btnPay = New Button()
        Label28 = New Label()
        lblChange = New Label()
        Panel16 = New Panel()
        Label42 = New Label()
        cmbApprovedBooking = New ComboBox()
        Label27 = New Label()
        lblBillingSummary = New Label()
        Label24 = New Label()
        Label26 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel9.SuspendLayout()
        Panel8.SuspendLayout()
        Panel2.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel12.SuspendLayout()
        Panel11.SuspendLayout()
        Panel10.SuspendLayout()
        CType(dgvShow, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgvRoomShow, ComponentModel.ISupportInitialize).BeginInit()
        Panel13.SuspendLayout()
        CType(nudMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMax, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        CType(dgvBillingRoom, ComponentModel.ISupportInitialize).BeginInit()
        TabPage5.SuspendLayout()
        Panel15.SuspendLayout()
        Panel14.SuspendLayout()
        TabPage6.SuspendLayout()
        Panel18.SuspendLayout()
        Panel17.SuspendLayout()
        CType(nudAmount, ComponentModel.ISupportInitialize).BeginInit()
        Panel16.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(11), CByte(37), CByte(69))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnBilling)
        Panel1.Controls.Add(btnCustomerView)
        Panel1.Controls.Add(btnBookings)
        Panel1.Controls.Add(btnRoomSearch)
        Panel1.Controls.Add(btnBookRoom)
        Panel1.Controls.Add(btnHome)
        Panel1.Location = New Point(-5, -6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(204, 657)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.Nompass_mainlogo
        PictureBox1.Location = New Point(17, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(164, 107)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.Location = New Point(15, 593)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(70, 52)
        btnLogout.TabIndex = 7
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnBilling
        ' 
        btnBilling.BackColor = SystemColors.ControlLightLight
        btnBilling.FlatStyle = FlatStyle.Flat
        btnBilling.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnBilling.Image = CType(resources.GetObject("btnBilling.Image"), Image)
        btnBilling.ImageAlign = ContentAlignment.MiddleLeft
        btnBilling.Location = New Point(15, 446)
        btnBilling.Name = "btnBilling"
        btnBilling.Size = New Size(173, 52)
        btnBilling.TabIndex = 6
        btnBilling.Text = "BILLING"
        btnBilling.UseVisualStyleBackColor = False
        ' 
        ' btnCustomerView
        ' 
        btnCustomerView.BackColor = SystemColors.ControlLightLight
        btnCustomerView.FlatStyle = FlatStyle.Flat
        btnCustomerView.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnCustomerView.Image = CType(resources.GetObject("btnCustomerView.Image"), Image)
        btnCustomerView.ImageAlign = ContentAlignment.MiddleLeft
        btnCustomerView.Location = New Point(15, 388)
        btnCustomerView.Name = "btnCustomerView"
        btnCustomerView.Size = New Size(173, 52)
        btnCustomerView.TabIndex = 5
        btnCustomerView.Text = "     CUSTOMER VIEW"
        btnCustomerView.UseVisualStyleBackColor = False
        ' 
        ' btnBookings
        ' 
        btnBookings.BackColor = SystemColors.ControlLightLight
        btnBookings.FlatStyle = FlatStyle.Flat
        btnBookings.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnBookings.Image = CType(resources.GetObject("btnBookings.Image"), Image)
        btnBookings.ImageAlign = ContentAlignment.MiddleLeft
        btnBookings.Location = New Point(15, 330)
        btnBookings.Name = "btnBookings"
        btnBookings.Size = New Size(173, 52)
        btnBookings.TabIndex = 4
        btnBookings.Text = " BOOKINGS"
        btnBookings.UseVisualStyleBackColor = False
        ' 
        ' btnRoomSearch
        ' 
        btnRoomSearch.BackColor = SystemColors.ControlLightLight
        btnRoomSearch.FlatStyle = FlatStyle.Flat
        btnRoomSearch.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnRoomSearch.Image = CType(resources.GetObject("btnRoomSearch.Image"), Image)
        btnRoomSearch.ImageAlign = ContentAlignment.MiddleLeft
        btnRoomSearch.Location = New Point(15, 272)
        btnRoomSearch.Name = "btnRoomSearch"
        btnRoomSearch.Size = New Size(173, 52)
        btnRoomSearch.TabIndex = 3
        btnRoomSearch.Text = "  ROOM SEARCH"
        btnRoomSearch.UseVisualStyleBackColor = False
        ' 
        ' btnBookRoom
        ' 
        btnBookRoom.BackColor = SystemColors.ControlLightLight
        btnBookRoom.FlatStyle = FlatStyle.Flat
        btnBookRoom.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnBookRoom.Image = CType(resources.GetObject("btnBookRoom.Image"), Image)
        btnBookRoom.ImageAlign = ContentAlignment.MiddleLeft
        btnBookRoom.Location = New Point(15, 214)
        btnBookRoom.Name = "btnBookRoom"
        btnBookRoom.Size = New Size(173, 52)
        btnBookRoom.TabIndex = 2
        btnBookRoom.Text = "BOOK ROOM"
        btnBookRoom.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = SystemColors.ControlLightLight
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnHome.Image = CType(resources.GetObject("btnHome.Image"), Image)
        btnHome.ImageAlign = ContentAlignment.MiddleLeft
        btnHome.Location = New Point(15, 156)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(173, 52)
        btnHome.TabIndex = 1
        btnHome.Text = "HOME"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Controls.Add(TabPage6)
        TabControl1.Location = New Point(191, -6)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(627, 657)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(250))
        TabPage1.Controls.Add(Label30)
        TabPage1.Controls.Add(Panel3)
        TabPage1.Controls.Add(Panel2)
        TabPage1.Controls.Add(Label1)
        TabPage1.ForeColor = SystemColors.ControlText
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(619, 629)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Location = New Point(17, 48)
        Label30.Name = "Label30"
        Label30.Size = New Size(219, 15)
        Label30.TabIndex = 5
        Label30.Text = "Guests and room availability at a glance."
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Panel9)
        Panel3.Controls.Add(Panel8)
        Panel3.Controls.Add(lblTotalRooms)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(310, 96)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(289, 297)
        Panel3.TabIndex = 4
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(219), CByte(244), CByte(230))
        Panel9.Controls.Add(lblAvailableRooms)
        Panel9.Controls.Add(Label11)
        Panel9.Location = New Point(147, 152)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(131, 64)
        Panel9.TabIndex = 10
        ' 
        ' lblAvailableRooms
        ' 
        lblAvailableRooms.AutoSize = True
        lblAvailableRooms.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        lblAvailableRooms.Location = New Point(7, 33)
        lblAvailableRooms.Name = "lblAvailableRooms"
        lblAvailableRooms.Size = New Size(22, 24)
        lblAvailableRooms.TabIndex = 7
        lblAvailableRooms.Text = "6"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(7, 10)
        Label11.Name = "Label11"
        Label11.Size = New Size(95, 15)
        Label11.TabIndex = 4
        Label11.Text = "Available Rooms"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(250))
        Panel8.Controls.Add(Label10)
        Panel8.Controls.Add(lblOccupiedRooms)
        Panel8.Location = New Point(10, 152)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(131, 64)
        Panel8.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(7, 10)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 15)
        Label10.TabIndex = 3
        Label10.Text = "Occupied Rooms"
        ' 
        ' lblOccupiedRooms
        ' 
        lblOccupiedRooms.AutoSize = True
        lblOccupiedRooms.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        lblOccupiedRooms.Location = New Point(7, 33)
        lblOccupiedRooms.Name = "lblOccupiedRooms"
        lblOccupiedRooms.Size = New Size(22, 24)
        lblOccupiedRooms.TabIndex = 6
        lblOccupiedRooms.Text = "1"
        ' 
        ' lblTotalRooms
        ' 
        lblTotalRooms.AutoSize = True
        lblTotalRooms.Font = New Font("Arial", 24F, FontStyle.Bold)
        lblTotalRooms.Location = New Point(16, 91)
        lblTotalRooms.Name = "lblTotalRooms"
        lblTotalRooms.Size = New Size(35, 37)
        lblTotalRooms.TabIndex = 5
        lblTotalRooms.Text = "7"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(48, 108)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 15)
        Label9.TabIndex = 2
        Label9.Text = "Total Rooms"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        Label4.Location = New Point(39, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 24)
        Label4.TabIndex = 1
        Label4.Text = "Rooms"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(lblGuest)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(12, 96)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(289, 297)
        Panel2.TabIndex = 3
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(250))
        Panel7.Controls.Add(lblElderies)
        Panel7.Controls.Add(Label8)
        Panel7.Location = New Point(147, 222)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(131, 64)
        Panel7.TabIndex = 10
        ' 
        ' lblElderies
        ' 
        lblElderies.AutoSize = True
        lblElderies.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        lblElderies.Location = New Point(7, 33)
        lblElderies.Name = "lblElderies"
        lblElderies.Size = New Size(34, 24)
        lblElderies.TabIndex = 11
        lblElderies.Text = "10"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(7, 10)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 15)
        Label8.TabIndex = 6
        Label8.Text = "Elderies"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(250))
        Panel6.Controls.Add(Label7)
        Panel6.Controls.Add(lblChildren)
        Panel6.Location = New Point(10, 222)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(131, 64)
        Panel6.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(7, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 15)
        Label7.TabIndex = 5
        Label7.Text = "Children"
        ' 
        ' lblChildren
        ' 
        lblChildren.AutoSize = True
        lblChildren.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        lblChildren.Location = New Point(7, 33)
        lblChildren.Name = "lblChildren"
        lblChildren.Size = New Size(34, 24)
        lblChildren.TabIndex = 10
        lblChildren.Text = "10"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(250))
        Panel5.Controls.Add(Label6)
        Panel5.Controls.Add(lblFemales)
        Panel5.Location = New Point(147, 152)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(131, 64)
        Panel5.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 15)
        Label6.TabIndex = 4
        Label6.Text = "Females"
        ' 
        ' lblFemales
        ' 
        lblFemales.AutoSize = True
        lblFemales.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        lblFemales.Location = New Point(7, 33)
        lblFemales.Name = "lblFemales"
        lblFemales.Size = New Size(34, 24)
        lblFemales.TabIndex = 9
        lblFemales.Text = "10"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(250))
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(lblMales)
        Panel4.Location = New Point(10, 152)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(131, 64)
        Panel4.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(7, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 15)
        Label5.TabIndex = 3
        Label5.Text = "Males"
        ' 
        ' lblMales
        ' 
        lblMales.AutoSize = True
        lblMales.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMales.Location = New Point(7, 33)
        lblMales.Name = "lblMales"
        lblMales.Size = New Size(34, 24)
        lblMales.TabIndex = 8
        lblMales.Text = "10"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(39, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 24)
        Label2.TabIndex = 1
        Label2.Text = "Guests"
        ' 
        ' lblGuest
        ' 
        lblGuest.AutoSize = True
        lblGuest.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGuest.Location = New Point(16, 91)
        lblGuest.Name = "lblGuest"
        lblGuest.Size = New Size(53, 37)
        lblGuest.TabIndex = 7
        lblGuest.Text = "10"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(65, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 2
        Label3.Text = "No. of Guests"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 21.75F, FontStyle.Bold)
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 34)
        Label1.TabIndex = 0
        Label1.Text = "OVERVIEW"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(250))
        TabPage2.Controls.Add(Panel12)
        TabPage2.Controls.Add(btnSubmit)
        TabPage2.Controls.Add(Panel11)
        TabPage2.Controls.Add(Panel10)
        TabPage2.Controls.Add(dgvShow)
        TabPage2.Controls.Add(Label32)
        TabPage2.Controls.Add(Label31)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(619, 629)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(11), CByte(38), CByte(68))
        Panel12.Controls.Add(lblSummary)
        Panel12.Controls.Add(Label35)
        Panel12.Location = New Point(370, 316)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(231, 145)
        Panel12.TabIndex = 19
        ' 
        ' lblSummary
        ' 
        lblSummary.ForeColor = SystemColors.Control
        lblSummary.Location = New Point(17, 48)
        lblSummary.Name = "lblSummary"
        lblSummary.Size = New Size(205, 70)
        lblSummary.TabIndex = 19
        lblSummary.Text = "Add occupants and pick an available room to see the price." & vbCrLf & "s" & vbCrLf & "s"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        Label35.ForeColor = SystemColors.Control
        Label35.Location = New Point(17, 13)
        Label35.Name = "Label35"
        Label35.Size = New Size(196, 24)
        Label35.TabIndex = 15
        Label35.Text = "Booking Summary"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(61), CByte(79), CByte(19))
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = SystemColors.Control
        btnSubmit.Location = New Point(370, 467)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(231, 41)
        btnSubmit.TabIndex = 17
        btnSubmit.Text = "Submit Booking Request"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.White
        Panel11.Controls.Add(Label34)
        Panel11.Controls.Add(Label16)
        Panel11.Controls.Add(dtpCheckin)
        Panel11.Controls.Add(Label17)
        Panel11.Controls.Add(cmbAvailableRoom)
        Panel11.Controls.Add(dtpCheckout)
        Panel11.Controls.Add(Label18)
        Panel11.Location = New Point(370, 84)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(231, 216)
        Panel11.TabIndex = 3
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        Label34.Location = New Point(13, 9)
        Label34.Name = "Label34"
        Label34.Size = New Size(54, 24)
        Label34.TabIndex = 9
        Label34.Text = "Stay"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(13, 43)
        Label16.Name = "Label16"
        Label16.Size = New Size(55, 15)
        Label16.TabIndex = 9
        Label16.Text = "Check-in"
        ' 
        ' dtpCheckin
        ' 
        dtpCheckin.Location = New Point(13, 61)
        dtpCheckin.Name = "dtpCheckin"
        dtpCheckin.Size = New Size(204, 23)
        dtpCheckin.TabIndex = 10
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(13, 96)
        Label17.Name = "Label17"
        Label17.Size = New Size(63, 15)
        Label17.TabIndex = 11
        Label17.Text = "Check-out"
        ' 
        ' cmbAvailableRoom
        ' 
        cmbAvailableRoom.FormattingEnabled = True
        cmbAvailableRoom.Location = New Point(13, 170)
        cmbAvailableRoom.Name = "cmbAvailableRoom"
        cmbAvailableRoom.Size = New Size(204, 23)
        cmbAvailableRoom.TabIndex = 14
        ' 
        ' dtpCheckout
        ' 
        dtpCheckout.Location = New Point(13, 114)
        dtpCheckout.Name = "dtpCheckout"
        dtpCheckout.Size = New Size(204, 23)
        dtpCheckout.TabIndex = 12
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(13, 152)
        Label18.Name = "Label18"
        Label18.Size = New Size(90, 15)
        Label18.TabIndex = 13
        Label18.Text = "Available Room"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.White
        Panel10.Controls.Add(Label33)
        Panel10.Controls.Add(Label12)
        Panel10.Controls.Add(txtName)
        Panel10.Controls.Add(Label13)
        Panel10.Controls.Add(cmbSex)
        Panel10.Controls.Add(Label14)
        Panel10.Controls.Add(dtpBirthday)
        Panel10.Controls.Add(Label15)
        Panel10.Controls.Add(txtAddress)
        Panel10.Controls.Add(btnAddOccupant)
        Panel10.Location = New Point(17, 84)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(347, 262)
        Panel10.TabIndex = 2
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        Label33.Location = New Point(13, 9)
        Label33.Name = "Label33"
        Label33.Size = New Size(180, 24)
        Label33.TabIndex = 0
        Label33.Text = "Occupant details"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(13, 43)
        Label12.Name = "Label12"
        Label12.Size = New Size(39, 15)
        Label12.TabIndex = 0
        Label12.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(13, 61)
        txtName.Name = "txtName"
        txtName.Size = New Size(318, 23)
        txtName.TabIndex = 1
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(13, 96)
        Label13.Name = "Label13"
        Label13.Size = New Size(51, 15)
        Label13.TabIndex = 2
        Label13.Text = "Birthday"
        ' 
        ' cmbSex
        ' 
        cmbSex.FormattingEnabled = True
        cmbSex.Location = New Point(217, 114)
        cmbSex.Name = "cmbSex"
        cmbSex.Size = New Size(114, 23)
        cmbSex.TabIndex = 5
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(217, 96)
        Label14.Name = "Label14"
        Label14.Size = New Size(24, 15)
        Label14.TabIndex = 4
        Label14.Text = "Sex"
        ' 
        ' dtpBirthday
        ' 
        dtpBirthday.Location = New Point(13, 114)
        dtpBirthday.Name = "dtpBirthday"
        dtpBirthday.Size = New Size(189, 23)
        dtpBirthday.TabIndex = 3
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(15, 152)
        Label15.Name = "Label15"
        Label15.Size = New Size(49, 15)
        Label15.TabIndex = 6
        Label15.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(15, 170)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(316, 23)
        txtAddress.TabIndex = 7
        ' 
        ' btnAddOccupant
        ' 
        btnAddOccupant.FlatStyle = FlatStyle.Flat
        btnAddOccupant.Location = New Point(13, 209)
        btnAddOccupant.Name = "btnAddOccupant"
        btnAddOccupant.Size = New Size(194, 41)
        btnAddOccupant.TabIndex = 8
        btnAddOccupant.Text = "Add Occupant"
        btnAddOccupant.UseVisualStyleBackColor = True
        ' 
        ' dgvShow
        ' 
        dgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvShow.Location = New Point(17, 364)
        dgvShow.Name = "dgvShow"
        dgvShow.Size = New Size(347, 245)
        dgvShow.TabIndex = 18
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(17, 48)
        Label32.Name = "Label32"
        Label32.Size = New Size(382, 15)
        Label32.TabIndex = 1
        Label32.Text = "Add every occupant, pick the dates and room, then submit the request."
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Arial", 21.75F, FontStyle.Bold)
        Label31.Location = New Point(12, 15)
        Label31.Name = "Label31"
        Label31.Size = New Size(192, 34)
        Label31.TabIndex = 0
        Label31.Text = "Book a room"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(250))
        TabPage3.Controls.Add(dgvRoomShow)
        TabPage3.Controls.Add(Panel13)
        TabPage3.Controls.Add(Label37)
        TabPage3.Controls.Add(Label36)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(619, 629)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        ' 
        ' dgvRoomShow
        ' 
        dgvRoomShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRoomShow.Location = New Point(17, 231)
        dgvRoomShow.Name = "dgvRoomShow"
        dgvRoomShow.Size = New Size(582, 379)
        dgvRoomShow.TabIndex = 15
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.White
        Panel13.Controls.Add(Label39)
        Panel13.Controls.Add(Label38)
        Panel13.Controls.Add(cmbType)
        Panel13.Controls.Add(dtpEnd)
        Panel13.Controls.Add(Label22)
        Panel13.Controls.Add(Label19)
        Panel13.Controls.Add(nudMin)
        Panel13.Controls.Add(dtpStart)
        Panel13.Controls.Add(radAvailable)
        Panel13.Controls.Add(nudMax)
        Panel13.Controls.Add(txtFeature)
        Panel13.Controls.Add(Label20)
        Panel13.Controls.Add(Label21)
        Panel13.Location = New Point(17, 84)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(582, 131)
        Panel13.TabIndex = 2
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Location = New Point(341, 94)
        Label39.Name = "Label39"
        Label39.Size = New Size(18, 15)
        Label39.TabIndex = 12
        Label39.Text = "to"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Location = New Point(17, 59)
        Label38.Name = "Label38"
        Label38.Size = New Size(547, 15)
        Label38.TabIndex = 15
        Label38.Text = "____________________________________________________________________________________________________________"
        ' 
        ' cmbType
        ' 
        cmbType.FormattingEnabled = True
        cmbType.Location = New Point(17, 32)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(130, 23)
        cmbType.TabIndex = 1
        ' 
        ' dtpEnd
        ' 
        dtpEnd.Location = New Point(362, 88)
        dtpEnd.Name = "dtpEnd"
        dtpEnd.Size = New Size(200, 23)
        dtpEnd.TabIndex = 11
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(369, 16)
        Label22.Name = "Label22"
        Label22.Size = New Size(46, 15)
        Label22.TabIndex = 6
        Label22.Text = "Feature"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(17, 14)
        Label19.Name = "Label19"
        Label19.Size = New Size(32, 15)
        Label19.TabIndex = 0
        Label19.Text = "Type"
        ' 
        ' nudMin
        ' 
        nudMin.Location = New Point(153, 33)
        nudMin.Name = "nudMin"
        nudMin.Size = New Size(103, 23)
        nudMin.TabIndex = 13
        ' 
        ' dtpStart
        ' 
        dtpStart.Location = New Point(135, 88)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(200, 23)
        dtpStart.TabIndex = 10
        ' 
        ' radAvailable
        ' 
        radAvailable.AutoSize = True
        radAvailable.Location = New Point(17, 92)
        radAvailable.Name = "radAvailable"
        radAvailable.Size = New Size(121, 19)
        radAvailable.TabIndex = 9
        radAvailable.TabStop = True
        radAvailable.Text = "Available between"
        radAvailable.UseVisualStyleBackColor = True
        ' 
        ' nudMax
        ' 
        nudMax.Location = New Point(262, 33)
        nudMax.Name = "nudMax"
        nudMax.Size = New Size(101, 23)
        nudMax.TabIndex = 14
        ' 
        ' txtFeature
        ' 
        txtFeature.Location = New Point(369, 32)
        txtFeature.Name = "txtFeature"
        txtFeature.Size = New Size(193, 23)
        txtFeature.TabIndex = 7
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(153, 16)
        Label20.Name = "Label20"
        Label20.Size = New Size(78, 15)
        Label20.TabIndex = 2
        Label20.Text = "Min. capacity"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(262, 17)
        Label21.Name = "Label21"
        Label21.Size = New Size(58, 15)
        Label21.TabIndex = 4
        Label21.Text = "Max price"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Location = New Point(17, 48)
        Label37.Name = "Label37"
        Label37.Size = New Size(322, 15)
        Label37.TabIndex = 1
        Label37.Text = "Filter rooms by type, capacity, price, feature and availability."
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Arial", 21.75F, FontStyle.Bold)
        Label36.Location = New Point(12, 15)
        Label36.Name = "Label36"
        Label36.Size = New Size(199, 34)
        Label36.TabIndex = 0
        Label36.Text = "Room search"
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(250))
        TabPage4.Controls.Add(dgvBillingRoom)
        TabPage4.Controls.Add(lblSummary1)
        TabPage4.Controls.Add(btnGoBilling)
        TabPage4.Controls.Add(btnReject)
        TabPage4.Controls.Add(btnApprove)
        TabPage4.Controls.Add(Label23)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(619, 629)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TabPage4"
        ' 
        ' dgvBillingRoom
        ' 
        dgvBillingRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBillingRoom.Location = New Point(17, 33)
        dgvBillingRoom.Name = "dgvBillingRoom"
        dgvBillingRoom.Size = New Size(543, 208)
        dgvBillingRoom.TabIndex = 6
        ' 
        ' lblSummary1
        ' 
        lblSummary1.AutoSize = True
        lblSummary1.Location = New Point(17, 343)
        lblSummary1.Name = "lblSummary1"
        lblSummary1.Size = New Size(47, 15)
        lblSummary1.TabIndex = 5
        lblSummary1.Text = "Label24"
        ' 
        ' btnGoBilling
        ' 
        btnGoBilling.FlatStyle = FlatStyle.Flat
        btnGoBilling.Location = New Point(445, 247)
        btnGoBilling.Name = "btnGoBilling"
        btnGoBilling.Size = New Size(115, 53)
        btnGoBilling.TabIndex = 4
        btnGoBilling.Text = "Go to Billing"
        btnGoBilling.UseVisualStyleBackColor = True
        ' 
        ' btnReject
        ' 
        btnReject.FlatStyle = FlatStyle.Flat
        btnReject.Location = New Point(138, 247)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(115, 53)
        btnReject.TabIndex = 3
        btnReject.Text = "Reject"
        btnReject.UseVisualStyleBackColor = True
        ' 
        ' btnApprove
        ' 
        btnApprove.FlatStyle = FlatStyle.Flat
        btnApprove.Location = New Point(17, 247)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(115, 53)
        btnApprove.TabIndex = 2
        btnApprove.Text = "Approve"
        btnApprove.UseVisualStyleBackColor = True
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(17, 15)
        Label23.Name = "Label23"
        Label23.Size = New Size(163, 15)
        Label23.TabIndex = 0
        Label23.Text = "Booking Details and Approval"
        ' 
        ' TabPage5
        ' 
        TabPage5.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(250))
        TabPage5.Controls.Add(Panel15)
        TabPage5.Controls.Add(Panel14)
        TabPage5.Controls.Add(Label41)
        TabPage5.Controls.Add(Label40)
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(619, 629)
        TabPage5.TabIndex = 4
        TabPage5.Text = "TabPage5"
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.White
        Panel15.Controls.Add(lblCustomerView)
        Panel15.Location = New Point(17, 190)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(582, 213)
        Panel15.TabIndex = 6
        ' 
        ' lblCustomerView
        ' 
        lblCustomerView.AutoSize = True
        lblCustomerView.Location = New Point(14, 37)
        lblCustomerView.Name = "lblCustomerView"
        lblCustomerView.Size = New Size(47, 15)
        lblCustomerView.TabIndex = 5
        lblCustomerView.Text = "Label26"
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.White
        Panel14.Controls.Add(txtBookingID)
        Panel14.Controls.Add(Label25)
        Panel14.Controls.Add(btnViewBooking)
        Panel14.Location = New Point(17, 84)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(582, 79)
        Panel14.TabIndex = 2
        ' 
        ' txtBookingID
        ' 
        txtBookingID.Location = New Point(14, 39)
        txtBookingID.Name = "txtBookingID"
        txtBookingID.Size = New Size(361, 23)
        txtBookingID.TabIndex = 3
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(14, 13)
        Label25.Name = "Label25"
        Label25.Size = New Size(92, 15)
        Label25.TabIndex = 2
        Label25.Text = "Your booking ID"
        ' 
        ' btnViewBooking
        ' 
        btnViewBooking.BackColor = Color.FromArgb(CByte(61), CByte(79), CByte(21))
        btnViewBooking.FlatStyle = FlatStyle.Flat
        btnViewBooking.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnViewBooking.ForeColor = SystemColors.Control
        btnViewBooking.Location = New Point(381, 13)
        btnViewBooking.Name = "btnViewBooking"
        btnViewBooking.Size = New Size(182, 49)
        btnViewBooking.TabIndex = 4
        btnViewBooking.Text = "View my booking"
        btnViewBooking.UseVisualStyleBackColor = False
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Location = New Point(17, 48)
        Label41.Name = "Label41"
        Label41.Size = New Size(364, 15)
        Label41.TabIndex = 1
        Label41.Text = "Guests enter their booking ID to see the status and cost of their stay."
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Arial", 21.75F, FontStyle.Bold)
        Label40.Location = New Point(12, 15)
        Label40.Name = "Label40"
        Label40.Size = New Size(381, 34)
        Label40.TabIndex = 0
        Label40.Text = "Customer view of booking"
        ' 
        ' TabPage6
        ' 
        TabPage6.BackColor = Color.FromArgb(CByte(242), CByte(245), CByte(250))
        TabPage6.Controls.Add(Panel18)
        TabPage6.Controls.Add(Panel17)
        TabPage6.Controls.Add(Panel16)
        TabPage6.Controls.Add(Label24)
        TabPage6.Controls.Add(Label26)
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.Size = New Size(619, 629)
        TabPage6.TabIndex = 5
        TabPage6.Text = "TabPage6"
        ' 
        ' Panel18
        ' 
        Panel18.BackColor = Color.White
        Panel18.Controls.Add(btnQR)
        Panel18.Controls.Add(Label46)
        Panel18.Location = New Point(367, 325)
        Panel18.Name = "Panel18"
        Panel18.Size = New Size(236, 114)
        Panel18.TabIndex = 13
        ' 
        ' btnQR
        ' 
        btnQR.FlatStyle = FlatStyle.Flat
        btnQR.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnQR.Location = New Point(13, 39)
        btnQR.Name = "btnQR"
        btnQR.Size = New Size(209, 62)
        btnQR.TabIndex = 9
        btnQR.Text = "Pay and Check-out"
        btnQR.UseVisualStyleBackColor = True
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        Label46.Location = New Point(13, 9)
        Label46.Name = "Label46"
        Label46.Size = New Size(100, 24)
        Label46.TabIndex = 9
        Label46.Text = "QR Code"
        ' 
        ' Panel17
        ' 
        Panel17.BackColor = Color.White
        Panel17.Controls.Add(Label45)
        Panel17.Controls.Add(Label44)
        Panel17.Controls.Add(Label43)
        Panel17.Controls.Add(nudAmount)
        Panel17.Controls.Add(btnPay)
        Panel17.Controls.Add(Label28)
        Panel17.Controls.Add(lblChange)
        Panel17.Location = New Point(367, 84)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(236, 226)
        Panel17.TabIndex = 12
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        Label45.Location = New Point(13, 125)
        Label45.Name = "Label45"
        Label45.Size = New Size(88, 24)
        Label45.TabIndex = 8
        Label45.Text = "Change"
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Location = New Point(13, 91)
        Label44.Name = "Label44"
        Label44.Size = New Size(212, 15)
        Label44.TabIndex = 7
        Label44.Text = "_________________________________________"
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        Label43.Location = New Point(13, 9)
        Label43.Name = "Label43"
        Label43.Size = New Size(98, 24)
        Label43.TabIndex = 6
        Label43.Text = "Payment"
        ' 
        ' nudAmount
        ' 
        nudAmount.Location = New Point(13, 65)
        nudAmount.Name = "nudAmount"
        nudAmount.Size = New Size(209, 23)
        nudAmount.TabIndex = 5
        ' 
        ' btnPay
        ' 
        btnPay.BackColor = Color.FromArgb(CByte(245), CByte(166), CByte(35))
        btnPay.FlatStyle = FlatStyle.Flat
        btnPay.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnPay.Location = New Point(13, 170)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(209, 41)
        btnPay.TabIndex = 7
        btnPay.Text = "Pay and Check-out"
        btnPay.UseVisualStyleBackColor = False
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(13, 47)
        Label28.Name = "Label28"
        Label28.Size = New Size(101, 15)
        Label28.TabIndex = 4
        Label28.Text = "Amount tendered"
        ' 
        ' lblChange
        ' 
        lblChange.AutoSize = True
        lblChange.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblChange.Location = New Point(181, 127)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(28, 21)
        lblChange.TabIndex = 6
        lblChange.Text = "P0"
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.White
        Panel16.Controls.Add(Label42)
        Panel16.Controls.Add(cmbApprovedBooking)
        Panel16.Controls.Add(Label27)
        Panel16.Controls.Add(lblBillingSummary)
        Panel16.Location = New Point(17, 84)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(344, 488)
        Panel16.TabIndex = 11
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Location = New Point(12, 61)
        Label42.Name = "Label42"
        Label42.Size = New Size(322, 15)
        Label42.TabIndex = 3
        Label42.Text = "_______________________________________________________________"
        ' 
        ' cmbApprovedBooking
        ' 
        cmbApprovedBooking.FormattingEnabled = True
        cmbApprovedBooking.Location = New Point(12, 35)
        cmbApprovedBooking.Name = "cmbApprovedBooking"
        cmbApprovedBooking.Size = New Size(319, 23)
        cmbApprovedBooking.TabIndex = 2
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(12, 12)
        Label27.Name = "Label27"
        Label27.Size = New Size(106, 15)
        Label27.TabIndex = 1
        Label27.Text = "Approved booking"
        ' 
        ' lblBillingSummary
        ' 
        lblBillingSummary.AutoSize = True
        lblBillingSummary.Location = New Point(12, 94)
        lblBillingSummary.Name = "lblBillingSummary"
        lblBillingSummary.Size = New Size(47, 15)
        lblBillingSummary.TabIndex = 3
        lblBillingSummary.Text = "Label28"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(17, 48)
        Label24.Name = "Label24"
        Label24.Size = New Size(374, 15)
        Label24.TabIndex = 10
        Label24.Text = "Choose an approved booking, take payment and check the guest out."
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Arial", 21.75F, FontStyle.Bold)
        Label26.Location = New Point(12, 15)
        Label26.Name = "Label26"
        Label26.Size = New Size(291, 34)
        Label26.TabIndex = 0
        Label26.Text = "Billing and payment"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(814, 647)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        CType(dgvShow, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(dgvRoomShow, ComponentModel.ISupportInitialize).EndInit()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        CType(nudMin, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMax, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        CType(dgvBillingRoom, ComponentModel.ISupportInitialize).EndInit()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        Panel15.ResumeLayout(False)
        Panel15.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        TabPage6.ResumeLayout(False)
        TabPage6.PerformLayout()
        Panel18.ResumeLayout(False)
        Panel18.PerformLayout()
        Panel17.ResumeLayout(False)
        Panel17.PerformLayout()
        CType(nudAmount, ComponentModel.ISupportInitialize).EndInit()
        Panel16.ResumeLayout(False)
        Panel16.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBilling As Button
    Friend WithEvents btnCustomerView As Button
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnRoomSearch As Button
    Friend WithEvents btnBookRoom As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbAvailableRoom As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dtpCheckout As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents dtpCheckin As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents btnAddOccupant As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents nudAmount As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtFeature As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents radAvailable As RadioButton
    Friend WithEvents Label23 As Label
    Friend WithEvents nudMax As NumericUpDown
    Friend WithEvents nudMin As NumericUpDown
    Friend WithEvents btnApprove As Button
    Friend WithEvents lblSummary1 As Label
    Friend WithEvents btnGoBilling As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents lblCustomerView As Label
    Friend WithEvents btnViewBooking As Button
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblBillingSummary As Label
    Friend WithEvents cmbApprovedBooking As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents btnQR As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents lblAvailableRooms As Label
    Friend WithEvents lblOccupiedRooms As Label
    Friend WithEvents lblTotalRooms As Label
    Friend WithEvents lblElderies As Label
    Friend WithEvents lblChildren As Label
    Friend WithEvents lblFemales As Label
    Friend WithEvents lblMales As Label
    Friend WithEvents lblGuest As Label
    Friend WithEvents dgvShow As DataGridView
    Friend WithEvents lblSummary As Label
    Friend WithEvents dgvRoomShow As DataGridView
    Friend WithEvents dgvBillingRoom As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label42 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Label46 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label43 As Label
End Class
