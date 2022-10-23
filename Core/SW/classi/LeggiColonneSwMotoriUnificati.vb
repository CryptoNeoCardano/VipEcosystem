Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.AccessControl
Imports System.Net.Mail
Imports System.Runtime.InteropServices


'La seguente classe legge i nomi della tabella DiamReti MotoriUnificati
Public Class LeggiColonneSwMotoriUnificati

    Public Sub Main()

        Dim tableName = "MotoriUnificati"
        Dim filterValues = {Nothing, Nothing, tableName, Nothing}
        Dim i As Integer = 0

        Using conn = New OleDbConnection(constring_RefExcel)

            conn.Open()
            Dim columns = conn.GetSchema("Columns", filterValues)
            For Each row As DataRow In columns.Rows
                i = i + 1

                If row("column_name") <> "ID" Then
                    Nome_colonne_SW_UNI(i) = row("column_name")
                Else
                    i = i - 1
                End If
            Next

        End Using

        Numero_colonne_SW_UNI = i - 1

    End Sub


End Class
