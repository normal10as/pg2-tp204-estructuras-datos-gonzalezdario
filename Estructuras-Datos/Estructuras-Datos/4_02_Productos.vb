Module _4_02_Productos

    Dim codigos = New Integer() {1, 2, 3, 4}
    Dim productos = New String() {"Harina", "Sal", "Manteca", "Azucar"}
    Dim precios = New Decimal() {50, 10, 30, 40}

    Dim codigo As Integer
    Dim indice As Integer
    Dim cantidad As Integer
    Dim total As Decimal
    Dim subtotal As Decimal

    Sub Main()
        Do
            Console.WriteLine("#--------------------------------")
            Console.Write("Ingrese el codigo del producto: ")
            codigo = Console.ReadLine()

            If codigo <> 0 Then
                indice = codigo - 1
                Console.WriteLine("#--------------------------------")
                Console.WriteLine("> Descripcion: " & productos(indice))
                Console.WriteLine("> Precio: $" & precios(indice))

                Console.WriteLine()
                Console.Write("Ingrese la cantidad: ")
                cantidad = Console.ReadLine()

                subtotal = cantidad * precios(indice)
                Console.WriteLine("Total: $" & subtotal)
            End If

            total = total + subtotal
        Loop Until codigo = 0

        Console.WriteLine("#--------------------------------")
        Console.WriteLine("Total a pagar: $" & total)
    End Sub

End Module