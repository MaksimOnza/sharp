using System;
using System.Collections.Generic;
using System.Threading;

public class Sounds
{
    public Dictionary<string, string> OriginalAlphabet { get { return Alphabet.alphabetChar; } }
    public Sounds(string str)
	{
        PlaySymbol(str);
	}

	private void PlaySymbol(string signal)
	{
        int addFreq = 500;
        signal = signal.ToUpper();
        foreach (char c in signal.ToCharArray())
        {
            Console.WriteLine($"{c} -> {OriginalAlphabet[c.ToString()]}");
            foreach (char symbol in OriginalAlphabet[c.ToString()])
            {
                if (symbol == '1' | symbol == '-')
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
}
