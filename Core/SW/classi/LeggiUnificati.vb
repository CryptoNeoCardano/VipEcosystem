Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.AccessControl
Imports System.Net.Mail
Imports System.Runtime.InteropServices

Public Class LeggiUnificati


    Public TestState As Integer = 0
    Private NomeFanStar As String
    Public Sub Main(NomeFan As String, ByRef cbx_Diam As Guna.UI2.WinForms.Guna2ComboBox, ByRef cbx_unificato As Guna.UI2.WinForms.Guna2ComboBox, NomeFanU As String)

        Dim tableName = "MotoriUnificati"
        Dim DiamFan As String = cbx_Diam.SelectedItem
        Dim CodeDiam As String = ""

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
                cbx_unificato.Items.Clear()
            Catch ex As Exception

            End Try


            'Identifico il codice del diametro selezionato

            For i = 0 To Numero_colonne_SW_UNI
                Try

                    Dim ColonnaName As String = Nome_colonne_SW_UNI(i + 1).Substring(0, Nome_colonne_SW_UNI(i + 1).Length - 1)

                    If myreader(Nome_colonne_SW_UNI(i + 1)) = DiamFan Then
                        CodeDiam = Nome_colonne_SW_UNI(i + 1)(Nome_colonne_SW_UNI(i + 1).Length - 1)
                    End If
                Catch ex As Exception

                End Try
            Next




            'Cerco alla riga del ventilatore selezionato le taglie di motore presenti
            Dim Codej As Integer = 1
            Dim CodiceUnificato As String = ""
            For i = 0 To Numero_colonne_SW_UNI - 1
                Dim ColonnaName As String = Nome_colonne_SW_UNI(i + 1).Substring(0, Nome_colonne_SW_UNI(i + 1).Length - 1)
                Try
                    CodiceUnificato = "TagliaM" & CodeDiam & Codej
                    If Nome_colonne_SW_UNI(i + 1) = "TagliaM" & CodeDiam & Codej And myreader(Nome_colonne_SW_UNI(i + 1)) <> "0" Then
                        cbx_unificato.Items.Add(myreader(Nome_colonne_SW_UNI(i + 1)))
                        Codej = Codej + 1
                    End If

                Catch ex As Exception

                End Try
            Next

            Try
                cbx_unificato.SelectedIndex = 0
            Catch ex As Exception

            End Try



        End Using



    End Sub





End Class
