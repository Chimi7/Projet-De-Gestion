Module Module1

    Sub Main()
        ' Initialisation des variables
        Dim LaDate As Date
        'Récupération de la date du jour
        LaDate = Date.Now
        'boucle infinie
        While 1
            Console.WriteLine(" -------------------------------------------- ")
            Console.WriteLine(" ------------- " & LaDate.ToLongDateString & " ---------- ")
            Console.WriteLine(" -------------------------------------------- ")
            ' pause pour 3 seconde
            System.Threading.Thread.Sleep(3000)
            'Balayage de l'écran
            Console.Clear()
        End While
        ' Pause factice
        Console.ReadLine()
    End Sub

End Module
