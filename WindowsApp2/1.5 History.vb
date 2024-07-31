Imports System.Data.Odbc
Public Class History

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            sql = "select sum(Sales) from foodhistory"
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn1()
        DataGridView2.DefaultCellStyle.ForeColor = Color.Black

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Try
            sql = "select count(*) from foodhistory"
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
            sql = " select * from foodhistory where Payment_type='CARD' "
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
            sql = " select * from foodhistory where Payment_type='CASH' "
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SearchIconButton_Click(sender As Object, e As EventArgs) Handles SearchIconButton.Click
        Try
            sql = " select * from foodhistory where OrderId='" & OrderIDTextBox.Text & "'  "
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView2.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Form1.RoomHistoryIconButton.PerformClick()
    End Sub
End Class