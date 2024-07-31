Imports System.Data.Odbc
Public Class FoodDetailsForm
    Private Sub FoodDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn1()
        DataGridView1.ForeColor = System.Drawing.SystemColors.MenuText
        CallDatabase()
    End Sub

    Private Sub CallDatabase()
        sql = "select FoodID, Food_Type, Food_Name, Price from FoodDetails"
        dml = New OdbcCommand(sql, conn)
        adp = New OdbcDataAdapter(dml)
        tab = New DataTable()
        adp.Fill(tab)
        DataGridView1.DataSource = tab
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FoodIDTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FoodIDTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FoodNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FoodNameTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "qwertyuioplkjhgfdsazxcvbnm"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("plz enter a character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub FoodTypeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedchars As String = "qwertyuioplkjhgfdsazxcvbnm"
            If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
                MessageBox.Show("plz enter a character")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub PriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PriceTextBox.KeyPress
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
            sql = "select * from FoodDetails where FoodID= '" & FoodIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                FoodTypeComboBox.Text = dr.GetValue(1)
                FoodNameTextBox.Text = dr.GetValue(2)
                PriceTextBox.Text = dr.GetValue(3)
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
                sql = "select * from FoodDetails where FoodID = '" & FoodIDTextBox.Text & "' "
                dml = New OdbcCommand(sql, conn)
                dr = dml.ExecuteReader
                If dr.HasRows Then
                    MsgBox("Dulpicate entry Found!", MsgBoxStyle.Critical)
                Else
                    sql = "insert into FoodDetails(FoodID, Food_Type, Food_Name, Price) values('" & FoodIDTextBox.Text & "','" & FoodTypeComboBox.Text & "','" & FoodNameTextBox.Text & "',
                    '" & PriceTextBox.Text & "')"
                    dml = New OdbcCommand(sql, conn)
                    dml.ExecuteNonQuery()
                    MsgBox("data inserted")
                    CallDatabase()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub

    Private Sub UpdateIconButton_Click(sender As Object, e As EventArgs) Handles UpdateIconButton.Click
        Try
            sql = " update FoodDetails set   Food_Type = '" & FoodTypeComboBox.Text & "', Food_Name = '" & FoodNameTextBox.Text & "',
                Price = '" & PriceTextBox.Text & "'  where  FoodID = '" & FoodIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("data updated")
            CallDatabase()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RemoveIconButton_Click(sender As Object, e As EventArgs) Handles RemoveIconButton.Click
        Try
            sql = " delete from FoodDetails where FoodID = '" & FoodIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            MsgBox("data deleted")
            CallDatabase()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearIconButton_Click(sender As Object, e As EventArgs) Handles ClearIconButton.Click
        FoodIDTextBox.Clear()
        FoodNameTextBox.Clear()
        PriceTextBox.Clear()
    End Sub

    Private Sub ShowDatbaseIconButton_Click(sender As Object, e As EventArgs) Handles ShowDatbaseIconButton.Click
        CallDatabase()
    End Sub
End Class