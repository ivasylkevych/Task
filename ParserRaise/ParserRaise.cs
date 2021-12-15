// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace ParserRaise
{
    #region Usings

    using System;
    using System.Xml;

    #endregion

    /// <summary>
    /// XML parser.
    /// </summary>
    class ParserRaise
    {
        public void ParserXml(string filePath)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(filePath);

            // Getting root element.
            XmlElement? rootElement = xml.DocumentElement;
            if (rootElement != null)
            {
                // Check all nodes in root element.
                foreach (XmlElement xnode in rootElement)
                {
                    // Check all child nodes of the main node.
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        // If child node is "Name".
                        if (childnode.Name == "Name")
                        {
                            Console.WriteLine($"Name: {childnode.InnerText}");
                        }

                        // If child node is "Phone".
                        if (childnode.Name == "Phone")
                        {
                            XmlNode? attr = childnode.Attributes.GetNamedItem("Type");
                            Console.WriteLine($"Phone ({attr?.Value}): {childnode.InnerText}");
                        }

                        // If child node is "Address".
                        if (childnode.Name == "Address")
                        {
                            // To get full address using child elements of the node "Address"
                            foreach (XmlNode subChild in childnode.ChildNodes)
                            {
                                if (subChild.Name == "Street1")
                                {
                                    Console.Write($"Address: {subChild.InnerText}, ");
                                }
                                if (subChild.Name == "City")
                                {
                                    Console.Write($"{subChild.InnerText}, ");
                                }
                                if (subChild.Name == "State")
                                {
                                    Console.Write($"{subChild.InnerText}, ");
                                }
                                if (subChild.Name == "Postal")
                                {
                                    Console.Write($"{subChild.InnerText}");
                                }
                            }
                            Console.WriteLine();
                        }

                        // If child node is "NetWorth".
                        if (childnode.Name == "NetWorth")
                        {
                            Console.WriteLine($"NetWorth: {childnode.InnerText}");
                        }
                    }

                    // To create an empty line between contacts. 
                    Console.WriteLine();
                }
            }
        }
    }
}
