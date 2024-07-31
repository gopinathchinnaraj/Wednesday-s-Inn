Imports System.Data.Odbc
Public Class CustomerFeedbackHistoryvb
    Private Sub CustomerFeedbackHistoryvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn1()
        DataGridView2.DefaultCellStyle.ForeColor = Color.Black
        Call database()
    End Sub

    Private Sub database()
        sql = "select * from customerfeedback"
        dml = New OdbcCommand(sql, conn)
        adp = New OdbcDataAdapter(dml)
        tab = New DataTable()
        adp.Fill(tab)
        DataGridView2.DataSource = tab
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

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Form1.RoomHistoryIconButton.PerformClick()
    End Sub

    Private Sub SearchIconButton_Click(sender As Object, e As EventArgs) Handles SearchIconButton.Click
        sql = "select * from customerfeedback where Customer_ID= '" & CustomerIDTextBox.Text & "' "
        dml = New OdbcCommand(sql, conn)
        adp = New OdbcDataAdapter(dml)
        tab = New DataTable()
        adp.Fill(tab)
        DataGridView2.DataSource = tab
    End Sub
End Class