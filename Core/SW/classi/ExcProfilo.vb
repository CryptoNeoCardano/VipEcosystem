Public Class ExcProfilo
    'Classe usata per gestire l'eccezione dei serie ventole. Per esempio VH5 ->V oppure VH6 --> H

    Public Sub Main(SerieVentola)

        Select Case SerieVentola
            Case "VH4"
                Serie_ventola = "K"
            Case "VH5"
                Serie_ventola = "V"
            Case "VH6"
                Serie_ventola = "H"
        End Select

    End Sub


End Class
