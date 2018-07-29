Imports Repaso_Pelicula

Module TestPelicula
    Sub Main()
        Dim Actor1 As New Actor
        Dim Actor2 As New Actor
        Dim Actor3 As New Actor
        Dim Actor4 As New Actor

        Dim Personaje1 As New Personaje("BATMAN", Actor1, 1000)
        Dim Personaje2 As New Personaje("SPIDERMAN", Actor2, 500)
        Dim Personaje3 As New Personaje("IRON MAN", Actor3, 1000)
        Dim Personaje4 As New Personaje("NUEVO MAN", Actor4, 3000)
        Dim Personaje5 As New Personaje("THOR", Actor4, 2000)
        Dim Personaje6 As New Personaje("CAPITAN MARVEL", Actor3, 3000)

        Dim Pelicula1 As New Pelicula

        Try
            Actor1.Nombre = ""
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Actor1.Nombre = "Alberto"
            Actor2.Nombre = "Luciano"
            Actor3.Nombre = "Roberto"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Pelicula1.Nombre = ""
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Pelicula1.Nombre = "Los tres man"
        Catch ex As Exception

        End Try
        Try
            Pelicula1.AddPersonaje(Personaje1)
            Pelicula1.AddPersonaje(Personaje2)
            Pelicula1.AddPersonaje(Personaje3)
            Pelicula1.AddPersonaje(Personaje4)
            Pelicula1.AddPersonaje(Personaje5)
            Pelicula1.AddPersonaje(Personaje6)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        'Try
        '    Console.WriteLine(Pelicula1.ToString())
        '    Console.WriteLine("- Lista de personajes:")
        '    For Each Personaje In Pelicula1.getAllPersonajes()
        '        Console.WriteLine(Personaje.ToString)
        '    Next
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try
        'Try
        '    Console.WriteLine("- Creditos:")
        '    For Each Personaje In Pelicula1.Creditos()
        '        Console.WriteLine(Personaje)
        '    Next
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try
        'Try
        '    Actor4.Nombre = "Fabio"
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try
        'Try
        '    Pelicula1.AddPersonaje(Personaje4)
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try
        Try
            Console.WriteLine(Pelicula1.ToString())
            Console.WriteLine("- Lista de personajes Nuevos:")
            For Each Personaje In Pelicula1.getAllPersonajes()
                Console.WriteLine(Personaje.ToString)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Console.WriteLine("-Total sueldos: " & vbNewLine & Pelicula1.SumarSueldo())
            Console.WriteLine("-Mejores sueldos: ")
            For Each elemento In Pelicula1.TopSueldos()
                Console.WriteLine(elemento)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


        Console.ReadLine()

    End Sub
End Module
