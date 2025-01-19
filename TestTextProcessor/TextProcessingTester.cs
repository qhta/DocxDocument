using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

using DocumentFormat.OpenXml;

using NUnit.Framework;

namespace Qhta.OpenXmlTools;

public partial class TextProcessingTester
{
  /// <summary>
  /// Determines the level of verbosity of the cleaner.
  /// </summary>
  public int VerboseLevel { get; set; }

  public TextOptions TestTextOptions = TextOptions.PlainText;

  /// <summary>
  /// Run all text processing tests.
  /// </summary>
  /// <param name="fileName"></param>
  public void TestTextProcessing(string fileName)
  {
    DXPack.WordprocessingDocument? wordDoc = null;
    var tryCount = 3;
    while (tryCount > 0)
    {
      try
      {
        wordDoc = DXPack.WordprocessingDocument.Open(fileName, true);
        tryCount = 0;
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        tryCount--;
      }
    }
    if (wordDoc != null)
      try
      {
        var body = wordDoc.GetBody();
        //TestSimpleFindAndReplace(body);
        //TestMultipleRunsTextFindAndReplace(body);
        //TestTextFindAndFormattedReplace(body);
        //TestFormattedTextFindAndReplace(body);
        //TestWholeWordsTextFindAndReplace(body);
        //TestCaseInsensitiveTextFindAndReplace(body);
        //TestFormatFindAndReplace(body);
        //TestRunElementsEncoding(body);
        TestCharEncoding(body);
      }
      finally
      {
        wordDoc.Dispose();
      }
  }
}
