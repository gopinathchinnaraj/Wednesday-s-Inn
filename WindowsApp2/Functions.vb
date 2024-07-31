Module Functions
    Dim pric, cost1 As String
    Public Function sendprice(name As String, Cost As String)
        pric = name
        cost1 = Cost
    End Function
    Public Function prx(text As TextBox, CostTextBox As TextBox)
        text.Text = pric
        CostTextBox.Text = cost1
    End Function

End Module
