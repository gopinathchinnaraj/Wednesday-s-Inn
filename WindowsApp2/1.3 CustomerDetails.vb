Imports System.Data.Odbc

Public Class CustomerDetails
    Private Sub CustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn1()
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        CallDatabase()
        add()
    End Sub
    Private Sub add()
        Try
            sql = "select count(*) from customerdetails "
            dml = New OdbcCommand(sql, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                CustomerIDTextBox.Text = dr.GetValue(0) + Val(1001)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CallDatabase()
        sql = "select * from CustomerDetails"
        dml = New OdbcCommand(sql, conn)
        adp = New OdbcDataAdapter(dml)
        tab = New DataTable()
        adp.Fill(tab)
        DataGridView1.DataSource = tab
    End Sub


    Private Sub search()
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
    End Sub
    Private Sub CustomerIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CustomerIDTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FirstNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstNameTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "qwertyuioplkjhgfdsazxcvbnm"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("plz enter a character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub


    Private Sub PhoneNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PhoneNumberTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub EmailTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmailTextBox.KeyPress
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

    Private Sub AddressTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AddressTextBox.KeyPress
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

    Private Sub IDProofTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDProofTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub LastNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastNameTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "qwertyuioplkjhgfdsazxcvbnm"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("plz enter a character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles SearchIconButton.Click
        search()
        IsEmpty(Me)
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
                    CallDatabase()
                    add()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RemoveIconButton_Click(sender As Object, e As EventArgs) Handles RemoveIconButton.Click
        sql = " delete from CustomerDetails where Customer_ID = '" & CustomerIDTextBox.Text & "' "
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        MsgBox("data deleted")
        CallDatabase()
    End Sub

    Private Sub UpdateIconButton_Click(sender As Object, e As EventArgs) Handles UpdateIconButton.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill the required fields")
        Else
            sql = " update CustomerDetails set  First_name = '" & FirstNameTextBox.Text & "',
                Last_name = '" & LastNameTextBox.Text & "', Phone_number = '" & PhoneNumberTextBox.Text & "', Email = '" & EmailTextBox.Text & "',
                Address = '" & AddressTextBox.Text & "', ID_Proof = '" & IDProofTextBox.Text & "' where Customer_ID = '" & CustomerIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("data updated")
            CallDatabase()
        End If
    End Sub

    Private Sub ClearIconButton_Click(sender As Object, e As EventArgs) Handles ClearIconButton.Click
        CustomerIDTextBox.Clear()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        PhoneNumberTextBox.Clear()
        EmailTextBox.Clear()
        AddressTextBox.Clear()
        IDProofTextBox.Clear()
    End Sub

    Private Sub ShowDatbaseIconButton_Click(sender As Object, e As EventArgs) Handles ShowDatbaseIconButton.Click
        Call CallDatabase()
    End Sub
    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        add()
    End Sub
End Class