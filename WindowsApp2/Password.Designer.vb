<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Password))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoginconButton = New FontAwesome.Sharp.IconButton()
        Me.CancelIconButton = New FontAwesome.Sharp.IconButton()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Controls.Add(Me.PasswordTextBox)
        Me.Panel3.Controls.Add(Me.UsernameTextBox)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(555, 158)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(484, 463)
        Me.Panel3.TabIndex = 5
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(232, 257)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(201, 41)
        Me.PasswordTextBox.TabIndex = 4
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(232, 176)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(201, 41)
        Me.UsernameTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(58, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(58, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.Location = New System.Drawing.Point(41, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "login"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(58, 137)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 511)
        Me.Panel1.TabIndex = 4
        '
        'LoginconButton
        '
        Me.LoginconButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LoginconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.LoginconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LoginconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.LoginconButton.IconChar = FontAwesome.Sharp.IconChar.RightToBracket
        Me.LoginconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.LoginconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.LoginconButton.Location = New System.Drawing.Point(619, 505)
        Me.LoginconButton.Name = "LoginconButton"
        Me.LoginconButton.Size = New System.Drawing.Size(191, 51)
        Me.LoginconButton.TabIndex = 134
        Me.LoginconButton.Text = "LOGIN"
        Me.LoginconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LoginconButton.UseVisualStyleBackColor = False
        '
        'CancelIconButton
        '
        Me.CancelIconButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CancelIconButton.BackColor = System.Drawing.SystemColors.MenuText
        Me.CancelIconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelIconButton.Font = New System.Drawing.Font("Lost Leonenst", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelIconButton.ForeColor = System.Drawing.Color.MediumPurple
        Me.CancelIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.CancelIconButton.IconColor = System.Drawing.Color.MediumPurple
        Me.CancelIconButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CancelIconButton.Location = New System.Drawing.Point(818, 505)
        Me.CancelIconButton.Name = "CancelIconButton"
        Me.CancelIconButton.Size = New System.Drawing.Size(191, 51)
        Me.CancelIconButton.TabIndex = 135
        Me.CancelIconButton.Text = "CANCEL"
        Me.CancelIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelIconButton.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1096, 784)
        Me.ControlBox = False
        Me.Controls.Add(Me.LoginconButton)
        Me.Controls.Add(Me.CancelIconButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LoginconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents CancelIconButton As FontAwesome.Sharp.IconButton
End Class
