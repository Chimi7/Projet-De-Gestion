Module Module1

    Sub Main()
        'boucle infinie
        While 1
            Console.WriteLine(Date.Now.ToLongTimeString)
            ' pause pour 3 seconde
            System.Threading.Thread.Sleep(1000)
            'Balayage de l'écran
            Console.Clear()
        End While
        ' Pause factice
        Console.ReadLine()
    End Sub

End Module
