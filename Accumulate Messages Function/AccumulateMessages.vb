Option Strict On
Option Explicit On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Accumulate Message Function
'https://github.com/AftaAnfi/Accumulate-Messages-Function.git

Module AccumulateMessages

    Sub Main()

        'add ooof to total user messages 
        UserMessages("Message 1", False)

        'add another ooof to total messages and show in console
        Console.Write(UserMessages("Message 2", False))

        'reset messages
        'should not have message clear in the console due to clearing the messages is done after the input
        Console.Write(UserMessages("Message Clear", True))

        'add another ooof to total messages and show in console (only one due to messages being cleared)
        Console.Write(UserMessages("Message 3", False))


        Console.ReadLine()

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