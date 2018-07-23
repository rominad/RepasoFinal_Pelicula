Public NotInheritable Class Actor
    '-herencia'
    Inherits Persona
    '-campo clase/interfaz/asociacion'
    Shared _newId As Integer
    '-propiedad clase/interfaz/asociacion'
    Public ReadOnly Property ID As Integer
        Get
            _newId = _newId + 1
            Return _newId
        End Get
    End Property
    '-metodos'
    Public Overrides Function ToString() As String
        Return "Nombre Actor: " & Nombre
    End Function
    '-constructor'
    Sub New()
        _newId = ID
    End Sub
    Sub New(fechaNacimiento As Date, nombre As String)
        MyBase.New()
        Me.FechaNacimiento = fechaNacimiento
        Me.Nombre = nombre
    End Sub

End Class
