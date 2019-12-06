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
                            //Вызов класса для выбора типа шифра
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
                    Console.WriteLine("Continue? If Yes Press to 'y'.");
                    Console.WriteLine("Continue? If No Press to 'n'.");
                    enterString = Console.ReadLine();
                    if (enterString == "n")
                    {
                        booleanVar = false; Console.WriteLine("End");
                        break;
                    }
                    if (enterString == "y")
                    {
                        booleanVar = true; Console.WriteLine("Continue");
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
