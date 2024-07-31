Imports System.Data.Odbc
Public Class EmployeePaymentForm
    Public Check_IN As String
    Private Sub EmployeePaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn1()
        DataGridView1.ForeColor = System.Drawing.SystemColors.MenuText
        Call CallDatabase()
    End Sub

    Private Sub CallDatabase()
        sql = "select * from employeepayment"
        dml = New OdbcCommand(sql, conn)
        adp = New OdbcDataAdapter(dml)
        tab = New DataTable()
        adp.Fill(tab)
        DataGridView1.DataSource = tab
    End Sub

    Private Sub SearchIconButton_Click(sender As Object, e As EventArgs) Handles SearchIconButton.Click
        Try
            sql = "select * from EmployeeDetails where Employee_ID= '" & EmploeeIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                EmployeeNameTextBox.Text = dr.GetValue(1)
                DesignationTextBox.Text = dr.GetValue(4)
                SalaryTextBox.Text = dr.GetValue(6)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SubmiteIconButton_Click(sender As Object, e As EventArgs) Handles SubmiteIconButton.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill the required fields")
        Else
            Try
                Check_IN = Format(DateTimePicker1.Value, "yyyy-MM-dd")
                sql = "select * from employeepayment where Employee_ID= '" & EmploeeIDTextBox.Text & "' "
                dml = New OdbcCommand(sql, conn)
                dr = dml.ExecuteReader
                If dr.HasRows Then
                    MsgBox("Dulpicate entry Found!", MsgBoxStyle.Critical)
                Else
                    sql = "insert into employeepayment values('" & EmploeeIDTextBox.Text & "','" & EmployeeNameTextBox.Text & "','" & DesignationTextBox.Text & "',
                    '" & SalaryTextBox.Text & "','" & WorkingDaysTextBox.Text & "','" & DATextBox.Text & "','" & HRATextBox.Text & "','" & DeductionTextBox.Text & "',
                    '" & GrossPayTextBox.Text & "','" & Check_IN & "')"
                    dml = New OdbcCommand(sql, conn)
                    dml.ExecuteNonQuery()
                    MsgBox("data submited")
                    CallDatabase()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ClearIconButton_Click(sender As Object, e As EventArgs) Handles ClearIconButton.Click
        Try
            EmployeeNameTextBox.Clear()
            EmploeeIDTextBox.Clear()
            DeductionTextBox.Clear()
            SalaryTextBox.Clear()
            GrossPayTextBox.Clear()
            WorkingDaysTextBox.Clear()
            DesignationTextBox.Clear()
            DATextBox.Clear()
            HRATextBox.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShowDatbaseIconButton_Click(sender As Object, e As EventArgs) Handles ShowDatbaseIconButton.Click
        CallDatabase()
    End Sub

    Private Sub CalculateIconButton_Click(sender As Object, e As EventArgs) Handles CalculateIconButton.Click
        Dim hra, da, ded, gross, sal As Double
        sal = Val(SalaryTextBox.Text)
        ded = sal * 9 / 100
        DeductionTextBox.Text = ded

        If sal <= 40000 Then
            da = sal * 4 / 100
            DATextBox.Text = da
            hra = sal * 5 / 100
            HRATextBox.Text = hra
        End If

        If sal <= 50000 Then
            da = sal * 5 / 100
            DATextBox.Text = da
            hra = sal * 6 / 100
            HRATextBox.Text = hra
        End If

        If sal <= 60000 Then
            da = sal * 7 / 100
            DATextBox.Text = da
            hra = sal * 8 / 100
            HRATextBox.Text = hra
        End If

        If sal > 60000 Then
            da = sal * 7 / 100
            DATextBox.Text = da
            hra = sal * 8 / 100
            HRATextBox.Text = hra
        End If


        gross = da + hra - ded + sal
        GrossPayTextBox.Text = gross

    End Sub
End Class