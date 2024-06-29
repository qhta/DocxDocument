namespace ModelOpenXmlLibApp;

internal class Program
{
  static void Main(string[] args)
  {
    var t1 = DateTime.Now;
    var OpenXmlLibParser = new OpenXmlLibParser();
    OpenXmlLibParser.ParseSchemaFiles(@"D:\VS\Docs\OpenXML\Libraries", @"D:\VS\Docs\OpenXML\OpenXmlLib.accdb");
    var t2 = DateTime.Now;
    var dt = t2 - t1;
    if (dt.TotalMinutes >= 1)
      Console.WriteLine("Done in {0} min {1} sec", (int)dt.TotalMinutes, dt.Seconds);
    else
      Console.WriteLine("Done in {0} seconds", (int)dt.TotalSeconds);
    Console.WriteLine("Found {0} files, added {1}", OpenXmlLibParser.FilesTotal, OpenXmlLibParser.FilesAdded);
    Console.WriteLine("Found {0} namespaces, added {1}", OpenXmlLibParser.NamespacesTotal, OpenXmlLibParser.NamespacesAdded);
    Console.WriteLine("Found {0} file-namespace relationships, added {1}", OpenXmlLibParser.FileNamespacesTotal, OpenXmlLibParser.FileNamespacesAdded);
    Console.WriteLine("Found {0} types, added {1}, updated {2}", OpenXmlLibParser.TypesTotal, OpenXmlLibParser.TypesAdded, OpenXmlLibParser.TypesUpdated);
    Console.WriteLine("Found {0} properties, added {1}, updated {2}", OpenXmlLibParser.PropertiesTotal, OpenXmlLibParser.PropertiesAdded, OpenXmlLibParser.PropertiesUpdated);
    Console.WriteLine("Found {0} enum values, added {1}", OpenXmlLibParser.EnumValuesTotal, OpenXmlLibParser.EnumValuesAdded);

  }

}
