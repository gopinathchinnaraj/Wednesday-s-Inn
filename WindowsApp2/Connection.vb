Imports System.Data.Odbc
Module Connection
    Public sql As String
    Public dml As OdbcCommand
    Public dr As OdbcDataReader
    Public conn As OdbcConnection
    Public adp As OdbcDataAdapter
    Public tab As DataTable

    Public Sub conn1()
        conn = New OdbcConnection("DSN=demo3")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            conn.Close()
        End If
    End Sub




End Module
