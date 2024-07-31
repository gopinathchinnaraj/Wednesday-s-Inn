Imports System.Data.Odbc
Public Class Password
    Private Sub Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn1()
        clear()
    End Sub

    Private Sub LoginconButton_Click(sender As Object, e As EventArgs) Handles LoginconButton.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill the required fields")
        Else
            Try
                sql = "select Admin_name,Password from AdminPassword where Admin_name = '" & UsernameTextBox.Text & "' AND Password='" & PasswordTextBox.Text & "'"
                dml = New OdbcCommand(sql, conn)
                adp = New OdbcDataAdapter(dml)
                tab = New DataTable()
                adp.Fill(tab)
                If tab.Rows.Count = 0 Then
                    MsgBox("Invalid Username or Password")
                Else
                    MsgBox("Login Successful")
                    Admin.Show()
                    Me.Visible = False
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Me.Hide()
            End Try
        End If
    End Sub

    Private Sub clear()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub
    Private Sub CancelIconButton_Click(sender As Object, e As EventArgs) Handles CancelIconButton.Click
        clear()
        Me.Close()
    End Sub
End Class