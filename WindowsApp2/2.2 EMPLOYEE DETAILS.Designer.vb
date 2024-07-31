<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmploeeDetailsForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.WorkingExprerienceTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.ShowDatbaseIconButton = New FontAwesome.Sharp.IconButton()
        Me.AddIconButton = New FontAwesome.Sharp.IconButton()
        Me.RemoveIconButton = New FontAwesome.Sharp.IconButton()
        Me.UpdateIconButton = New FontAwesome.Sharp.IconButton()
        Me.ClearIconButton = New FontAwesome.Sharp.IconButton()
        Me.SearchIconButton = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(126, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 29)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "EMPLOYEE DETAILS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(51, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 29)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "EMPLOYEE ID"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.EmployeeIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(367, 78)
        Me.EmployeeIDTextBox.MaxLength = 4
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(254, 34)
        Me.EmployeeIDTextBox.TabIndex = 92
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PhoneNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(367, 167)
        Me.PhoneNumberTextBox.MaxLength = 10
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(253, 34)
        Me.PhoneNumberTextBox.TabIndex = 91
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(50, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 29)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "PHONE NUMBER"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(50, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 29)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "EMPLOYEE NAME"
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.EmployeeNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(367, 124)
        Me.EmployeeNameTextBox.MaxLength = 25
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(253, 34)
        Me.EmployeeNameTextBox.TabIndex = 86
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(51, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 29)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "DESIGNATION"
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DesignationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.DesignationTextBox.Location = New System.Drawing.Point(367, 248)
        Me.DesignationTextBox.MaxLength = 25
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(254, 34)
        Me.DesignationTextBox.TabIndex = 101
        '
        'CityTextBox
        '
        Me.CityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(367, 422)
        Me.CityTextBox.MaxLength = 25
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(253, 34)
        Me.CityTextBox.TabIndex = 100
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(367, 379)
        Me.AddressTextBox.MaxLength = 50
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(253, 34)
        Me.AddressTextBox.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(50, 427)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 29)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "CITY"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(50, 386)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 29)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "ADDRESS"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(50, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 29)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "SALARY"
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SalaryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalaryTextBox.Location = New System.Drawing.Point(367, 333)
        Me.SalaryTextBox.MaxLength = 6
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(253, 34)
        Me.SalaryTextBox.TabIndex = 95
        '
        'WorkingExprerienceTextBox
        '
        Me.WorkingExprerienceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.WorkingExprerienceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingExprerienceTextBox.Location = New System.Drawing.Point(367, 465)
        Me.WorkingExprerienceTextBox.MaxLength = 2
        Me.WorkingExprerienceTextBox.Name = "WorkingExprerienceTextBox"
        Me.WorkingExprerienceTextBox.Size = New System.Drawing.Size(253, 34)
        Me.WorkingExprerienceTextBox.TabIndex = 105
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(50, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(299, 29)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "WORKING EXPERIENCE"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(50, 294)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 29)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "GENDER"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lost Leonenst", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lost Leonenst", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(163, 541)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1225, 266)
        Me.DataGridView1.TabIndex = 119
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(51, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 29)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(367, 206)
        Me.EmailTextBox.MaxLength = 50
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(254, 34)
        Me.EmailTextBox.TabIndex = 120
        '
        'GenderComboBox
        '
        Me.GenderComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GenderComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.GenderComboBox.Location = New System.Drawing.Point(367, 288)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(254, 37)
        Me.GenderComboBox.TabIndex = 123
        '
        'ShowDatbaseIconButton
        '
        Me.ShowDatbaseIconButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ShowDatbaseIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.ShowDatbaseIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ShowDatbaseIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowDatbaseIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.ShowDatbaseIconButton.IconChar = FontAwesome.Sharp.IconChar.Server
        Me.ShowDatbaseIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.ShowDatbaseIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ShowDatbaseIconButton.Location = New System.Drawing.Point(862, 483)
        Me.ShowDatbaseIconButton.Name = "ShowDatbaseIconButton"
        Me.ShowDatbaseIconButton.Size = New System.Drawing.Size(323, 51)
        Me.ShowDatbaseIconButton.TabIndex = 132
        Me.ShowDatbaseIconButton.Text = "SHOW DATABASE"
        Me.ShowDatbaseIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ShowDatbaseIconButton.UseVisualStyleBackColor = False
        '
        'AddIconButton
        '
        Me.AddIconButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AddIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.AddIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AddIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.AddIconButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.AddIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.AddIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddIconButton.Location = New System.Drawing.Point(711, 186)
        Me.AddIconButton.Name = "AddIconButton"
        Me.AddIconButton.Size = New System.Drawing.Size(191, 51)
        Me.AddIconButton.TabIndex = 131
        Me.AddIconButton.Text = "ADD"
        Me.AddIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddIconButton.UseVisualStyleBackColor = False
        '
        'RemoveIconButton
        '
        Me.RemoveIconButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RemoveIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.RemoveIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RemoveIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.RemoveIconButton.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.RemoveIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.RemoveIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RemoveIconButton.Location = New System.Drawing.Point(711, 247)
        Me.RemoveIconButton.Name = "RemoveIconButton"
        Me.RemoveIconButton.Size = New System.Drawing.Size(191, 51)
        Me.RemoveIconButton.TabIndex = 130
        Me.RemoveIconButton.Text = "REMOVE"
        Me.RemoveIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RemoveIconButton.UseVisualStyleBackColor = False
        '
        'UpdateIconButton
        '
        Me.UpdateIconButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UpdateIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.UpdateIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UpdateIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.UpdateIconButton.IconChar = FontAwesome.Sharp.IconChar.PenNib
        Me.UpdateIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.UpdateIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.UpdateIconButton.Location = New System.Drawing.Point(711, 304)
        Me.UpdateIconButton.Name = "UpdateIconButton"
        Me.UpdateIconButton.Size = New System.Drawing.Size(191, 51)
        Me.UpdateIconButton.TabIndex = 129
        Me.UpdateIconButton.Text = "UPDATE"
        Me.UpdateIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpdateIconButton.UseVisualStyleBackColor = False
        '
        'ClearIconButton
        '
        Me.ClearIconButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ClearIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.ClearIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClearIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.ClearIconButton.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.ClearIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.ClearIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ClearIconButton.Location = New System.Drawing.Point(711, 361)
        Me.ClearIconButton.Name = "ClearIconButton"
        Me.ClearIconButton.Size = New System.Drawing.Size(191, 51)
        Me.ClearIconButton.TabIndex = 128
        Me.ClearIconButton.Text = "CLEAR"
        Me.ClearIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ClearIconButton.UseVisualStyleBackColor = False
        '
        'SearchIconButton
        '
        Me.SearchIconButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SearchIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.SearchIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SearchIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.SearchIconButton.IconChar = FontAwesome.Sharp.IconChar.Searchengin
        Me.SearchIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.SearchIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SearchIconButton.Location = New System.Drawing.Point(711, 129)
        Me.SearchIconButton.Name = "SearchIconButton"
        Me.SearchIconButton.Size = New System.Drawing.Size(191, 51)
        Me.SearchIconButton.TabIndex = 127
        Me.SearchIconButton.Text = "SEARCH"
        Me.SearchIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchIconButton.UseVisualStyleBackColor = False
        '
        'EmploeeDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1483, 785)
        Me.ControlBox = False
        Me.Controls.Add(Me.ShowDatbaseIconButton)
        Me.Controls.Add(Me.AddIconButton)
        Me.Controls.Add(Me.RemoveIconButton)
        Me.Controls.Add(Me.UpdateIconButton)
        Me.Controls.Add(Me.ClearIconButton)
        Me.Controls.Add(Me.SearchIconButton)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.WorkingExprerienceTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DesignationTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EmploeeDetailsForm"
        Me.Text = "Employee Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DesignationTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents WorkingExprerienceTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents ShowDatbaseIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents AddIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents RemoveIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents UpdateIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ClearIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents SearchIconButton As FontAwesome.Sharp.IconButton
End Class
