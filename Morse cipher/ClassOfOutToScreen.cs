using System;

public static class ClassOfOutToScreen
{
    public static void MainScreenForChoise()
    {
        Console.Clear();
        Console.WriteLine("Enter the number for cipher!");
        Console.WriteLine("1. Morse");
        Console.WriteLine("2. Transposition");
        Console.WriteLine("3. Caesar's");
        Console.WriteLine("4. Combo");
    }

    public static void CaesarScreen()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("It is the Caesar's code!");
        Console.WriteLine("Enter the number for action!");
        Console.WriteLine("1. To Caesar's");
        Console.WriteLine("2. From Caesar's");
    }

    public static void MorseScreen()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("It is the Morse code!");
        Console.WriteLine("");
        Console.WriteLine("Enter a number for action!");
        Console.WriteLine("1. To Morse");
        Console.WriteLine("2. From Morse");
        Console.WriteLine("3. Sound of Morse");
    }

    public static void OutQuestionOfContinueScreen()
    {
        Console.WriteLine("Continue?");
        Console.WriteLine("Enter 'n' if no");
        Console.WriteLine("Enter any key if yes");
    }

    public static void HelloMessage()
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("");
    }

}
