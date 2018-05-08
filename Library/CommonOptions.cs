using System;
using CommandLine;

namespace Library
{
    public class CommonOptions
    {
        [Option('d', "directory", HelpText = "The directory to look for actions in")]
        public String ActionDirectory { get; set; } = ".";
    }
}