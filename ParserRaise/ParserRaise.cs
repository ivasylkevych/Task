// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace ParserRaise
{
    #region Usings

    using System;
    using System.Text.RegularExpressions;
    using System.Xml.Linq;

    #endregion

    /// <summary>
    /// The main class for XML parser with all properties and methods.
    /// </summary>
    class ParserRaise
    {
        #region Properties and Indexers

        /// <summary>
        /// Stores person`s name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Stores person`s full name.
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Stores person`s ID.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Stores raise which we connect with person's name by ID. 
        /// </summary>
        public int Raise { get; set; }

        /// <summary>
        /// Stores person`s ID converted in raise ID format.
        /// </summary>
        public string? RaiseId { get; set; }

        /// <summary>
        /// Stores person`s net worth.
        /// </summary>
        public int NetWorth { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Getting all the elements of xml file and put their values into properties. 
        /// </summary>
        /// <param name="filePath"></param>
        public void ParserXml(string filePath)
        {
            XDocument xDoc = XDocument.Load(filePath);
            ParserRaise p = new ParserRaise();
            int num = 1;
            foreach (XElement contactElement in xDoc.Element("DataBase").Element("Contacts").Elements("Contact"))
            {
                Console.WriteLine($"{num++}. {contactElement.Element("Name").Value} - Net worth: ${contactElement.Element("NetWorth").Value}.");
            }

            while (true)
            {
                p.Id = "";
                Console.Write($"\nName: ");
                p.Name = Console.ReadLine();

                if (p.Name == "")
                {
                    continue;
                }

                foreach (XElement contactElement in xDoc.Element("DataBase").Element("Contacts").Elements("Contact"))
                {
                    if (contactElement.Element("Name").Value.Contains(p.Name))
                    {
                        p.FullName = contactElement.Element("Name").Value;
                        p.NetWorth = Convert.ToInt32(contactElement.Element("NetWorth").Value);
                        p.Id = contactElement.Element("Id").Value;
                        p.RaiseId = $"ID {p.Id}";
                    }
                }

                foreach (XElement raiseElement in xDoc.Element("DataBase").Element("Raise").Elements("PersonalRaise"))
                {
                    if (raiseElement.Attribute("ID").Value == p.RaiseId)
                    {
                        p.Raise = Convert.ToInt32(0+Regex.Match(raiseElement.Value, @"\d+").Value);
                    }
                }
                if (p.Id == "")
                {
                    Console.WriteLine($"Can't find the name '{p.Name}' in database. Please try again.");
                }
                else
                {
                    Console.WriteLine($"Full name: {p.FullName}. Raise: ${p.Raise}. Total net worth: ${p.NetWorth + p.Raise}.");
                    Console.WriteLine();
                }
                
            }
        }
        #endregion
    }
}
