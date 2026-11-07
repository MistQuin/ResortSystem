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
        btnLogout = New Button()
        btnBilling = New Button()
        btnCustomerView = New Button()
        btnBookings = New Button()
        btnRoomSearch = New Button()
        btnBookRoom = New Button()
        btnHome = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Panel3 = New Panel()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        btnSubmit = New Button()
        lblSummary = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        cmbAvailableRoom = New ComboBox()
        Label18 = New Label()
        dtpCheckout = New DateTimePicker()
        Label17 = New Label()
        dtpCheckin = New DateTimePicker()
        Label16 = New Label()
        Button1 = New Button()
        txtAddress = New TextBox()
        Label15 = New Label()
        cmbSex = New ComboBox()
        Label14 = New Label()
        dtpBirthday = New DateTimePicker()
        Label13 = New Label()
        txtName = New TextBox()
        Label12 = New Label()
        TabPage3 = New TabPage()
        nudMax = New NumericUpDown()
        nudMin = New NumericUpDown()
        TableLayoutPanel2 = New TableLayoutPanel()
        dtpEnd = New DateTimePicker()
        dtpStart = New DateTimePicker()
        radAvailable = New RadioButton()
        txtFeature = New TextBox()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        cmbType = New ComboBox()
        Label19 = New Label()
        TabPage4 = New TabPage()
        lblSummary1 = New Label()
        btnGoBilling = New Button()
        btnReject = New Button()
        btnApprove = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label23 = New Label()
        TabPage5 = New TabPage()
        lblSummary2 = New Label()
        btnViewBooking = New Button()
        txtBookingID = New TextBox()
        Label25 = New Label()
        Label24 = New Label()
        TabPage6 = New TabPage()
        lblChange = New Label()
        nudAmount = New NumericUpDown()
        Label28 = New Label()
        lblSummary3 = New Label()
        ComboBox1 = New ComboBox()
        Label27 = New Label()
        Label26 = New Label()
        btnPay = New Button()
        Label29 = New Label()
        Button2 = New Button()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(nudMax, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMin, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        TabPage6.SuspendLayout()
        CType(nudAmount, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(11), CByte(37), CByte(69))
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnBilling)
        Panel1.Controls.Add(btnCustomerView)
        Panel1.Controls.Add(btnBookings)
        Panel1.Controls.Add(btnRoomSearch)
        Panel1.Controls.Add(btnBookRoom)
        Panel1.Controls.Add(btnHome)
        Panel1.Location = New Point(-5, -6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(204, 512)
        Panel1.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Arial", 9.75F, FontStyle.Bold)
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.Location = New Point(17, 387)
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
        btnBilling.Location = New Point(17, 329)
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
        btnCustomerView.Location = New Point(17, 271)
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
        btnBookings.Location = New Point(17, 213)
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
        btnRoomSearch.Location = New Point(17, 155)
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
        btnBookRoom.Location = New Point(17, 97)
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
        btnHome.Location = New Point(17, 39)
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
        TabControl1.Location = New Point(205, -6)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(600, 512)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Panel3)
        TabPage1.Controls.Add(Panel2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(592, 578)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(310, 96)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(239, 289)
        Panel3.TabIndex = 4
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(42, 170)
        Label11.Name = "Label11"
        Label11.Size = New Size(95, 15)
        Label11.TabIndex = 4
        Label11.Text = "Available Rooms"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(42, 130)
        Label10.Name = "Label10"
        Label10.Size = New Size(98, 15)
        Label10.TabIndex = 3
        Label10.Text = "Occupied Rooms"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(42, 93)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 15)
        Label9.TabIndex = 2
        Label9.Text = "Total Rooms"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 21.75F, FontStyle.Bold)
        Label4.Location = New Point(57, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 34)
        Label4.TabIndex = 1
        Label4.Text = "ROOMS"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(35, 96)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(239, 289)
        Panel2.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(25, 246)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 15)
        Label8.TabIndex = 6
        Label8.Text = "Elderies"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(25, 209)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 15)
        Label7.TabIndex = 5
        Label7.Text = "Children"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(25, 170)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 15)
        Label6.TabIndex = 4
        Label6.Text = "Females"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 15)
        Label5.TabIndex = 3
        Label5.Text = "Males"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 15)
        Label3.TabIndex = 2
        Label3.Text = "No. of Guests"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 21.75F, FontStyle.Bold)
        Label2.Location = New Point(51, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 34)
        Label2.TabIndex = 1
        Label2.Text = "GUESTS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 21.75F, FontStyle.Bold)
        Label1.Location = New Point(214, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 34)
        Label1.TabIndex = 0
        Label1.Text = "OVERVIEW"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnSubmit)
        TabPage2.Controls.Add(lblSummary)
        TabPage2.Controls.Add(TableLayoutPanel1)
        TabPage2.Controls.Add(cmbAvailableRoom)
        TabPage2.Controls.Add(Label18)
        TabPage2.Controls.Add(dtpCheckout)
        TabPage2.Controls.Add(Label17)
        TabPage2.Controls.Add(dtpCheckin)
        TabPage2.Controls.Add(Label16)
        TabPage2.Controls.Add(Button1)
        TabPage2.Controls.Add(txtAddress)
        TabPage2.Controls.Add(Label15)
        TabPage2.Controls.Add(cmbSex)
        TabPage2.Controls.Add(Label14)
        TabPage2.Controls.Add(dtpBirthday)
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(txtName)
        TabPage2.Controls.Add(Label12)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(592, 578)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Location = New Point(17, 416)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(194, 41)
        btnSubmit.TabIndex = 17
        btnSubmit.Text = "Submit booking request"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' lblSummary
        ' 
        lblSummary.AutoSize = True
        lblSummary.Location = New Point(19, 382)
        lblSummary.Name = "lblSummary"
        lblSummary.Size = New Size(65, 15)
        lblSummary.TabIndex = 16
        lblSummary.Text = "SUMMARY"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Location = New Point(17, 199)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 26.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 74.0F))
        TableLayoutPanel1.Size = New Size(550, 100)
        TableLayoutPanel1.TabIndex = 15
        ' 
        ' cmbAvailableRoom
        ' 
        cmbAvailableRoom.FormattingEnabled = True
        cmbAvailableRoom.Location = New Point(382, 342)
        cmbAvailableRoom.Name = "cmbAvailableRoom"
        cmbAvailableRoom.Size = New Size(185, 23)
        cmbAvailableRoom.TabIndex = 14
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(382, 324)
        Label18.Name = "Label18"
        Label18.Size = New Size(90, 15)
        Label18.TabIndex = 13
        Label18.Text = "Available Room"
        ' 
        ' dtpCheckout
        ' 
        dtpCheckout.Location = New Point(198, 342)
        dtpCheckout.Name = "dtpCheckout"
        dtpCheckout.Size = New Size(164, 23)
        dtpCheckout.TabIndex = 12
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(198, 324)
        Label17.Name = "Label17"
        Label17.Size = New Size(63, 15)
        Label17.TabIndex = 11
        Label17.Text = "Check-out"
        ' 
        ' dtpCheckin
        ' 
        dtpCheckin.Location = New Point(17, 342)
        dtpCheckin.Name = "dtpCheckin"
        dtpCheckin.Size = New Size(162, 23)
        dtpCheckin.TabIndex = 10
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(17, 324)
        Label16.Name = "Label16"
        Label16.Size = New Size(55, 15)
        Label16.TabIndex = 9
        Label16.Text = "Check-in"
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(17, 131)
        Button1.Name = "Button1"
        Button1.Size = New Size(194, 41)
        Button1.TabIndex = 8
        Button1.Text = "Add Occupant"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(17, 91)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(194, 23)
        txtAddress.TabIndex = 7
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(17, 73)
        Label15.Name = "Label15"
        Label15.Size = New Size(49, 15)
        Label15.TabIndex = 6
        Label15.Text = "Address"
        ' 
        ' cmbSex
        ' 
        cmbSex.FormattingEnabled = True
        cmbSex.Location = New Point(391, 33)
        cmbSex.Name = "cmbSex"
        cmbSex.Size = New Size(73, 23)
        cmbSex.TabIndex = 5
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(391, 15)
        Label14.Name = "Label14"
        Label14.Size = New Size(24, 15)
        Label14.TabIndex = 4
        Label14.Text = "Sex"
        ' 
        ' dtpBirthday
        ' 
        dtpBirthday.Location = New Point(227, 33)
        dtpBirthday.Name = "dtpBirthday"
        dtpBirthday.Size = New Size(145, 23)
        dtpBirthday.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(227, 15)
        Label13.Name = "Label13"
        Label13.Size = New Size(51, 15)
        Label13.TabIndex = 2
        Label13.Text = "Birthday"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(17, 33)
        txtName.Name = "txtName"
        txtName.Size = New Size(194, 23)
        txtName.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(17, 15)
        Label12.Name = "Label12"
        Label12.Size = New Size(39, 15)
        Label12.TabIndex = 0
        Label12.Text = "Name"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(nudMax)
        TabPage3.Controls.Add(nudMin)
        TabPage3.Controls.Add(TableLayoutPanel2)
        TabPage3.Controls.Add(dtpEnd)
        TabPage3.Controls.Add(dtpStart)
        TabPage3.Controls.Add(radAvailable)
        TabPage3.Controls.Add(txtFeature)
        TabPage3.Controls.Add(Label22)
        TabPage3.Controls.Add(Label21)
        TabPage3.Controls.Add(Label20)
        TabPage3.Controls.Add(cmbType)
        TabPage3.Controls.Add(Label19)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(592, 578)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' nudMax
        ' 
        nudMax.Location = New Point(241, 31)
        nudMax.Name = "nudMax"
        nudMax.Size = New Size(89, 23)
        nudMax.TabIndex = 14
        ' 
        ' nudMin
        ' 
        nudMin.Location = New Point(145, 32)
        nudMin.Name = "nudMin"
        nudMin.Size = New Size(78, 23)
        nudMin.TabIndex = 13
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.Location = New Point(17, 141)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.84375F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 85.15625F))
        TableLayoutPanel2.Size = New Size(544, 256)
        TableLayoutPanel2.TabIndex = 12
        ' 
        ' dtpEnd
        ' 
        dtpEnd.Location = New Point(361, 86)
        dtpEnd.Name = "dtpEnd"
        dtpEnd.Size = New Size(200, 23)
        dtpEnd.TabIndex = 11
        ' 
        ' dtpStart
        ' 
        dtpStart.Location = New Point(144, 86)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(200, 23)
        dtpStart.TabIndex = 10
        ' 
        ' radAvailable
        ' 
        radAvailable.AutoSize = True
        radAvailable.Location = New Point(17, 90)
        radAvailable.Name = "radAvailable"
        radAvailable.Size = New Size(121, 19)
        radAvailable.TabIndex = 9
        radAvailable.TabStop = True
        radAvailable.Text = "Available between"
        radAvailable.UseVisualStyleBackColor = True
        ' 
        ' txtFeature
        ' 
        txtFeature.Location = New Point(348, 31)
        txtFeature.Name = "txtFeature"
        txtFeature.Size = New Size(213, 23)
        txtFeature.TabIndex = 7
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(348, 15)
        Label22.Name = "Label22"
        Label22.Size = New Size(46, 15)
        Label22.TabIndex = 6
        Label22.Text = "Feature"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(241, 15)
        Label21.Name = "Label21"
        Label21.Size = New Size(58, 15)
        Label21.TabIndex = 4
        Label21.Text = "Max price"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(145, 15)
        Label20.Name = "Label20"
        Label20.Size = New Size(78, 15)
        Label20.TabIndex = 2
        Label20.Text = "Min. capacity"
        ' 
        ' cmbType
        ' 
        cmbType.FormattingEnabled = True
        cmbType.Location = New Point(17, 33)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(114, 23)
        cmbType.TabIndex = 1
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(17, 15)
        Label19.Name = "Label19"
        Label19.Size = New Size(32, 15)
        Label19.TabIndex = 0
        Label19.Text = "Type"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(lblSummary1)
        TabPage4.Controls.Add(btnGoBilling)
        TabPage4.Controls.Add(btnReject)
        TabPage4.Controls.Add(btnApprove)
        TabPage4.Controls.Add(TableLayoutPanel3)
        TabPage4.Controls.Add(Label23)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(592, 578)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TabPage4"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' lblSummary1
        ' 
        lblSummary1.AutoSize = True
        lblSummary1.Location = New Point(17, 324)
        lblSummary1.Name = "lblSummary1"
        lblSummary1.Size = New Size(47, 15)
        lblSummary1.TabIndex = 5
        lblSummary1.Text = "Label24"
        ' 
        ' btnGoBilling
        ' 
        btnGoBilling.FlatStyle = FlatStyle.Flat
        btnGoBilling.Location = New Point(445, 228)
        btnGoBilling.Name = "btnGoBilling"
        btnGoBilling.Size = New Size(115, 53)
        btnGoBilling.TabIndex = 4
        btnGoBilling.Text = "Go to Billing"
        btnGoBilling.UseVisualStyleBackColor = True
        ' 
        ' btnReject
        ' 
        btnReject.FlatStyle = FlatStyle.Flat
        btnReject.Location = New Point(138, 228)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(115, 53)
        btnReject.TabIndex = 3
        btnReject.Text = "Reject"
        btnReject.UseVisualStyleBackColor = True
        ' 
        ' btnApprove
        ' 
        btnApprove.FlatStyle = FlatStyle.Flat
        btnApprove.Location = New Point(17, 228)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(115, 53)
        btnApprove.TabIndex = 2
        btnApprove.Text = "Approve"
        btnApprove.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Location = New Point(17, 33)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 17.3184357F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 82.6815643F))
        TableLayoutPanel3.Size = New Size(543, 179)
        TableLayoutPanel3.TabIndex = 1
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
        TabPage5.Controls.Add(lblSummary2)
        TabPage5.Controls.Add(btnViewBooking)
        TabPage5.Controls.Add(txtBookingID)
        TabPage5.Controls.Add(Label25)
        TabPage5.Controls.Add(Label24)
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(592, 578)
        TabPage5.TabIndex = 4
        TabPage5.Text = "TabPage5"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' lblSummary2
        ' 
        lblSummary2.AutoSize = True
        lblSummary2.Location = New Point(17, 131)
        lblSummary2.Name = "lblSummary2"
        lblSummary2.Size = New Size(47, 15)
        lblSummary2.TabIndex = 5
        lblSummary2.Text = "Label26"
        ' 
        ' btnViewBooking
        ' 
        btnViewBooking.FlatStyle = FlatStyle.Flat
        btnViewBooking.Location = New Point(181, 57)
        btnViewBooking.Name = "btnViewBooking"
        btnViewBooking.Size = New Size(145, 36)
        btnViewBooking.TabIndex = 4
        btnViewBooking.Text = "View my booking"
        btnViewBooking.UseVisualStyleBackColor = True
        ' 
        ' txtBookingID
        ' 
        txtBookingID.Location = New Point(17, 70)
        txtBookingID.Name = "txtBookingID"
        txtBookingID.Size = New Size(147, 23)
        txtBookingID.TabIndex = 3
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(17, 52)
        Label25.Name = "Label25"
        Label25.Size = New Size(92, 15)
        Label25.TabIndex = 2
        Label25.Text = "Your booking ID"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(17, 15)
        Label24.Name = "Label24"
        Label24.Size = New Size(147, 15)
        Label24.TabIndex = 1
        Label24.Text = "Customer view of booking"
        ' 
        ' TabPage6
        ' 
        TabPage6.Controls.Add(Button2)
        TabPage6.Controls.Add(Label29)
        TabPage6.Controls.Add(btnPay)
        TabPage6.Controls.Add(lblChange)
        TabPage6.Controls.Add(nudAmount)
        TabPage6.Controls.Add(Label28)
        TabPage6.Controls.Add(lblSummary3)
        TabPage6.Controls.Add(ComboBox1)
        TabPage6.Controls.Add(Label27)
        TabPage6.Controls.Add(Label26)
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.Size = New Size(592, 484)
        TabPage6.TabIndex = 5
        TabPage6.Text = "TabPage6"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' lblChange
        ' 
        lblChange.AutoSize = True
        lblChange.Location = New Point(162, 307)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(67, 15)
        lblChange.TabIndex = 6
        lblChange.Text = "Change: P0"
        ' 
        ' nudAmount
        ' 
        nudAmount.Location = New Point(17, 304)
        nudAmount.Name = "nudAmount"
        nudAmount.Size = New Size(139, 23)
        nudAmount.TabIndex = 5
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(17, 286)
        Label28.Name = "Label28"
        Label28.Size = New Size(101, 15)
        Label28.TabIndex = 4
        Label28.Text = "Amount tendered"
        ' 
        ' lblSummary3
        ' 
        lblSummary3.AutoSize = True
        lblSummary3.Location = New Point(17, 122)
        lblSummary3.Name = "lblSummary3"
        lblSummary3.Size = New Size(47, 15)
        lblSummary3.TabIndex = 3
        lblSummary3.Text = "Label28"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(17, 70)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(203, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(17, 52)
        Label27.Name = "Label27"
        Label27.Size = New Size(106, 15)
        Label27.TabIndex = 1
        Label27.Text = "Approved booking"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(17, 15)
        Label26.Name = "Label26"
        Label26.Size = New Size(113, 15)
        Label26.TabIndex = 0
        Label26.Text = "Billing and payment"
        ' 
        ' btnPay
        ' 
        btnPay.Location = New Point(251, 286)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(138, 41)
        btnPay.TabIndex = 7
        btnPay.Text = "Pay and check out"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(17, 354)
        Label29.Name = "Label29"
        Label29.Size = New Size(106, 15)
        Label29.TabIndex = 8
        Label29.Text = "QR generator code"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(17, 372)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 87)
        Button2.TabIndex = 9
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(801, 505)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(nudMax, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMin, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        TabPage6.ResumeLayout(False)
        TabPage6.PerformLayout()
        CType(nudAmount, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblSummary As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents nudAmount As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtFeature As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents radAvailable As RadioButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label23 As Label
    Friend WithEvents nudMax As NumericUpDown
    Friend WithEvents nudMin As NumericUpDown
    Friend WithEvents btnApprove As Button
    Friend WithEvents lblSummary1 As Label
    Friend WithEvents btnGoBilling As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents lblSummary2 As Label
    Friend WithEvents btnViewBooking As Button
    Friend WithEvents txtBookingID As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblSummary3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents btnPay As Button
End Class
