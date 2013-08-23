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
        Me.components = New System.ComponentModel.Container()
        Dim Employee_IdLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Hire_DateLabel As System.Windows.Forms.Label
        Dim Date_of_BirthLabel As System.Windows.Forms.Label
        Dim Basic_PayLabel As System.Windows.Forms.Label
        Dim House_Rental_AllowanceLabel As System.Windows.Forms.Label
        Dim Dearness_AllowanceLabel As System.Windows.Forms.Label
        Dim Provident_FundLabel As System.Windows.Forms.Label
        Dim Date_of_LeavingLabel As System.Windows.Forms.Label
        Dim GradeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DetailsDataSet = New Payroll_Management_System.DetailsDataSet()
        Me.DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetailsTableAdapter = New Payroll_Management_System.DetailsDataSetTableAdapters.DetailsTableAdapter()
        Me.TableAdapterManager = New Payroll_Management_System.DetailsDataSetTableAdapters.TableAdapterManager()
        Me.DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Employee_IdTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Hire_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Basic_PayTextBox = New System.Windows.Forms.TextBox()
        Me.House_Rental_AllowanceTextBox = New System.Windows.Forms.TextBox()
        Me.Dearness_AllowanceTextBox = New System.Windows.Forms.TextBox()
        Me.Provident_FundTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_LeavingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Employee_IdLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Hire_DateLabel = New System.Windows.Forms.Label()
        Date_of_BirthLabel = New System.Windows.Forms.Label()
        Basic_PayLabel = New System.Windows.Forms.Label()
        House_Rental_AllowanceLabel = New System.Windows.Forms.Label()
        Dearness_AllowanceLabel = New System.Windows.Forms.Label()
        Provident_FundLabel = New System.Windows.Forms.Label()
        Date_of_LeavingLabel = New System.Windows.Forms.Label()
        GradeLabel = New System.Windows.Forms.Label()
        CType(Me.DetailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Employee_IdLabel
        '
        Employee_IdLabel.AutoSize = True
        Employee_IdLabel.Location = New System.Drawing.Point(36, 53)
        Employee_IdLabel.Name = "Employee_IdLabel"
        Employee_IdLabel.Size = New System.Drawing.Size(68, 13)
        Employee_IdLabel.TabIndex = 1
        Employee_IdLabel.Text = "Employee Id:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(44, 112)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 3
        TitleLabel.Text = "Title:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(34, 163)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 5
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(43, 219)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 7
        Last_NameLabel.Text = "Last Name:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(56, 273)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(23, 329)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 11
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Hire_DateLabel
        '
        Hire_DateLabel.AutoSize = True
        Hire_DateLabel.Location = New System.Drawing.Point(36, 376)
        Hire_DateLabel.Name = "Hire_DateLabel"
        Hire_DateLabel.Size = New System.Drawing.Size(55, 13)
        Hire_DateLabel.TabIndex = 13
        Hire_DateLabel.Text = "Hire Date:"
        '
        'Date_of_BirthLabel
        '
        Date_of_BirthLabel.AutoSize = True
        Date_of_BirthLabel.Location = New System.Drawing.Point(35, 425)
        Date_of_BirthLabel.Name = "Date_of_BirthLabel"
        Date_of_BirthLabel.Size = New System.Drawing.Size(69, 13)
        Date_of_BirthLabel.TabIndex = 15
        Date_of_BirthLabel.Text = "Date of Birth:"
        '
        'Basic_PayLabel
        '
        Basic_PayLabel.AutoSize = True
        Basic_PayLabel.Location = New System.Drawing.Point(560, 60)
        Basic_PayLabel.Name = "Basic_PayLabel"
        Basic_PayLabel.Size = New System.Drawing.Size(57, 13)
        Basic_PayLabel.TabIndex = 17
        Basic_PayLabel.Text = "Basic Pay:"
        AddHandler Basic_PayLabel.Click, AddressOf Me.Basic_PayLabel_Click
        '
        'House_Rental_AllowanceLabel
        '
        House_Rental_AllowanceLabel.AutoSize = True
        House_Rental_AllowanceLabel.Location = New System.Drawing.Point(490, 112)
        House_Rental_AllowanceLabel.Name = "House_Rental_AllowanceLabel"
        House_Rental_AllowanceLabel.Size = New System.Drawing.Size(127, 13)
        House_Rental_AllowanceLabel.TabIndex = 19
        House_Rental_AllowanceLabel.Text = "House Rental Allowance:"
        '
        'Dearness_AllowanceLabel
        '
        Dearness_AllowanceLabel.AutoSize = True
        Dearness_AllowanceLabel.Location = New System.Drawing.Point(510, 166)
        Dearness_AllowanceLabel.Name = "Dearness_AllowanceLabel"
        Dearness_AllowanceLabel.Size = New System.Drawing.Size(107, 13)
        Dearness_AllowanceLabel.TabIndex = 21
        Dearness_AllowanceLabel.Text = "Dearness Allowance:"
        '
        'Provident_FundLabel
        '
        Provident_FundLabel.AutoSize = True
        Provident_FundLabel.Location = New System.Drawing.Point(535, 216)
        Provident_FundLabel.Name = "Provident_FundLabel"
        Provident_FundLabel.Size = New System.Drawing.Size(82, 13)
        Provident_FundLabel.TabIndex = 23
        Provident_FundLabel.Text = "Provident Fund:"
        AddHandler Provident_FundLabel.Click, AddressOf Me.Provident_FundLabel_Click
        '
        'Date_of_LeavingLabel
        '
        Date_of_LeavingLabel.AutoSize = True
        Date_of_LeavingLabel.Location = New System.Drawing.Point(23, 568)
        Date_of_LeavingLabel.Name = "Date_of_LeavingLabel"
        Date_of_LeavingLabel.Size = New System.Drawing.Size(86, 13)
        Date_of_LeavingLabel.TabIndex = 25
        Date_of_LeavingLabel.Text = "Date of Leaving:"
        '
        'GradeLabel
        '
        GradeLabel.AutoSize = True
        GradeLabel.Location = New System.Drawing.Point(55, 496)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New System.Drawing.Size(39, 13)
        GradeLabel.TabIndex = 27
        GradeLabel.Text = "Grade:"
        AddHandler GradeLabel.Click, AddressOf Me.GradeLabel_Click
        '
        'DetailsDataSet
        '
        Me.DetailsDataSet.DataSetName = "DetailsDataSet"
        Me.DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetailsBindingSource
        '
        Me.DetailsBindingSource.DataMember = "Details"
        Me.DetailsBindingSource.DataSource = Me.DetailsDataSet
        '
        'DetailsTableAdapter
        '
        Me.DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetailsTableAdapter = Me.DetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Payroll_Management_System.DetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DetailsBindingNavigator
        '
        Me.DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DetailsBindingNavigator.BindingSource = Me.DetailsBindingSource
        Me.DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DetailsBindingNavigatorSaveItem})
        Me.DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DetailsBindingNavigator.Name = "DetailsBindingNavigator"
        Me.DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DetailsBindingNavigator.Size = New System.Drawing.Size(892, 25)
        Me.DetailsBindingNavigator.TabIndex = 0
        Me.DetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DetailsBindingNavigatorSaveItem
        '
        Me.DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DetailsBindingNavigatorSaveItem.Name = "DetailsBindingNavigatorSaveItem"
        Me.DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Employee_IdTextBox
        '
        Me.Employee_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Employee Id", True))
        Me.Employee_IdTextBox.Location = New System.Drawing.Point(110, 53)
        Me.Employee_IdTextBox.Name = "Employee_IdTextBox"
        Me.Employee_IdTextBox.Size = New System.Drawing.Size(222, 20)
        Me.Employee_IdTextBox.TabIndex = 2
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(110, 105)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(222, 20)
        Me.TitleTextBox.TabIndex = 4
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(110, 160)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(222, 20)
        Me.First_NameTextBox.TabIndex = 6
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(110, 216)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(222, 20)
        Me.Last_NameTextBox.TabIndex = 8
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(110, 270)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(222, 20)
        Me.EmailTextBox.TabIndex = 10
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Phone Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(110, 326)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(222, 20)
        Me.Phone_NumberTextBox.TabIndex = 12
        '
        'Hire_DateDateTimePicker
        '
        Me.Hire_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DetailsBindingSource, "Hire Date", True))
        Me.Hire_DateDateTimePicker.Location = New System.Drawing.Point(110, 370)
        Me.Hire_DateDateTimePicker.Name = "Hire_DateDateTimePicker"
        Me.Hire_DateDateTimePicker.Size = New System.Drawing.Size(222, 20)
        Me.Hire_DateDateTimePicker.TabIndex = 14
        '
        'Date_of_BirthDateTimePicker
        '
        Me.Date_of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DetailsBindingSource, "Date of Birth", True))
        Me.Date_of_BirthDateTimePicker.Location = New System.Drawing.Point(110, 421)
        Me.Date_of_BirthDateTimePicker.Name = "Date_of_BirthDateTimePicker"
        Me.Date_of_BirthDateTimePicker.Size = New System.Drawing.Size(222, 20)
        Me.Date_of_BirthDateTimePicker.TabIndex = 16
        '
        'Basic_PayTextBox
        '
        Me.Basic_PayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Basic Pay", True))
        Me.Basic_PayTextBox.Location = New System.Drawing.Point(644, 53)
        Me.Basic_PayTextBox.Name = "Basic_PayTextBox"
        Me.Basic_PayTextBox.Size = New System.Drawing.Size(222, 20)
        Me.Basic_PayTextBox.TabIndex = 18
        '
        'House_Rental_AllowanceTextBox
        '
        Me.House_Rental_AllowanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "House Rental Allowance", True))
        Me.House_Rental_AllowanceTextBox.Location = New System.Drawing.Point(644, 105)
        Me.House_Rental_AllowanceTextBox.Name = "House_Rental_AllowanceTextBox"
        Me.House_Rental_AllowanceTextBox.Size = New System.Drawing.Size(222, 20)
        Me.House_Rental_AllowanceTextBox.TabIndex = 20
        '
        'Dearness_AllowanceTextBox
        '
        Me.Dearness_AllowanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Dearness Allowance", True))
        Me.Dearness_AllowanceTextBox.Location = New System.Drawing.Point(644, 163)
        Me.Dearness_AllowanceTextBox.Name = "Dearness_AllowanceTextBox"
        Me.Dearness_AllowanceTextBox.Size = New System.Drawing.Size(222, 20)
        Me.Dearness_AllowanceTextBox.TabIndex = 22
        '
        'Provident_FundTextBox
        '
        Me.Provident_FundTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Provident Fund", True))
        Me.Provident_FundTextBox.Location = New System.Drawing.Point(644, 212)
        Me.Provident_FundTextBox.Name = "Provident_FundTextBox"
        Me.Provident_FundTextBox.Size = New System.Drawing.Size(221, 20)
        Me.Provident_FundTextBox.TabIndex = 24
        '
        'Date_of_LeavingDateTimePicker
        '
        Me.Date_of_LeavingDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DetailsBindingSource, "Date of Leaving", True))
        Me.Date_of_LeavingDateTimePicker.Location = New System.Drawing.Point(115, 568)
        Me.Date_of_LeavingDateTimePicker.Name = "Date_of_LeavingDateTimePicker"
        Me.Date_of_LeavingDateTimePicker.Size = New System.Drawing.Size(228, 20)
        Me.Date_of_LeavingDateTimePicker.TabIndex = 26
        '
        'GradeTextBox
        '
        Me.GradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetailsBindingSource, "Grade", True))
        Me.GradeTextBox.Location = New System.Drawing.Point(110, 489)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(222, 20)
        Me.GradeTextBox.TabIndex = 28
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 759)
        Me.Controls.Add(GradeLabel)
        Me.Controls.Add(Me.GradeTextBox)
        Me.Controls.Add(Date_of_LeavingLabel)
        Me.Controls.Add(Me.Date_of_LeavingDateTimePicker)
        Me.Controls.Add(Provident_FundLabel)
        Me.Controls.Add(Me.Provident_FundTextBox)
        Me.Controls.Add(Dearness_AllowanceLabel)
        Me.Controls.Add(Me.Dearness_AllowanceTextBox)
        Me.Controls.Add(House_Rental_AllowanceLabel)
        Me.Controls.Add(Me.House_Rental_AllowanceTextBox)
        Me.Controls.Add(Basic_PayLabel)
        Me.Controls.Add(Me.Basic_PayTextBox)
        Me.Controls.Add(Date_of_BirthLabel)
        Me.Controls.Add(Me.Date_of_BirthDateTimePicker)
        Me.Controls.Add(Hire_DateLabel)
        Me.Controls.Add(Me.Hire_DateDateTimePicker)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Employee_IdLabel)
        Me.Controls.Add(Me.Employee_IdTextBox)
        Me.Controls.Add(Me.DetailsBindingNavigator)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DetailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailsBindingNavigator.ResumeLayout(False)
        Me.DetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DetailsDataSet As Payroll_Management_System.DetailsDataSet
    Friend WithEvents DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetailsTableAdapter As Payroll_Management_System.DetailsDataSetTableAdapters.DetailsTableAdapter
    Friend WithEvents TableAdapterManager As Payroll_Management_System.DetailsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DetailsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Employee_IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Hire_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_of_BirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Basic_PayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents House_Rental_AllowanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dearness_AllowanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Provident_FundTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_LeavingDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GradeTextBox As System.Windows.Forms.TextBox
End Class
