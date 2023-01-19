// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2022
// ----------------------------------------------------------------------

namespace ParserJson
{
    #region Usings

    using System;

    #endregion

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
            while (true)
            {
                Console.Write("\nWebsite URL: ");
                var url = Console.ReadLine();
                ParseJsonData parser = new ParseJsonData();

                try
                {
                    var json = parser.GetJsonFromUrl(url);
                    parser.ParseJson(json);
                }
                catch
                {
                    Console.WriteLine("Please provide the correct URL");
                }
                
            }
        }
    }
}
