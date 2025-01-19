using System.Reflection;

using Qhta.OpenXmlTools;

namespace TestTextProcessor;

public class Program
{
  static void Main(string[] args)
  {
    var docxPath = Assembly.GetExecutingAssembly().Location;
    while (!docxPath!.EndsWith("bin"))
      docxPath = Path.GetDirectoryName(docxPath);

    Directory.SetCurrentDirectory(docxPath);
    var argList = args.ToList();
    var verboseLevel = 2;
    if (argList.Count > 0)
    {
      var k = argList.IndexOf("-v");
      if (k >= 0)
      {
        if (k < argList.Count - 1)
        {
          verboseLevel = int.Parse(argList[k + 1]);
          argList.RemoveAt(k + 1);
        }
        argList.RemoveAt(k);
      }
    }
    if (argList.Count > 0)
    {
      var tester = new TextProcessingTester();
      tester.VerboseLevel = verboseLevel;
      tester.TestTextProcessing(argList.First());
    }
  }

}
