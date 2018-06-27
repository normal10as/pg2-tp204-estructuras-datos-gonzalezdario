Module _4_07_Alumnos2
    Const maxalumnos As Byte = 40
    Const maxnotas As Byte = 4

    Dim cantidadalumnos As Byte
    Dim nombre As String

    Dim cantidadnotas As Byte
    Dim nota As Single

    Dim alumnos As New ArrayList
    Dim calificaciones As New ArrayList
    Dim promedios As New ArrayList


    Sub Main()
        IngresarValor(cantidadalumnos, maxalumnos, "alumnos")
        IngresarValor(cantidadnotas, maxnotas, "notas")

        cantidadalumnos -= 1
        cantidadnotas -= 1

        For x = 0 To cantidadalumnos
            Do
                Console.Write("Ingrese el nombre: ")
                nombre = Console.ReadLine()
            Loop Until Validar(nombre) And Not Duplicado(nombre)
            alumnos.Add(nombre)

            Dim matriz(cantidadnotas) As Single
            Dim promedio As Single
            For y = 0 To cantidadnotas
                Do
                    If Not Validar(nota, 10) Then
                        Console.WriteLine("Error - El valor supera a 10.")
                    End If
                    Console.Write("Ingrese la " & y + 1 & "° nota: ")
                    matriz(y) = Console.ReadLine()
                Loop Until Validar(nota, 10)
                promedio += matriz(y)
            Next
            promedio /= (cantidadnotas + 1)
            calificaciones.Add(matriz)
            promedios.Add(promedio)
        Next

        For x = 0 To cantidadalumnos
            Console.WriteLine("Nombre: {0,-30} Promedio: {1,4}", alumnos.Item(x), promedios.Item(x))
        Next
    End Sub

    Sub IngresarValor(ByRef valor As Byte, ByRef maximo As Byte, ByRef texto As String)
        Do
            Console.Write("Ingrese la cantidad de " & texto & ": ")
            valor = Console.ReadLine()
        Loop Until Validar(valor, maximo)
    End Sub

    Function Validar(ByRef valor As Decimal, ByRef maximo As Byte) As Boolean
        Return valor <= maximo
    End Function

    Function Validar(ByRef valor As String) As Boolean
        Return valor <> ""
    End Function

    Function Duplicado(ByRef valor As String) As Boolean
        Return alumnos.Contains(valor)
    End Function

End Module
