Imports Repaso_Pelicula

Public Class Personaje
    '_IMPLEMENTO INTERFACE'
    Implements Entidad
    '_CAMPOS DE CLASE'
    Private _sueldo As Decimal
    '_CAMPOS DE INTERFACE'
    Private _nombre As String
    '_CAMPOS DE ASOCIACION'
    Private _actor As Actor
    '_PROPIEDAD DE CLASE'
    Public Property Sueldo As Decimal
        Get
            Return _sueldo
        End Get
        Set(ByVal value As Decimal)
            If value < 0 Then
                Throw New Exception("El sueldo no puede ser menor a cero!!")
            End If
            _sueldo = value
        End Set
    End Property
    '_PROPIEDAD DE INTERFACE'
    Public Property Nombre As String Implements Entidad.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("El nombre no puede estar vacio!!")
            End If
            _nombre = value
        End Set
    End Property
    '_PROPIEDAD DE ASOCIACION'
    Public Property Actor As Actor
        Get
            Return _actor
        End Get
        Set(ByVal value As Actor)
            _actor = value
        End Set
    End Property
    '_METODO DE CLASE'
    Public Overrides Function ToString() As String
        Return Nombre + " (" + Actor.Nombre + ")"
    End Function
    '_CONSTRUCTORES'
    Sub New()
        Nombre = Nothing
        Sueldo = Nothing
    End Sub
    Sub New(nombre As String, actor As Actor, sueldo As Decimal)
        Me.Nombre = nombre
        Me.Actor = actor
        Me.Sueldo = sueldo
    End Sub
    '_'
End Class
