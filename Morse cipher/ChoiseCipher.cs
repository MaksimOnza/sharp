using System;

public class ChoiseCipher
{
    private int Number;
	public ChoiseCipher(int num)
	{
        SetNumber(num);
        CipherChoise(Number);
    }

    public void SetNumber(int num)
    {
        Number = num;
    }

    private void CipherChoise(int num)
    {
        switch (num)
        {
            case 1:
                Morse_matrix.StartMorse();
                break;
            case 3:
                CesarCipher.StartCaesar();
                break;
            case 2:
                Console.WriteLine("It is the Transposition code!");
                Console.WriteLine("Enter the number for action!");
                Console.WriteLine("1. To Transposition");
                Console.WriteLine("2. From Transposition");
                break;
            case 4:
                Console.WriteLine("Hello!");
                Console.WriteLine("Enter the number of cipher!");
                Console.WriteLine("1. Morse");
                Console.WriteLine("2. Transposition");
                Console.WriteLine("3. Caesar's");
                Console.WriteLine("4. Combo");
                break;
            default:
                break;
        }
    }
}
