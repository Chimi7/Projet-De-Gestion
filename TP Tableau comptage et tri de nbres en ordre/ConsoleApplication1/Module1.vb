Module Module1

    Sub Main()
        'Initialisation des variables 
        Dim MonTableau(20), Intermediaire, TailleTableau As Integer
        Dim EnOrdre As Boolean = False
        'Remplissage du tableau de nombres aléatoires 
        For i As Integer = 0 To MonTableau.Length - 1
            MonTableau(i) = Rnd(1) * 10
        Next
        'Tri à bulles  
        TailleTableau = MonTableau.Length
        While Not EnOrdre
            EnOrdre = True
            For i = 0 To TailleTableau - 2
                If MonTableau(i) > MonTableau(i + 1) Then
                    Intermediaire = MonTableau(i)
                    MonTableau(i) = MonTableau(i + 1)
                    MonTableau(i + 1) = Intermediaire
                    EnOrdre = False
                End If
            Next
            TailleTableau = TailleTableau - 1
        End While
        'Affichage des résultats 
        For i = 0 To MonTableau.Length - 1
            Console.Write(" " & MonTableau(i))
        Next
        'Pause        
        Console.Read()
    End Sub

End Module
