// See https://aka.ms/new-console-template for more information

using SoftwarePrinters;
using MechanicalPrinters;

namespace Program
{
    /*
        variables
        if else
        while
        functions
        classes
    */

    public class FirstClass
    {
        int myInt = 0;

        public FirstClass(int setValue)
        {
            myInt = setValue;
        }

        int GetMyInt()
        {
            return myInt;
        }
    }

    public enum RPS{Rock, Paper, Sisors};

    public class Program
    {
        static int Main()
        {
            try
            {
                throw new fasd();

                throw new Exception("Connection couldn't be established with the database");
                throw new IOException("Connection couldn't be established with the database");


                int a = 21;
            }
            // catch(fasd ioe)
            // {
            //     // Do connection stuff
            // }
            catch(Exception e)
            {
                Console.WriteLine($"Caught Exception: {e.Message}");
                // Generic handler
            }
            catch
            {
                // Never runs
            }

            Coins coin = new Coins(new(){1, 10, 7, 11});
            Console.WriteLine(coin.FindMin(28));
            return 0;
        }

        private static long RandInt()
        {
            return Random.Shared.NextInt64();
        }
    }

    public class fasd : Exception
    {
    }
}
