namespace ModelDocApp;

internal class Program
{
  static void Main(string[] args)
  {
    var xmlSchemaParser = new XmlSchemaParser();
    xmlSchemaParser.ParseSchemaFiles();
  }


}

