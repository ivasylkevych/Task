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
        /// Stores message ID.
        /// </summary>
        public string? MessageId { get; set; }

        /// <summary>
        /// Stores file ID.
        /// </summary>
        public string? FileId { get; set; }

        /// <summary>
        /// Stores line number.
        /// </summary>
        public string? LineNumber { get; set; }

        /// <summary>
        /// Stores line data. 
        /// </summary>
        public string? LineData { get; set; }

        /// <summary>
        /// Stores file path.
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
            ParserDecoder parser = new ParserDecoder();

            while (true)
            {
                parser.FileId = "";
                Console.Write("\nMessage ID: ");
                parser.MessageId = Console.ReadLine();

                foreach (XElement messageElement in xDoc.Element("Dictionary").Element("Messages").Elements("Message"))
                {
                    if (messageElement.Attribute("ID").Value == parser.MessageId)
                    {
                        parser.FileId = messageElement.Attribute("File").Value;
                        parser.LineNumber = messageElement.Attribute("Line").Value;
                        parser.LineData = messageElement.Value;
                    }
                }
                foreach (XElement fileElement in xDoc.Element("Dictionary").Element("SourceFiles").Elements("File"))
                {
                    if (fileElement.Attribute("ID").Value == parser.FileId)
                    {
                        parser.FilePath = fileElement.Value;
                    }
                }
                if (parser.FileId == "")
                {
                    Console.WriteLine($"Cannot find the message with ID '{parser.MessageId}' in database. Please try again.");
                }
                else
                {
                    Console.WriteLine($"File ID: {parser.FileId}.\nLine number: {parser.LineNumber}.\nLine data: {parser.LineData}.\nFile path: {parser.FilePath}.");
                }
            }
        }
        #endregion
    }
}
