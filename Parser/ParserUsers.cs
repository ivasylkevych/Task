// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace Parser
{
    #region Usings

    using System;
    using System.Xml;

    #endregion

    /// <summary>
    /// XML parser.
    /// </summary>
    class ParserUsers
    {
        /// <summary>
        /// Parses XML file.
        /// </summary>
        /// <param name="filePath">
        /// The path to xml file.
        /// </param>
        public void ParserXml(string filePath)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filePath);
            // Getting root element.
            XmlElement? xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                // Check all nodes in root element.
                foreach (XmlElement xnode in xRoot)
                {
                    // Getting attribut "name".
                    XmlNode? attr = xnode.Attributes.GetNamedItem("name");
                    Console.WriteLine(attr?.Value);

                    // Check all child nodes of the main node.
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        // If child node is "company".
                        if (childnode.Name == "company")
                        {
                            Console.WriteLine($"Company: {childnode.InnerText}");
                        }
                        // If child node is "age".
                        if (childnode.Name == "age")
                        {
                            Console.WriteLine($"Age: {childnode.InnerText}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
