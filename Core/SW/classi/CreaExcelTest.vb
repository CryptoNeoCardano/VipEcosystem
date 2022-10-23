Imports System.IO.Ports
Imports System.Threading
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting




Public Class CreaExcelTest

    Public objExcel As Object
    Public objWorkbook As Object
    Public Sub main(NomeFan, ListaTest)

        Dim dirSave As String = directory_test & NomeFan
        System.IO.Directory.CreateDirectory(dirSave)

        'crea il file excel performance
        objExcel = CreateObject("Excel.Application")
        objExcel.visible = False
        objWorkbook = objExcel.Workbooks.Add()

        objWorkbook.saveas(FileName:=dirSave & "\" & NomeFan & ".xlsx")
        objExcel.quit

        objExcel.workbooks.open(dirSave & "\" & NomeFan & ".xlsx")
        objExcel.Worksheets("Foglio1").Range("A1").Value = "Nomi Test"
        objExcel.Worksheets("Foglio1").Range("B1").Value = "Stato"


        Dim i As Integer = 0
        Do While ListaTest(i) <> Nothing
            objExcel.Worksheets("Foglio1").Range("A" & (2 + i)).Value = ListaTest(i)
            i = i + 1
        Loop

        'Creo l'elenco dei test che vengono effettuati

        'save the file
        objExcel.DisplayAlerts = False
        objExcel.ActiveWorkbook.saveas(dirSave & "\" & NomeFan & ".xlsx", 51)
        objExcel.ActiveWorkbook.close()



    End Sub




End Class
