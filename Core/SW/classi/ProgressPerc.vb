Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.AccessControl
Imports System.Net.Mail
Imports System.Runtime.InteropServices


Public Class ProgressPerc

    Public Percentuale As Integer
    Public StringPercenuale As String
    'la seguente classe gestisce l'avanzamento della percentuale montaggio assemblato in SW
    Public Sub Main(NomeFile As String, ByRef lb As Label, ByRef lb1 As Label, CodiceVentilatore As String, FaseAvanzamento As Integer,
                    ByRef progressB As Guna.UI2.WinForms.Guna2ProgressBar, ByRef progressC As Guna.UI2.WinForms.Guna2CircleProgressBar)

        If FaseAvanzamento < 15 Then
            If NomeFile = "" Then
                progressB.Visible = True
                progressC.Visible = False
            Else
                progressB.Visible = True
                progressC.Visible = True
            End If
        End If

        Percentuale = 10
        Select Case FaseAvanzamento
            Case 0 'Ricerca in archivio
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Cerco nell'archivio " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Cerco nell'archivio " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 1 'Montaggio motore
                Percentuale = 20
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio motore in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio motore in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 2 'Montaggio ventola1
                Percentuale = 32
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 3 'Montaggio ventola2
                Percentuale = 34
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 4 'Montaggio ventola3
                Percentuale = 36
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 5 'Montaggio ventola4
                Percentuale = 38
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 6 'Montaggio ventola5
                Percentuale = 40
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 7 'Montaggio ventola6
                Percentuale = 42
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 8 'Montaggio ventola7
                Percentuale = 44
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 9 'Montaggio ventola8
                Percentuale = 50
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 10 'Montaggio ventola9
                Percentuale = 55
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio ventola in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 11 'Montaggio Accessorio1
                Percentuale = 57
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio accessorio in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio accessorio in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 12 'Montaggio Accessorio2
                Percentuale = 78
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio accessorio in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio accessorio in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 13 'Montaggio Accessorio3
                Percentuale = 84
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Montaggio accessorio in " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Montaggio accessorio in " & CodiceVentilatore
                    progressC.Value = Percentuale
                End If
            Case 14 'Salvataggio
                Percentuale = 99
                If NomeFile = "" Then
                    lb.Text = Percentuale & "% - Salvataggio " & CodiceVentilatore
                    progressB.Value = Percentuale
                Else
                    lb1.Text = Percentuale & "% - Salvataggio " & CodiceVentilatore
                    progressC.Value = Percentuale
                    progressC.Visible = False
                End If

        End Select

        Application.DoEvents()


    End Sub


End Class
