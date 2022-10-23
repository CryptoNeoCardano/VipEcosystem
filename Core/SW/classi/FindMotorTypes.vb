Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.AccessControl
Imports System.Net.Mail
Imports System.Runtime.InteropServices

Public Class FindMotorTypes

    Public FanName_star As String

    Public Sub Main(Motore As String, Ventola As String, Configurazione As String,
                    ByRef cbx_marche As Guna.UI2.WinForms.Guna2ComboBox, ByRef btn1 As Guna.UI2.WinForms.Guna2Button)

        Try

            cbx_marche.Items.Clear()
            Dim files() As String = IO.Directory.GetFiles(directory_SW_assemblati & Motore & Ventola & "\MODELLI AUTOMATICI\" & Configurazione)

            For Each file As String In files
                Dim NameFile As String = IO.Path.GetFileName(file)

                If (NameFile(0) = Motore) And (NameFile(1) = Ventola) And (NameFile.Length >= Configurazione.Length) Then

                    Dim controllo As Boolean = False

                    For i = 0 To cbx_marche.Items.Count - 1
                        If (HMarche(NameFile(25).ToString()) = Convert.ToString(cbx_marche.Items(i))) Then
                            controllo = True
                        End If
                    Next

                    If controllo = False Then
                        Try
                            cbx_marche.Items.Add(HMarche(NameFile(25).ToString()))
                            cbx_marche.SelectedIndex = 0
                        Catch ex As Exception

                        End Try
                    End If

                End If

            Next


            'Di base se non trovo motori significa che la cartella non contiene file
            If cbx_marche.Items.Count = 0 Then
                btn1.Enabled = False
            End If

        Catch ex As Exception

        End Try



    End Sub


End Class
