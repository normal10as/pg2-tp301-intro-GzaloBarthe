Public Class coto

    Inherits Loro
    Private _edadHumana As UShort
    Private atento As Boolean
    Sub New()
        MyBase.New()
        atento = True
        MyBase.Nombre = "laurita"
        FechaNacimiento = Now
        _edadHumana = Edad * 2
    End Sub
    Public ReadOnly Property EdadHumana As UShort
        Get
            Return Edad * 2
        End Get
    End Property
    Public Overrides Sub Escuchar(frase As String)
        If atento Then
            MyBase.Escuchar(frase)
            atento = False
        Else
            atento = True
        End If

    End Sub

End Class
