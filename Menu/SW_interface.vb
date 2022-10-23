Imports System.Data.OleDb
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Security.AccessControl
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports System.IO.Ports
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Net.Sockets
Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting
Imports DevExpress.XtraReports.UI
Imports System.Collections
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraPrinting.Control
Imports DevExpress.XtraPrinting.Localization
Imports DevExpress.XtraPrinting.Native.ExportOptionsControllers
Imports DevExpress.XtraPrinting.Native
Imports Microsoft.VisualBasic
Imports VipDesignerUM.SwOpenFile
Imports VipDesignerUM.CercaFan
Imports VipDesignerUM.SegnalaErrore




Public Class SW_interface



    Public cf As CercaFan = New CercaFan()
    Public cm As FindMotorTypes = New FindMotorTypes()
    Public LeggiColonneSW As LeggiColonneSwDiamReti = New LeggiColonneSwDiamReti()
    Public LeggiColonneSW_UNI As LeggiColonneSwMotoriUnificati = New LeggiColonneSwMotoriUnificati()
    Public Compila_cbx_Diam As LeggiDiam = New LeggiDiam()
    Public Compila_cbx_Pala As LeggiPala = New LeggiPala()
    Public Compila_cbx_Cestello As LeggiCestello = New LeggiCestello()
    Public Compila_cbx_Unificato As LeggiUnificati = New LeggiUnificati()
    Public TestaFan As TestFan = New TestFan()
    Public EccezioneFan As ExcProfilo = New ExcProfilo()



    Private Sub SW_interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'DataBaseSWDataSet15.MarcaMotore'. È possibile spostarla o rimuoverla se necessario.
        Me.MarcaMotoreTableAdapter.Fill(Me.DataBaseSWDataSet15.MarcaMotore)
        'TODO: questa riga di codice carica i dati nella tabella 'DataBaseSWDataSet14.TipoCestello'. È possibile spostarla o rimuoverla se necessario.
        Me.TipoCestelloTableAdapter.Fill(Me.DataBaseSWDataSet14.TipoCestello)
        'TODO: questa riga di codice carica i dati nella tabella 'DataBaseSWDataSet12.TipoPala'. È possibile spostarla o rimuoverla se necessario.
        Me.TipoPalaTableAdapter.Fill(Me.DataBaseSWDataSet12.TipoPala)
        'TODO: questa riga di codice carica i dati nella tabella 'DataBaseSWDataSet1.Angolo'. È possibile spostarla o rimuoverla se necessario.
        Me.AngoloTableAdapter.Fill(Me.DataBaseSWDataSet1.Angolo)
        'TODO: questa riga di codice carica i dati nella tabella 'DataBaseSWDataSet1.Diametri'. È possibile spostarla o rimuoverla se necessario.
        Me.DiametriTableAdapter.Fill(Me.DataBaseSWDataSet1.Diametri)
        'TODO: questa riga di codice carica i dati nella tabella 'DataBaseSWDataSet.Ventilatori'. È possibile spostarla o rimuoverla se necessario.
        Me.VentilatoriTableAdapter.Fill(Me.DataBaseSWDataSet.Ventilatori)
        'TODO: questa riga di codice carica i dati nella tabella 'DataBaseSWDataSet.Motore'. È possibile spostarla o rimuoverla se necessario.
        Me.MotoreTableAdapter.Fill(Me.DataBaseSWDataSet.Motore)
        'TODO: questa riga di codice carica i dati nella tabella 'DataBaseSWDataSet.SerieVentola'. È possibile spostarla o rimuoverla se necessario.
        Me.SerieVentolaTableAdapter.Fill(Me.DataBaseSWDataSet.SerieVentola)

        cbx_ventola.SelectedIndex = -1
        cbx_motore.SelectedIndex = -1
        cbx_ventilatore.SelectedIndex = -1
        cbx_diametro.SelectedIndex = -1
        cbx_angolo.SelectedIndex = -1

        Serie_ventola = ""
        Serie_motore = ""
        Config_ventilatore = ""
        Flusso = ""
        Npale_ventola = ""


        Pan2.Visible = False
        Pan3.Visible = False
        btnOpenSW.Enabled = False

        BtnSegnalaVisible()
        BtnTestaVisible()


        LeggiColonneSW.Main()
        LeggiColonneSW_UNI.Main()
        MarcheMotori.MarcheMotori()

    End Sub



    Private Sub Serie_ventola_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_ventola.SelectedIndexChanged

        Try

            If cbx_ventola.SelectedItem(1)(0) <> "W" Then 'caso ventole vip
                Serie_ventola = cbx_ventola.SelectedItem(1)(1)
                EccezioneFan.Main(cbx_ventola.SelectedItem(1))
                Npale_ventola = cbx_ventola.SelectedItem(1)(2)

                Try
                    Profilo_ventola = cbx_ventola.SelectedItem(1)(6)
                Catch ex As Exception
                    Profilo_ventola = 0
                End Try

            ElseIf cbx_ventola.SelectedItem(1).Length = 2 Then 'caso ventole MW
                Serie_ventola = cbx_ventola.SelectedItem(1)(1)
                EccezioneFan.Main(cbx_ventola.SelectedItem(1))
                Npale_ventola = cbx_ventola.SelectedItem(1)(0)

                Try
                    Profilo_ventola = cbx_ventola.SelectedItem(1)(5)
                Catch ex As Exception
                    Profilo_ventola = 0
                End Try

            End If


        Catch ex As Exception

        End Try


        GUIupdate()

    End Sub


    Private Sub cbx_pala_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_pala.SelectedIndexChanged

        Try
            TipoPala = cbx_pala.SelectedItem(0)
        Catch ex As Exception

        End Try


        Compila_cbx_Cestello.Main(cf.FanName_star, cbx_diametro, cbx_cestello, cf.FanName_starU)
        cf.Main(Serie_motore, Serie_ventola, Diam_SW, Angolo_SW, Config_ventilatore,
                TipoPala, Profilo_ventola, Npale_ventola, Flusso, btnOpenSW, btnSegnala, cbx_diametro, cbx_pala, cbx_angolo, cbx_cestello, Compila_cbx_Cestello.TestState, cbx_marca)
        BtnSegnalaVisible()


    End Sub

    Private busy As Boolean = False
    Private Sub cbx_marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_marca.SelectedIndexChanged

        Try
            Marca_motore = cbx_marca.SelectedItem
        Catch ex As Exception

        End Try
        busy = True
        GUIupdate()
        busy = False

    End Sub


    Private Sub Serie_motore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_motore.SelectedIndexChanged

        Try
            Serie_motore = cbx_motore.SelectedItem(1)
        Catch ex As Exception

        End Try


        GUIupdate()
    End Sub





    Private Sub cbx_ventilatore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_ventilatore.SelectedIndexChanged

        Try
            Config_ventilatore = cbx_ventilatore.SelectedItem(1)
        Catch ex As Exception

        End Try

        GUIupdate()

    End Sub


    Private Sub cbx_flusso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_flusso.SelectedIndexChanged


        Flusso = cbx_flusso.SelectedItem
        GUIupdate()


    End Sub


    Public Sub sblocca_diam_ang()

        If Serie_ventola <> "" And Serie_motore <> "" And Config_ventilatore <> "" And Flusso <> "" And Npale_ventola <> "" Then
            Pan2.Visible = True

            file_exc_name = Serie_motore & Serie_ventola & " _._._ -_._-_._-" & Config_ventilatore & "_-_._." & Profilo_ventola & Npale_ventola & "_-" & Flusso

            Lettura_RefExcel1()

            accessories_display()

        Else
            Pan2.Visible = False
            Pan3.Visible = False
        End If

    End Sub






    Public Sub accessories_display()


        For Each item As Control In Pan3.Controls

            If item.GetType Is GetType(Guna.UI2.WinForms.Guna2CheckBox) Then
                item.Visible = False
            End If

        Next



        If Serie_motore <> "U" Then
            For i = 0 To Numero_colonne_SW - 1
                Try

                    Dim check As Guna.UI2.WinForms.Guna2CheckBox
                    check = Pan3.Controls("Check" & i + 1)

                    check.Text = Nome_colonne_SW(i + 1)
                    check.Visible = True

                Catch ex As Exception
                End Try
            Next
        End If



    End Sub


    Private Sub Diametro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_diametro.SelectedIndexChanged

        Diam_SW = cbx_diametro.SelectedItem

        If cbx_diametro.SelectedIndex <> -1 And cbx_angolo.SelectedIndex <> -1 Then
            Pan3.Visible = True
            'btn_creaSW.Visible = True
        Else
            Pan3.Visible = False
            'btn_creaSW.Visible = False
        End If

        'GUIupdate()
        LeggiColonneSW.Main()
        Compila_cbx_Pala.Main(cf.FanName_star, cbx_diametro, cbx_pala, cf.FanName_starU)
        Compila_cbx_Cestello.Main(cf.FanName_star, cbx_diametro, cbx_cestello, cf.FanName_starU)
        Compila_cbx_Unificato.Main(cf.FanName_star, cbx_diametro, cbx_unificato, cf.FanName_starU)
        cf.Main(Serie_motore, Serie_ventola, Diam_SW, Angolo_SW, Config_ventilatore,
                TipoPala, Profilo_ventola, Npale_ventola, Flusso, btnOpenSW, btnSegnala, cbx_diametro, cbx_pala, cbx_angolo, cbx_cestello, Compila_cbx_Cestello.TestState, cbx_marca)
        BtnSegnalaVisible()

    End Sub


    Private Sub Angolo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_angolo.SelectedIndexChanged

        Try
            Angolo_SW = cbx_angolo.SelectedItem(1)

        Catch ex As Exception

        End Try

        If cbx_diametro.SelectedIndex <> -1 And cbx_angolo.SelectedIndex <> -1 Then
            Pan3.Visible = True
            'btn_creaSW.Visible = True
        Else
            Pan3.Visible = False
            'btn_creaSW.Visible = False
        End If


        cf.Main(Serie_motore, Serie_ventola, Diam_SW, Angolo_SW, Config_ventilatore,
                TipoPala, Profilo_ventola, Npale_ventola, Flusso, btnOpenSW, btnSegnala, cbx_diametro, cbx_pala, cbx_angolo, cbx_cestello, Compila_cbx_Cestello.TestState, cbx_marca)
        BtnSegnalaVisible()
    End Sub


    Public Sub generate_excel()


        Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
        saveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.DefaultExt = ".xlsx"
        saveFileDialog1.AddExtension = True
        saveFileDialog1.FileName = file_exc_name



        Dim files(1) As String
        Dim save_dir As String = ""
        Dim nome_file As String


        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If saveFileDialog1.FileName IsNot Nothing Then
                save_dir = saveFileDialog1.FileName
                nome_file = Path.GetFileNameWithoutExtension(save_dir)
            End If
        End If


        'copia l'excel nella directory
        Try
            Dim file_name_MP As String = save_dir

            If System.IO.File.Exists(file_name_MP) = False Then
                IO.File.Copy(File_SW, file_name_MP, True) 'copy(dalla cartella, alla cartella con nome del file)
            End If

        Catch ex As Exception

        End Try



        'Apro il file excel e cerco la posizione della tabella prestabilita (LA CELLA RICERCATA E' "PTI")
        objExcel_SW = CreateObject("Excel.Application")
        objExcel_SW.workbooks.open(save_dir)
        objExcel_SW.visible = False




        'objExcel_SW.Worksheets("Foglio1").Cells(1, 1).value = file_exc_name


        objExcel_SW.Worksheets("Foglio1").Cells(1, 1).value = ""
        objExcel_SW.Worksheets("Foglio1").Cells(2, 1).value = "default"


        objExcel_SW.Worksheets("Foglio1").Cells(1, 2).value = "$DESCRIZIONE"
        objExcel_SW.Worksheets("Foglio1").Cells(2, 2).value = "Bulk"

        objExcel_SW.Worksheets("Foglio1").Cells(1, 3).value = "$STATOVISUALIZZAZIONE"
        objExcel_SW.Worksheets("Foglio1").Cells(2, 3).value = "Stato di visualizzazione-1"

        objExcel_SW.Worksheets("Foglio1").Cells(1, 4).value = "$NUMEROPARTE"
        objExcel_SW.Worksheets("Foglio1").Cells(2, 4).value = "$D"


        objExcel_SW.Worksheets("Foglio1").Cells(1, 5).value = "$PADRE"
        objExcel_SW.Worksheets("Foglio1").Cells(2, 5).value = ""

        objExcel_SW.Worksheets("Foglio1").Cells(1, 6).value = "$CONFIGURAZIONE@PALE PER " & Serie_ventola & Npale_ventola & " D400<1>"
        objExcel_SW.Worksheets("Foglio1").Cells(2, 6).value = Diam_SW & " C" & Angolo_SW

        objExcel_SW.Worksheets("Foglio1").Cells(1, 7).value = "$STATO@" & Serie_motore & Serie_ventola & " _._._ -_._-_._-" & Config_ventilatore & "-_._._._._-_<1>"
        objExcel_SW.Worksheets("Foglio1").Cells(2, 7).value = "R"

        objExcel_SW.Worksheets("Foglio1").Cells(1, 8).value = "$CONFIGURAZIONE@" & Serie_motore & Serie_ventola & " _._._ -_._-_._-" & Config_ventilatore & "-_._._._._-_<1>"
        objExcel_SW.Worksheets("Foglio1").Cells(2, 8).value = Diam_SW

        For i = 0 To Numero_colonne_SW - 1
            objExcel_SW.Worksheets("Foglio1").Cells(1, 9 + i).value = Valore_CellaRiga_SW(i)
        Next


        compila_StatiExc()

        'chiudo il file
        objExcel_SW.DisplayAlerts = False
        objExcel_SW.ActiveWorkbook.saveas(save_dir, 51)

        Try
            objExcel_SW.ActiveWorkbook.close()
        Catch ex As Exception

        End Try


        'CHIUDO EXCEL
        objExcel_SW.quit()


    End Sub




    Private Sub btn_creaSW_Click(sender As Object, e As EventArgs)
        generate_excel()
    End Sub


    Public Sub compila_StatiExc()


        For Each item As Control In Pan3.Controls

            If item.GetType Is GetType(Guna.UI2.WinForms.Guna2CheckBox) Then

                Dim CheckX As Guna.UI2.WinForms.Guna2CheckBox


                For i = 0 To Numero_colonne_SW - 1

                    If item.Text = Nome_colonne_SW(i + 1) Then

                        CheckX = Pan3.Controls("Check" & i + 1)

                        If CheckX.Checked = True Then
                            objExcel_SW.Worksheets("Foglio1").Cells(2, 9 + i).value = "R"
                        Else
                            objExcel_SW.Worksheets("Foglio1").Cells(2, 9 + i).value = "S"
                        End If

                    End If

                Next

            End If

        Next

    End Sub




    Public Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnOpenSW.Click

        'ATTIVA IL LOADING
        Guna2Panel2.Visible = True  '------> ESEGUIRE IN PARALLELO
        Guna2Panel2.BringToFront()  '------> ESEGUIRE IN PARALLELO
        Label22.Text = "0% - Apertura SolidWorks"
        Label22.Location = New System.Drawing.Point(480, 490)
        Application.DoEvents()


        Try
            Dim SwOpen As SwOpenFile = New SwOpenFile()
            SwOpen.Main(Serie_motore, Serie_ventola, Diam_SW, Angolo_SW, Config_ventilatore, TipoPala,
                        Npale_ventola, Flusso, Pan3, Guna2Panel2, Label22, TipoCestello, "", "", Label8, Guna2ProgressBar1, Guna2CircleProgressBar1, cbx_unificato.SelectedItem,
                        cf.CodiceMotore, Marca_motore, cbx_ventilazione.SelectedIndex, cbx_cappello.SelectedIndex, cbx_piedini.SelectedIndex)
        Catch ex As Exception

        End Try



    End Sub





    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnSegnala.Click
        Dim mail As SegnalaErrore = New SegnalaErrore()
        mail.Main(Serie_motore, Serie_ventola, Diam_SW, Angolo_SW, Config_ventilatore, TipoPala, Profilo_ventola, Npale_ventola, Flusso)
        btnSegnala.Visible = False
    End Sub



    Private Sub Check1_CheckedChanged(sender As Object, e As EventArgs) Handles Check1.CheckedChanged, Check2.CheckedChanged, Check3.CheckedChanged, Check4.CheckedChanged, Check5.CheckedChanged,
            Check6.CheckedChanged, Check7.CheckedChanged, Check8.CheckedChanged, Check9.CheckedChanged, Check10.CheckedChanged, Check11.CheckedChanged, Check12.CheckedChanged, Check13.CheckedChanged,
            Check13.CheckedChanged, Check14.CheckedChanged, Check15.CheckedChanged, Check16.CheckedChanged, Check17.CheckedChanged, Check18.CheckedChanged, Check19.CheckedChanged, Check20.CheckedChanged,
            Check21.CheckedChanged


        Dim chx As Guna.UI2.WinForms.Guna2CheckBox = CType(sender, Guna.UI2.WinForms.Guna2CheckBox)
        Dim Regola1 As RegolaMorsetierePressacavo = New RegolaMorsetierePressacavo()

        Regola1.Main(Pan3, chx, chx.Text)


    End Sub

    Private Sub cbx_cestello_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_cestello.SelectedIndexChanged
        Try
            TipoCestello = cbx_cestello.SelectedItem
        Catch ex As Exception

        End Try
        BtnSegnalaVisible()
    End Sub



    Private Sub btnTestaFan_Click(sender As Object, e As EventArgs) Handles btnTestaFan.Click

        Try
            TestaFan.Main(Pan2, Pan3, Guna2Panel2, Label22, Serie_motore, Serie_ventola, Diam_SW, Angolo_SW, Config_ventilatore,
            TipoPala, Profilo_ventola, Npale_ventola, Flusso, cbx_diametro, cbx_pala, cbx_angolo, cbx_cestello, Label8, Guna2ProgressBar1, Guna2CircleProgressBar1, cbx_unificato, cbx_marca, cbx_ventilazione,
            cbx_cappello, cbx_piedini, cf.CodiceMotore)
        Catch ex As Exception

        End Try


    End Sub

    Public Sub AzzeraSelezioneCbx()
        cbx_diametro.SelectedIndex = -1
        cbx_pala.SelectedIndex = -1
        cbx_angolo.SelectedIndex = -1
        cbx_cestello.SelectedIndex = -1
    End Sub


    Public Sub BtnSegnalaVisible()

        Dim cbx1 As Integer = cbx_ventola.SelectedIndex
        Dim cbx2 As Integer = cbx_motore.SelectedIndex
        Dim cbx3 As Integer = cbx_ventilatore.SelectedIndex
        Dim cbx4 As Integer = cbx_flusso.SelectedIndex
        Dim cbx5 As Integer = cbx_diametro.SelectedIndex
        Dim cbx6 As Integer = cbx_pala.SelectedIndex
        Dim cbx7 As Integer = cbx_angolo.SelectedIndex
        Dim cbx8 As Integer = cbx_cestello.SelectedIndex

        If cbx1 > -1 And cbx2 > -1 And cbx3 > -1 And cbx4 > -1 And cbx5 > -1 And cbx6 > -1 And cbx7 > -1 And cbx8 > -1 Then
            btnSegnala.Visible = True
        Else
            btnSegnala.Visible = False
        End If

    End Sub

    Public Sub BtnTestaVisible()

        Dim cbx1 As Integer = cbx_ventola.SelectedIndex
        Dim cbx2 As Integer = cbx_motore.SelectedIndex
        Dim cbx3 As Integer = cbx_ventilatore.SelectedIndex
        Dim cbx4 As Integer = cbx_flusso.SelectedIndex
        Dim cbx5 As Integer = cbx_marca.SelectedIndex


        If (nome_macchina = "Remo" Or nome_macchina = "Lorenzo" Or nome_macchina = "Davide") And cbx1 > -1 And cbx2 > -1 And cbx3 > -1 And ((cbx5 > -1) Or (Serie_motore <> "U")) Then
            btnTestaFan.Visible = True
        Else
            btnTestaFan.Visible = False
        End If

    End Sub


    Public Sub GUIupdate()


        Try

            'Gestione della combobox motori unificati
            If Serie_motore <> "U" Then

                cbx_unificato.Visible = False
                lab_unificato.Visible = False
                cbx_ventilazione.Visible = False
                lab_ventilaione.Visible = False
                cbx_cappello.Visible = False
                lab_cappello.Visible = False
                cbx_piedini.Visible = False
                lab_piedini.Visible = False
                cbx_marca.Visible = False
                lab_marca.Visible = False
            Else

                cbx_unificato.Visible = True
                lab_unificato.Visible = True
                cbx_ventilazione.Visible = True
                lab_ventilaione.Visible = True
                cbx_cappello.Visible = True
                lab_cappello.Visible = True
                cbx_piedini.Visible = True
                lab_piedini.Visible = True
                cbx_marca.Visible = True
                lab_marca.Visible = True

                If busy = False Then
                    cbx_marca.Visible = True
                    lab_marca.Visible = True
                    cm.Main(Serie_motore, Serie_ventola, Config_ventilatore, cbx_marca, btnOpenSW)
                End If

            End If

        Catch ex As Exception

        End Try

        sblocca_diam_ang()
        cf.Main(Serie_motore, Serie_ventola, Diam_SW, Angolo_SW, Config_ventilatore,
                TipoPala, Profilo_ventola, Npale_ventola, Flusso, btnOpenSW, btnSegnala, cbx_diametro, cbx_pala, cbx_angolo, cbx_cestello, Compila_cbx_Cestello.TestState, cbx_marca)
        LeggiColonneSW.Main()
        LeggiColonneSW_UNI.Main()
        Compila_cbx_Diam.Main(cf.FanName_star, cbx_diametro, cf.FanName_starU)
        BtnSegnalaVisible()
        BtnTestaVisible()
        AzzeraSelezioneCbx()


    End Sub

End Class