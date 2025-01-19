using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

using DocumentFormat.OpenXml;

using NUnit.Framework;

namespace Qhta.OpenXmlTools;

public partial class TextProcessingTester
{

  /// <summary>
  /// Run a trimming test in the document.
  /// </summary>
  /// <param name="body"></param>
  public void TestTrimming(DX.OpenXmlCompositeElement body)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTesting paragraph trimming");
    var paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      paragraph.Remove();
    }
    foreach (var text in TrimTexts)
    {
      body.Append(new DXW.Paragraph(text.Insert(4, xmlnsString)));
    }
    var count = 0;
    paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      if (TestTrimming(paragraph))
        count++;
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} tests passed.");
  }

  /// <summary>
  /// Run a simple find and replace plain text test in the paragraph.
  /// </summary>
  /// <param name="paragraph"></param>
  public bool TestTrimming(DXW.Paragraph paragraph)
  {
    var formattedText = new FormattedText(paragraph, TestTextOptions);
    formattedText.Replace("bold", "boldfaced");
    Assert.That(paragraph.GetText(TextOptions.PlainText),
      Is.EqualTo("This text is boldfaced, and this is italicized."));
    formattedText.Replace("italicized", "italic");
    Assert.That(paragraph.GetText(TextOptions.PlainText), Is.EqualTo("This text is boldfaced, and this is italic."));
    return true;
  }

  private static readonly string[] TrimTexts = new string[]
{
    "<w:p><w:r><w:t>This text is bold, and this is italicized.</w:t></w:r></w:p>",
    "<w:p w:rsidRPr=\"00C0491F\" w:rsidR=\"007D6C6C\" w:rsidP=\"00F043F7\" w:rsidRDefault=\"00D74F81\" w14:paraId=\"7DF600F6\" w14:textId=\"3F81EAE3\">\r\n\t\t\t<w:bookmarkStart w:name=\"_GoBack\" w:id=\"0\"/>\r\n\t\t\t<w:bookmarkEnd w:id=\"0\"/>\r\n\t\t\t<w:r w:rsidRPr=\"00E7749D\">\r\n\t\t\t\t<w:t>This</w:t>\r\n\t\t\t\t<w:t xml:space=\"preserve\"> </w:t>\r\n\t\t\t\t<w:t>text</w:t>\r\n\t\t\t\t<w:t xml:space=\"preserve\"> </w:t>\r\n\t\t\t\t<w:t>is</w:t>\r\n\t\t\t\t<w:t xml:space=\"preserve\"> </w:t>\r\n\t\t\t</w:r>\r\n\t\t\t<w:r w:rsidRPr=\"00E7749D\">\r\n\t\t\t\t<w:rPr>\r\n\t\t\t\t\t<w:b/>\r\n\t\t\t\t\t<w:bCs/>\r\n\t\t\t\t</w:rPr>\r\n\t\t\t\t<w:t>bold</w:t>\r\n\t\t\t\t<w:t>,</w:t>\r\n\t\t\t</w:r>\r\n\t\t\t<w:r w:rsidRPr=\"00E7749D\">\r\n\t\t\t\t<w:t xml:space=\"preserve\"> and </w:t>\r\n\t\t\t\t<w:t>this</w:t>\r\n\t\t\t\t<w:t xml:space=\"preserve\"> </w:t>\r\n\t\t\t\t<w:t>is</w:t>\r\n\t\t\t\t<w:t xml:space=\"preserve\"> </w:t>\r\n\t\t\t</w:r>\r\n\t\t\t<w:r w:rsidRPr=\"00E7749D\">\r\n\t\t\t\t<w:rPr>\r\n\t\t\t\t\t<w:i/>\r\n\t\t\t\t\t<w:iCs/>\r\n\t\t\t\t</w:rPr>\r\n\t\t\t\t<w:t>italicized</w:t>\r\n\t\t\t</w:r>\r\n\t\t\t<w:r w:rsidRPr=\"00E7749D\">\r\n\t\t\t\t<w:t>.</w:t>\r\n\t\t\t</w:r>\r\n\t\t</w:p>",
    "<w:p w14:paraId=\"763D35DE\" w14:textId=\"4BD8BFE4\" w:rsidR=\"00B65346\" w:rsidRDefault=\"006F2D84\" w:rsidP=\"00307B9B\">\r\n" +
    "      <w:pPr>\r\n" +
    "        <w:pStyle w:val=\"Normal\"/>\r\n" +
    "      </w:pPr>\r\n" +
    "      <w:r w:rsidRPr=\"006F2D84\" my:runId=\"00000001\">\r\n" +
    "        <w:t xml:space=\"preserve\">This text </w:t>\r\n" +
    "      </w:r>      " +
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
    "    </w:p>",
};

}

