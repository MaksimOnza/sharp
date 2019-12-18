using Morse_cipher;
using System;
using System.Collections.Generic;
using System.Threading;

class Morse_Cipher : GeneralCipherClass, ICrypt
{
    public Morse_Cipher(string str = "")
    {
        if (str == "")
        {
            Show_matrix();
        }
    }

    public void crypt(string word)
    {
        word = word.ToUpper();
        foreach (char c in word.ToCharArray())
        {
            Console.WriteLine($"{c} -> {this[c.ToString()]}");
        }
    }

    public void decrypt(string signal)
    {
        string[] str = signal.Split(' ');
        foreach (string s in str)
        {
            if (OriginalAlphabet.ContainsValue(s))
            {
                foreach (KeyValuePair<string, string> recordOfDictionary in OriginalAlphabet)
                {
                    if (recordOfDictionary.Value.Equals(s))
                        Console.WriteLine(s + " -> " + recordOfDictionary.Key);
                }
            }
            else
            {
                Console.WriteLine("Wrong symbol of signal");
            }
            str = Console.ReadLine().Split(' ');

        }
    }
    public void SoundOfMorse(string signal)
    {
        int addFreq = 500;
        signal = signal.ToUpper();
        foreach (char c in signal.ToCharArray())
        {
            Console.WriteLine($"{c} -> {this[c.ToString()]}");
            foreach (char s in this[c.ToString()])
            {
                if (s == '1' | s == '-')
                {
                    Console.Beep(440 + addFreq, 300);
                    Thread.Sleep(100);
                }
                else
                {
                    Console.Beep(440 + addFreq, 100);
                    Thread.Sleep(100);
                }
            }
            Thread.Sleep(500);
        }
    }
    public Dictionary<string, string> TransformToCharFromDigit()
    {
        Dictionary<string, string> str_matrix_2 = new Dictionary<string, string>(OriginalAlphabet);
        foreach (string c in OriginalAlphabet.Keys)
        {
            str_matrix_2[c] = str_matrix_2[c].Replace("1", "-");
            str_matrix_2[c] = str_matrix_2[c].Replace("0", ".");
            Console.WriteLine("str_matrix_2 = " + str_matrix_2[c]);
        }
        return str_matrix_2;
    }
    public static void StartMorse()
    {
        bool exitStr = true;
        while (exitStr)
        {
            try
            {
                ClassOfOutToScreen.MorseScreen();
                string choise = Console.ReadLine();
                if(GeneralCipherClass.SelectEnterForExit(choise))
                {
                    break;
                }
                int number = int.Parse(choise);
                Morse_Cipher morseCode;
                if (number <= 3 & number >= 1)
                {
                    switch (number)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter Word");
                            string val1 = Console.ReadLine();
                            morseCode = new Morse_Cipher(val1);
                            morseCode.crypt(val1);
                            ClassOfOutToScreen.OutQuestionOfContinueScreen();
                            val1 = Console.ReadLine();
                            exitStr = SelectContinueAct(val1);
                            break;
                        case 2:
                            Console.WriteLine("Enter Word");
                            string val2 = Console.ReadLine();
                            morseCode = new Morse_Cipher(val2);
                            morseCode.decrypt(val2);
                            break;
                        case 3:
                            Console.WriteLine("Enter Word Or Signal");
                            string val3 = Console.ReadLine();
                            morseCode = new Morse_Cipher(val3);
                            morseCode.SoundOfMorse(val3);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Wrong digit entered");
            }

        }
    }
    
}
