Module _4_03_Alumnos
    Const maxalumnos As Byte = 40
    Const maxnotas As Byte = 4

    Dim alumnos As Byte
    Dim notas As Byte

    Sub Main()
        IngresarValor(alumnos, maxalumnos, "alumnos")
        IngresarValor(notas, maxnotas, "notas")

        alumnos -= 1

        Dim nombres(alumnos) As String
        Dim calificaciones(alumnos, notas) As Decimal

        For x = 0 To alumnos

            Do
                Console.Write("Ingrese el nombre: ")
                nombres(x) = Console.ReadLine()
            Loop Until Validar(nombres(x)) And Not Duplicado(nombres(x), nombres, x - 1)

            For y = 0 To notas - 1
                Do
                    If Not Validar(calificaciones(x, y), 10) Then
                        Console.WriteLine("Error - El valor supera a 10.")
                    End If
                    Console.Write("Ingrese la " & y + 1 & "° nota: ")
                    calificaciones(x, y) = Console.ReadLine()
                Loop Until Validar(calificaciones(x, y), 10)
                calificaciones(x, notas) += calificaciones(x, y) 'Promedio
            Next
            calificaciones(x, notas) /= notas 'Promedio
        Next

        Dim observacion As String
        For x = 0 To alumnos

            If calificaciones(x, notas) >= 6 Then
                observacion = "Aprobado"
            Else
                observacion = "Desaprobado"
            End If
            Console.WriteLine("Nombre: {0,-30} Promedio: {1,4}  {2}", nombres(x), calificaciones(x, notas), observacion)
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

    Function Duplicado(ByRef valor As String, lista As Array, final As Integer) As Boolean
        Dim a As Boolean
        If (final > -1) Then
            For x = 0 To final
                If valor = lista(x) Then
                    a = True
                Else
                    a = False
                End If
            Next
        End If
        Return a
    End Function

End Module
