Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.AccessControl
Imports System.Net.Mail
Imports System.Runtime.InteropServices



'La seguente classe viene usata per cercare nell'archivio degli assemblati se esiste il file
Public Class CercaFan


    Public FanName_star As String
    Public FanName_starU As String 'Usata per la del file nelle directory per il caso unificato
    Public CodiceMotore As String
    Private DirFanName As String
    Public Sub Main(Motore As String, Ventola As String, Diametro As String, Calettamento As String, Configurazione As String, TipoPala As String, TipoVentola As String,
                    NumeroPale As String, Flusso As String, ByRef btn1 As Guna.UI2.WinForms.Guna2Button, ByRef btn2 As Guna.UI2.WinForms.Guna2Button,
                    ByRef cbx_diametro As Guna.UI2.WinForms.Guna2ComboBox, ByRef cbx_pala As Guna.UI2.WinForms.Guna2ComboBox,
                    ByRef cbx_angolo As Guna.UI2.WinForms.Guna2ComboBox, ByRef cbx_cestello As Guna.UI2.WinForms.Guna2ComboBox, TestFan As Integer,
                    ByRef cbx_Marcamotore As Guna.UI2.WinForms.Guna2ComboBox)

        Try


            FanName_star = Motore & Ventola & " _._._-_._-_._-" & Configurazione & "-_._._" & NumeroPale & "_-" & Flusso
            DirFanName = FanName_star
            If Motore = "U" Then
                Dim keys As New List(Of String)(HMarche.Keys.OfType(Of String)())
                Dim strMarca As String = cbx_Marcamotore.SelectedItem
                CodiceMotore = HMarche.Values.OfType(Of String)().Select(Function(htI, i) New With {.Key = keys(i), .Value = htI}).Where(Function(htKVP) htKVP.Value = strMarca).Select(Function(htKVP) htKVP.Key).FirstOrDefault()
                FanName_starU = Motore & Ventola & " _._._-_._-_._-" & Configurazione & "-_._._" & NumeroPale & CodiceMotore & "-" & Flusso
                DirFanName = FanName_starU
            End If



            If System.IO.File.Exists(directory_SW_assemblati & Motore & Ventola & "\MODELLI AUTOMATICI\" & Configurazione & "\" & DirFanName & ".SLDASM") Then
                btn1.Enabled = True
                btn2.Visible = False
            Else
                btn1.Enabled = False
                btn2.Visible = True
            End If


            If cbx_diametro.Items.Count < 1 Or cbx_pala.Items.Count < 1 Or cbx_angolo.Items.Count < 1 Or cbx_cestello.Items.Count < 1 Then
                btn1.Enabled = False
                btn2.Visible = True
            End If

            If TestFan = 0 Then
                btn1.Enabled = False
                btn2.Visible = True
            End If

        Catch ex As Exception

        End Try


    End Sub





End Class
