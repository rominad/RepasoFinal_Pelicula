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
        _personajes.Add(personaje)
    End Sub
    Public Sub RemovePersonaje(Personaje As Personaje)
        _personajes.Remove(Personaje)
    End Sub
    Public Function getAllPersonajes() As List(Of Personaje)
        Return _personajes
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
        ''debe devolver la lista de 3actores con mejor sueldo,asignar nombre de actor + monto del sueldo
        Dim listaSueldos As New List(Of Single)
        Dim listaFinal As New List(Of String)
        Dim listaNueva As New List(Of Single)
        Dim aux As Single = 0
        'cargamos todos  los sueldo a la listaSueldos
        For Each Personaje In _personajes
            listaSueldos.Add(Personaje.Sueldo)
        Next
        'ordenamos la lista para juntar los sueldos similares, y la ponemos de reversa para que el mayor este primero
        listaSueldos.Sort()
        listaSueldos.Reverse()
        'agregamos a la listaNueva los sueldos, ya que se repiten
        For x = 0 To listaSueldos.Count() - 1
            If listaSueldos.Item(x) <> aux Then
                listaNueva.Add(listaSueldos.Item(x))
                aux = listaSueldos.Item(x)
            End If
        Next
        'cargamos los tres primeros + sus nombres a la lista final
        For y = 0 To 2
            For Each personaje In _personajes
                If listaNueva.Item(y) = personaje.Sueldo Then
                    listaFinal.Add(personaje.Nombre & " - $" & listaNueva.Item(y))
                End If
            Next
        Next
        Return listaFinal
    End Function

    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    '_CONSTRUCTORES'
    Sub New()
        _personajes = New List(Of Personaje)
    End Sub
End Class
