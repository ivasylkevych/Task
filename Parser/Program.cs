namespace ParserUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            ParserUsers parser = new ParserUsers();
            parser.ParserXml("user.xml");
        }
    }
}
