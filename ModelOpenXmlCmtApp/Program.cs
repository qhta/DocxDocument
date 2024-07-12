namespace ModelOpenXmlCmtApp;

internal class Program
{
  static void Main(string[] args)
  {
    var t1 = DateTime.Now;
    var OpenXmlCmtParser = new OpenXmlCmtParser();
    OpenXmlCmtParser.ParseDocuments(@"D:\VS\Docs\OpenXML\Libraries", @"D:\VS\Docs\OpenXML\OpenXmlCmt.accdb");
    var t2 = DateTime.Now;
    var dt = t2 - t1;
    if (dt.TotalMinutes >= 1)
      Console.WriteLine("Done in {0} min {1} sec", (int)dt.TotalMinutes, dt.Seconds);
    else
      Console.WriteLine("Done in {0} seconds", (int)dt.TotalSeconds);
    Console.WriteLine("Found {0} files, added {1}", OpenXmlCmtParser.FilesTotal, OpenXmlCmtParser.FilesAdded);
    Console.WriteLine("Found {0} types, added {1}, updated {2}", OpenXmlCmtParser.TypesTotal, OpenXmlCmtParser.TypesAdded, OpenXmlCmtParser.TypesUpdated);
    Console.WriteLine("Found {0} fields, added {1}, updated {2}", OpenXmlCmtParser.FieldsTotal, OpenXmlCmtParser.FieldsAdded, OpenXmlCmtParser.FieldsUpdated);
    Console.WriteLine("Found {0} properties, added {1}, updated {2}", OpenXmlCmtParser.PropsTotal, OpenXmlCmtParser.PropsAdded, OpenXmlCmtParser.PropsUpdated);

    //foreach (var entry in OpenXmlCmtParser.CommentsCountersMap)
    //{
    //  Console.WriteLine($"Found {entry.Value.Total} {entry.Key} comments, added {entry.Value.Added}, updated {entry.Value.Updated}");
    //}
  }

}
