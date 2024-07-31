Imports System.Data.Odbc
Public Class EmploeeDetailsForm
    Private Sub EmploeeDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn1()
        DataGridView1.ForeColor = System.Drawing.SystemColors.MenuText
        CallDatabase()
    End Sub
    Private Sub CallDatabase()
        sql = "select * from EmployeeDetails"
        dml = New OdbcCommand(sql, conn)
        adp = New OdbcDataAdapter(dml)
        tab = New DataTable()
        adp.Fill(tab)
        DataGridView1.DataSource = tab
    End Sub

    Private Sub EmployeeIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeIDTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub EmployeeNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmployeeNameTextBox.KeyPress
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

    Private Sub DesignationTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DesignationTextBox.KeyPress
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

    Private Sub SalaryTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SalaryTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
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

    Private Sub CityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CityTextBox.KeyPress
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

    Private Sub WorkingExprerienceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WorkingExprerienceTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub SearchIconButton_Click(sender As Object, e As EventArgs) Handles SearchIconButton.Click
        Try
            sql = "select * from EmployeeDetails where Employee_ID= '" & EmployeeIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                EmployeeNameTextBox.Text = dr.GetValue(1)
                PhoneNumberTextBox.Text = dr.GetValue(2)
                EmailTextBox.Text = dr.GetValue(3)
                DesignationTextBox.Text = dr.GetValue(4)
                GenderComboBox.Text = dr.GetValue(5)
                SalaryTextBox.Text = dr.GetValue(6)
                AddressTextBox.Text = dr.GetValue(7)
                CityTextBox.Text = dr.GetValue(8)
                WorkingExprerienceTextBox.Text = dr.GetValue(9)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddIconButton_Click(sender As Object, e As EventArgs) Handles AddIconButton.Click
        Try
            sql = "insert into EmployeeDetails values('" & EmployeeIDTextBox.Text & "','" & EmployeeNameTextBox.Text & "','" & PhoneNumberTextBox.Text & "'
                ,'" & EmailTextBox.Text & "','" & DesignationTextBox.Text & "','" & GenderComboBox.Text & "','" & SalaryTextBox.Text & "'
                ,'" & AddressTextBox.Text & "','" & CityTextBox.Text & "','" & WorkingExprerienceTextBox.Text & "')"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("data inserted")
            CallDatabase()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RemoveIconButton_Click(sender As Object, e As EventArgs) Handles RemoveIconButton.Click
        Try
            sql = " delete from EmployeeDetails where Employee_ID = '" & EmployeeIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("data deleted")
            CallDatabase()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UpdateIconButton_Click(sender As Object, e As EventArgs) Handles UpdateIconButton.Click
        Try
            sql = " update EmployeeDetails set   Employee_Name = '" & EmployeeNameTextBox.Text & "', Phone_number = '" & PhoneNumberTextBox.Text & "',
                Email_ID = '" & EmailTextBox.Text & "', Designation = '" & DesignationTextBox.Text & "', Gender = '" & GenderComboBox.Text & "',
                Salary = '" & SalaryTextBox.Text & "' , Address = '" & AddressTextBox.Text & "', City = '" & CityTextBox.Text & "',
                Working_Expressence = '" & WorkingExprerienceTextBox.Text & "'  where  Employee_ID = '" & EmployeeIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("data updated")
            CallDatabase()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearIconButton_Click(sender As Object, e As EventArgs) Handles ClearIconButton.Click
        EmployeeIDTextBox.Clear()
        EmployeeNameTextBox.Clear()
        PhoneNumberTextBox.Clear()
        EmailTextBox.Clear()
        DesignationTextBox.Clear()
        SalaryTextBox.Clear()
        AddressTextBox.Clear()
        CityTextBox.Clear()
        WorkingExprerienceTextBox.Clear()
    End Sub

    Private Sub ShowDatbaseIconButton_Click(sender As Object, e As EventArgs) Handles ShowDatbaseIconButton.Click
        CallDatabase()
    End Sub
End Class