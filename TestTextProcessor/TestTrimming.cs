using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

using DocumentFormat.OpenXml;

using NUnit.Framework;

namespace Qhta.OpenXmlTools;

public partial class TextProcessingTester
{

  /// <summary>
  /// Run a find and replace test in the document.
  /// </summary>
  /// <param name="body"></param>
  public void TestSimpleFindAndReplace(DX.OpenXmlCompositeElement body)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTesting simple find and replace");
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
    var formattedText = new FormattedText(paragraph, TestTextOptions);
    formattedText.Replace("bold", "boldfaced");
    Assert.That(paragraph.GetText(TextOptions.PlainText),
      Is.EqualTo("This text is boldfaced, and this is italicized."));
    formattedText.Replace("italicized", "italic");
    Assert.That(paragraph.GetText(TextOptions.PlainText), Is.EqualTo("This text is boldfaced, and this is italic."));
    return true;
  }


  /// <summary>
  /// Run a multiple runs text find and replace test in the document.
  /// </summary>
  /// <param name="body"></param>
  public void TestMultipleRunsTextFindAndReplace(DX.OpenXmlCompositeElement body)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest multiple runs text find and replace");

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
    var formattedText = new FormattedText(paragraph, TestTextOptions);
    formattedText.Replace(", and this is", ", and this text is");
    Assert.That(paragraph.GetText(TextOptions.PlainText),
      Is.EqualTo("This text is bold, and this text is italicized."));
    return true;
  }


  /// <summary>
  /// Run a text find and formatted replace test in the document.
  /// </summary>
  /// <param name="body"></param>
  public void TestTextFindAndFormattedReplace(DX.OpenXmlCompositeElement body)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest text find and formatted replace");

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
    var formattedText = new FormattedText(paragraph, TestTextOptions);
    formattedText.Replace(", and this is", ", and this text is", new TextFormat { Bold = false });
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }),
      Is.EqualTo("This text is <b>bold</b>, and this text is <i>italicized</i>."));
    return true;
  }

  /// <summary>
  /// Run a test to find and replace formatted text in the document.
  /// </summary>
  /// <param name="body"></param>
  public void TestFormattedTextFindAndReplace(DX.OpenXmlCompositeElement body)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest formatted text find and replace");

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
    var formattedText = new FormattedText(paragraph, TestTextOptions);
    formattedText.Replace(" is ", new TextFormat { Italic = true }, " is ", new TextFormat { Italic = false });
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }),
      Is.EqualTo("This text <b>is bold,</b> and <i>this</i> is <i>italicized</i>."));
    return true;
  }

  /// <summary>
  /// Run a test of find and replace whole words in the document.
  /// </summary>
  /// <param name="body"></param>
  public void TestWholeWordsTextFindAndReplace(DX.OpenXmlCompositeElement body)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest whole words text find and replace");

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
    var formattedText = new FormattedText(paragraph, TestTextOptions);
    formattedText.Replace("is", new TextFormat { Italic = true }, "is", new TextFormat { Italic = false },
      new FindAndReplaceOptions { FindWholeWordsOnly = true });
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }),
      Is.EqualTo("This text <b>is bold,</b> and <i>this </i>is<i> italicized</i>."));
    return true;
  }

  /// <summary>
  /// Run a test of find and replace whole words in the document.
  /// </summary>
  /// <param name="body"></param>
  public void TestCaseInsensitiveTextFindAndReplace(DX.OpenXmlCompositeElement body)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest whole words text find and replace");

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
    var formattedText = new FormattedText(paragraph, TestTextOptions);
    formattedText.Replace("this", "that", new FindAndReplaceOptions { MatchCaseInsensitive = true });
    formattedText.Replace("this", "that", new FindAndReplaceOptions { MatchCaseInsensitive = true });
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }),
      Is.EqualTo("That text <b>is bold,</b> and <i>that is italicized</i>."));
    return true;
  }

  /// <summary>
  /// Run a test of find and replace whole words in the document.
  /// </summary>
  /// <param name="body"></param>
  public void TestFormatFindAndReplace(DX.OpenXmlCompositeElement body)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest format find and replace");

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
      if (TestFormatFindAndReplace(paragraph))
        count++;
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} tests passed.");
  }

  /// <summary>
  /// Run a test of find and replace whole words in the paragraph.
  /// </summary>
  /// <param name="paragraph"></param>
  public bool TestFormatFindAndReplace(DXW.Paragraph paragraph)
  {
    var formattedText = new FormattedText(paragraph, TestTextOptions);
    formattedText.Replace(null, new TextFormat { Italic = true }, null, new TextFormat { Bold = true });
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }),
      Is.EqualTo("This text <b>is bold,</b> and <b><i>this is italicized</i></b>."));
    formattedText.Replace(null, new TextFormat { Bold = true, Italic = false }, null,
      new TextFormat { Bold = false, Italic = true });
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }),
      Is.EqualTo("This text <i>is bold,</i> and <b><i>this is italicized</i></b>."));
    formattedText.Replace("is", null, null, new TextFormat { Italic = true },
      new FindAndReplaceOptions { FindWholeWordsOnly = false });
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }),
      Is.EqualTo("Th<i>is</i> text <i>is bold,</i> and <b><i>this is italicized</i></b>."));
    formattedText.Replace(null, new TextFormat { Italic = true }, null, new TextFormat { Bold = true, Italic = true },
      new FindAndReplaceOptions { FindWholeWordsOnly = true });
    Assert.That(paragraph.GetText(TextOptions.PlainText with { UseHtmlFormatting = true }),
      Is.EqualTo("Th<i>is</i> text <b><i>is bold,</i></b> and <b><i>this is italicized</i></b>."));
    return true;
  }
}

