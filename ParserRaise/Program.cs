using System;

namespace ParserRaise
{
    class Program
    {
        static void Main(string[] args)
        {
            ParserRaise parser = new ParserRaise();
            parser.ParserXml("contactsRaise.xml");
        }
    }
}
