Module _4_05_Dominios2
    Enum tareas As Byte
        consulta = 1
        agregar = 2
        modificar = 3
        eliminar = 4
    End Enum

    Dim dominios As New Collection
    Dim seleccion As Byte
    Dim dominio As String
    Dim pais As String

    Sub Main()
        dominios.Add("Argentina", ".ar")
        dominios.Add("Brasil", ".br")
        dominios.Add("Paraguay", ".py")
        dominios.Add("Bolivia", ".bo")
        dominios.Add("Chile", ".cl")
        dominios.Add("Colombia", ".co")
        dominios.Add("Peru", ".pe")
        dominios.Add("Mexico", ".mx")

        'Menu--------------------------------------------------------
        Do
            Titulo("Coleccion de Dominios...")
            Console.WriteLine("¿Qué accion desea realizar?")
            Console.WriteLine("1 - Consultar por un dominio")
            Console.WriteLine("2 - Agregar un dominio a la coleccion")
            Console.WriteLine("3 - Modificar un dominio de la coleccion")
            Console.WriteLine("4 - Eliminar un dominio")
            Console.WriteLine(vbCrLf & "La coleccion actualmente cuenta con: " & dominios.Count & " dominios.")
            Console.Write(vbCrLf & ":")
            seleccion = Console.ReadLine()

            Select Case seleccion
                Case tareas.consulta
                    Consultar()
                Case tareas.agregar
                    Agregar()
                Case tareas.modificar
                    Modificar()
                Case tareas.eliminar
                    Eliminar()
            End Select
        Loop Until seleccion = 0


    End Sub

    Sub Eliminar()
        Titulo("Eliminar un dominio...")
        Console.Write("Ingrese el dominio a eliminar: ")
        dominio = Console.ReadLine()
        dominios.Remove(dominio)
        Console.WriteLine(vbCrLf & "Dominio Eliminado.")
        Console.ReadKey()
    End Sub

    Sub Modificar()
        Dim nuevodominio As String
        Titulo("Modificar un dominio de la coleccion...")
        Console.Write("Ingrese el dominio a modificar: ")
        dominio = Console.ReadLine()

        If dominios.Contains(dominio) Then
            Titulo("Modificar un dominio de la coleccion...")
            Console.WriteLine("¿Qué desea modificar?")
            Console.WriteLine("1 - El dominio")
            Console.WriteLine("2 - El pais")
            Console.Write(vbCrLf & ":")
            seleccion = Console.ReadLine()

            Select Case seleccion
                Case 1
                    pais = dominios.Item(dominio)
                    Titulo("Modificar un dominio de la coleccion...")

                    Do
                        Console.Write("Ingrese el nuevo dominio: ")
                        nuevodominio = Console.ReadLine()
                        If Not dominios.Contains(nuevodominio) Then
                            dominios.Remove(dominio)
                            dominios.Add(pais, nuevodominio)
                            Console.WriteLine(vbCrLf & "Modificacion realizada con exito.")
                            Console.ReadKey()
                            Exit Do
                        Else
                            Console.WriteLine(vbCrLf & "El dominio que usted ingreso ya existe.")
                        End If
                    Loop Until nuevodominio = "" Or nuevodominio = "0"

                Case 2
                    Dim bandera As Boolean
                    Titulo("Modificar un dominio de la coleccion...")
                    Do
                        bandera = True
                        Console.Write("Ingrese el nuevo pais: ")
                        pais = Console.ReadLine()
                        For x = 1 To dominios.Count
                            If pais = dominios.Item(x) Then
                                Console.WriteLine(vbCrLf & "El pais que usted ingreso ya existe.")
                                bandera = False
                                Exit For
                            End If
                        Next
                        If bandera And pais <> "" Then
                            dominios.Remove(dominio)
                            dominios.Add(pais, dominio)
                            Console.WriteLine(vbCrLf & "Modificacion realizada con exito.")
                            Console.ReadKey()
                        End If
                    Loop Until bandera
            End Select
        Else
            Console.WriteLine(vbCrLf & "El dominio no existe. Si desea agregarlo, puede hacerlo seleccionando la opcion correspondiente.")
        End If
    End Sub

    Sub Agregar()
        Titulo("Agregar un dominio a la coleccion...")
        Console.Write("Ingrese el nuevo dominio: ")
        dominio = Console.ReadLine()
        Console.Write("Ingrese el país al que corresponde el dominio: ")
        pais = Console.ReadLine()
        dominios.Add(pais, dominio)
        Console.WriteLine(vbCrLf & "Dominio agregado.")
        Console.ReadKey()
    End Sub

    Sub Consultar()
        Titulo("Consultar por un dominio...")
        Console.Write("Ingrese el dominio: ")
        dominio = Console.ReadLine()
        If dominios.Contains(dominio) Then
            Console.WriteLine(vbCrLf & "Pais: " & dominios.Item(dominio))
        ElseIf dominio <> "" Then
            Console.WriteLine(vbCrLf & "No existe el dominio en la coleccion")
        End If
        Console.ReadKey()
    End Sub

    Sub Titulo(texto As String)
        Console.Clear()
        Console.WriteLine("#--------------------------------------------------------")
        Console.WriteLine(" " + texto)
        Console.WriteLine("#--------------------------------------------------------")
    End Sub

End Module
