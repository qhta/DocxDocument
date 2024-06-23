namespace ModelXmlSchemaApp;

using ModelXmlSchema;

internal class Program
{
  static void Main(string[] args)
  {
    var t1 = DateTime.Now;
    var XmlSchemaParser = new XmlSchemaParser();
    XmlSchemaParser.ParseSchemaFiles(@"D:\VS\Docs\OpenXML\Schemas", @"D:\VS\Docs\OpenXML\XmlSchema.accdb");
    var t2 = DateTime.Now;
    Console.WriteLine("Done in {0} seconds", (int)(t2-t1).TotalSeconds);
    Console.WriteLine("Parsed {0} files", XmlSchemaParser.SchemaFilesCount);
    Console.WriteLine("Counted {0} namespaces", XmlSchemaParser.SchemaNamespacesCount);
  }
}
