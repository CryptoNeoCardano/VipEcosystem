'---------------------------------------------------------------------------
' Preconditions: 
' 1. Verify that the specified document to open exists.
' 2. Open the Immediate window.
'
' Postconditions:
' 1. Opens the specified document.
' 2. Sets the SOLIDWORKS working directory to the document directory.
' 3. Examine the Immediate window.
'---------------------------------------------------------------------------

Imports SolidWorks.Interop.sldworks
Imports SolidWorks.Interop.swconst

'Imports Microsoft.Office.Interop.Excel


'Imports System.Runtime.InteropServices

'Imports System

'Imports System.Diagnostics


Public Class SwOpenFile

    Dim doc As ModelDoc2


    Dim fileerror As Integer

    Dim filewarning As Integer

    Public swApp As SldWorks = CreateObject("SldWorks.Application")

    Public Sub Main(Motore As String, Ventola As String, Diametro As String, Calettamento As String, Configurazione As String, TipoPala As String,
                    NumeroPale As String, Flusso As String, ByRef pan As Guna.UI2.WinForms.Guna2Panel, ByRef load As Guna.UI2.WinForms.Guna2Panel, ByRef lb As Label, TipoCestello As String, NomeFile As String,
                    NomeSpec As String, ByRef lb1 As Label, ByRef progressB As Guna.UI2.WinForms.Guna2ProgressBar, ByRef progressC As Guna.UI2.WinForms.Guna2CircleProgressBar, TagliaMotore As String, CodiceMotore As String, MarcaMotore As String, VentilazioneMotore As Integer,
                    CappelloMotore As Integer, PiediniMotore As Integer)


        Control.CheckForIllegalCrossThreadCalls = False
        Dim Progress As ProgressPerc = New ProgressPerc()
        Dim percentuale As Integer = 0

        Lettura_RefExcel1()

        Try

            Dim diam_SW_star As String = ""

            If Diam_SW < 1000 Then
                diam_SW_star = "0" & Diam_SW(0) & Diam_SW(1)
            Else
                diam_SW_star = Diam_SW(0) & Diam_SW(1) & Diam_SW(2)
            End If

            swApp.Visible = True

            'Get the current working directory before opening the document

            Debug.Print("Current working directory is " & swApp.GetCurrentWorkingDirectory)

            If Motore <> "U" Then
                CodiceMotore = "_"
            End If

            Dim CodiceVentilatore As String = Motore & Ventola & " _._._-_._-_._-" & Configurazione & "-_._._" & NumeroPale & CodiceMotore & "-" & Flusso
            Dim CodiceVentilatore1 As String = Motore & Ventola & " _._._-_._-_._-[" & Configurazione & "]-_._._" & NumeroPale & CodiceMotore & "-" & Flusso
            Dim CodiceVentilatore2 As String = Motore & Ventola & " " & diam_SW_star & "-" & Calettamento & "-" & "_._" & "-" & Configurazione & "-" & "_._" & TipoPala & NumeroPale & CodiceMotore & "-" & Flusso
            Dim CodiceVentilatore3 As String = Motore & Ventola & " _._._-_._-_._-" & Configurazione & "-_._._ "


            lb.Location = New System.Drawing.Point(480, 490)
            Progress.Main(NomeFile, lb, lb1, CodiceVentilatore, percentuale, progressB, progressC)


            'Apertura della directory contenente l'assemblato
            doc = swApp.OpenDoc6(directory_SW_assemblati & Motore & Ventola & "\MODELLI AUTOMATICI\" & Configurazione & "\" & CodiceVentilatore & ".SLDASM", swDocumentTypes_e.swDocASSEMBLY, swOpenDocOptions_e.swOpenDocOptions_Silent, "", fileerror, filewarning)


            'Opening a document with SldWorks::OpenDoc6 does not set the working directory

            Debug.Print("Current working directory is still " & swApp.GetCurrentWorkingDirectory)


            'Set the working directory to the document directory
            swApp.SetCurrentWorkingDirectory(Left(doc.GetPathName, InStrRev(doc.GetPathName, "\")))
            Debug.Print("Current working directory is now " & swApp.GetCurrentWorkingDirectory)


            percentuale = percentuale + 1
            Progress.Main(NomeFile, lb, lb1, CodiceVentilatore, percentuale, progressB, progressC)
            'Dim swDesTable As DesignTable
            'Dim nTotRow As Integer
            'Dim nTotCol As Integer
            'Dim sRowStr As String
            'Dim i As Integer
            'Dim j As Integer
            'Dim bRet As Boolean

            'swDesTable = doc.GetDesignTable
            'bRet = swDesTable.Attach

            'nTotRow = swDesTable.GetTotalRowCount
            'nTotCol = swDesTable.GetTotalColumnCount
            'Debug.Print("File = " & doc.GetPathName)
            'Debug.Print("  Title        = " & swDesTable.GetTitle)
            'Debug.Print("  Row          = " & swDesTable.GetRowCount)
            'Debug.Print("  Col          = " & swDesTable.GetColumnCount)
            'Debug.Print("  TotRow       = " & nTotRow)
            'Debug.Print("  TotCol       = " & nTotCol)
            'Debug.Print("  VisRow       = " & swDesTable.GetVisibleRowCount)
            'Debug.Print("  VisCol       = " & swDesTable.GetVisibleColumnCount)
            'Debug.Print("")

            'For i = 0 To nTotRow
            '    sRowStr = "  |"
            '    For j = 0 To nTotCol
            '        sRowStr = sRowStr + swDesTable.GetEntryText(i, j) + "|"
            '    Next j
            '    Debug.Print(sRowStr)
            'Next i
            'swDesTable.Detach()

            'oggetto che identifica la dimensione della raggera
            Dim LeggiRaggera As LeggiSwDbRaggera = New LeggiSwDbRaggera()
            LeggiRaggera.Main(Ventola, NumeroPale, Motore, TipoPala)

            Dim status As Boolean
            Dim docDocExt As ModelDocExtension

            docDocExt = doc.Extension
            'status = docDocExt.SelectByID2("063 M@RR _._._ -_._-_._-[M]-_._._7_-A.SLDASM", "CONFIGURATIONS", 0, 0, 0, False, 0, Nothing, 0)
            'status = docDocExt.SelectByID2(diam_SW_star & " M@" & CodiceVentilatore1 & ".SLDASM", "CONFIGURATIONS", 0, 0, 0, False, 0, Nothing, 0)


            status = docDocExt.SelectByID2(diam_SW_star, "CONFIGURATIONS", 0, 0, 0, False, 0, Nothing, 0)

            'Aggiungo una doppia selezione perchè in alcuni casi non è presente la lettera della configurazione ma solo il diametro
            doc.ShowConfiguration2(diam_SW_star & " " & Configurazione)
            doc.ShowConfiguration2(diam_SW_star)


            'boolstatus = Part.Extension.SelectByID2("ER _._._ -_._-_._-F-_._._-1@ER _._._-_._-_._-F-_._._7_-A", "COMPONENT", 0, 0, 0, False, 0, Nothing, 0)
            'Part.EditSuppress2
            'Part.ClearSelection2 True
            'boolstatus = Part.Extension.SelectByID2("ER _._._ -_._-_._-F-_._._ valtenesi-1@ER _._._-_._-_._-F-_._._7_-A", "COMPONENT", 0, 0, 0, False, 0, Nothing, 0)



            'Gestione Motore Unificato
            If Motore = "U" Then

                'Selezione taglia motore e piedini
                For i = 0 To 9
                    If PiediniMotore = 1 Then
                        doc.Extension.SelectByID2("MEC " & TagliaMotore & " B34 " & MarcaMotore & "-" & i & "@" & CodiceVentilatore1, "COMPONENT", 0, 0, 0, False, 0, Nothing, 0)
                        doc.EditUnsuppress2()
                        doc.Extension.SelectByID2("MEC " & TagliaMotore & " B34 " & MarcaMotore & "-" & i & "@" & CodiceVentilatore1, "COMPONENT", 0, 0, 0, False, 0, Nothing, 0)
                    Else
                        doc.Extension.SelectByID2("MEC " & TagliaMotore & " B14 " & MarcaMotore & "-" & i & "@" & CodiceVentilatore1, "COMPONENT", 0, 0, 0, False, 0, Nothing, 0)
                        doc.EditUnsuppress2()
                        doc.Extension.SelectByID2("MEC " & TagliaMotore & " B14 " & MarcaMotore & "-" & i & "@" & CodiceVentilatore1, "COMPONENT", 0, 0, 0, False, 0, Nothing, 0)
                    End If

                Next



                Dim Ventilazione_motore As String
                Dim Cappello_motore As String

                If VentilazioneMotore = 0 Then
                    Ventilazione_motore = "IC418"
                Else
                    Ventilazione_motore = "IC411"
                End If


                If CappelloMotore = 0 Then
                    Cappello_motore = ""
                Else
                    Cappello_motore = " + Cappello"
                End If


                'Selezione raffreddamento e cappello
                Dim swComp As Component2
                swComp = doc.SelectionManager.GetSelectedObjectsComponent4(1, -1)
                swComp.ReferencedConfiguration = Ventilazione_motore & Cappello_motore
                status = doc.EditRebuild3()

            End If




            'Eccezione per pala TUV con motore V e F
            If (Motore = "F" Or Motore = "V") And TipoPala = 2 Then
                TipoPala = "6"
                SW_Raggera = "440"
                CodiceVentilatore2 = Motore & Ventola & " " & diam_SW_star & "-" & Calettamento & "-" & "_._" & "-" & Configurazione & "-" & "_._" & TipoPala & NumeroPale & "._-" & Flusso
            End If
            'Eccezione per pala TUV con motore V e F
            If (Motore = "F" Or Motore = "V") And TipoPala = 0 Then
                TipoPala = "J"
                SW_Raggera = "440"
                CodiceVentilatore2 = Motore & Ventola & " " & diam_SW_star & "-" & Calettamento & "-" & "_._" & "-" & Configurazione & "-" & "_._" & TipoPala & NumeroPale & "._-" & Flusso
            End If



            For i = 0 To 9
                Try
                    doc.Extension.SelectByID2("PALE PER " & TipoPala & " " & Ventola & NumeroPale & " D" & SW_Raggera & "-" & i & "@" & CodiceVentilatore1, "COMPONENT", 0, 0, 0, False, 0, Nothing, 0)
                    doc.EditUnsuppress2()
                    'riseleziono l'elemento --> da fare se no non lo trova
                    doc.Extension.SelectByID2("PALE PER " & TipoPala & " " & Ventola & NumeroPale & " D" & SW_Raggera & "-" & i & "@" & CodiceVentilatore1, "COMPONENT", 0, 0, 0, False, 0, Nothing, 0)

                    If NomeFile = "" Then
                        Dim swComp As Component2
                        swComp = doc.SelectionManager.GetSelectedObjectsComponent4(1, -1)
                        swComp.ReferencedConfiguration = diam_SW_star & " C" & Calettamento
                    End If
                    status = doc.EditRebuild3()
                    doc.ClearSelection2(True)

                Catch ex As Exception

                End Try

                percentuale = percentuale + 1
                Progress.Main(NomeFile, lb, lb1, CodiceVentilatore, percentuale, progressB, progressC)
            Next

            For i = 0 To 9
                Try
                    doc.Extension.SelectByID2(CodiceVentilatore3 & TipoCestello & "-" & i & "@" & CodiceVentilatore, "COMPONENT", 0, 0, 0, False, 0, Nothing, 0)
                    doc.EditUnsuppress2()

                Catch ex As Exception

                End Try
            Next
            doc.ClearSelection2(True)


            'Montaggio cestello
            'docDocExt = doc.Extension
            'status = docDocExt.SelectByID2("063 M@RR _._._ -_._-_._-[M]-_._._7_-A.SLDASM", "CONFIGURATIONS", 0, 0, 0, False, 0, Nothing, 0)
            'status = docDocExt.SelectByID2(diam_SW_star & " M@" & CodiceVentilatore1 & ".SLDASM", "CONFIGURATIONS", 0, 0, 0, False, 0, Nothing, 0)
            ''Aggiungo una doppia selezione perchè in alcuni casi non è presente la lettera della configurazione ma solo il diametro
            'doc.ShowConfiguration2(diam_SW_star & " " & Configurazione)
            'doc.ShowConfiguration2(diam_SW_star)



            '' Select a sketch and hide it
            'status = docDocExt.SelectByID2("PALE PER R7 D440-2@VR _._._-_._-_._-Q-_._._7_-A", "COMPONENT", 0, 0, 0, False, 0, Nothing, 0)
            ''doc.FeatureManager.HideBodies()
            'doc.EditSuppress2()

            'Dim swComp As Component2
            'swComp = doc.SelectionManager.GetSelectedObjectsComponent4(1, -1)
            'swComp.ReferencedConfiguration = diam_SW_star & " C" & Calettamento
            'status = doc.EditRebuild3()
            'doc.ClearSelection2(True)


            Dim chx_count As Integer = 0
            For Each item As Control In pan.Controls



                percentuale = percentuale + 1
                Progress.Main(NomeFile, lb, lb1, CodiceVentilatore, percentuale, progressB, progressC)

                If item.GetType Is GetType(Guna.UI2.WinForms.Guna2CheckBox) Then



                    Dim CheckX As Guna.UI2.WinForms.Guna2CheckBox
                    CheckX = pan.Controls("Check" & (chx_count + 1))

                    If CheckX.Visible = True Then

                        status = docDocExt.SelectByID2(Valore_CellaRiga_SW(chx_count) & "@" & CodiceVentilatore1, "COMPONENT", 0, 0, 0, False, 0, Nothing, 0)

                        If CheckX.Checked = True Then
                            doc.EditUnsuppress2()
                        Else
                            doc.EditSuppress2()
                        End If

                        doc.ClearSelection2(True)
                        chx_count = chx_count + 1

                    End If

                End If

            Next

            Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            saveFileDialog1.FilterIndex = 1
            saveFileDialog1.RestoreDirectory = True


            saveFileDialog1.FileName = CodiceVentilatore2


            saveFileDialog1.DefaultExt = "STEP"
            saveFileDialog1.AddExtension = True


            percentuale = percentuale + 1
            Progress.Main(NomeFile, lb, lb1, CodiceVentilatore, percentuale, progressB, progressC)

            If NomeFile = "" Then
                If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                    If saveFileDialog1.FileName IsNot Nothing Then
                        status = doc.SaveAs3(saveFileDialog1.FileName, 0, 2)
                    End If
                End If
            Else
                'Caso di TEST assemblato (il nome assegnato è legato alla confiurazione testata, per esempio se testo un accessorio, metterò il nome dell'accessorio)
                NomeSpec = NomeSpec.Replace(" ", "")
                status = doc.SaveAs3(NomeFile & "\" & NomeSpec & ".STEP", 0, 2)
            End If



            'status = doc.SaveAs3("C:\Users\" & nome_macchina & "\" & "Desktop" & "\" & CodiceVentilatore2 & ".STEP", 0, 2)
            'Dim sketchLines As Object
            'Dim swSketchSegment As SketchSegment
            'Dim swSketchMgr As SketchManager
            'swSketchMgr = doc.SketchManager


            '' Sketch a rectangle
            'status = docDocExt.SelectByID2("Front Plane", "PLANE", 0, 0, 0, False, 0, Nothing, 0)
            'doc.ClearSelection2(True)
            'sketchLines = swSketchMgr.CreateCornerRectangle(-0.0684166678777842, 0.0376953152008355, 0, -0.0273535635019471, 0.00483994917499331, 0)
            'doc.ClearSelection2(True)
            'swSketchMgr.InsertSketch(True)

            '' Sketch a circle
            'status = docDocExt.SelectByID2("Front Plane", "PLANE", 0, 0, 0, False, 0, Nothing, 0)
            'doc.ClearSelection2(True)
            'swSketchSegment = swSketchMgr.CreateCircle(0.044426, 0.079347, 0.0#, 0.057359, 0.06229, 0.0#)
            'doc.ClearSelection2(True)
            'swSketchMgr.InsertSketch(True)


            swApp.ExitApp()


            'il software rimne in esecuzione, ad una riapertura sucessiva mi dà errore se non killo l'app
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "SLDWORKS" Then
                    prog.Kill()
                End If
            Next



        Catch ex As Exception



            swApp.ExitApp()


            'il software rimne in esecuzione, ad una riapertura sucessiva mi dà errore se non killo l'app
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "SLDWORKS" Then
                    prog.Kill()
                End If
            Next



            'ATTIVA IL LOADING
            If NomeFile = "" Then
                load.Visible = False  '------> ESEGUIRE IN PARALLELO
                load.SendToBack()  '------> ESEGUIRE IN PARALLELO
                lb.Text = "LOADING..."
                lb.Location = New System.Drawing.Point(480, 490)
                Application.DoEvents()
            Else

                lb1.Text = ""
                Application.DoEvents()
            End If

        End Try

        'ATTIVA IL LOADING
        If NomeFile = "" Then
            load.Visible = False  '------> ESEGUIRE IN PARALLELO
            load.SendToBack()  '------> ESEGUIRE IN PARALLELO
            lb.Text = ""
            lb.Location = New System.Drawing.Point(480, 490)
            Application.DoEvents()
        Else
            lb1.Text = ""
            Application.DoEvents()
        End If


    End Sub



End Class
