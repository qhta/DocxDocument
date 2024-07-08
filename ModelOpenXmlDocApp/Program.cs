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

  }

}
