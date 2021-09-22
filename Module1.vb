Module Module1

    Sub Main()
        Dim name As String
        Dim address As String
        Dim gender As String
        Const male As String = "m"
        Const female As String = "f"
        Dim age As Boolean
        Dim haircolour As String
        Dim shoesize As Single
        Dim weight As Single

        Console.WriteLine(vbNewLine & "Input Name")
        name = Console.ReadLine()



        Console.WriteLine(vbNewLine & "Input Address")
        address = Console.ReadLine()

        Do
            Console.WriteLine(vbNewLine & "Input Gender")
            gender = Console.ReadLine()

            If gender <> male And gender <> female Then
                Console.WriteLine(vbNewLine & "Gender Invalid")
            End If

        Loop Until gender = male Or gender = female

        Console.WriteLine(vbNewLine & "Is age greater than 18 {true/false}")
        age = Console.ReadLine()

        Console.WriteLine(vbNewLine & "Input colour of hair")
        haircolour = Console.ReadLine()

        Console.WriteLine(vbNewLine & "Input shoe size")
        shoesize = Console.ReadLine()

        Console.WriteLine(vbNewLine & "Input weight")
        weight = Console.ReadLine()

        Console.WriteLine(vbNewLine & "The name is " & name & vbNewLine & "The address is " & address & vbNewLine & "The gender is " & gender & vbNewLine & "The colour of hair is " & haircolour & vbNewLine & "The shoe size is " & shoesize & vbNewLine & "The weight is " & weight & "Kg" & vbNewLine)

        If age = True Then

            Console.WriteLine("The age is greater than 18")

        Else

            Console.WriteLine("The age is less than 18")

        End If

        Console.ReadLine()

    End Sub

End Module
