using System;
using System.Collections.Generic;

class CesarCipher : GeneralCipherClass, IMorse_crypt
{
    Dictionary<int, string> ListOfCesarCipher;
    List<string> AlpabetListModified = new List<string>();
    List<string> ListStringOfKeys;
    List<string> ModifiedListSymbols = new List<string>();
    List<string> OrignalListSymbols = new List<string>();

    public CesarCipher(int shift)
	{
        ListStringOfKeys = Show_matrix_key_value(true);
        ListOfCesarCipher = new Dictionary<int, string>();
        int j = 0;
        for (int i = shift; i < ListStringOfKeys.Count; i++)
        {
            AlpabetListModified.Add(ListStringOfKeys[i]);
            j++;
        }
        for(int i = 0; i < shift; i++)
        {
            AlpabetListModified.Add(ListStringOfKeys[i]);
        }
        int ji = 0;
        foreach (string symbol in AlpabetListModified)
        {
            ListOfCesarCipher.Add(ji, symbol);
            ji++;
        }
    }
    public int GetKeyByValue(string value)
    {
        foreach (var recordOfDictionary in ListOfCesarCipher)
        {
            if (recordOfDictionary.Value.Equals(value))
                return recordOfDictionary.Key;
        }
        return -1;
    }
    private void ToScreenSymbols()
    {
        foreach (string s in ModifiedListSymbols)
        {
            Console.Write(s);
        }
        Console.Write(" -> ");
        foreach (string s in OrignalListSymbols)
        {
            Console.Write(s);
        }
        Console.WriteLine();
    }
    public void crypt(string word)
    {
        string d;
        word = word.ToUpper();
        Console.WriteLine(word);
        Console.WriteLine();
        Console.WriteLine();
        foreach (char c in word)
        {
            d = AlpabetListModified.Find((x) => x == c.ToString());
            ModifiedListSymbols.Add(d); 
            int keys = GetKeyByValue(c.ToString());
            OrignalListSymbols.Add(ListStringOfKeys[keys]);
        }
        ToScreenSymbols();
    }

    public void decrypt(string signal)
    {
        throw new NotImplementedException();
    }

    public static void StartCaesar()
    {
        bool exitStr = true;
        while (exitStr)
        {
            try
            {
                ClassOfOutToScreen.CaesarScreen();
                int number = int.Parse(Console.ReadLine());
                CesarCipher cesarCode;
                if (number <= 3 & number >= 1)
                {
                    switch (number)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("from 1 Enter Word");
                            string val1 = Console.ReadLine();
                            cesarCode = new CesarCipher(1);
                            cesarCode.crypt(val1);
                            ClassOfOutToScreen.OutQuestionOfContinueScreen();
                            val1 = Console.ReadLine();
                            exitStr = ChoiceContinueAct(val1);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Enter Word");
                            string val2 = Console.ReadLine();
                            cesarCode = new CesarCipher(Int32.Parse(val2));
                            cesarCode.decrypt(val2);
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
