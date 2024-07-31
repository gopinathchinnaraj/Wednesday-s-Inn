<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodDetailsForm
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
        Me.FoodIDTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FoodNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FoodTypeComboBox = New System.Windows.Forms.ComboBox()
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
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(340, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 31)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "FOOD DETAILS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(265, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 31)
        Me.Label13.TabIndex = 123
        Me.Label13.Text = "FOOD ID"
        '
        'FoodIDTextBox
        '
        Me.FoodIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FoodIDTextBox.Font = New System.Drawing.Font("Lost Leonenst", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoodIDTextBox.Location = New System.Drawing.Point(581, 169)
        Me.FoodIDTextBox.MaxLength = 4
        Me.FoodIDTextBox.Name = "FoodIDTextBox"
        Me.FoodIDTextBox.Size = New System.Drawing.Size(254, 31)
        Me.FoodIDTextBox.TabIndex = 122
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PriceTextBox.Font = New System.Drawing.Font("Lost Leonenst", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(582, 302)
        Me.PriceTextBox.MaxLength = 4
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(253, 31)
        Me.PriceTextBox.TabIndex = 121
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(265, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 31)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "PRICE"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(265, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 31)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "FOOD NAME"
        '
        'FoodNameTextBox
        '
        Me.FoodNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FoodNameTextBox.Font = New System.Drawing.Font("Lost Leonenst", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoodNameTextBox.Location = New System.Drawing.Point(582, 256)
        Me.FoodNameTextBox.MaxLength = 30
        Me.FoodNameTextBox.Name = "FoodNameTextBox"
        Me.FoodNameTextBox.Size = New System.Drawing.Size(253, 31)
        Me.FoodNameTextBox.TabIndex = 118
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(265, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 31)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "FOOD TYPE"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lost Leonenst", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DataGridView1.Location = New System.Drawing.Point(251, 459)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1043, 319)
        Me.DataGridView1.TabIndex = 133
        '
        'FoodTypeComboBox
        '
        Me.FoodTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FoodTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoodTypeComboBox.FormattingEnabled = True
        Me.FoodTypeComboBox.Items.AddRange(New Object() {"Veg", "Non Veg", "Drink", "Ice Cream"})
        Me.FoodTypeComboBox.Location = New System.Drawing.Point(581, 214)
        Me.FoodTypeComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FoodTypeComboBox.Name = "FoodTypeComboBox"
        Me.FoodTypeComboBox.Size = New System.Drawing.Size(254, 33)
        Me.FoodTypeComboBox.TabIndex = 135
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
        Me.ShowDatbaseIconButton.Location = New System.Drawing.Point(1063, 401)
        Me.ShowDatbaseIconButton.Name = "ShowDatbaseIconButton"
        Me.ShowDatbaseIconButton.Size = New System.Drawing.Size(323, 51)
        Me.ShowDatbaseIconButton.TabIndex = 141
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
        Me.AddIconButton.Location = New System.Drawing.Point(883, 159)
        Me.AddIconButton.Name = "AddIconButton"
        Me.AddIconButton.Size = New System.Drawing.Size(191, 51)
        Me.AddIconButton.TabIndex = 140
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
        Me.RemoveIconButton.Location = New System.Drawing.Point(883, 220)
        Me.RemoveIconButton.Name = "RemoveIconButton"
        Me.RemoveIconButton.Size = New System.Drawing.Size(191, 51)
        Me.RemoveIconButton.TabIndex = 139
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
        Me.UpdateIconButton.Location = New System.Drawing.Point(883, 277)
        Me.UpdateIconButton.Name = "UpdateIconButton"
        Me.UpdateIconButton.Size = New System.Drawing.Size(191, 51)
        Me.UpdateIconButton.TabIndex = 138
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
        Me.ClearIconButton.Location = New System.Drawing.Point(883, 334)
        Me.ClearIconButton.Name = "ClearIconButton"
        Me.ClearIconButton.Size = New System.Drawing.Size(191, 51)
        Me.ClearIconButton.TabIndex = 137
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
        Me.SearchIconButton.Location = New System.Drawing.Point(883, 102)
        Me.SearchIconButton.Name = "SearchIconButton"
        Me.SearchIconButton.Size = New System.Drawing.Size(191, 51)
        Me.SearchIconButton.TabIndex = 136
        Me.SearchIconButton.Text = "SEARCH"
        Me.SearchIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchIconButton.UseVisualStyleBackColor = False
        '
        'FoodDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1486, 805)
        Me.ControlBox = False
        Me.Controls.Add(Me.ShowDatbaseIconButton)
        Me.Controls.Add(Me.AddIconButton)
        Me.Controls.Add(Me.RemoveIconButton)
        Me.Controls.Add(Me.UpdateIconButton)
        Me.Controls.Add(Me.ClearIconButton)
        Me.Controls.Add(Me.SearchIconButton)
        Me.Controls.Add(Me.FoodTypeComboBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.FoodIDTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FoodNameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FoodDetailsForm"
        Me.Text = "Food Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents FoodIDTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FoodNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FoodTypeComboBox As ComboBox
    Friend WithEvents ShowDatbaseIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents AddIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents RemoveIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents UpdateIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ClearIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents SearchIconButton As FontAwesome.Sharp.IconButton
End Class
