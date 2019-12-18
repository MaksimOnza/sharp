using System;
using System.Collections.Generic;

 abstract class GeneralCipherClass
{
    public Dictionary<string, string> OriginalAlphabet { get { return Alphabet.alphabetChar; } }
    public List<string> ListOfKeyORValue;
 
    //Indexator
    internal string this[string word]
    {
        get
        {
            return OriginalAlphabet[word];
        }
        set
        {
            if(OriginalAlphabet.ContainsKey(word))
                OriginalAlphabet[word] = value;
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
            foreach (string c in OriginalAlphabet.Keys)
            {
                ListOfKeyORValue.Add(c);
            }
        }
        else
        {
            foreach (string p in OriginalAlphabet.Values)
            {
                ListOfKeyORValue.Add(p);
            }
        }
        return ListOfKeyORValue;
    }
    public static bool ChoiceContinueAct(string str)
    {
        if (str == "n")
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
