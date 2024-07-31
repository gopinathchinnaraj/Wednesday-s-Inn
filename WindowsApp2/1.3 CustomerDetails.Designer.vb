<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IDProofTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SearchIconButton = New FontAwesome.Sharp.IconButton()
        Me.ClearIconButton = New FontAwesome.Sharp.IconButton()
        Me.UpdateIconButton = New FontAwesome.Sharp.IconButton()
        Me.RemoveIconButton = New FontAwesome.Sharp.IconButton()
        Me.AddIconButton = New FontAwesome.Sharp.IconButton()
        Me.ShowDatbaseIconButton = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(275, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(188, 29)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "CUSTOMER ID"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(620, 109)
        Me.CustomerIDTextBox.MaxLength = 5
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(254, 34)
        Me.CustomerIDTextBox.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(275, 379)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 29)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "ADDRESS"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.AddressTextBox.Location = New System.Drawing.Point(620, 377)
        Me.AddressTextBox.MaxLength = 45
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(253, 34)
        Me.AddressTextBox.TabIndex = 64
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.EmailTextBox.Location = New System.Drawing.Point(621, 316)
        Me.EmailTextBox.MaxLength = 45
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(253, 34)
        Me.EmailTextBox.TabIndex = 63
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(620, 265)
        Me.PhoneNumberTextBox.MaxLength = 10
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(253, 34)
        Me.PhoneNumberTextBox.TabIndex = 62
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LastNameTextBox.Location = New System.Drawing.Point(620, 214)
        Me.LastNameTextBox.MaxLength = 45
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(253, 34)
        Me.LastNameTextBox.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(275, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 29)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "E-MAIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(274, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 29)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "PHONE NUMBER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(274, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 29)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "LAST NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(274, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 29)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "FIRST NAME"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.FirstNameTextBox.Location = New System.Drawing.Point(620, 161)
        Me.FirstNameTextBox.MaxLength = 45
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(253, 34)
        Me.FirstNameTextBox.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(434, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 29)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "CUSTOMER DETAILS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(275, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(283, 29)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "ID PROOF(AADHAAR)"
        '
        'IDProofTextBox
        '
        Me.IDProofTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDProofTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.IDProofTextBox.Location = New System.Drawing.Point(620, 427)
        Me.IDProofTextBox.MaxLength = 12
        Me.IDProofTextBox.Name = "IDProofTextBox"
        Me.IDProofTextBox.Size = New System.Drawing.Size(254, 34)
        Me.IDProofTextBox.TabIndex = 86
        '
        'DataGridView1
        '
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
        Me.DataGridView1.Location = New System.Drawing.Point(186, 529)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1109, 260)
        Me.DataGridView1.TabIndex = 108
        '
        'SearchIconButton
        '
        Me.SearchIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.SearchIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SearchIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.SearchIconButton.IconChar = FontAwesome.Sharp.IconChar.Searchengin
        Me.SearchIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.SearchIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SearchIconButton.Location = New System.Drawing.Point(911, 149)
        Me.SearchIconButton.Name = "SearchIconButton"
        Me.SearchIconButton.Size = New System.Drawing.Size(191, 51)
        Me.SearchIconButton.TabIndex = 121
        Me.SearchIconButton.Text = "SEARCH"
        Me.SearchIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchIconButton.UseVisualStyleBackColor = False
        '
        'ClearIconButton
        '
        Me.ClearIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.ClearIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClearIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.ClearIconButton.IconChar = FontAwesome.Sharp.IconChar.Broom
        Me.ClearIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.ClearIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ClearIconButton.Location = New System.Drawing.Point(911, 381)
        Me.ClearIconButton.Name = "ClearIconButton"
        Me.ClearIconButton.Size = New System.Drawing.Size(191, 51)
        Me.ClearIconButton.TabIndex = 122
        Me.ClearIconButton.Text = "CLEAR"
        Me.ClearIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ClearIconButton.UseVisualStyleBackColor = False
        '
        'UpdateIconButton
        '
        Me.UpdateIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.UpdateIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UpdateIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.UpdateIconButton.IconChar = FontAwesome.Sharp.IconChar.PenNib
        Me.UpdateIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.UpdateIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.UpdateIconButton.Location = New System.Drawing.Point(911, 324)
        Me.UpdateIconButton.Name = "UpdateIconButton"
        Me.UpdateIconButton.Size = New System.Drawing.Size(191, 51)
        Me.UpdateIconButton.TabIndex = 123
        Me.UpdateIconButton.Text = "UPDATE"
        Me.UpdateIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpdateIconButton.UseVisualStyleBackColor = False
        '
        'RemoveIconButton
        '
        Me.RemoveIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.RemoveIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RemoveIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.RemoveIconButton.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.RemoveIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.RemoveIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RemoveIconButton.Location = New System.Drawing.Point(911, 267)
        Me.RemoveIconButton.Name = "RemoveIconButton"
        Me.RemoveIconButton.Size = New System.Drawing.Size(191, 51)
        Me.RemoveIconButton.TabIndex = 124
        Me.RemoveIconButton.Text = "REMOVE"
        Me.RemoveIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RemoveIconButton.UseVisualStyleBackColor = False
        '
        'AddIconButton
        '
        Me.AddIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.AddIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AddIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.AddIconButton.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.AddIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.AddIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AddIconButton.Location = New System.Drawing.Point(911, 206)
        Me.AddIconButton.Name = "AddIconButton"
        Me.AddIconButton.Size = New System.Drawing.Size(191, 51)
        Me.AddIconButton.TabIndex = 125
        Me.AddIconButton.Text = "ADD"
        Me.AddIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddIconButton.UseVisualStyleBackColor = False
        '
        'ShowDatbaseIconButton
        '
        Me.ShowDatbaseIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.ShowDatbaseIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ShowDatbaseIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowDatbaseIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.ShowDatbaseIconButton.IconChar = FontAwesome.Sharp.IconChar.Server
        Me.ShowDatbaseIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.ShowDatbaseIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ShowDatbaseIconButton.Location = New System.Drawing.Point(1062, 470)
        Me.ShowDatbaseIconButton.Name = "ShowDatbaseIconButton"
        Me.ShowDatbaseIconButton.Size = New System.Drawing.Size(323, 51)
        Me.ShowDatbaseIconButton.TabIndex = 126
        Me.ShowDatbaseIconButton.Text = "SHOW DATABASE"
        Me.ShowDatbaseIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ShowDatbaseIconButton.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.SystemColors.MenuText
        Me.IconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconButton1.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight
        Me.IconButton1.IconColor = System.Drawing.Color.MediumPurple
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(911, 92)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(323, 51)
        Me.IconButton1.TabIndex = 127
        Me.IconButton1.Text = "New Customer"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'CustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1397, 874)
        Me.ControlBox = False
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.ShowDatbaseIconButton)
        Me.Controls.Add(Me.AddIconButton)
        Me.Controls.Add(Me.RemoveIconButton)
        Me.Controls.Add(Me.UpdateIconButton)
        Me.Controls.Add(Me.ClearIconButton)
        Me.Controls.Add(Me.SearchIconButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IDProofTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CustomerDetails"
        Me.Text = "Customer Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IDProofTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SearchIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ClearIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents UpdateIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents RemoveIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents AddIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ShowDatbaseIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
