Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.AccessControl
Imports System.Net.Mail
Imports System.Runtime.InteropServices

'La seguente classe ha lo scopo di leggere il database "DataBaseSW" nella tabella DiamReti --> Dato letto CESTELLO
Public Class LeggiCestello


    Public TestState As Integer = 0
    Private NomeFanStar As String
    Public Sub Main(NomeFan As String, ByRef cbx_Diam As Guna.UI2.WinForms.Guna2ComboBox, ByRef cbx_cestello As Guna.UI2.WinForms.Guna2ComboBox, NomeFanU As String)

        Dim tableName = "DiamReti"
        Dim CestellloSel As String = cbx_Diam.SelectedItem
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
                cbx_cestello.Items.Clear()
            Catch ex As Exception

            End Try


            'Identifico il numero del diametro selezionato(da 1 a 9)

            For i = 0 To Numero_colonne_SW


                Dim ColonnaName As String = Nome_colonne_SW(i + 1).Substring(0, Nome_colonne_SW(i + 1).Length - 1)
                Try
                    If myreader(Nome_colonne_SW(i + 1)) = CestellloSel Then
                        CodeDiam = Nome_colonne_SW(i + 1)(Nome_colonne_SW(i + 1).Length - 1)
                    End If


                    If myreader(Nome_colonne_SW(i + 1)) = "Da Testare" Or myreader(Nome_colonne_SW(i + 1)) = "Testato" Then
                        TestState = 1
                    End If
                Catch ex As Exception

                End Try


            Next




            Try
                For i = 0 To Numero_colonne_SW
                    Dim ColonnaName As String = Nome_colonne_SW(i + 1).Substring(0, Nome_colonne_SW(i + 1).Length - 1)
                    Try

                        If myreader(Nome_colonne_SW(i + 1)) <> "0" And myreader(Nome_colonne_SW(i + 1)) <> "" And ColonnaName & CodeDiam = Nome_colonne_SW(i + 1) Then

                            If ColonnaName = "LAE" Or ColonnaName = "VALTENESI" Then
                                cbx_cestello.Items.Add(ColonnaName)
                                cbx_cestello.SelectedIndex = 0
                            End If

                        End If

                    Catch ex As Exception

                    End Try
                Next

            Catch ex As Exception

            End Try

        End Using



    End Sub

End Class
