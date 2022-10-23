Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.AccessControl
Imports System.Net.Mail
Imports System.Runtime.InteropServices



Public Class SegnalaErrore

    Public Sub Main(Motore As String, Ventola As String, Diametro As String, Calettamento As String,
                    Configurazione As String, TipoPala As String, TipoVentola As String, NumeroPale As String, Flusso As String)

        Try

            Dim CodiceVentilatore As String = Motore & Ventola & " _._._-_._-_._-" & Configurazione & "-_._._" & NumeroPale & "_-" & Flusso

            Dim client As New WebClient
            Dim test_owner As String

            '= "Buongiorno Lorenzo la rigenerazione del database ha presentato i seguenti errori: " & Environment.NewLine & TestoMail
            test_owner = "Hanno segnalato il seguente ventilatore: " & CodiceVentilatore & ". Bisogna aggiungerlo agli assemblati. Grazie!"
            Dim oggetto As String = CodiceVentilatore


            'Invio mail a lorenzo
            email_owner = "l.peretti@vipblade.it"
            Dim url_owner As String = "http://vipfan.ddns.net:9995/?cmd=send_mail_2&msg=" & test_owner & "&ogg=" & oggetto & "&dst=" & email_owner
            Dim risposta As String = client.DownloadString(url_owner)
            'Invio mail a Remo
            email_owner = "remo.ricchetti@gmail.com"
            url_owner = "http://vipfan.ddns.net:9995/?cmd=send_mail_2&msg=" & test_owner & "&ogg=" & oggetto & "&dst=" & email_owner
            risposta = client.DownloadString(url_owner)

        Catch ex As Exception

        End Try


    End Sub


End Class
