Imports FontAwesome.Sharp
Public Class Admin
    'fields
    Private currentBtn As IconButton
    Private leftBoarderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBoarderBtn = New Panel()
        leftBoarderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBoarderBtn)

        'form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    Private Sub ActivateButton(SenderBtn As Object, customColor As Color)
        If SenderBtn IsNot Nothing Then
            Disablebutton()
            'Button
            currentBtn = CType(SenderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'left button
            leftBoarderBtn.BackColor = customColor
            leftBoarderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBoarderBtn.BringToFront()
            leftBoarderBtn.Visible = True
            'current form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
            Title_Lable.ForeColor = customColor

        End If

    End Sub
    Private Sub Disablebutton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(0, 0, 1)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText

        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form, customColor As Color)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        Title_Lable.Text = childForm.Text
        Title_Lable.ForeColor = customColor
    End Sub


    Private Sub Reset()
        Disablebutton()
        leftBoarderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        Title_Lable.Text = "Home"
    End Sub

    Private Sub PanelDesktop_Resize(sender As Object, e As EventArgs) Handles PanelDesktop.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()

        End If
        Reset()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender, RGBColora.color1)
        OpenChildForm(New EmploeeDetailsForm, RGBColora.color1)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActivateButton(sender, RGBColora.color1)
        OpenChildForm(New EmployeePaymentForm, RGBColora.color1)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        ActivateButton(sender, RGBColora.color1)
        OpenChildForm(New FoodDetailsForm, RGBColora.color1)
    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActivateButton(sender, RGBColora.color1)
        OpenChildForm(New ChangePassword, RGBColora.color1)
    End Sub


    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Form1.Show()
        Me.Visible = False
    End Sub

    Private Sub IconButton8_Click_1(sender As Object, e As EventArgs) Handles IconButton8.Click
        End
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class