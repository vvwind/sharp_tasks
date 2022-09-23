using System;

namespace Program
{
    class Program
    {
        class Fail
        {
            public void DoEverything()
            {
                Console.WriteLine("Hello World");
            }
            
        }


        static void Main(string[] args)
        {
            try
            {
                FailProcess();
            }
            catch { }

            Console.WriteLine("Failed to fail process!");
            Console.ReadKey();
        }

        static void FailProcess()
        {
            Fail fail = null;
            

            fail.DoEverything();

            
        }



    }
}
