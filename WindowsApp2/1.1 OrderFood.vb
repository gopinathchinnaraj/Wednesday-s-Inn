Imports System.Data.Odbc
Public Class OrderFood
    Private Sub OrderFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conn1()
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        dotask()
        CallDatabase()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        add()
    End Sub
    Private Sub add()
        Try
            sql = "select count(*) from foodhistory "
            dml = New OdbcCommand(sql, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                OrderIDTextBox.Text = dr.GetValue(0) + Val(101)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Clear()
        FoodTypeTextBox.Clear()
        SelectFoodTextBox.Clear()
        PriceTextBox.Clear()
        FoodIDTextBox.Clear()
        QuatityTextBox.Clear()
        PaymentTypeComboBox.Text = " "
        TotalBillTextBox.Clear()
    End Sub
    Private Sub CallDatabase()
        sql = "select * from FoodDetails"
        dml = New OdbcCommand(sql, conn)
        adp = New OdbcDataAdapter(dml)
        tab = New DataTable()
        adp.Fill(tab)
        DataGridView1.DataSource = tab
    End Sub

    Private Sub TextBox1_Keypress(sender As Object, e As KeyPressEventArgs) Handles OrderIDTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MessageBox.Show("plz enter a number")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub dotask()
        sql = " update FoodDetails set Quantity=0  "
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        sql = " update FoodDetails set Total_price=0  "
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FoodTypeComboBox.SelectedIndexChanged
        Try
            sql = "select * from FoodDetails where Food_Type='" & FoodTypeComboBox.Text & "'"
            dml = New OdbcCommand(sql, conn)
            adp = New OdbcDataAdapter(dml)
            tab = New DataTable()
            adp.Fill(tab)
            DataGridView1.DataSource = tab
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SearchIconButton_Click(sender As Object, e As EventArgs) Handles SearchIconButton.Click
        Try
            sql = "select * from FoodDetails where FoodID= '" & FoodIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dr = dml.ExecuteReader
            If dr.Read Then
                FoodTypeTextBox.Text = dr.GetValue(1)
                SelectFoodTextBox.Text = dr.GetValue(2)
                PriceTextBox.Text = dr.GetValue(3)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddIconButton_Click(sender As Object, e As EventArgs) Handles AddIconButton.Click
        Try
            sql = " update FoodDetails set Quantity='" & QuatityTextBox.Text & "' where FoodID= '" & FoodIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            CallDatabase()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub delete_Button_Click(sender As Object, e As EventArgs)
        Try
            sql = " update FoodDetails Set Quantity=0 where FoodID= '" & FoodIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            sql = " update FoodDetails set Total_price=0 where FoodID= '" & FoodIDTextBox.Text & "' "
            dml = New OdbcCommand(sql, conn)
            dml.ExecuteNonQuery()
            CallDatabase()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearIconButton_Click(sender As Object, e As EventArgs) Handles ClearIconButton.Click
        Clear()
    End Sub

    Private Sub ClaculateIconButton_Click(sender As Object, e As EventArgs) Handles CalculateIconButton.Click
        sql = " update FoodDetails set Total_price = Quantity * Price   "
        dml = New OdbcCommand(sql, conn)
        dml.ExecuteNonQuery()
        CallDatabase()
        sql = "select sum(Total_price) from FoodDetails "
        dml = New OdbcCommand(sql, conn)
        dr = dml.ExecuteReader
        If dr.Read Then
            TotalBillTextBox.Text = dr.GetValue(0)
        End If
    End Sub

    Private Sub ShowDatbaseIconButton_Click(sender As Object, e As EventArgs) Handles FinalIconButton.Click
        If IsEmpty(Me) Then
            MsgBox("Please fill the required fields")
        Else
            Try
                Dim dat As String
                dat = Format(DateTimePicker1.Value, "yyyy-MM-dd")
                sql = " insert into FoodHistory values('" & OrderIDTextBox.Text & "','" & dat & "','" & TotalBillTextBox.Text & "','" & PaymentTypeComboBox.Text & "') "
                dml = New OdbcCommand(sql, conn)
                dml.ExecuteNonQuery()
                MsgBox("Order Finalized")
                Clear()
                add()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        dotask()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs)
        add()
    End Sub
End Class