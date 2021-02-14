Option Strict On
Option Explicit On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Accumulate Message Function
'https://github.com/AftaAnfi/Accumulate-Messages-Function.git

Module AccumulateMessages
    Dim tempString As String
    Dim runProgram As Boolean = True

    Sub Main()
        While runProgram
            Console.Clear()
            Console.WriteLine("Inputs for following functions")
            Console.WriteLine("C - clear messages")
            Console.WriteLine("S - show messages")
            Console.WriteLine("Q - quit program")
            Console.WriteLine("any other input to enter message")

            'set console input to a variable
            tempString = Console.ReadLine()

            Select Case tempString
                Case "C"
                    'clear messages
                    UserMessages("", True)
                Case "S"
                    'return stored messages
                    If UserMessages("", False) = "" Then
                        Console.WriteLine("There are no saved messages.")
                    Else
                        Console.Write(UserMessages("", False))
                    End If
                Case "Q"
                    'Quit application
                    Console.WriteLine("Thanks, have a good day!")
                    System.Threading.Thread.Sleep(2000)
                    End
                Case Else
                    'add input to messages
                    UserMessages(tempString, False)
            End Select
            Console.WriteLine("Press any key to continue")
            Console.ReadKey(False)
        End While

    End Sub



    'Function to add messages or clear messages
    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String

        'create a string variable that's lifetime is the program
        Static messages As String


        'add the message into the total messages if it's not blank
        If newMessage <> "" Then
            messages &= (newMessage & vbNewLine)
        End If

        'if clear is true set messages to empty
        If clear Then
            messages = ""
        End If

        Return messages

    End Function

End Module