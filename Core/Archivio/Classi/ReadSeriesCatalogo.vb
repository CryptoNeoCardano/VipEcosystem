Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.AccessControl
Imports System.Net.Mail
Imports System.Runtime.InteropServices

Public Class ReadSeriesCatalogo


    'Mi connetto al database 'NewPJ' e leggo nella tabella Catalogo il NomeSerie
    Public Sub Main(ByRef cbx As Guna.UI2.WinForms.Guna2ComboBox)

        cbx.Items.Clear()

        'Mi connetto al Database
        Dim cn As New OleDb.OleDbConnection(constring)
        Dim dr As OleDbDataReader
        cn.Open()

        Dim StrCmd As String = "SELECT * FROM " & "Catalogo"
        Dim cmd As OleDbCommand = New OleDbCommand(StrCmd, cn)
        dr = cmd.ExecuteReader
        cbx.Items.Add("?")
        While dr.Read()
            cbx.Items.Add(dr("NomeSerie").ToString)
        End While
        cbx.SelectedIndex = 0

    End Sub



End Class
