Public NotInheritable Class Actor
    '-herencia'
    Inherits Persona
    '-campo
    Shared _newId As Integer
    '-propiedades
    Public ReadOnly Property ID As Integer
        Get
            Return _newId
        End Get
    End Property
    '-metodos'
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    '-constructor'
    Sub New()
        _newId += ID
    End Sub
    Sub New(fechaNacimiento As Date, nombre As String)
        MyBase.New()
        Me.FechaNacimiento = fechaNacimiento
        Me.Nombre = nombre
    End Sub
End Class
