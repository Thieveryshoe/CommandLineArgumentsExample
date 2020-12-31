using System;

namespace CommandLineArgsLib
{
    public class Processor : IProcessor
    {
        public void Execute()
        {
            Console.WriteLine("This is the regular Processor.");
            Console.ReadKey();
        }
    }
}
