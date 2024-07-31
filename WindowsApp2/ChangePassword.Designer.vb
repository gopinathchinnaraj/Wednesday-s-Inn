<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UaserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShowDatbaseIconButton = New FontAwesome.Sharp.IconButton()
        Me.AddIconButton = New FontAwesome.Sharp.IconButton()
        Me.RemoveIconButton = New FontAwesome.Sharp.IconButton()
        Me.UpdateIconButton = New FontAwesome.Sharp.IconButton()
        Me.ClearIconButton = New FontAwesome.Sharp.IconButton()
        Me.SearchIconButton = New FontAwesome.Sharp.IconButton()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Controls.Add(Me.PasswordTextBox)
        Me.Panel3.Controls.Add(Me.UaserNameTextBox)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(655, 81)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(484, 463)
        Me.Panel3.TabIndex = 142
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordTextBox.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(235, 258)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(201, 35)
        Me.PasswordTextBox.TabIndex = 4
        '
        'UaserNameTextBox
        '
        Me.UaserNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UaserNameTextBox.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UaserNameTextBox.Location = New System.Drawing.Point(232, 177)
        Me.UaserNameTextBox.Name = "UaserNameTextBox"
        Me.UaserNameTextBox.Size = New System.Drawing.Size(201, 35)
        Me.UaserNameTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(58, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(58, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.Location = New System.Drawing.Point(41, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN DETAILS"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lost Leonenst", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText
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
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(614, 632)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(575, 260)
        Me.DataGridView1.TabIndex = 147
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(158, 60)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 511)
        Me.Panel1.TabIndex = 141
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
        Me.ShowDatbaseIconButton.Location = New System.Drawing.Point(816, 575)
        Me.ShowDatbaseIconButton.Name = "ShowDatbaseIconButton"
        Me.ShowDatbaseIconButton.Size = New System.Drawing.Size(323, 51)
        Me.ShowDatbaseIconButton.TabIndex = 138
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
        Me.AddIconButton.Location = New System.Drawing.Point(1163, 173)
        Me.AddIconButton.Name = "AddIconButton"
        Me.AddIconButton.Size = New System.Drawing.Size(191, 51)
        Me.AddIconButton.TabIndex = 137
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
        Me.RemoveIconButton.Location = New System.Drawing.Point(1163, 234)
        Me.RemoveIconButton.Name = "RemoveIconButton"
        Me.RemoveIconButton.Size = New System.Drawing.Size(191, 51)
        Me.RemoveIconButton.TabIndex = 136
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
        Me.UpdateIconButton.Location = New System.Drawing.Point(1163, 291)
        Me.UpdateIconButton.Name = "UpdateIconButton"
        Me.UpdateIconButton.Size = New System.Drawing.Size(191, 51)
        Me.UpdateIconButton.TabIndex = 135
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
        Me.ClearIconButton.Location = New System.Drawing.Point(1163, 348)
        Me.ClearIconButton.Name = "ClearIconButton"
        Me.ClearIconButton.Size = New System.Drawing.Size(191, 51)
        Me.ClearIconButton.TabIndex = 134
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
        Me.SearchIconButton.Location = New System.Drawing.Point(1163, 116)
        Me.SearchIconButton.Name = "SearchIconButton"
        Me.SearchIconButton.Size = New System.Drawing.Size(191, 51)
        Me.SearchIconButton.TabIndex = 133
        Me.SearchIconButton.Text = "SEARCH"
        Me.SearchIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchIconButton.UseVisualStyleBackColor = False
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1482, 953)
        Me.Controls.Add(Me.ShowDatbaseIconButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.AddIconButton)
        Me.Controls.Add(Me.RemoveIconButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.UpdateIconButton)
        Me.Controls.Add(Me.ClearIconButton)
        Me.Controls.Add(Me.SearchIconButton)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ChangePassword"
        Me.Text = "ChangePassword"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UaserNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShowDatbaseIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents AddIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents RemoveIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents UpdateIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ClearIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents SearchIconButton As FontAwesome.Sharp.IconButton
End Class
