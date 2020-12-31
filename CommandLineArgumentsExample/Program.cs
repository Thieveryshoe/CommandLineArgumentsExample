using System;
using System.Collections.Generic;
using CommandLine;

namespace CommandLineArgumentsExampleCLI
{
    internal class Options
    {
        [Option('s', "simulation", Required = false, HelpText = "Used to simulate processing.")]
        public bool SimulationMode { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(RunOptions)
                .WithNotParsed(HandleParseError);
        }

        private static void RunOptions(Options opts)
        {
            Console.WriteLine(opts.SimulationMode
                ? "The program is running in simulation mode."
                : "The program is running in regular mode.");
            Console.ReadKey();
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
            Console.WriteLine("Something went wrong.");
            Console.ReadKey();
        }
    }
}