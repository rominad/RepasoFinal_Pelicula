Imports Repaso_Pelicula
Module TestPersonaje
    Sub main()
        Dim actor1 As New Actor
        Dim personaje1 As New Personaje("Coky", actor1, 15000)

        Try
            actor1.Nombre = ""
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            actor1.Nombre = "SuperKoky"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            personaje1.Actor = actor1
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            personaje1.Sueldo = -16000
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            personaje1.Sueldo = 16000
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.WriteLine(personaje1.ToString())
        Console.ReadLine()
    End Sub
End Module
