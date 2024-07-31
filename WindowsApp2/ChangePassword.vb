Imports System.Data.Odbc

Public Class ChangePassword


    Private Sub CallDatabase()
        Try
            sql = "select * from AdminPassword  "
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView1.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn1()
        Call CallDatabase()
        DataGridView1.ForeColor = System.Drawing.SystemColors.MenuText
    End Sub

    Private Sub SearchIconButton_Click(sender As Object, e As EventArgs) Handles SearchIconButton.Click
        Try
            sql = "select User_Name,Password from Password where User_Name = '" & UaserNameTextBox.Text & "' AND Password='" & PasswordTextBox.Text & "'"
            dml = New OdbcCommand(sql, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                UaserNameTextBox.Text = dr.GetValue(1)
                Password.Text = dr.GetValue(2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddIconButton_Click(sender As Object, e As EventArgs) Handles AddIconButton.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill the required fields")
        Else
            Try
                sql = "select Admin_name,Password from AdminPassword where Admin_name = '" & UaserNameTextBox.Text & "' AND Password='" & PasswordTextBox.Text & "'  "
                dml = New OdbcCommand(sql, conn)
                dr = dml.ExecuteReader
                If dr.HasRows Then
                    MsgBox("Dulpicate entry Found!", MsgBoxStyle.Critical)
                Else
                    sql = "insert into AdminPassword values('" & UaserNameTextBox.Text & "','" & PasswordTextBox.Text & "')"
                    dml = New OdbcCommand(sql, conn)
                    dml.ExecuteNonQuery()
                    MsgBox("data updated")
                    CallDatabase()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RemoveIconButton_Click(sender As Object, e As EventArgs) Handles RemoveIconButton.Click
        Try
            Dim Admin As String = "Admin"
            Dim Emp As String = "Employee"
            sql = " delete from Password where User_Name = '" & UaserNameTextBox.Text & "' AND Password='" & PasswordTextBox.Text & "'"
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("data deleted")
            CallDatabase()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearIconButton_Click(sender As Object, e As EventArgs) Handles ClearIconButton.Click
        Try
            UaserNameTextBox.Clear()
            PasswordTextBox.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub UpdateIconButton_Click(sender As Object, e As EventArgs) Handles UpdateIconButton.Click
        Try
            sql = " update Password set   Password = '" & PasswordTextBox.Text & "'where  User_Name = '" & UaserNameTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("data updated")
            CallDatabase()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShowDatbaseIconButton_Click(sender As Object, e As EventArgs) Handles ShowDatbaseIconButton.Click
        CallDatabase()
    End Sub

End Class