Module Module1

    Sub Main()
        ' déclaration des variables
        Dim choix As String = ""
        Dim valeurentree As String = ""
        Dim valeur1 As Double = 0
        Dim valeur2 As Double = 0
        'confection du menu
        Console.WriteLine(" Mini Calculatrice")
        Console.WriteLine(" Opérations Possibles")
        Console.WriteLine(" Addition: a")
        Console.WriteLine(" Soustraction: b")
        Console.WriteLine(" Multiplication: m")
        Console.WriteLine(" Division: d")
        Do
            Console.WriteLine(" Faites votre choix ")
            choix = Console.ReadLine()
            'tourne jusqu'à ce que le choix soit correct
        Loop Until choix = "a" Or choix = "b" Or choix = "c" Or choix = "d"
        'récupération du premier nombre
        Do
            Console.WriteLine(" Entrer la première valeur")
            valeurentree = Console.ReadLine()
        Loop Until IsNumeric(valeurentree)
        'positionne la valeur dans un double
        valeur1 = valeurentree
        ' Récupération de la seconde valeur
        Do
            Console.WriteLine(" Entrer la seconde valeur")
            valeurentree = Console.ReadLine()
        Loop Until IsNumeric(valeurentree)
        'positionne la valeur dans un double
        valeur2 = valeurentree 
        Select Case choix
            Case "a"
                ' Addition
                Console.WriteLine(valeur1 & "+" & valeur2 & "=" & valeur1 + valeur2)
            Case "s"
                'Soustraction
                Console.WriteLine(valeur1 & "-" & valeur2 & "=" & valeur1 - valeur2)
            Case "m"
                ' Multiplication
                Console.WriteLine(valeur1 & "x" & valeur2 & "=" & valeur1 * valeur2)
            Case "d"
                ' Division
                Console.WriteLine(valeur1 & "/" & valeur2 & "=")
                Console.WriteLine(" Valeur exacte :" & valeur1 / valeur2)
                Console.WriteLine(" Résultat entier :" & valeur1 \ valeur2)
                Console.WriteLine(" Reste :" & valeur1 Mod valeur2)
        End Select
        Console.ReadLine()
    End Sub

End Module
