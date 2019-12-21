using System;
using System.Collections.Generic;

 abstract class GeneralCipherClass
{
    public Dictionary<string, string> OriginalAlphabet { get { return Alphabet.alphabetChar; } }
    public List<string> ListOfKeyORValue;
 
    //Indexator
    internal string this[string symbol]
    {
        get
        {
            return OriginalAlphabet[symbol];
        }
        set
        {
            if(OriginalAlphabet.ContainsKey(symbol))
                OriginalAlphabet[symbol] = value;
        }
    }
    //Out matrix Alphabet
    public virtual void Show_matrix()
    {
        foreach(KeyValuePair<string, string> keyValue in OriginalAlphabet)
        {
            Console.WriteLine(keyValue.Key+ " -> "+keyValue.Value);
        }
    }
    //Out of key or value
    public List<string> Show_matrix_key_value(bool key)
    {
        ListOfKeyORValue = new List<string>();
        if (key)
        {
            foreach (string singleKey in OriginalAlphabet.Keys)
            {
                ListOfKeyORValue.Add(singleKey);
            }
        }
        else
        {
            foreach (string value in OriginalAlphabet.Values)
            {
                ListOfKeyORValue.Add(value);
            }
        }
        return ListOfKeyORValue;
    }
    public static bool SelectContinueAct(string select)
    {
        if (select == "n")
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public static bool SelectEnterForExit(string choise)
    {
        if (choise == " ")
        {
            Console.Clear();
            return  true;
        }
        else
        {
            return false;
        }
    }
}
