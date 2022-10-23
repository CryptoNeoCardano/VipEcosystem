Public Class TestFan


    Private ElencoTest(100) As String
    Public Sub Main(ByRef PanDiamCest As Guna.UI2.WinForms.Guna2Panel, ByRef PanAccessori As Guna.UI2.WinForms.Guna2Panel, ByRef panel As Guna.UI2.WinForms.Guna2Panel, ByRef lab As Label,
                    Serie_motore As String, Serie_ventola As String, Diam_SW As String, Angolo_SW As String, Config_ventilatore As String, TipoPala As String, Profilo_ventola As String,
                    Npale_ventola As String, Flusso As String, ByRef cbx_diametro As Guna.UI2.WinForms.Guna2ComboBox, ByRef cbx_pala As Guna.UI2.WinForms.Guna2ComboBox,
                    ByRef cbx_angolo As Guna.UI2.WinForms.Guna2ComboBox, ByRef cbx_cestello As Guna.UI2.WinForms.Guna2ComboBox, ByRef lab1 As Label,
                    ByRef progressB As Guna.UI2.WinForms.Guna2ProgressBar, ByRef progressC As Guna.UI2.WinForms.Guna2CircleProgressBar, ByRef cbx_unificato As Guna.UI2.WinForms.Guna2ComboBox,
                    ByRef cbx_marca As Guna.UI2.WinForms.Guna2ComboBox, ByRef cbx_ventilazione As Guna.UI2.WinForms.Guna2ComboBox, ByRef cbx_cappello As Guna.UI2.WinForms.Guna2ComboBox,
                    ByRef cbx_piedini As Guna.UI2.WinForms.Guna2ComboBox, CodiceMotore As String)


        For i = 0 To 99
            ElencoTest(i) = Nothing
        Next


        Control.CheckForIllegalCrossThreadCalls = False
        progressB.Visible = True
        Angolo_SW = "15"
        Dim CodiceVentilatore As String = Serie_motore & Serie_ventola & " _._._-_._-_._-" & Config_ventilatore & "-_._._" & Npale_ventola & "_-" & Flusso
        'Creo sul desktop la cartella di test
        Dim dirSave As String = directory_test & CodiceVentilatore
        System.IO.Directory.CreateDirectory(dirSave)


        'Identifico a monte il numero di accessori da testare
        Dim NomeTest As String = ""
        Dim NumAccTest As Integer = 0
        Dim NextAcc As Integer = 0
        Dim PercTestAcc As Double = 0
        Dim numDiam As Integer = cbx_diametro.Items.Count
        Dim numProfili As Integer = 0
        Dim numCestelli As Integer = 0

        cbx_diametro.SelectedIndex = 0
        cbx_pala.SelectedIndex = 0
        cbx_angolo.SelectedIndex = 0
        Try
            cbx_cestello.SelectedIndex = 0
        Catch ex As Exception

        End Try



        'Conto il numero di accessori --> TEST 1
        For Each item As Control In PanAccessori.Controls
            If item.Visible = True Then
                ElencoTest(NumAccTest) = item.Text
                NumAccTest = NumAccTest + 1
            End If
        Next

        'Conto il numero di profili per ogni diametro --> TEST 2
        For i = 0 To numDiam - 1
            cbx_diametro.SelectedIndex = i
            numProfili = cbx_pala.Items.Count
            For j = 0 To numProfili - 1
                cbx_pala.SelectedIndex = j
                NomeTest = cbx_diametro.SelectedItem & " - " & cbx_pala.SelectedItem
                ElencoTest(NumAccTest) = NomeTest
                NumAccTest = NumAccTest + 1
            Next
        Next

        'Conto il numero di cestelli per ogni diametro --> TEST 3
        For i = 0 To numDiam - 1
            cbx_diametro.SelectedIndex = i
            cbx_pala.SelectedIndex = 0
            numCestelli = cbx_cestello.Items.Count
            For j = 0 To numCestelli - 1
                cbx_cestello.SelectedIndex = j
                NomeTest = cbx_diametro.SelectedItem & " - " & cbx_cestello.SelectedItem
                ElencoTest(NumAccTest) = NomeTest
                NumAccTest = NumAccTest + 1
            Next
        Next


        'Solo nel caso in cui ho scelto il motore unificao
        Dim ListDiamMaxNumFrame(100) As String
        Dim ListNum As Integer = 0
        If Serie_motore = "U" Then
            For i = 0 To cbx_marca.Items.Count - 1
                Dim maxN_frame As Integer = 0
                For j = 0 To cbx_diametro.Items.Count - 1
                    cbx_diametro.SelectedIndex = j
                    For k = 0 To cbx_unificato.Items.Count - 1
                        If k >= maxN_frame Then
                            maxN_frame = k
                            ListDiamMaxNumFrame(ListNum) = cbx_diametro.SelectedItem
                        End If
                    Next
                Next

                'scrivo nell'excel i test da effettuare per la marca i
                cbx_diametro.SelectedItem = ListDiamMaxNumFrame(ListNum)
                For n = 0 To maxN_frame
                    cbx_unificato.SelectedIndex = n
                    NomeTest = cbx_diametro.SelectedItem & " - " & cbx_marca.SelectedItem & " - " & cbx_unificato.SelectedItem
                    ElencoTest(NumAccTest) = NomeTest
                    NumAccTest = NumAccTest + 1
                    ListNum = ListNum + 1
                Next

            Next
        End If



        Dim CreaExc As CreaExcelTest = New CreaExcelTest
        CreaExc.main(CodiceVentilatore, ElencoTest)

        '----------------------------------------CICLO DI TEST ACCESSORI----------------------------------------------------
        'Seleziono il caso 0 ---> sono interessato a testare solo gli accessori, la configurazione è indifferente
        cbx_diametro.SelectedIndex = 0
        Try
            cbx_unificato.SelectedIndex = 0
        Catch ex As Exception

        End Try


        cbx_pala.SelectedIndex = 0
        cbx_angolo.SelectedIndex = 0
        If Serie_motore = "U" Then
            cbx_marca.SelectedIndex = 0
        End If

        Try
            cbx_cestello.SelectedIndex = 0
        Catch ex As Exception

        End Try

        cbx_ventilazione.SelectedIndex = 0
        cbx_cappello.SelectedIndex = 0
        cbx_piedini.SelectedIndex = 0


        For Each item As Control In PanAccessori.Controls
            'ATTIVA IL LOADING
            panel.Visible = True  '------> ESEGUIRE IN PARALLELO
            panel.BringToFront()  '------> ESEGUIRE IN PARALLELO
            lab.Location = New System.Drawing.Point(480, 490)
            Application.DoEvents()



            If item.Visible = True Then
                Dim check As Guna.UI2.WinForms.Guna2CheckBox
                Try
                    PercTestAcc = Math.Round((NextAcc / NumAccTest) * 100, 0)
                    progressB.Value = PercTestAcc
                    lab.Text = PercTestAcc & "% - TEST ASSEMBLATO - " & item.Text
                    Application.DoEvents()
                    check = PanAccessori.Controls(item.Name)
                    check.Checked = True
                    Dim SwOpen As SwOpenFile = New SwOpenFile()
                    SwOpen.Main(Serie_motore, Serie_ventola, Diam_SW, Angolo_SW, Config_ventilatore, TipoPala, Npale_ventola,
                               Flusso, PanAccessori, panel, lab, TipoCestello, dirSave, item.Text, lab1, progressB, progressC, cbx_unificato.SelectedItem, CodiceMotore, cbx_marca.SelectedItem,
                               cbx_ventilazione.SelectedIndex, cbx_cappello.SelectedIndex, cbx_piedini.SelectedIndex)


                Catch ex As Exception

                End Try

                check.Checked = False

                NextAcc = NextAcc + 1

            End If

        Next
        '-----------------------------------------------------------------------------------------------------------------------






        '----------------------------------------CICLO DI TEST DIAMETRI/PALE----------------------------------------------------

        If Serie_motore = "U" Then
            cbx_ventilazione.SelectedIndex = 0
            cbx_cappello.SelectedIndex = 0
            cbx_piedini.SelectedIndex = 0
        End If

        For i = 0 To numDiam - 1
            cbx_diametro.SelectedIndex = i
            numProfili = cbx_pala.Items.Count
            If Serie_motore = "U" Then
                cbx_unificato.SelectedIndex = 0
            End If
            For j = 0 To numProfili - 1
                cbx_pala.SelectedIndex = j

                'ATTIVA IL LOADING
                panel.Visible = True  '------> ESEGUIRE IN PARALLELO
                panel.BringToFront()  '------> ESEGUIRE IN PARALLELO
                lab.Location = New System.Drawing.Point(480, 490)
                Application.DoEvents()



                Try
                    PercTestAcc = Math.Round((NextAcc / NumAccTest) * 100, 0)
                    progressB.Value = PercTestAcc
                    NomeTest = cbx_diametro.SelectedItem & " - " & cbx_pala.SelectedItem
                    lab.Text = PercTestAcc & "% - TEST ASSEMBLATO - Diametro/Pala: " & NomeTest
                    Application.DoEvents()
                    TipoPala = j

                    Dim SwOpen As SwOpenFile = New SwOpenFile()
                    SwOpen.Main(Serie_motore, Serie_ventola, Diam_SW, Angolo_SW, Config_ventilatore, TipoPala, Npale_ventola,
                              Flusso, PanAccessori, panel, lab, TipoCestello, dirSave, NomeTest, lab1, progressB, progressC, cbx_unificato.SelectedItem, CodiceMotore, cbx_marca.SelectedItem,
                              cbx_ventilazione.SelectedIndex, cbx_cappello.SelectedIndex, cbx_piedini.SelectedIndex)

                Catch ex As Exception

                End Try


                NextAcc = NextAcc + 1

            Next
        Next

        '-----------------------------------------------------------------------------------------------------------------------






        '----------------------------------------CICLO DI TEST DIAMETRI/PANNELLI----------------------------------------------------
        If Serie_motore = "U" Then
            cbx_ventilazione.SelectedIndex = 0
            cbx_cappello.SelectedIndex = 0
            cbx_piedini.SelectedIndex = 0
        End If

        For i = 0 To numDiam - 1
            cbx_diametro.SelectedIndex = i
            cbx_pala.SelectedIndex = 0
            If Serie_motore = "U" Then
                cbx_unificato.SelectedIndex = 0
            End If
            numCestelli = cbx_cestello.Items.Count
            For j = 0 To numCestelli - 1
                cbx_cestello.SelectedIndex = j


                'ATTIVA IL LOADING
                panel.Visible = True  '------> ESEGUIRE IN PARALLELO
                panel.BringToFront()  '------> ESEGUIRE IN PARALLELO
                lab.Location = New System.Drawing.Point(480, 490)
                Application.DoEvents()


                Try
                    PercTestAcc = Math.Round((NextAcc / NumAccTest) * 100, 0)
                    progressB.Value = PercTestAcc
                    NomeTest = cbx_diametro.SelectedItem & " - " & cbx_cestello.SelectedItem
                    lab.Text = PercTestAcc & "% - TEST ASSEMBLATO - Diametro/Cestello: " & NomeTest
                    Application.DoEvents()
                    Dim SwOpen As SwOpenFile = New SwOpenFile()
                    SwOpen.Main(Serie_motore, Serie_ventola, Diam_SW, Angolo_SW, Config_ventilatore, TipoPala, Npale_ventola,
                             Flusso, PanAccessori, panel, lab, TipoCestello, dirSave, NomeTest, lab1, progressB, progressC, cbx_unificato.SelectedItem, CodiceMotore, cbx_marca.SelectedItem,
                             cbx_ventilazione.SelectedIndex, cbx_cappello.SelectedIndex, cbx_piedini.SelectedIndex)

                Catch ex As Exception

                End Try

                NextAcc = NextAcc + 1

            Next
        Next

        '-----------------------------------------------------------------------------------------------------------------------



        '----------------------------------------CICLO DI TEST MOTORI UNIFICATI----------------------------------------------------
        If Serie_motore = "U" Then
            ListNum = 0
            For i = 0 To cbx_marca.Items.Count - 1
                cbx_angolo.SelectedIndex = 0
                cbx_diametro.SelectedItem = ListDiamMaxNumFrame(ListNum)
                'testo tutti i frame del diametro che ne contiene di più
                For j = 0 To cbx_unificato.Items.Count - 1
                    cbx_ventilazione.SelectedIndex = 1
                    cbx_cappello.SelectedIndex = 1
                    cbx_piedini.SelectedIndex = 1
                    cbx_unificato.SelectedIndex = j

                    Try
                        PercTestAcc = Math.Round((NextAcc / NumAccTest) * 100, 0)
                        progressB.Value = PercTestAcc
                        NomeTest = cbx_diametro.SelectedItem & " - " & cbx_marca.SelectedItem & " - " & cbx_unificato.SelectedItem
                        lab.Text = PercTestAcc & "% - TEST ASSEMBLATO - Motore unificato: " & NomeTest
                        Application.DoEvents()
                        Dim SwOpen As SwOpenFile = New SwOpenFile()
                        SwOpen.Main(Serie_motore, Serie_ventola, Diam_SW, Angolo_SW, Config_ventilatore, TipoPala, Npale_ventola,
                                   Flusso, PanAccessori, panel, lab, TipoCestello, dirSave, NomeTest, lab1, progressB, progressC, cbx_unificato.SelectedItem, CodiceMotore, cbx_marca.SelectedItem,
                                   cbx_ventilazione.SelectedIndex, cbx_cappello.SelectedIndex, cbx_piedini.SelectedIndex)

                    Catch ex As Exception

                    End Try

                    NextAcc = NextAcc + 1


                Next


            Next
        End If
        '-----------------------------------------------------------------------------------------------------------------------


        PercTestAcc = 100

        Try
            progressB.Value = PercTestAcc
        Catch ex As Exception

        End Try


        lab.Text = PercTestAcc & "% - TEST ASSEMBLATO"
        Application.DoEvents()

        panel.Visible = False  '------> ESEGUIRE IN PARALLELO
        panel.SendToBack()  '------> ESEGUIRE IN PARALLELO
        lab.Text = "LOADING..."
        lab.Location = New System.Drawing.Point(480, 490)
        Application.DoEvents()
        progressB.Visible = False


    End Sub


End Class
