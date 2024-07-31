Public Class BookRoom
    Public RoomPrice As Integer = 0

    Private Sub SearchIconButton_Click(sender As Object, e As EventArgs) Handles SearchIconButton.Click
        Dim price As Integer
        price = Val(1000)
        sendprice("Simple_Room", "1000")
        Form1.BillingIconButton.PerformClick()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim price As Integer
        price = Val(3000)
        sendprice("Standard_Room", "3000")
        Form1.BillingIconButton.PerformClick()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim price As Integer
        price = Val(5000)
        sendprice("Duplex Room Book", "5000")
        Form1.BillingIconButton.PerformClick()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Dim price As Integer
        price = Val(10000)
        sendprice("Luxury Room", "10000")
        Form1.BillingIconButton.PerformClick()
    End Sub
End Class