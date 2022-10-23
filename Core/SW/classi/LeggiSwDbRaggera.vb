Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.AccessControl
Imports System.Net.Mail
Imports System.Runtime.InteropServices


Public Class LeggiSwDbRaggera

    Dim ControlloDiametro As String
    Public Sub Main(Ventola, Npale, Motore, TipoVentola)

        Try

            Using cn As New OleDb.OleDbConnection(constring_RefExcel)
                'provider to be used when working with access database
                cn.Open()


                'Controllo che il caso in analisi non stia contemplando una casistica in cui viene considerato anche il diametro della girante come elemento per identificare il diametro della raggera
                Dim cmd As New OleDb.OleDbCommand("SELECT [Dnom],[DiamVentola] FROM Raggere WHERE SerieVentola = '" & Ventola & "' AND Npale = '" & Npale & "' AND Motore = '" & Motore & "' AND TipoVentola = '" & TipoVentola & "'", cn)
                Dim myreader As OleDbDataReader

                myreader = cmd.ExecuteReader
                myreader.Read()
                ControlloDiametro = myreader("DiamVentola")

                If ControlloDiametro <> "0" Then
                    Dim cmd1 As New OleDb.OleDbCommand("SELECT [Dnom] FROM Raggere WHERE SerieVentola = '" & Ventola & "' AND Npale = '" & Npale & "' AND Motore = '" & Motore & "' AND TipoVentola = '" & TipoVentola & "' AND DiamVentola = '" & ControlloDiametro & "'", cn)
                    Dim myreader1 As OleDbDataReader


                    myreader1 = cmd1.ExecuteReader
                    SW_Raggera = myreader1("Dnom")
                Else
                    SW_Raggera = myreader("Dnom")
                End If


                cn.Close()

            End Using




        Catch ex As Exception



        End Try




    End Sub






End Class
