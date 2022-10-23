Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.AccessControl
Imports System.Net.Mail
Imports System.Runtime.InteropServices

Public Class LeggiDiam

    Private NomeFanStar As String
    'La seguente classe ha lo scopo di leggere il database "DataBaseSW" nella tabella DiamReti --> Dato letto DIAMETRO
    Public Sub Main(NomeFan As String, ByRef cbx_Diam As Guna.UI2.WinForms.Guna2ComboBox, NomeFanU As String)

        Dim tableName = "DiamReti"

        Using cn As New OleDb.OleDbConnection(constring_RefExcel)

            cn.Open()

            If Serie_motore <> "U" Then
                NomeFanStar = NomeFan
            Else
                NomeFanStar = NomeFanU
            End If

            Dim cmd As New OleDb.OleDbCommand("SELECT * FROM " & tableName & " WHERE NomeFan = '" & NomeFanStar & "'", cn)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()

            Try
                cbx_Diam.Items.Clear()
            Catch ex As Exception

            End Try


            For i = 0 To Numero_colonne_SW

                    Dim ColonnaName As String = Nome_colonne_SW(i + 1).Substring(0, Nome_colonne_SW(i + 1).Length - 1)
                Try

                    If myreader(Nome_colonne_SW(i + 1)) <> "0" And myreader(Nome_colonne_SW(i + 1)) <> "" Then
                        If ColonnaName = "Diametro" Then
                            cbx_Diam.Items.Add((myreader(Nome_colonne_SW(i + 1))))
                        End If
                    End If

                Catch ex As Exception

                End Try

            Next


        End Using


    End Sub


End Class
