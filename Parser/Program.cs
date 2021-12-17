// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace Parser
{
    #region Usings



    #endregion

    /// <summary>
    /// The main class for running parser.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Runs parser.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ParserUsers parser = new ParserUsers();
            parser.ParserXml("user.xml");
        }
    }
}
