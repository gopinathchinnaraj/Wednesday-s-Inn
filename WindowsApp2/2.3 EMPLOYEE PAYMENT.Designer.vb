<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeePaymentForm
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DATextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WorkingDaysTextBox = New System.Windows.Forms.TextBox()
        Me.GrossPayTextBox = New System.Windows.Forms.TextBox()
        Me.DeductionTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.HRATextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EmploeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.SearchIconButton = New FontAwesome.Sharp.IconButton()
        Me.CalculateIconButton = New FontAwesome.Sharp.IconButton()
        Me.SubmiteIconButton = New FontAwesome.Sharp.IconButton()
        Me.ClearIconButton = New FontAwesome.Sharp.IconButton()
        Me.ShowDatbaseIconButton = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(357, 478)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(224, 30)
        Me.DateTimePicker1.TabIndex = 162
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGray
        Me.Label9.Location = New System.Drawing.Point(42, 478)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(275, 31)
        Me.Label9.TabIndex = 161
        Me.Label9.Text = "DATE OF PAYMENT"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lost Leonenst", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(151, 555)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1220, 319)
        Me.DataGridView1.TabIndex = 159
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(41, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 31)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "DA"
        '
        'DATextBox
        '
        Me.DATextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATextBox.Location = New System.Drawing.Point(357, 298)
        Me.DATextBox.Name = "DATextBox"
        Me.DATextBox.Size = New System.Drawing.Size(224, 34)
        Me.DATextBox.TabIndex = 153
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(42, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 31)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "WORKING DAYS"
        '
        'WorkingDaysTextBox
        '
        Me.WorkingDaysTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WorkingDaysTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkingDaysTextBox.Location = New System.Drawing.Point(358, 257)
        Me.WorkingDaysTextBox.Name = "WorkingDaysTextBox"
        Me.WorkingDaysTextBox.Size = New System.Drawing.Size(224, 34)
        Me.WorkingDaysTextBox.TabIndex = 151
        '
        'GrossPayTextBox
        '
        Me.GrossPayTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrossPayTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossPayTextBox.Location = New System.Drawing.Point(358, 431)
        Me.GrossPayTextBox.Name = "GrossPayTextBox"
        Me.GrossPayTextBox.Size = New System.Drawing.Size(223, 34)
        Me.GrossPayTextBox.TabIndex = 150
        '
        'DeductionTextBox
        '
        Me.DeductionTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeductionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeductionTextBox.Location = New System.Drawing.Point(358, 388)
        Me.DeductionTextBox.Name = "DeductionTextBox"
        Me.DeductionTextBox.Size = New System.Drawing.Size(223, 34)
        Me.DeductionTextBox.TabIndex = 149
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(41, 436)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 31)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "GROSS PAY"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(41, 395)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 31)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "DEDUCTION"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(41, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 31)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "HRA"
        '
        'HRATextBox
        '
        Me.HRATextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HRATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HRATextBox.Location = New System.Drawing.Point(358, 342)
        Me.HRATextBox.Name = "HRATextBox"
        Me.HRATextBox.Size = New System.Drawing.Size(223, 34)
        Me.HRATextBox.TabIndex = 145
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(117, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 31)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "EMPLOYEE PAYMENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(42, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(197, 31)
        Me.Label13.TabIndex = 143
        Me.Label13.Text = "EMPLOYEE ID"
        '
        'EmploeeIDTextBox
        '
        Me.EmploeeIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmploeeIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmploeeIDTextBox.Location = New System.Drawing.Point(358, 72)
        Me.EmploeeIDTextBox.Name = "EmploeeIDTextBox"
        Me.EmploeeIDTextBox.Size = New System.Drawing.Size(224, 34)
        Me.EmploeeIDTextBox.TabIndex = 142
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalaryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalaryTextBox.Location = New System.Drawing.Point(358, 207)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(223, 34)
        Me.SalaryTextBox.TabIndex = 141
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DesignationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignationTextBox.Location = New System.Drawing.Point(358, 164)
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(223, 34)
        Me.DesignationTextBox.TabIndex = 140
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(41, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 31)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "SALARY"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(41, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 31)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "DESIGNATION"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(41, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 31)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "EMPOLYEE NAME"
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmployeeNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(358, 118)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(223, 34)
        Me.EmployeeNameTextBox.TabIndex = 136
        '
        'SearchIconButton
        '
        Me.SearchIconButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.SearchIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SearchIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.SearchIconButton.IconChar = FontAwesome.Sharp.IconChar.Searchengin
        Me.SearchIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.SearchIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SearchIconButton.Location = New System.Drawing.Point(652, 123)
        Me.SearchIconButton.Name = "SearchIconButton"
        Me.SearchIconButton.Size = New System.Drawing.Size(251, 51)
        Me.SearchIconButton.TabIndex = 163
        Me.SearchIconButton.Text = "SEARCH"
        Me.SearchIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchIconButton.UseVisualStyleBackColor = False
        '
        'CalculateIconButton
        '
        Me.CalculateIconButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalculateIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.CalculateIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CalculateIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.CalculateIconButton.IconChar = FontAwesome.Sharp.IconChar.Calculator
        Me.CalculateIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.CalculateIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CalculateIconButton.Location = New System.Drawing.Point(652, 180)
        Me.CalculateIconButton.Name = "CalculateIconButton"
        Me.CalculateIconButton.Size = New System.Drawing.Size(251, 51)
        Me.CalculateIconButton.TabIndex = 164
        Me.CalculateIconButton.Text = "CALCULATE"
        Me.CalculateIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CalculateIconButton.UseVisualStyleBackColor = False
        '
        'SubmiteIconButton
        '
        Me.SubmiteIconButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubmiteIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.SubmiteIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SubmiteIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmiteIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.SubmiteIconButton.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.SubmiteIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.SubmiteIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SubmiteIconButton.Location = New System.Drawing.Point(652, 237)
        Me.SubmiteIconButton.Name = "SubmiteIconButton"
        Me.SubmiteIconButton.Size = New System.Drawing.Size(251, 51)
        Me.SubmiteIconButton.TabIndex = 165
        Me.SubmiteIconButton.Text = "SUBMIT"
        Me.SubmiteIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SubmiteIconButton.UseVisualStyleBackColor = False
        '
        'ClearIconButton
        '
        Me.ClearIconButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.ClearIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClearIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.ClearIconButton.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.ClearIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.ClearIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ClearIconButton.Location = New System.Drawing.Point(652, 298)
        Me.ClearIconButton.Name = "ClearIconButton"
        Me.ClearIconButton.Size = New System.Drawing.Size(251, 51)
        Me.ClearIconButton.TabIndex = 166
        Me.ClearIconButton.Text = "CLEAR"
        Me.ClearIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ClearIconButton.UseVisualStyleBackColor = False
        '
        'ShowDatbaseIconButton
        '
        Me.ShowDatbaseIconButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowDatbaseIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.ShowDatbaseIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ShowDatbaseIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowDatbaseIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.ShowDatbaseIconButton.IconChar = FontAwesome.Sharp.IconChar.Server
        Me.ShowDatbaseIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.ShowDatbaseIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ShowDatbaseIconButton.Location = New System.Drawing.Point(992, 497)
        Me.ShowDatbaseIconButton.Name = "ShowDatbaseIconButton"
        Me.ShowDatbaseIconButton.Size = New System.Drawing.Size(323, 51)
        Me.ShowDatbaseIconButton.TabIndex = 167
        Me.ShowDatbaseIconButton.Text = "SHOW DATABASE"
        Me.ShowDatbaseIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ShowDatbaseIconButton.UseVisualStyleBackColor = False
        '
        'EmployeePaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1498, 998)
        Me.ControlBox = False
        Me.Controls.Add(Me.ShowDatbaseIconButton)
        Me.Controls.Add(Me.ClearIconButton)
        Me.Controls.Add(Me.SubmiteIconButton)
        Me.Controls.Add(Me.CalculateIconButton)
        Me.Controls.Add(Me.SearchIconButton)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DATextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.WorkingDaysTextBox)
        Me.Controls.Add(Me.GrossPayTextBox)
        Me.Controls.Add(Me.DeductionTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.HRATextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.EmploeeIDTextBox)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Me.DesignationTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmployeeNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EmployeePaymentForm"
        Me.Text = "Employee payment Info"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents DATextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents WorkingDaysTextBox As TextBox
    Friend WithEvents GrossPayTextBox As TextBox
    Friend WithEvents DeductionTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents HRATextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents EmploeeIDTextBox As TextBox
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents DesignationTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents SearchIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents CalculateIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents SubmiteIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ClearIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ShowDatbaseIconButton As FontAwesome.Sharp.IconButton
End Class
