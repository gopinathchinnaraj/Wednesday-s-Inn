<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Feedback
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
        Me.FeedbackTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchIconButton = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'FeedbackTextBox
        '
        Me.FeedbackTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FeedbackTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold)
        Me.FeedbackTextBox.Location = New System.Drawing.Point(526, 259)
        Me.FeedbackTextBox.Name = "FeedbackTextBox"
        Me.FeedbackTextBox.Size = New System.Drawing.Size(355, 53)
        Me.FeedbackTextBox.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lost Leonenst", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(178, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 41)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "FEEDBACK"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lost Leonenst", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(178, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(269, 41)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "CUSTOMER ID"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CustomerIDTextBox.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold)
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(526, 178)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(355, 53)
        Me.CustomerIDTextBox.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lost Leonenst", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(298, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 29)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "CUSTOMER FEEDBACK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SearchIconButton
        '
        Me.SearchIconButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SearchIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.SearchIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SearchIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.SearchIconButton.IconChar = FontAwesome.Sharp.IconChar.Rocket
        Me.SearchIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.SearchIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SearchIconButton.Location = New System.Drawing.Point(664, 333)
        Me.SearchIconButton.Name = "SearchIconButton"
        Me.SearchIconButton.Size = New System.Drawing.Size(191, 51)
        Me.SearchIconButton.TabIndex = 134
        Me.SearchIconButton.Text = "SUBMIT"
        Me.SearchIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchIconButton.UseVisualStyleBackColor = False
        '
        'Customer_Feedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1058, 544)
        Me.Controls.Add(Me.SearchIconButton)
        Me.Controls.Add(Me.FeedbackTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Customer_Feedback"
        Me.Text = "Customer_Feedback"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FeedbackTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchIconButton As FontAwesome.Sharp.IconButton
End Class
