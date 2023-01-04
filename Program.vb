Imports System

Module Array_Practise
    'Code with assistance from a friend
    Dim myarray() As String
    Dim nums() As Integer
    Dim len = 0 'length
    Sub Main()
        Dim i, index As Integer
        Dim str_input, menu As String
        str_input = ""

        Do Until menu = "5"
            Console.WriteLine(
                $"1. Add names {vbNewLine}2. Display names {vbNewLine}3. Display name by Index {vbNewLine}4. Clear name list {vbNewLine}5. Exit {vbNewLine}")
            menu = Console.ReadLine()
            Select Case menu

                Case 1
                    Do Until str_input = "
"

                        Console.WriteLine($"Add Name to the list. Press enter with no input to stop {vbNewLine}")

                        str_input = Console.ReadLine & Format("
")

                        'ReDim: allows coder to change size of array after declaration
                        'Preserve: preserves data in an array when adding values
                        'myarray() the () idicates the static number
                        ReDim Preserve myarray(len + 1)
                        myarray(len) = str_input
                        len += 1

                    Loop

                Case 2
                    Console.WriteLine($"Displaying names: {vbNewLine}")
                    'displays array
                    For i = 0 To myarray.Length - 1
                        Console.WriteLine(myarray(i))
                    Next

                Case 3
                    Console.WriteLine($"Choose index number: {vbNewLine}")
                    index = Console.ReadLine
                    Console.WriteLine(myarray(index))
                Case 4
                    Console.WriteLine($"Names have been deleted")
                    ReDim myarray(0)


                Case 5
                    End
            End Select
        Loop
        'John Calverley
    End Sub
End Module

'    Sub Main()
'        Dim i As Integer
'        Dim str_input, menu As String
'        str_input = " "

'        Do
'            Console.WriteLine(
'$"1. Add names {vbNewLine}2. Display names{vbNewLine}3. Display name by Index {vbNewLine}4. Clear name list {vbNewLine}5. Exit")
'            '$ allows for use of vbNewLine and must be within the " "
'            menu = Console.ReadLine()
'            Select Case menu

'                Case 1
'                    Console.WriteLine($"You have chosen to enter names: {vbNewLine}")
'                    Do Until str_input = ""


'                        Console.WriteLine($"Add Name to the list. Press enter with no input to stop: {vbNewLine}")
'                        str_input = Console.ReadLine

'                        'ReDim: allows coder to change size of array after declaration
'                        'Preserve: preserves data in an array when adding values
'                        'myarray() the () idicates the static number
'                        ReDim Preserve myarray(i)
'                        myarray(i) = myarray(i) + str_input

'                    Loop

'                Case 2
'                    Console.WriteLine("Displaying names:")
'                    Console.WriteLine("______________________")

'                    'displays array
'                    For Each name As String In myarray
'                        Console.WriteLine(name)
'                    Next

'                Case 3

'                    Console.WriteLine("UNDER CONSTRUCTION")
'                Case 4
'                    Console.WriteLine("Names have been deleted")
'                    Console.Write("______________________")
'                    myarray(0) = " "
'                    str_input = " "

'                Case 5
'                    End
'                Case Else
'                    Console.WriteLine("Invalid entry, try again")
'            End Select
'        Loop
'        'John Calverley
'    End Sub
