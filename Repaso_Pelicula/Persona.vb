Public MustInherit Class Persona
    'mustinherit class (son clases que heredan, no debo instanciar)
    Implements Entidad
    'CAMPO CLASE
    Private _FechaNacimiento As Date
    'CAMPO DE INTERFAZ
    Private _nombre As String

    'PROPIEDAD DE INTERFAZ
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
    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            If value = Nothing Then
                Throw New ArgumentException("El valor no debe ser vacio!")
            End If
            _FechaNacimiento = value
        End Set
    End Property
End Class
