Imports Entidades

Module Test_loro

    Sub Main()
        Dim lorito As New Loro()
        lorito.Nombre = "Paquito"
        lorito.FechaNacimiento = #1999-10-15#
        Console.WriteLine(lorito.FechaNacimiento)
        Console.WriteLine(lorito.ToString & " tiene " & lorito.Edad & " años")
        lorito.Escuchar("papita ")
        Console.WriteLine(lorito.Hablar())
        lorito.Escuchar("pal loro ")
        Console.WriteLine(lorito.Hablar())
        lorito.Escuchar("Juan")
        Console.WriteLine(lorito.Hablar())
        Console.WriteLine(lorito.Hablar())
    End Sub

End Module
