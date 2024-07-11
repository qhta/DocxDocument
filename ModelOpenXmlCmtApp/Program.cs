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
    Console.WriteLine("Found {0} members, added {1}, updated {2}", OpenXmlCmtParser.MembersTotal, OpenXmlCmtParser.MembersAdded, OpenXmlCmtParser.MembersUpdated);
  }

}
