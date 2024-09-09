'Justin Bell
'RCET0265
'Fall 2024
'Better Calculator
' [link]

Option Compare Text
Option Explicit On
Option Strict On

Module BetterCalculator

    Sub Main()

        Dim userinput As String
        Dim first As Decimal
        Dim second As Decimal
        Dim valid As Boolean = False
        Dim validMath As Boolean = False

        'main event structure

        Do Until valid = True

            Console.WriteLine("Please enter two numbers. Enter ""Q"" at any time to quit.")
            Console.Write("Choose a Number:")
            userinput = Console.ReadLine()
            Console.WriteLine($"You entered ""{userinput}""")

            'first input processing and error handling

            If userinput = "Q" Then
                Exit Do
            End If


            Try
                first = CDec(userinput)
            Catch ex As Exception
                Console.WriteLine($"You entered ""{userinput}"", please enter a whole number.")
            Catch ex As OverflowException
                Console.WriteLine($"You entered ""{userinput}"".")
                Console.WriteLine($"{userinput} is too large.")
            End Try

            Console.Write("Choose a Number:")
            userinput = Console.ReadLine()
            Console.WriteLine($"You entered ""{userinput}""")

            If userinput = "Q" Then
                Exit Do
            End If

            'second input error handling

            Try
                second = CDec(userinput)
            Catch ex As Exception
                Console.WriteLine($"You entered ""{userinput}"", please enter a whole number.")
            Catch ex As OverflowException
                Console.WriteLine($"You entered ""{userinput}"".")
                Console.WriteLine($"{userinput} is too large.")
            End Try

            'mathmatical function select

            Console.WriteLine("Choose one of the following options:")
            Console.WriteLine("1. Add")
            Console.WriteLine("2. Subtract")
            Console.WriteLine("3. Multiply")
            Console.WriteLine("4. Divide")
            userinput = Console.ReadLine()
            Console.WriteLine($"You entered {userinput}.")

            If userinput = "Q" Then
                Exit Do
            End If

            'carries out the selected function and ensures that a function does happen
            Do
                If (userinput = "1" Or userinput = "2" Or userinput = "3" Or userinput = "4") Then
                    Select Case userinput
                        Case ("1")
                            Console.WriteLine($"{first} + {second} = {first + second}")
                            validMath = True
                        Case "2"
                            Console.WriteLine($"{first} - {second} = {first - second}")
                            validMath = True
                        Case "3"
                            Console.WriteLine($"{first} * {second} = {first * second}")
                            validMath = True
                        Case "4"
                            Console.WriteLine($"{first} ÷ {second} = {first / second}")
                            validMath = True
                    End Select
                Else
                    Console.WriteLine()
                    Console.WriteLine("Invailid input")
                    Console.WriteLine("Choose one of the following options:")
                    Console.WriteLine("1. Add")
                    Console.WriteLine("2. Subtract")
                    Console.WriteLine("3. Multiply")
                    Console.WriteLine("4. Divide")
                    userinput = Console.ReadLine()
                    Console.WriteLine($"You entered {userinput}.")
                End If
            Loop Until validMath = True
        Loop

        Console.WriteLine("Have a nice day")
        Console.WriteLine("Press enter to close this window")
        Console.ReadLine()

    End Sub

End Module
