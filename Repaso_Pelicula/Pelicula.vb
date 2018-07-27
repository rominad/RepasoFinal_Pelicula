Imports Repaso_Pelicula

Public Class Pelicula
    '_IMPLEMENTO INTERFACE'
    Implements Entidad
    '_CAMPOS 
    Private _nombre As String
    Private _personajes As List(Of Personaje)
    '_PROPIEDADES
    Public Property Nombre As String Implements Entidad.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value = "" Then
                Throw New Exception("El nombre no puede estar vacio!!")
            End If
            _nombre = value
        End Set
    End Property
    Public Sub AddPersonaje(personaje As Personaje)
        _Personajes.Add(personaje)
    End Sub
    Public Sub RemovePersonaje(Personaje As Personaje)
        _Personajes.Remove(Personaje)
    End Sub
    Public Function getAllPersonajes() As List(Of Personaje)
        Return _Personajes
    End Function
    '_METODOS
    Function Creditos() As List(Of String)
        'debe devolver 1 lista con nombres de actores y su personaje interpretado entre(),ordenados por nombre de actor. 
        Dim lista As New List(Of String)
        For Each Personaje In _personajes
            lista.Add(Personaje.ToString)
        Next
        'aca ordeno la lista!!!!
        lista.Sort()
        Return lista
    End Function
    Function SumarSueldo() As Decimal
        'debe devolver sumatoria de sueldos
        Dim Total As Decimal = 0.0
        For Each Personaje In _personajes
            Total += Personaje.Sueldo
        Next
        Return Total
    End Function
    Function TopSueldos() As List(Of String)
        'debe devolver la lista de 3actores con mejor sueldo,asignar nombre de actor + monto del sueldo
        Dim Lista As New List(Of Decimal)
        Dim ListaFinal As New List(Of String)
        Dim mayor_sueldo As Decimal = 0.00
        'cargamos la lista y obtenemos una variable con el mayor sueldo
        For Each Personaje In _personajes
            Lista.Add(Personaje.Sueldo)
            If Personaje.Sueldo > mayor_sueldo Then
                mayor_sueldo = Personaje.Sueldo
            End If
        Next
        'buscamos los tres mayores
        For Each Personaje In _personajes
            If Personaje.Sueldo = mayor_sueldo Then
                Dim aux As String = ""
                aux = Personaje.Nombre + " - " + Personaje.Sueldo.ToString
                ListaFinal.Add(aux)
            End If
        Next
        ListaFinal.Sort()
        Return ListaFinal
    End Function
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    '_CONSTRUCTORES'
    Sub New()
        _personajes = New List(Of Personaje)
    End Sub
End Class
