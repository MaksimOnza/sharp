using System;

public static class ClassMessDisplay
{
    private static readonly string Morse_Ciher = "Morse";
    private static readonly string Ceaser_Ciher = "Ceaser";

    public static void MainScreenForChoise()
    {
        //Console.Clear();
        Console.WriteLine("Select cipher!");
        Console.WriteLine($"1. {Morse_Ciher}");
        Console.WriteLine("2. Transposition");
        Console.WriteLine($"3. {Ceaser_Ciher}'s");
        Console.WriteLine("' ' -> Close Programm");
    }
    private static void SelectNumberForAct()
    {
        Console.WriteLine("Select a number for action!");
    }

    public static void CaesarScreen()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine($"It's the {Ceaser_Ciher}'s code!");
        SelectNumberForAct();
        Console.WriteLine($"1. To {Ceaser_Ciher}'s");
        Console.WriteLine($"2. From {Ceaser_Ciher}'s");
        Console.WriteLine("' ' -> EXIT");
    }

    public static void MorseScreen()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine($"It's the {Morse_Ciher} code!");
        Console.WriteLine("");
        SelectNumberForAct();
        Console.WriteLine($"1. To {Morse_Ciher}");
        Console.WriteLine($"2. From {Morse_Ciher}");
        Console.WriteLine($"3. Sound of {Morse_Ciher}");
        Console.WriteLine("' ' -> EXIT");
    }

    public static void OutQuestionOfContinueScreen()
    {
        Console.WriteLine("Continue?");
        Console.WriteLine("Enter 'N' if no");
        Console.WriteLine("Enter any key if yes");
    }

    public static void HelloMessage()
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("");
    }

    public static void CeaserErrorMessage()
    {
        Console.WriteLine("It's not integer number.\nPleas enter a number of shift.");
    }

}
