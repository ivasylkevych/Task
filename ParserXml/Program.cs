// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace ParserXml
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
            ParserContacts parser = new ParserContacts();
            parser.ParserXml("contacts.xml");
        }
    }
}
