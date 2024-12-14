using System;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;

namespace Qhta.OpenXmlTools;

public partial class TextProcessingTester
{
  /// <summary>
  /// Determines the level of verbosity of the cleaner.
  /// </summary>
  public int VerboseLevel { get; set; }

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
        TestSimpleFindAndReplace(wordDoc);
        TestMultipleRunsTextFindAndReplace(wordDoc);
        TestTextFindAndFormattedReplace(wordDoc);
        TestFormattedTextFindAndReplace(wordDoc);
        TestWholeWordsTextFindAndReplace(wordDoc);
        TestCaseInsensitiveTextFindAndReplace(wordDoc);
      }
      finally
      {
        wordDoc.Dispose();
      }
  }

  /// <summary>
  /// Run a find and replace test in the document.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void TestSimpleFindAndReplace(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTesting simple find and replace");
    var body = wordDoc.GetBody();
    var paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      paragraph.Remove();
    }
    foreach (var text in TestTexts)
    {
      body.Append(new DXW.Paragraph(text.Insert(4, xmlnsString)));
    }
    var count = 0;
    paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      if (TestSimpleFindAndReplace(paragraph))
        count++;
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} tests passed.");
  }

  /// <summary>
  /// Run a simple find and replace plain text test in the paragraph.
  /// </summary>
  /// <param name="paragraph"></param>
  public bool TestSimpleFindAndReplace(DXW.Paragraph paragraph)
  {
    var formattedText = new FormattedText(paragraph);
    formattedText.Replace("bold", "boldfaced");
    Assert.That(paragraph.GetText(TextOptions.PlainText), Is.EqualTo("This text is boldfaced, and this is italicized."));
    formattedText.Replace("italicized", "italic");
    Assert.That(paragraph.GetText(TextOptions.PlainText), Is.EqualTo("This text is boldfaced, and this is italic."));
    return true;
  }


  /// <summary>
  /// Run a multiple runs text find and replace test in the document.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void TestMultipleRunsTextFindAndReplace(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest multiple runs text find and replace");
    var body = wordDoc.GetBody();
    var paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      paragraph.Remove();
    }
    foreach (var text in TestTexts)
    {
      body.Append(new DXW.Paragraph(text.Insert(4, xmlnsString)));
    }
    var count = 0;
    paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      if (TestMultipleRunsTextFindAndReplace(paragraph))
        count++;
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} tests passed.");
  }

  /// <summary>
  /// Run a find and replace plain text test in the paragraph.
  /// </summary>
  /// <param name="paragraph"></param>
  public bool TestMultipleRunsTextFindAndReplace(DXW.Paragraph paragraph)
  {
    var formattedText = new FormattedText(paragraph);
    formattedText.Replace(", and this is", ", and this text is");
    Assert.That(paragraph.GetText(TextOptions.PlainText), Is.EqualTo("This text is bold, and this text is italicized."));
    return true;
  }


  /// <summary>
  /// Run a text find and formatted replace test in the document.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void TestTextFindAndFormattedReplace(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest text find and formatted replace");
    var body = wordDoc.GetBody();
    var paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      paragraph.Remove();
    }
    foreach (var text in TestTexts)
    {
      body.Append(new DXW.Paragraph(text.Insert(4, xmlnsString)));
    }
    var count = 0;
    paragraphs = body.Elements<DXW.Paragraph>().ToList();
    if (TestTextFindAndFormattedReplace(paragraphs[1]))
      count++;
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} tests passed.");
  }

  /// <summary>
  /// Run a find and replace plain text test in the paragraph.
  /// </summary>
  /// <param name="paragraph"></param>
  public bool TestTextFindAndFormattedReplace(DXW.Paragraph paragraph)
  {
    var formattedText = new FormattedText(paragraph);
    formattedText.Replace(", and this is", ", and this text is", new TextFormat{Bold = false});
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }), Is.EqualTo("This text is <b>bold</b>, and this text is <i>italicized</i>."));
    return true;
  }

  /// <summary>
  /// Run a test to find and replace formatted text in the document.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void TestFormattedTextFindAndReplace(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest formatted text find and replace");
    var body = wordDoc.GetBody();
    var paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      paragraph.Remove();
    }
    var text = TestTexts[2];
    {
      body.Append(new DXW.Paragraph(text.Insert(4, xmlnsString)));
    }
    var count = 0;
    paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      if (TestFormattedTextFindAndReplace(paragraph))
        count++;
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} tests passed.");
  }

  /// <summary>
  /// Run a test to find and replace formatted text in the paragraph.
  /// </summary>
  /// <param name="paragraph"></param>
  public bool TestFormattedTextFindAndReplace(DXW.Paragraph paragraph)
  {
    var formattedText = new FormattedText(paragraph);
    formattedText.Replace(" is ", new TextFormat { Italic = true }, " is ", new TextFormat { Italic = false });
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }), Is.EqualTo("This text <b>is bold,</b> and <i>this</i> is <i>italicized</i>."));
    return true;
  }

  /// <summary>
  /// Run a test of find and replace whole words in the document.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void TestWholeWordsTextFindAndReplace(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest whole words text find and replace");
    var body = wordDoc.GetBody();
    var paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      paragraph.Remove();
    }
    var text = TestTexts[2];
    {
      body.Append(new DXW.Paragraph(text.Insert(4, xmlnsString)));
    }
    var count = 0;
    paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      if (TestWholeWordsTextFindAndReplace(paragraph))
        count++;
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} tests passed.");
  }

  /// <summary>
  /// Run a test of find and replace whole words in the paragraph.
  /// </summary>
  /// <param name="paragraph"></param>
  public bool TestWholeWordsTextFindAndReplace(DXW.Paragraph paragraph)
  {
    var formattedText = new FormattedText(paragraph);
    formattedText.Replace("is", new TextFormat { Italic = true }, "is", new TextFormat { Italic = false }, new FindAndReplaceOptions { FindWholeWordsOnly = true});
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }), Is.EqualTo("This text <b>is bold,</b> and <i>this </i>is<i> italicized</i>."));
    return true;
  }

  /// <summary>
  /// Run a test of find and replace whole words in the document.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void TestCaseInsensitiveTextFindAndReplace(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest whole words text find and replace");
    var body = wordDoc.GetBody();
    var paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      paragraph.Remove();
    }
    var text = TestTexts[2];
    {
      body.Append(new DXW.Paragraph(text.Insert(4, xmlnsString)));
    }
    var count = 0;
    paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      if (TestCaseInsensitiveTextFindAndReplace(paragraph))
        count++;
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} tests passed.");
  }

  /// <summary>
  /// Run a test of find and replace whole words in the paragraph.
  /// </summary>
  /// <param name="paragraph"></param>
  public bool TestCaseInsensitiveTextFindAndReplace(DXW.Paragraph paragraph)
  {
    var formattedText = new FormattedText(paragraph);
    formattedText.Replace("this", "that", new FindAndReplaceOptions{ MatchCaseInsensitive = true });
    formattedText.Replace("this", "that", new FindAndReplaceOptions { MatchCaseInsensitive = true });
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }), Is.EqualTo("That text <b>is bold,</b> and <i>that is italicized</i>."));
    return true;
  }

  private const string xmlnsString =
    " xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"" +
    " xmlns:w14=\"http://schemas.microsoft.com/office/word/2010/wordml\"" +
    " xmlns:my=\"presentationPurpose\"" +
    //" xmlns:wpc=\"http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas\"" +
    //" xmlns:cx=\"http://schemas.microsoft.com/office/drawing/2014/chartex\"" +
    //" xmlns:cx1=\"http://schemas.microsoft.com/office/drawing/2015/9/8/chartex\"" +
    //" xmlns:cx2=\"http://schemas.microsoft.com/office/drawing/2015/10/21/chartex\"" +
    //" xmlns:cx3=\"http://schemas.microsoft.com/office/drawing/2016/5/9/chartex\"" +
    //" xmlns:cx4=\"http://schemas.microsoft.com/office/drawing/2016/5/10/chartex\"" +
    //" xmlns:cx5=\"http://schemas.microsoft.com/office/drawing/2016/5/11/chartex\"" +
    //" xmlns:cx6=\"http://schemas.microsoft.com/office/drawing/2016/5/12/chartex\"" +
    //" xmlns:cx7=\"http://schemas.microsoft.com/office/drawing/2016/5/13/chartex\"" +
    //" xmlns:cx8=\"http://schemas.microsoft.com/office/drawing/2016/5/14/chartex\"" +
    //" xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\"" +
    //" xmlns:aink=\"http://schemas.microsoft.com/office/drawing/2016/ink\"" +
    //" xmlns:am3d=\"http://schemas.microsoft.com/office/drawing/2017/model3d\"" +
    //" xmlns:o=\"urn:schemas-microsoft-com:office:office\"" +
    //" xmlns:oel=\"http://schemas.microsoft.com/office/2019/extlst\"" +
    //" xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\"" +
    //" xmlns:m=\"http://schemas.openxmlformats.org/officeDocument/2006/math\"" +
    //" xmlns:v=\"urn:schemas-microsoft-com:vml\"" +
    //" xmlns:wp14=\"http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing\"" +
    //" xmlns:wp=\"http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing\"" +
    //" xmlns:w10=\"urn:schemas-microsoft-com:office:word\"" +
    //" xmlns:w15=\"http://schemas.microsoft.com/office/word/2012/wordml\"" +
    //" xmlns:w16cex=\"http://schemas.microsoft.com/office/word/2018/wordml/cex\"" +
    //" xmlns:w16cid=\"http://schemas.microsoft.com/office/word/2016/wordml/cid\"" +
    //" xmlns:w16=\"http://schemas.microsoft.com/office/word/2018/wordml\"" +
    //" xmlns:w16du=\"http://schemas.microsoft.com/office/word/2023/wordml/word16du\"" +
    //" xmlns:w16sdtdh=\"http://schemas.microsoft.com/office/word/2020/wordml/sdtdatahash\"" +
    //" xmlns:w16se=\"http://schemas.microsoft.com/office/word/2015/wordml/symex\"" +
    //" xmlns:wpg=\"http://schemas.microsoft.com/office/word/2010/wordprocessingGroup\"" +
    //" xmlns:wpi=\"http://schemas.microsoft.com/office/word/2010/wordprocessingInk\"" +
    //" xmlns:wne=\"http://schemas.microsoft.com/office/word/2006/wordml\"" +
    //" xmlns:wps=\"http://schemas.microsoft.com/office/word/2010/wordprocessingShape\"" +
    //" mc:Ignorable=\"w14 w15 w16se w16cid w16 w16cex w16sdtdh w16du wp14\"" +
    "";
  private static readonly string[] TestTexts = new string[]
  {
    "<w:p><w:r><w:t>This text is bold, and this is italicized.</w:t></w:r></w:p>",
    "<w:p w:rsidRPr=\"00C0491F\" w:rsidR=\"007D6C6C\" w:rsidP=\"00F043F7\" w:rsidRDefault=\"00D74F81\" w14:paraId=\"7DF600F6\" w14:textId=\"3F81EAE3\">\r\n\t\t\t<w:bookmarkStart w:name=\"_GoBack\" w:id=\"0\"/>\r\n\t\t\t<w:bookmarkEnd w:id=\"0\"/>\r\n\t\t\t<w:r w:rsidRPr=\"00E7749D\">\r\n\t\t\t\t<w:t>This</w:t>\r\n\t\t\t\t<w:t xml:space=\"preserve\"> </w:t>\r\n\t\t\t\t<w:t>text</w:t>\r\n\t\t\t\t<w:t xml:space=\"preserve\"> </w:t>\r\n\t\t\t\t<w:t>is</w:t>\r\n\t\t\t\t<w:t xml:space=\"preserve\"> </w:t>\r\n\t\t\t</w:r>\r\n\t\t\t<w:r w:rsidRPr=\"00E7749D\">\r\n\t\t\t\t<w:rPr>\r\n\t\t\t\t\t<w:b/>\r\n\t\t\t\t\t<w:bCs/>\r\n\t\t\t\t</w:rPr>\r\n\t\t\t\t<w:t>bold</w:t>\r\n\t\t\t\t<w:t>,</w:t>\r\n\t\t\t</w:r>\r\n\t\t\t<w:r w:rsidRPr=\"00E7749D\">\r\n\t\t\t\t<w:t xml:space=\"preserve\"> and </w:t>\r\n\t\t\t\t<w:t>this</w:t>\r\n\t\t\t\t<w:t xml:space=\"preserve\"> </w:t>\r\n\t\t\t\t<w:t>is</w:t>\r\n\t\t\t\t<w:t xml:space=\"preserve\"> </w:t>\r\n\t\t\t</w:r>\r\n\t\t\t<w:r w:rsidRPr=\"00E7749D\">\r\n\t\t\t\t<w:rPr>\r\n\t\t\t\t\t<w:i/>\r\n\t\t\t\t\t<w:iCs/>\r\n\t\t\t\t</w:rPr>\r\n\t\t\t\t<w:t>italicized</w:t>\r\n\t\t\t</w:r>\r\n\t\t\t<w:r w:rsidRPr=\"00E7749D\">\r\n\t\t\t\t<w:t>.</w:t>\r\n\t\t\t</w:r>\r\n\t\t</w:p>",
    "<w:p w14:paraId=\"763D35DE\" w14:textId=\"4BD8BFE4\" w:rsidR=\"00B65346\" w:rsidRDefault=\"006F2D84\" w:rsidP=\"00307B9B\">\r\n" +
    "      <w:pPr>\r\n" +
    "        <w:pStyle w:val=\"Normal\"/>\r\n" +
    "      </w:pPr>\r\n" +
    "      <w:r w:rsidRPr=\"006F2D84\" my:runId=\"00000001\">\r\n" +
    "        <w:t xml:space=\"preserve\">This text </w:t>\r\n" +
    "      </w:r>\r\n      " +
    "      <w:r w:rsidRPr=\"006F2D84\" my:runId=\"00000002\">\r\n" +
    "        <w:rPr>\r\n" +
    "          <w:b/>\r\n" +
    "          <w:bCs/>\r\n" +
    "        </w:rPr>\r\n" +
    "        <w:t>is bold,</w:t>\r\n" +
    "      </w:r>\r\n" +
    "      <w:r w:rsidRPr=\"006F2D84\" my:runId=\"00000003\">\r\n" +
    "        <w:t xml:space=\"preserve\"> and </w:t>\r\n" +
    "      </w:r>\r\n" +
    "      <w:r w:rsidRPr=\"006F2D84\" my:runId=\"00000004\">\r\n" +
    "        <w:rPr>\r\n" +
    "          <w:i/>\r\n" +
    "          <w:iCs/>\r\n" +
    "        </w:rPr>\r\n" +
    "        <w:t>this is italicized</w:t>\r\n" +
    "      </w:r>\r\n" +
    "      <w:r w:rsidRPr=\"006F2D84\" my:runId=\"00000005\">\r\n" +
    "        <w:t>.</w:t>\r\n" +
    "      </w:r>\r\n" +
    "    </w:p>\r\n",

  };
}