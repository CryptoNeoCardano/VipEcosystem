Public Class RegolaMorsetierePressacavo


    Public Sub Main(ByRef Pan As Guna.UI2.WinForms.Guna2Panel, ByRef chx As Guna.UI2.WinForms.Guna2CheckBox, NomeChx As String)



        Select Case NomeChx

            Case "Calotta Posteriore Pressacavo"

                If chx.Text = NomeChx And chx.Checked = True Then

                    For Each item As Control In Pan.Controls

                        If item.GetType Is GetType(Guna.UI2.WinForms.Guna2CheckBox) Then

                            Dim check As Guna.UI2.WinForms.Guna2CheckBox
                            check = Pan.Controls(item.Name)

                            If (check.Text = "Morsettiera Metallo" Or check.Text = "Morsettiera Plastica") And check.Checked = True Then
                                check.Checked = False
                            End If


                        End If
                    Next

                End If

            Case "Morsettiera Plastica"

                If chx.Text = NomeChx And chx.Checked = True Then

                    For Each item As Control In Pan.Controls

                        If item.GetType Is GetType(Guna.UI2.WinForms.Guna2CheckBox) Then

                            Dim check As Guna.UI2.WinForms.Guna2CheckBox
                            check = Pan.Controls(item.Name)

                            If check.Text = "Morsettiera Metallo" Or check.Text = "Calotta Posteriore Pressacavo" And check.Checked = True Then
                                check.Checked = False
                            End If


                        End If
                    Next

                End If

            Case "Morsettiera Metallo"

                If chx.Text = NomeChx And chx.Checked = True Then

                    For Each item As Control In Pan.Controls

                        If item.GetType Is GetType(Guna.UI2.WinForms.Guna2CheckBox) Then

                            Dim check As Guna.UI2.WinForms.Guna2CheckBox
                            check = Pan.Controls(item.Name)

                            If check.Text = "Morsettiera Plastica" Or check.Text = "Calotta Posteriore Pressacavo" And check.Checked = True Then
                                check.Checked = False
                            End If


                        End If
                    Next

                End If

        End Select


    End Sub



End Class
