Imports System.Data.OleDb

Public Class DbControl

    Public DbReader As OleDbDataReader

    ' Returns the result from an SQL query on the database
    Public Function ExecuteQuery(Query As String)
        Dim DbConnection As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Project Database.accdb")
        Dim DbCommand As OleDbCommand
        Try
            DbConnection.Open()
            DbCommand = New OleDbCommand(Query, DbConnection)
            DbReader = DbCommand.ExecuteReader
        Catch ex As Exception
            MessageBox.Show("Query to database failed")
        End Try
        Return DbReader
        DbConnection.Close()
    End Function

End Class
