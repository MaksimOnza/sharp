using System;
using System.Collections.Generic;

public static class Alphabet
{
    public static readonly Dictionary<string, string> AlphabetChar = new Dictionary<string, string>(36);

     static Alphabet()
    {
        AlphabetChar.Add("A", "01");
        AlphabetChar.Add("B", "1000");
        AlphabetChar.Add("C", "1010");
        AlphabetChar.Add("D", "100");
        AlphabetChar.Add("E", "0");
        AlphabetChar.Add("F", "0010");
        AlphabetChar.Add("G", "110");
        AlphabetChar.Add("H", "0000");
        AlphabetChar.Add("I", "00");
        AlphabetChar.Add("J", "0111");
        AlphabetChar.Add("K", "101");
        AlphabetChar.Add("L", "0100");
        AlphabetChar.Add("M", "11");
        AlphabetChar.Add("N", "10");
        AlphabetChar.Add("O", "111");
        AlphabetChar.Add("P", "0110");
        AlphabetChar.Add("Q", "1101");
        AlphabetChar.Add("R", "010");
        AlphabetChar.Add("S", "000");
        AlphabetChar.Add("T", "1");
        AlphabetChar.Add("U", "001");
        AlphabetChar.Add("V", "0001");
        AlphabetChar.Add("W", "011");
        AlphabetChar.Add("X", "1001");
        AlphabetChar.Add("Y", "1011");
        AlphabetChar.Add("Z", "1100");
        AlphabetChar.Add("1", "01111");
        AlphabetChar.Add("2", "00111");
        AlphabetChar.Add("3", "00011");
        AlphabetChar.Add("4", "00001");
        AlphabetChar.Add("5", "00000");
        AlphabetChar.Add("6", "10000");
        AlphabetChar.Add("7", "11000");
        AlphabetChar.Add("8", "11100");
        AlphabetChar.Add("9", "11110");
        AlphabetChar.Add("0", "11111");
    }
    public static Dictionary<string, string> alphabetChar { get { return AlphabetChar; } }


    }
