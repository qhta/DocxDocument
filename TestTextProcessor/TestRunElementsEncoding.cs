using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

using DocumentFormat.OpenXml;

using NUnit.Framework;

namespace Qhta.OpenXmlTools;

public partial class TextProcessingTester
{
  /// <summary>
  /// Run a test Run elements encoding
  /// </summary>
  /// <param name="body"></param>
  public void TestRunElementsEncoding(DX.OpenXmlCompositeElement body)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTest simple special characters encoding");
    TestRunElementsEncoding(body, TextOptions.PlainText);
    TestRunElementsEncoding(body, TextOptions.RichText);
  }

  private void TestRunElementsEncoding(DX.OpenXmlCompositeElement body, TextOptions options)
  {

    var paragraphs = body.Elements<DXW.Paragraph>().ToList();
    foreach (var paragraph in paragraphs)
    {
      paragraph.Remove();
    }
    var text = BreakPageText.Insert(4, xmlnsString);
    {
      var paragraph = new DXW.Paragraph();
      var run = new DXW.Run();
      run.Append(new DXW.Text("This text is on one page."));
      run.Append(new DXW.Break() { Type = DXW.BreakValues.Page });
      run.Append(new DXW.Text("And this is on another page."));
      paragraph.Append(run);
      body.Append(paragraph);
    }
    var count = 0;
    paragraphs = body.Elements<DXW.Paragraph>().ToList();
    TestTextOptions = options;
    foreach (var paragraph in paragraphs)
    {
      count += TestRunElementsEncoding(paragraph);
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} {options.Mode} tests passed.");
  }

  private int TestRunElementsEncoding(DXW.Paragraph paragraph)
  {
    int count = 0;
    var formattedText = new FormattedText(paragraph, TestTextOptions);
    var text = formattedText.GetText();
    Assert.That(text, Is.EqualTo($"This text is on one page.{TestTextOptions.Tags.BreakPageTag}And this is on another page."));
    count++;
    formattedText.SetText(text, TestTextOptions);
    DX.OpenXmlElement? secondElement = (paragraph.GetMembers().ToArray()[0] as DXW.Run)?.GetMembers().ToArray()[1];
    Assert.That(secondElement?.GetType(), Is.EqualTo(typeof(DXW.Break)));
    Assert.That((secondElement as DXW.Break)?.Type?.Value, Is.EqualTo(DXW.BreakValues.Page));
    count++;
    var aText = paragraph.GetText(TestTextOptions);
    Assert.That(aText, Is.EqualTo(text));

    var n = SpecialCharactersElements.Count;
    if (TestTextOptions.Mode == FormattedTextMode.PlainText)
      n -= 2;
    for (int i = 0; i < n; i++)
    {
      TestRunElementsEncoding(paragraph, formattedText, i);
      count++;
    }
    return count;
  }

  private record TSC
  {
    internal readonly string SpecialChar;
    internal readonly DX.OpenXmlElement Element;


    internal TSC(string specialChar, DX.OpenXmlElement element)
    {
      this.SpecialChar = specialChar;
      this.Element = element;
    }
  }

  private void TestRunElementsEncoding(DXW.Paragraph paragraph, FormattedText formattedText, int index)
  {
    var element = SpecialCharactersElements[index];
    var text = "This text is before" + element.GetText(TestTextOptions) + "And this is after " + element.GetType().Name;
    Debug.WriteLine(text);
    formattedText.SetText(text, TestTextOptions);
    var secondElement = (paragraph.GetMembers().ToArray()[0] as DXW.Run)?.GetMembers().ToArray()[1];
    Assert.That(secondElement?.GetType(), Is.EqualTo(element.GetType()));
    Assert.That(secondElement, Is.EqualTo(element));
    var outerXml1 = element.GetOuterXml();
    var outerXml2 = secondElement?.GetOuterXml();
    Assert.That(outerXml2, Is.EqualTo(outerXml1));
    var aText = paragraph.GetText(TestTextOptions);
    Assert.That(aText, Is.EqualTo(text));
  }

  private readonly List<DX.OpenXmlElement> SpecialCharactersElements = new List<DX.OpenXmlElement>()
  {
    new DXW.Break() { Type = DXW.BreakValues.Page },
    new DXW.Break() { Type = DXW.BreakValues.Column },
    new DXW.Break() { Type = DXW.BreakValues.TextWrapping },
    new DXW.TabChar(),
    new DXW.SoftHyphen(),
    new DXW.NoBreakHyphen(),
    new DXW.AnnotationReferenceMark(),
    new DXW.LastRenderedPageBreak(),
    new DXW.ContinuationSeparatorMark(),
    new DXW.SeparatorMark(),
    new DXW.EndnoteReferenceMark(),
    new DXW.FootnoteReferenceMark(),
    new DXW.PageNumber(),
    new DXW.DayLong(),
    new DXW.DayShort(),
    new DXW.MonthLong(),
    new DXW.MonthShort(),
    new DXW.YearLong(),
    new DXW.YearShort(),
    new DXW.FieldChar() { FieldCharType = DXW.FieldCharValues.Begin },
    new DXW.FieldChar() { FieldCharType = DXW.FieldCharValues.Separate },
    new DXW.FieldChar() { FieldCharType = DXW.FieldCharValues.End },

    new DXW.Break() { Type = DXW.BreakValues.TextWrapping, Clear = new EnumValue<DXW.BreakTextRestartLocationValues>(DXW.BreakTextRestartLocationValues.Left)},
    new DXW.FieldChar() { FieldCharType = DXW.FieldCharValues.Begin, Dirty = true},
  };
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

  private static string BreakPageText =
    "<w:p w14:paraId=\"20A860B5\" w14:textId=\"15C3B12D\" w:rsidR=\"00AC7F04\" w:rsidRDefault=\"00AF29AF\" w:rsidP=\"00F043F7\">\r\n" +
    "  <w:r>\r\n" +
    "    <w:t xml:space=\"preserve\">This text is on one page.</w:t>\r\n" +
    "    <w:br w:type=\"page\"/>\r\n" +
    "    <w:t>And this is on another page.</w:t>\r\n" +
    "  </w:r>\r\n" +
    "</w:p>";
}