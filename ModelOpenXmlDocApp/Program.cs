namespace ModelOpenXmlDocApp;

internal class Program
{
  static void Main(string[] args)
  {
    var t1 = DateTime.Now;
    var OpenXmlDocParser = new OpenXmlDocParser();
    OpenXmlDocParser.ParseSchemaFiles(@"D:\VS\Docs\OpenXML\Documents", @"D:\VS\Docs\OpenXML\OpenXmlDoc.accdb");
    var t2 = DateTime.Now;
    var dt = t2 - t1;
    if (dt.TotalMinutes >= 1)
      Console.WriteLine("Done in {0} min {1} sec", (int)dt.TotalMinutes, dt.Seconds);
    else
      Console.WriteLine("Done in {0} seconds", (int)dt.TotalSeconds);
    Console.WriteLine("Found {0} files, added {1}", OpenXmlDocParser.FilesTotal, OpenXmlDocParser.FilesAdded);
    Console.WriteLine("Found {0} chapters, added {1}, updated {2}", OpenXmlDocParser.ChaptersTotal, OpenXmlDocParser.ChaptersAdded, OpenXmlDocParser.ChaptersUpdated);
    Console.WriteLine("Found {0} simple types, added {1}, updated {2}", OpenXmlDocParser.SimpleTypesTotal, OpenXmlDocParser.SimpleTypesAdded, OpenXmlDocParser.SimpleTypesUpdated);
    Console.WriteLine("Found {0} enum values, added {1}, updated {2}", OpenXmlDocParser.EnumValuesTotal, OpenXmlDocParser.EnumValuesAdded, OpenXmlDocParser.EnumValuesUpdated);
    Console.WriteLine("Found {0} elements, added {1}, updated {2}", OpenXmlDocParser.ElementsTotal, OpenXmlDocParser.ElementsAdded, OpenXmlDocParser.ElementsUpdated);
    Console.WriteLine("Found {0} attributes, added {1}, updated {2}", OpenXmlDocParser.AttributesTotal, OpenXmlDocParser.AttributesAdded, OpenXmlDocParser.AttributesUpdated);
  }

}
