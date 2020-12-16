using Service.Common;
using System;

namespace Service1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var screenWriter = new ScreenWriter(new DoSomething());

            screenWriter.WriteMessage(5).GetAwaiter().GetResult();

            Console.ReadKey();

        }
    }
}
