Imports Entidades

Module Cotorra_test

    Sub Main()
        Dim cotorra As New coto()
        cotorra.Nombre = "roberta"
        cotorra.FechaNacimiento = #1999-10-15#
        Console.WriteLine(cotorra.FechaNacimiento)
        Console.WriteLine(cotorra.ToString & " tiene " & cotorra.EdadHumana & " años Humanos")
        cotorra.Escuchar("papita ")
        Console.WriteLine(cotorra.Hablar())
        cotorra.Escuchar("pa mi ")
        Console.WriteLine(cotorra.Hablar())
        cotorra.Escuchar("Juanita ")
        Console.WriteLine(cotorra.Hablar())
        cotorra.Escuchar("la loca ")
        Console.WriteLine(cotorra.Hablar())
        cotorra.Escuchar("del arco")
        Console.WriteLine(cotorra.Hablar())
    End Sub

End Module
