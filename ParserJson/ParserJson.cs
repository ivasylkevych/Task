// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace ParserJson
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    #endregion

    /// <summary>
    /// The main class for JSON parser with all properties and methods.
    /// </summary>
    class ParserJson
    {
        #region Public Methods

        /// <summary>
        /// Getting all the elements of JSON file and put their values into properties. 
        /// </summary>
        /// <param name="filePath">
        /// The path to JSON file.
        /// </param>
        public void ParseJson(string filePath)
        {
            while (true)
            {
                Console.Write("\nPerson ID:  ");
                int id = Convert.ToInt32(Console.ReadLine());
                List<Contacts> contacts = JsonConvert.DeserializeObject<List<Contacts>>(File.ReadAllText(filePath));


                foreach (var item in contacts)
                {
                    if (item.PersonId == id)
                    {
                        Console.WriteLine($"First name: {item.FirstName}.\nLast name:  {item.LastName}.\nCity:       {item.City}.");
                    }
                }
                if (id > contacts.Count)
                {
                    Console.WriteLine($"Cannot find the person with ID '{id}'. Please try again.");
                }
            }
        }
        #endregion
    }
}
