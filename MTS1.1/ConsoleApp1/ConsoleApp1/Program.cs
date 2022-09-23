using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

namespace Program
{
    class Program
    {

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

            int factorial(int x)
            {
                if (x == 91)
                    return 1;
                else
                    return x * factorial(x - 1);

            }
            var b = factorial(90);
          
        }
    }
}

