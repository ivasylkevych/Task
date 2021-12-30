// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace Parser
{
    /// <summary>
    /// The main class for running parser.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Runs parser.
        /// </summary>
        /// <param name="args">
        /// Basic parameter for main method.
        /// </param>
        static void Main(string[] args)
        {
            ParserUsers parser = new ParserUsers();
            parser.ParserXml("user.xml");
        }
    }
}
