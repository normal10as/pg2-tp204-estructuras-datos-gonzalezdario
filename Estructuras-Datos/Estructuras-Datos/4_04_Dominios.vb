Module _4_04_Dominios

    Sub Main()

        Dim dominios As New Collection
        Dim dominio As String

        dominios.Add("Argentina", ".ar")
        dominios.Add("Brasil", ".br")
        dominios.Add("Paraguay", ".py")
        dominios.Add("Bolivia", ".bo")
        dominios.Add("Chile", ".cl")
        dominios.Add("Colombia", ".co")
        dominios.Add("Peru", ".pe")
        dominios.Add("Mexico", ".mx")

        Do
            Console.Write("Ingrese el dominio: ")
            dominio = Console.ReadLine()
            If dominios.Contains(dominio) Then
                Console.WriteLine(dominios.Item(dominio))
            ElseIf dominio <> "" Then
                Console.WriteLine("No existe el dominio en la coleccion")
            End If
        Loop Until dominio = ""

    End Sub

End Module
