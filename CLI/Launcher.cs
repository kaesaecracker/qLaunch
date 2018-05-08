namespace CLI
{
    public class Launcher
    {
        public static void Start(Options opt)
        {
            CommandLineOptions = opt;
        }

        public static Options CommandLineOptions { get; private set; }
    }
}