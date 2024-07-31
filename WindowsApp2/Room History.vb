Imports System.Data.Odbc

Public Class Room_History


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            sql = "select Booking_ID,Customer_ID,First_Name,Last_Name,Phone_Number,Email,Address,ID_Proof,Room from bookingdetails"
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Try
            sql = " select Booking_ID,Customer_ID,First_Name,Last_Name,Phone_Number,Payment_type,Room,Price from bookingdetails"
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Try
            sql = " select Booking_ID,Customer_ID,First_Name,Last_Name,Phone_Number,Room_Type,Room_No,No_of_Adults,no_of_child,Check_in_date,Check_out_date,Payment_type,Room,Price from bookingdetails "
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Try
            sql = " select Booking_ID,Customer_ID,First_Name,Last_Name,Phone_Number,Check_in_date,Check_out_date,Room from bookingdetails "
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Try
            sql = " select count(*) from bookingdetails "
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Try
            sql = " select Booking_ID,Customer_ID,First_Name,Last_Name,Phone_Number,Payment_type,Room,Price from bookingdetails where Payment_type='CARD' "
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Try
            sql = " select Booking_ID,Customer_ID,First_Name,Last_Name,Phone_Number,Payment_type,Room,Price from bookingdetails where Payment_type='CASH' "
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Try
            sql = "select sum(Price) from bookingdetails"
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Form1.CustomerfeedbackIconButton.PerformClick()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Form1.FoodHistoryIconButton.PerformClick()
    End Sub

    Private Sub SearchIconButton_Click(sender As Object, e As EventArgs) Handles SearchIconButton.Click
        Try
            sql = " select Booking_ID,Customer_ID,First_Name,Last_Name,Phone_Number,Room_Type,Room_No,No_of_Adults,no_of_child,Check_in_date,Check_out_date,Payment_type,Room,Price from bookingdetails where Customer_ID='" & OrderIDTextBox.Text & "'  "
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Room_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2.DefaultCellStyle.ForeColor = Color.Black
        Call conn1()
    End Sub
End Class