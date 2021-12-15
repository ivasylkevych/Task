namespace ParserXml
{
    class Program
    {
        static void Main(string[] args)
        {
            ParserContacts parser = new ParserContacts();
            parser.ParserXml("contacts.xml");
        }
    }
}
