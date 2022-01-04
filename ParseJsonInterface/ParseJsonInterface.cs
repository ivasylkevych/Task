// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace ParseJsonInterface
{
    #region Usings

    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    #endregion

    /// <summary>
    /// The main class for JSON parser with the ParseJson method.
    /// </summary>
    class ParseJsonInterface
    {
        /// <summary>
        /// Parsing JSON file.
        /// </summary>
        /// <param name="filePath">
        /// The path to JSON file.
        /// </param>
        public void ParseJson(string filePath)
        {
            while (true)
            {
                Console.Write("\nTitle:  ");
                string input = Console.ReadLine();
                int line = 0;
                var json = JObject.Parse(File.ReadAllText(filePath));
                
                if (input.ToLower() == "all")
                {
                    Console.WriteLine(Regex.Replace($"{json}", "[}{,'\"]", ""));
                }
               
                else if (!json.ToString().Contains(input))
                {
                    Console.WriteLine($"Cannot find title '{input}'. Please try again.");
                    continue;
                }

                else 
                {
                    Console.Write("Line:   ");
                    line = Convert.ToInt32(Console.ReadLine()) - 1;

                    foreach (var item in json)
                    {
                        if (item.Key == input)
                        {
                            IList<JToken> results = json[item.Key].Children().ToList();
                            if (results.Count < line || line < 0)
                            {
                                Console.WriteLine($"Cannot find line #{line+1}. Please input line number from a range: 1-{results.Count}.");
                                break;
                            }
                            Console.WriteLine(Regex.Replace($"Data:   {results[line]}", "[}{,'\"]", ""));
                            break;
                        }

                        var jsonChild = JObject.Parse(json[item.Key].ToString());

                        foreach (var itemChild in jsonChild)
                        {
                            if (itemChild.Key == input)
                            {
                                IList<JToken> resultsChild = jsonChild[itemChild.Key].Children().ToList();
                                Console.WriteLine(Regex.Replace($"Data:   {resultsChild[line]}", "[}{,'\"]", ""));
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
