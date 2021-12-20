// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace ParserDecoder
{
    #region Usings

    using System;
    using System.Text.RegularExpressions;
    using System.Xml.Linq;

    #endregion

    /// <summary>
    /// The main class for XML parser with all properties and methods.
    /// </summary>
    class ParserDecoder
    {
        #region Properties and Indexers

        /// <summary>
        /// Stores person`s name.
        /// </summary>
        public string? MessageId { get; set; }

        /// <summary>
        /// Stores person`s full name.
        /// </summary>
        public string? FileId { get; set; }

        /// <summary>
        /// Stores person`s ID.
        /// </summary>
        public string? LineNumber { get; set; }

        /// <summary>
        /// Stores raise which we connect with person's name by ID. 
        /// </summary>
        public string? LineData { get; set; }

        /// <summary>
        /// Stores person`s ID converted in raise ID format.
        /// </summary>
        public string? FilePath { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Getting all the elements of xml file and put their values into properties. 
        /// </summary>
        /// <param name="filePath"></param>
        public void ParserXml(string filePath)
        {
            XDocument xDoc = XDocument.Load(filePath);
            ParserDecoder p = new ParserDecoder();

            while (true)
            {
                p.FileId = "";
                Console.Write("\nMessage ID: ");
                p.MessageId = Console.ReadLine();

                foreach (XElement messageElement in xDoc.Element("Dictionary").Element("Messages").Elements("Message"))
                {
                    if (messageElement.Attribute("ID").Value == p.MessageId)
                    {
                        p.FileId = messageElement.Attribute("File").Value;
                        p.LineNumber = messageElement.Attribute("Line").Value;
                        p.LineData = messageElement.Value;
                    }
                }
                foreach (XElement fileElement in xDoc.Element("Dictionary").Element("SourceFiles").Elements("File"))
                {
                    if (fileElement.Attribute("ID").Value == p.FileId)
                    {
                        p.FilePath = fileElement.Value;
                    }
                }
                if (p.FileId == "")
                {
                    Console.WriteLine($"Cannot find the message ID '{p.MessageId}' in database. Please try again.");
                }
                else
                {
                    Console.WriteLine($"File ID: {p.FileId}.\nLine number: {p.LineNumber}.\nLine data: {p.LineData}.\nFile path: {p.FilePath}.");
                }
            }
        }
        #endregion
    }
}
