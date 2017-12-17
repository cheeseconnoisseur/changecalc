Imports System.Console
Module Module1
    Dim dictionary As New Dictionary(Of String, Decimal)
    Dim entry As Decimal
    Dim entry2 As Decimal
    Dim change As Decimal
    Dim changeoriginal As Decimal = 0
    Dim reaction As String
    Dim overdose As Integer
    Sub testing()
        Dim num As Decimal = dictionary.Item("tenp")
        WriteLine(num)
        ReadKey()
        allifs()
    End Sub
    Sub mainold()
        Clear()
        WriteLine("press s(s) for settings or g(g) for game or (ex) to exit")
        reaction = ReadLine()
        If reaction = "s" Then
            Clear()
            settings()
        ElseIf reaction = "g" Then
            Clear()
            Main2()
        ElseIf reaction = "ex" Then
            End
        ElseIf reaction = "t" Then
            Clear()
            testing()
        Else
            mainold()
        End If
    End Sub
    Sub main()
        dictionary.Add("fifty", 0)
        dictionary.Add("twenty", 0)
        dictionary.Add("ten", 0)
        dictionary.Add("five", 0)
        dictionary.Add("two", 0)
        dictionary.Add("one", 0)
        dictionary.Add("fiftyp", 0)
        dictionary.Add("twentyp", 0)
        dictionary.Add("tenp", 0)
        dictionary.Add("fivep", 0)
        dictionary.Add("twop", 0)
        dictionary.Add("onep", 0)
        ForegroundColor = ConsoleColor.Green
        BackgroundColor = ConsoleColor.Black
        Clear()
        WriteLine("press s(s) for settings or g(g) for game")
        reaction = ReadLine()
        If reaction = "s" Then
            Clear()
            settings()
        ElseIf reaction = "g" Then
            Clear()
            Main2()
        ElseIf reaction = "t" Then
            Clear()
            testing()
        Else
            main()
        End If
    End Sub
    Sub settings()
        WriteLine("do you want to change : background colour (bc) or background or text colour (tc) or exit (ex)")
        reaction = ReadLine()
        If reaction = "ex" Then
            mainold()
        ElseIf reaction = "bc" Then
            Clear()
            settingsb()
        ElseIf reaction = "tc" Then
            Clear()
            settingst()
        Else
            Clear()
            settings()
        End If
    End Sub
    Sub settingsb()
        WriteLine("change background to blue (b) red (r) black (bl) green (g)")
        reaction = ReadLine()
        If reaction = "b" Then
            BackgroundColor = ConsoleColor.Blue
            Clear()
            settings()
        ElseIf reaction = "r" Then
            BackgroundColor = ConsoleColor.Red
            Clear()
            settings()
        ElseIf reaction = "bl" Then
            BackgroundColor = ConsoleColor.Black
            Clear()
            settings()
        ElseIf reaction = "g" Then
            BackgroundColor = ConsoleColor.Green
            Clear()
            settings()
        Else
            settings()
        End If
    End Sub
    Sub settingst()
        WriteLine("change text to blue (b) red (r) black (bl) green (g)")
        reaction = ReadLine()
        If reaction = "b" Then
            ForegroundColor = ConsoleColor.Blue
            Clear()
            settings()
        ElseIf reaction = "r" Then
            ForegroundColor = ConsoleColor.Red
            Clear()
            settings()
        ElseIf reaction = "bl" Then
            ForegroundColor = ConsoleColor.Black
            Clear()
            settings()
        ElseIf reaction = "g" Then
            ForegroundColor = ConsoleColor.Green
            Clear()
            settings()
        Else
            settings()
        End If
    End Sub
    Sub Main2()
        Clear()
        WriteLine("enter your bill")
        entry = ReadLine()
        WriteLine("enter your amount paid")
        entry2 = ReadLine()
        Dim price As Decimal = Decimal.Parse(entry)
        Dim price2 As Decimal = Decimal.Parse(entry2)
        change = price - price2
        changeoriginal = change
        Clear()
        WriteLine("your change is " & change)
        ReadKey()
        allifs()
    End Sub
    Sub allifs()

        Dim value As Decimal
        If change >= 50 Then
            dictionary.TryGetValue("fifty", value)
            dictionary("fifty") = value + 1
            change = change - 50
            allifs()
        End If
        If change >= 20 Then
            dictionary.TryGetValue("twenty", value)
            dictionary("twenty") = value + 1
            change = change - 20
            allifs()
        End If
        If change >= 10 Then
            dictionary.TryGetValue("ten", value)
            dictionary("ten") = value + 1
            change = change - 10
            allifs()
        End If
        If change >= 5 Then
            dictionary.TryGetValue("five", value)
            dictionary("five") = value + 1
            change = change - 5
            allifs()
        End If
        If change >= 2 Then
            dictionary.TryGetValue("two", value)
            dictionary("two") = value + 1
            change = change - 2
            allifs()
        End If
        If change >= 1 Then
            dictionary.TryGetValue("one", value)
            dictionary("one") = value + 1
            change = change - 1
            allifs()
        End If
        If change >= 0.5 Then
            dictionary.TryGetValue("fiftyp", value)
            dictionary("fiftyp") = value + 1
            change = change - 0.5
            allifs()
        End If
        If change >= 0.2 Then
            dictionary.TryGetValue("twentyp", value)
            dictionary("twentyp") = value + 1
            change = change - 0.2
            allifs()
        End If
        If change >= 0.1 Then
            dictionary.TryGetValue("tenp", value)
            dictionary("tenp") = value + 1
            change = change - 0.1
            allifs()
        End If
        If change >= 0.05 Then
            dictionary.TryGetValue("fivep", value)
            dictionary("fivep") = value + 1
            change = change - 0.05
            allifs()
        End If
        If change >= 0.02 Then
            dictionary.TryGetValue("twop", value)
            dictionary("twop") = value + 1
            change = change - 0.02
            allifs()
        End If
        If change >= 0.01 Then
            dictionary.TryGetValue("onep", value)
            dictionary("onep") = value + 1
            change = change - 0.01
            allifs()
        End If
        Clear()
        WriteLine("change total :" & changeoriginal &
            "
 50 pound notes : " & dictionary.Item("fifty") & "
20 pound notes : " & dictionary.Item("twenty") & "
10 pound notes : " & dictionary.Item("ten") & "
5 pound notes : " & dictionary.Item("five") & "
2 pound coin : " & dictionary.Item("two") & "
1 pound coin : " & dictionary.Item("one") & "
50 p: " & dictionary.Item("fiftyp") & " 
20 p : " & dictionary.Item("twentyp") & "
ten p: " & dictionary.Item("tenp") & "
five p: " & dictionary.Item("fivep") & "
two p: " & dictionary.Item("twop") & "
one p: " & dictionary.Item("onep"))
        ReadKey()
        Clear()
        again()
    End Sub

    Sub again()
        Dim reaction As String
        If overdose = 0 Then
            overdose = overdose + 1
            WriteLine("want to use again? yes (y) exit (ex) menu (m)")
            reaction = ReadLine()
            If reaction = "y" Then
                overdose = 0
                Main2()
            ElseIf reaction = "ex" Then
                End
            ElseIf reaction = "m" Then
                overdose = 0
                mainold()
            Else
                again()
            End If
        Else
            WriteLine("oops something went wrong,want to use again? yes (Y) no (N)")
            reaction = ReadLine()
            If reaction = "y" Then
                overdose = 0
                Main2()
            ElseIf reaction = "ex" Then
                End
            ElseIf reaction = "m" Then
                overdose = 0
                mainold()
            Else
                again()
            End If
        End If

    End Sub
End Module
