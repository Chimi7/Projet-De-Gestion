Module Module1
   
    Sub Main()
        Dim Tableau(9) As Integer
        Dim Resultat As Integer = 0
        ' demande de valeur via la fonction
        For i As Integer = 0 To Tableau.Length - 1
            Tableau(i) = Demande(i)
        Next
        'additionne les valeurs
        For i As Integer = 0 To Tableau.Length - 1
            Resultat = Resultat + Tableau(i)
        Next
        ' affiche le résultat
        Console.WriteLine(Resultat)
        'pause factice
        Console.ReadLine()
    End Sub
    Function Demande(ByVal numero As Integer) As Integer
        Dim valeurentree As String
        'demande de valeur
        Do
            Console.WriteLine(" entrer la valeurs n° " & numero + 1)
            valeurentree = Console.ReadLine()
            ' tourne tant que la valeur entrée est un nombre
        Loop Until IsNumeric(valeurentree)
        Return valeurentree
    End Function



End Module
