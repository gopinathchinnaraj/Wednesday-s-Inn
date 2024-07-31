Imports System.Data.Odbc
Public Class Billing_page
    Public Check_IN, Check_Out As String

    Private Sub Billing_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn1()
        add()
        prx(RoomTextBox, TotalPriceTextBox)
    End Sub

    Private Sub add()
        Try
            sql = "select count(*) from bookingdetails "
            dml = New OdbcCommand(sql, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                BookingIDTextBox.Text = dr.GetValue(0) + Val(1001)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BookingIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub RoomNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub CustomerIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FirstNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "qwertyuioplkjhgfdsazxcvbnm"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("plz enter a character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LastNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "qwertyuioplkjhgfdsazxcvbnm"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("plz enter a character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PhoneNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub EmailTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "qwertyuioplkjhgfdsazxcvbnm"
            Dim allowednos As String = "1234567890"
            Dim allowedsymbols As String = "@."
            If Not allowednos.Contains(e.KeyChar.ToString.ToLower) And Not allowedchars.Contains(e.KeyChar.ToString.ToLower) And Not allowedsymbols.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("please enter a vaild email!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AddressTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "qwertyuioplkjhgfdsazxcvbnm"
            Dim allowednos As String = "1234567890"
            Dim allowedsymbols As String = "#,"
            If Not allowednos.Contains(e.KeyChar.ToString.ToLower) And Not allowedchars.Contains(e.KeyChar.ToString.ToLower) And Not allowedsymbols.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("please enter a vaild email!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub IDProofTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SearchIconButton_Click(sender As Object, e As EventArgs) Handles SearchIconButton.Click
        Try
            sql = "select * from CustomerDetails where Customer_ID= '" & CustomerIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                FirstNameTextBox.Text = dr.GetValue(1)
                LastNameTextBox.Text = dr.GetValue(2)
                PhoneNumberTextBox.Text = dr.GetValue(3)
                EmailTextBox.Text = dr.GetValue(4)
                AddressTextBox.Text = dr.GetValue(5)
                IDProofTextBox.Text = dr.GetValue(6)
            End If
            IsEmpty(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddIconButton_Click(sender As Object, e As EventArgs) Handles AddIconButton.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill the required fields")
        Else
            Try
                sql = "select * from CustomerDetails where Customer_ID = '" & CustomerIDTextBox.Text & "' "
                dml = New OdbcCommand(sql, conn)
                dr = dml.ExecuteReader
                If dr.HasRows Then
                    MsgBox("Dulpicate entry Found!", MsgBoxStyle.Critical)
                Else
                    sql = "insert into CustomerDetails values('" & CustomerIDTextBox.Text & "','" & FirstNameTextBox.Text & "','" & LastNameTextBox.Text & "',
                    '" & PhoneNumberTextBox.Text & "','" & EmailTextBox.Text & "','" & AddressTextBox.Text & "','" & IDProofTextBox.Text & "')"
                    dml = New OdbcCommand(sql, conn)
                    dml.ExecuteNonQuery()
                    MsgBox("data updated")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub NewCustomerIconButton_Click(sender As Object, e As EventArgs)
        add()
    End Sub


    Private Sub SubmiteIconButton_Click(sender As Object, e As EventArgs) Handles SubmiteIconButton.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill the required fields")
        Else
            Try
                Check_IN = Format(Check_IN_DateTimePicker.Value, "yyyy-MM-dd")
                Check_Out = Format(Check_Out_DateTimePicker.Value, "yyyy-MM-dd")
                sql = "select * from bookingdetails where Booking_ID = '" & BookingIDTextBox.Text & "' "
                dml = New OdbcCommand(sql, conn)
                dr = dml.ExecuteReader
                If dr.HasRows Then
                    MsgBox("Dulpicate entry Found!", MsgBoxStyle.Critical)
                Else
                    sql = "insert into bookingdetails values('" & BookingIDTextBox.Text & "','" & CustomerIDTextBox.Text & " ',' " & FirstNameTextBox.Text & "','" & LastNameTextBox.Text & "',
                                '" & PhoneNumberTextBox.Text & "','" & EmailTextBox.Text & "','" & AddressTextBox.Text & "','" & IDProofTextBox.Text & "','" & RoomTypeComboBox.Text & "',
                                '" & RoomNumberTextBox.Text & "','" & AdultsComboBox.Text & "','" & ChildComboBox.Text & " ',' " & Check_IN & "','" & Check_Out & "','" & PaymentTypeComboBox.Text & "',
                                '" & RoomTextBox.Text & "', '" & TotalPriceTextBox.Text & "')"
                    dml = New OdbcCommand(sql, conn)
                    dml.ExecuteNonQuery()
                    MsgBox("data inserted")
                    add()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class