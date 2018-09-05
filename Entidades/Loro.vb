Public Class Loro
    Private _memoria As New Queue(Of String)
    Private _edad As UShort
    Private _fechaNacimiento As Date
    Private _nombre As String
    Private texto As String
    Public Sub New()
        _edad = CalcularEdad(FechaNacimiento)
        FechaNacimiento = Now
        Nombre = "Paco peco chico rico"
    End Sub
    Public ReadOnly Property Edad As Short
        Get
            Return (CalcularEdad(FechaNacimiento))
        End Get
    End Property
    Public Property FechaNacimiento As Date
        Set(value As Date)
            _fechaNacimiento = value
        End Set
        Get
            Return (_fechaNacimiento)
        End Get
    End Property
    Public Property Nombre As String
        Set(value As String)
            _nombre = value
        End Set
        Get
            Return (_nombre)
        End Get
    End Property
    Private Function CalcularEdad(FechaNacimiento As Date) As UShort
        Dim Hoy As Date
        Hoy = Now
        Dim edad As UShort
        'sacar diferencia de anios.... si mes.hoy>=mes.Nac year-year sino (year-year)-1
        edad = DateDiff(DateInterval.Year, FechaNacimiento, Hoy)
        If Hoy.Month < FechaNacimiento.Month Then
            edad = edad - 1
        End If
        Return (edad)
    End Function
    Public Overridable Sub Escuchar(frase As String)
        _memoria.Enqueue(frase)
    End Sub
    Public Function Hablar() As String
        If _memoria.Count > 0 Then
            texto = texto & _memoria.Dequeue
        End If
        Return (texto)
    End Function
    Public Overrides Function ToString() As String
        Return (Nombre)
    End Function

End Class
