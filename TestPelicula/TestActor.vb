Imports Repaso_Pelicula


Module ActorTest
    Sub main()
        Try
            Dim actor1 As New Actor()
            actor1.FechaNacimiento = Today
            actor1.Nombre = "Primer Actor"
            Console.WriteLine(actor1.ToString())
        Catch ex As Exception
            Console.WriteLine("Error inesperado!")
        End Try
        Try
            Dim actor2 As New Actor(Today, "Segundo Actor")
            Console.WriteLine(actor2.ToString())
        Catch ex As Exception
            'Console.WriteLine(ex.Message)
            Console.WriteLine("Error inesperado!")
        End Try
        Console.ReadKey()
    End Sub
End Module
