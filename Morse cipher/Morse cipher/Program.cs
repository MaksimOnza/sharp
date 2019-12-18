using System;

namespace Morse_cipher
{
    class Program
    {
        
        private static void MainLoop()
        {
            bool booleanVar = true;
            string enterString;

            while (booleanVar)
            {
                try
                {
                    ClassOfOutToScreen.MainScreenForChoise();
                    enterString = Console.ReadLine();
                    //Условие работает только при первом вводе
                    if (enterString == " ") { Environment.Exit(0); }
                    int numCase;
                    if (int.TryParse(enterString, out numCase) & (Int32.Parse(enterString) >= 1 & Int32.Parse(enterString) <= 4))
                    {
                        try
                        {
                            ChoiseCipher choiseCipher = new ChoiseCipher(numCase);
                            choiseCipher = null;
                        }
                        catch (Exception)
                        {
                            booleanVar = false;
                            Console.WriteLine("Wrong digit entered");
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong symbol entered");
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            ClassOfOutToScreen.HelloMessage();
            MainLoop();
        } 
    }
}
