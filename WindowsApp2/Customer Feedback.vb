Imports System.Data.Odbc
Public Class Customer_Feedback

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

    Private Sub FeedbackTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FeedbackTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "qwertyuioplkjhgfdsazxcvbnm"
            Dim allowednos As String = "1234567890"
            Dim allowedsymbols As String = "@':;. "
            If Not allowednos.Contains(e.KeyChar.ToString.ToLower) And Not allowedchars.Contains(e.KeyChar.ToString.ToLower) And Not allowedsymbols.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("please enter a vaild email!")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Customer_Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn1()
    End Sub

    Private Sub SearchIconButton_Click(sender As Object, e As EventArgs) Handles SearchIconButton.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill the required fields")
        Else
            Try
                sql = "select * from customerfeedback where Customer_ID = '" & CustomerIDTextBox.Text & "' "
                dml = New OdbcCommand(sql, conn)
                dr = dml.ExecuteReader
                If dr.HasRows Then
                    MsgBox("Dulpicate entry Found!", MsgBoxStyle.Critical)
                Else
                    sql = "insert into customerfeedback values('" & CustomerIDTextBox.Text & "','" & FeedbackTextBox.Text & "')"
                    dml = New OdbcCommand(sql, conn)
                    dml.ExecuteNonQuery()
                    MsgBox("data inserted")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try


        End If
    End Sub
End Class