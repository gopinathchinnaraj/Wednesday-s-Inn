<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class History
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SearchIconButton = New FontAwesome.Sharp.IconButton()
        Me.OrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Font = New System.Drawing.Font("Lost Leonenst", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumPurple
        Me.GroupBox1.Location = New System.Drawing.Point(44, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1297, 569)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FoodHistory"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SearchIconButton)
        Me.GroupBox2.Controls.Add(Me.OrderIDTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.MediumPurple
        Me.GroupBox2.Location = New System.Drawing.Point(708, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 197)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Details"
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
        Me.SearchIconButton.Location = New System.Drawing.Point(262, 103)
        Me.SearchIconButton.Name = "SearchIconButton"
        Me.SearchIconButton.Size = New System.Drawing.Size(191, 51)
        Me.SearchIconButton.TabIndex = 128
        Me.SearchIconButton.Text = "SEARCH"
        Me.SearchIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchIconButton.UseVisualStyleBackColor = False
        '
        'OrderIDTextBox
        '
        Me.OrderIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIDTextBox.Location = New System.Drawing.Point(209, 60)
        Me.OrderIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OrderIDTextBox.Name = "OrderIDTextBox"
        Me.OrderIDTextBox.Size = New System.Drawing.Size(244, 30)
        Me.OrderIDTextBox.TabIndex = 120
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(52, 57)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 29)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Order ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-11, -49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(405, 37)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "View Hotel Food History...?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(11, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(383, 29)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "View Card Paid Orders...?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(11, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(382, 29)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "View Cash Paid Orders...?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(11, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(402, 29)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "View Total Order Count...?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(11, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(380, 29)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "View Total Food Sales...?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-11, -49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 37)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "View Hotel Food History...?"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView2.Location = New System.Drawing.Point(18, 290)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1263, 260)
        Me.DataGridView2.TabIndex = 117
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.SystemColors.MenuText
        Me.IconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconButton2.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Forward
        Me.IconButton2.IconColor = System.Drawing.Color.MediumPurple
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(1168, 678)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(76, 51)
        Me.IconButton2.TabIndex = 129
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1363, 781)
        Me.ControlBox = False
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "History"
        Me.Text = "Food History"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents OrderIDTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SearchIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
