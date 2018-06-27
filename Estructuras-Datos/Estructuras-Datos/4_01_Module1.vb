Module _4_01_Module1

    Dim media As Integer

    Dim arreglo(5) As Integer
    Sub Main()

        'For Each elemento In arreglo
        '    Console.Write("Ingrese un numero: ")
        '    arreglo(elemento) = Console.ReadLine()
        '    media += arreglo(elemento)
        'Next

        For x = 0 To arreglo.Length - 1
            Console.Write("Ingrese un numero: ")
            arreglo(x) = Console.ReadLine()
            media += arreglo(x)
        Next

        media /= arreglo.Length

        'For Each elemento In arreglo
        '    Console.WriteLine("Numero " & elemento + 1 & ": " & arreglo(elemento) & "Desviacion: " & media - arreglo(elemento))
        'Next

        For x = 0 To arreglo.Length - 1
            'Console.WriteLine("Numero " & x + 1 & ": " & arreglo(x) & "Desviacion: " & media - arreglo(x))

            Console.WriteLine("Numero {0} : {1,-5} Desviacion: {2,-5}", x + 1, arreglo(x), media - arreglo(x))
        Next

        Console.WriteLine("Media: " & media)
    End Sub

End Module
