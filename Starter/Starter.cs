using System;
using System.Collections.Generic;
using CommandLine;

namespace Starter
{
    class Starter
    {
        static void Main(string[] args)
        {
            var result = Parser.Default.ParseArguments<CLI.Options, UI.Options>(args)
                               .WithParsed(HandleParseSuccess).WithNotParsed(HandleParseError);
        }

        private static void HandleParseSuccess(object options)
        {
            if (options.GetType() == typeof(CLI.Options))
            {
                CLI.Launcher.Start((CLI.Options) options);
            }
            else if (options.GetType() == typeof(UI.Options))
            {
                UI.Launcher.Start((UI.Options) options);
            }
            else
            {
                Console.Error.WriteLine(
                    "Something went wrong - unrecognized options");
            }

            Console.Error.WriteLine("Launcher returned to Starter");
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
            Console.WriteLine("Error parsing arguments");
            foreach (var err in errs)
            {
                Console.WriteLine(err.ToString());
            }
        }
    }
}