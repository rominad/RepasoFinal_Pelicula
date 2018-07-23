Imports Repaso_Pelicula

Module TestPelicula
    Sub Main()
        Dim Actor1 As New Actor
        Dim Actor2 As New Actor
        Dim Actor3 As New Actor
        Dim Actor4 As New Actor

        Dim Personaje1 As New Personaje("Alberto", Actor1, 1500.5)
        Dim Personaje2 As New Personaje("Luciano", Actor2, 3800.8)
        Dim Personaje3 As New Personaje("Roberto", Actor3, 1500.5)
        Dim Personaje4 As New Personaje("Andres", Actor4, 3800.8)

        Dim Pelicula1 As New Pelicula

        Try
            Actor1.Nombre = ""
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Actor1.Nombre = "BATMAN"
            Actor2.Nombre = "SPIDERMAN"
            Actor3.Nombre = "IRON MAN"
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
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Console.WriteLine(Pelicula1.ToString())
            Console.WriteLine("- Lista de personajes:")
            For Each Personaje In Pelicula1.getAllPersonajes()
                Console.WriteLine(Personaje.ToString)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Console.WriteLine("- Creditos:")
            For Each Personaje In Pelicula1.Creditos()
                Console.WriteLine(Personaje)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Actor4.Nombre = "NUEVO man"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Pelicula1.AddPersonaje(Personaje4)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
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
