// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace ParserRaise
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
            ParserRaise parser = new ParserRaise();
            parser.ParserXml("contactsRaise.xml");
        }
    }
}
