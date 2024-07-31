Module Validation


    Public allSet As Boolean
    Function IsEmpty(ByVal portion As Control) As Boolean
        Dim ctrl As New Control
        'Focus TextBox
        Dim tex As New TextBox
        For Each ctrl In portion.Controls.OfType(Of TextBox)()
            tex = TryCast(ctrl, TextBox)
            If tex.Text = "" Then
                tex.Focus()
                tex.BackColor = Color.PaleVioletRed
                allSet = True
            Else
                tex.BackColor = Color.White
                allSet = False
            End If
        Next
        For Each ctrl In portion.Controls.OfType(Of ComboBox)()
            'Focus Combobox
            Dim combo As New ComboBox
            combo = TryCast(ctrl, ComboBox)
            If combo.Text = "-Select-" Or combo.Text = "" Then
                combo.Focus()
                combo.BackColor = Color.Yellow
                allSet = True
                combo.Text = "-Select-"
            Else
                combo.BackColor = Color.White
                allSet = False
            End If

        Next
        Return allSet
    End Function

End Module
