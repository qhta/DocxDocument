using System;

namespace Qhta.OpenXmlTools;

/// <summary>
/// A composite tool for cleaning a Wordprocessing document.
/// </summary>
public partial class DocumentCleaner
{
  /// <summary>
  /// Determines the level of verbosity of the cleaner.
  /// </summary>
  public int VerboseLevel { get; set; }

  /// <summary>
  /// Determines the font used for examples.
  /// </summary>
  public string ExampleFont { get; set; } = "Consolas";

  public string XmlExampleStyle { get; set; } = "XmlExample";

  public string XmlExampleStyleDef { get; set; } = 
    "<w:style xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" w:type=\"paragraph\" w:customStyle=\"1\" w:styleId=\"XmlExample\">" +
    "  <w:name w:val=\"XmlExample\"/>" +
    "  <w:basedOn w:val=\"Normal\"/>" +
    "  <w:qFormat/>" +
    "  <w:rsid w:val=\"00006BC1\"/>" +
    "  <w:pPr>" +
    "    <w:spacing w:after=\"5\" w:line=\"270\" w:lineRule=\"auto\"/>" +
    "    <w:ind w:left=\"480\" w:right=\"119\" w:hanging=\"480\"/>" +
    "  </w:pPr>" +
    "  <w:rPr>" +
    "    <w:rFonts w:ascii=\"Consolas\"/>" +
    "    <w:noProof/>" +
    "  </w:rPr>" +
    "</w:style>";

  /// <summary>
  /// Cleans the document using all the methods available.
  /// </summary>
  /// <param name="fileName"></param>
  public void CleanDocument(string fileName)
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
        CleanDocument(wordDoc);
      }
      finally
      {
        wordDoc.Dispose();
      }
  }

  /// <summary>
  /// Cleans the document using all the methods available.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void CleanDocument(DXPack.WordprocessingDocument wordDoc)
  {
    RemoveProofErrors(wordDoc);
    TrimParagraphs(wordDoc, TrimOptions.TrimEnd);
    NormalizeWhitespaces(wordDoc, WsMode.Reduce, TrimOptions.TrimEnd);
    RemoveEmptyParagraphs(wordDoc, true);
    RemoveFakeHeadersAndFooters(wordDoc);
    ResetHeadingsFormat(wordDoc);
    ReplaceSymbolEncoding(wordDoc);
    FixParagraphNumbering(wordDoc);
    FixKnownProofErrors(wordDoc);

    FixInternalTables(wordDoc);
    JoinAdjacentTables(wordDoc);
    FixDividedTables(wordDoc);
    FixTablesWithEmptyCells(wordDoc);
    //FixFakeTables(wordDoc);
    CreateTablesFromTabs(wordDoc);

    JoinAdjacentRuns(wordDoc);
    FixLongWords(wordDoc);
    RepairXmlExamples(wordDoc);
    JoinDividedSentences(wordDoc);
    JoinParagraphsInFirstColumn(wordDoc);
    BreakParagraphsBefore(wordDoc, "Namespace:");
    BreakParagraphsBefore(wordDoc, "end note]");
    BreakParagraphsBefore(wordDoc, "end example]");
    FormatTables(wordDoc);
    //SetStyleNames(wordDoc);
  }

  /// <summary>
  /// Trims all the paragraphs in the document removing ending whitespaces.
  /// </summary>
  /// <param name="wordDoc"></param>
  /// <param name="options"></param>
  public void TrimParagraphs(DXPack.WordprocessingDocument wordDoc, TrimOptions options)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nTrimming paragraphs");
    var body = wordDoc.GetBody();
    var count = body.TrimParagraphs(options);
    var headers = wordDoc.GetHeaders().ToList();
    foreach (var header in headers)
    {
      count += header.TrimParagraphs(options);
    }
    var footers = wordDoc.GetFooters().ToList();
    foreach (var footer in wordDoc.GetFooters())
    {
      count += footer.TrimParagraphs(options);
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} paragraphs trimmed.");
  }

  /// <summary>
  /// Normalize whitespaces in the document
  /// </summary>
  /// <param name="wordDoc"></param>
  /// <param name="mode"></param>
  /// <param name="trimOptions"></param>
  public void NormalizeWhitespaces(DXPack.WordprocessingDocument wordDoc, WsMode mode, TrimOptions trimOptions)
  {
    var whitespaceOptions = new WhitespaceOptions(mode, trimOptions);
    if (VerboseLevel > 0)
      Console.WriteLine("\nNormalizing whitespaces");
    var body = wordDoc.GetBody();
    var count = body.NormalizeWhitespaces(whitespaceOptions);
    var headers = wordDoc.GetHeaders().ToList();
    foreach (var header in headers)
    {
      count += header.NormalizeWhitespaces(whitespaceOptions);
    }
    var footers = wordDoc.GetFooters().ToList();
    foreach (var footer in wordDoc.GetFooters())
    {
      count += footer.NormalizeWhitespaces(whitespaceOptions);
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} paragraphs normalized.");
  }

  /// <summary>
  /// Removes all the empty paragraphs from the document.
  /// </summary>
  /// <param name="wordDoc"></param>
  /// <param name="allDescendants">should remove in all descendants or at children level only</param>
  public void RemoveEmptyParagraphs(DXPack.WordprocessingDocument wordDoc, bool allDescendants)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nRemoving empty paragraphs");
    var body = wordDoc.GetBody();
    var count = body.RemoveEmptyParagraphs(allDescendants);
    var headers = wordDoc.GetHeaders().ToList();
    foreach (var header in headers)
    {
      count += header.RemoveEmptyParagraphs(allDescendants);
    }
    var footers = wordDoc.GetFooters().ToList();
    foreach (var footer in wordDoc.GetFooters())
    {
      count += footer.RemoveEmptyParagraphs(allDescendants);
    }
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} paragraphs removed.");
  }

  /// <summary>
  /// Joins adjacent tables that have the same number of columns.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void JoinAdjacentRuns(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nJoining adjacent runs");
    var body = wordDoc.GetBody();
    var count = body.JoinAdjacentRuns();
    foreach (var header in wordDoc.GetHeaders().ToList())
      count += header.JoinAdjacentRuns();
    foreach (var footer in wordDoc.GetFooters().ToList())
      count += footer.JoinAdjacentRuns();
    if (VerboseLevel > 0)
      Console.WriteLine($"  {count} runs appended to previous ones");
  }

  /// <summary>
  /// Insert an optional hyphens into long words, especially URL's.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void FixLongWords(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nFixing long words");
    var body = wordDoc.GetBody();
    var count = body.FixLongWords();
    foreach (var header in wordDoc.GetHeaders().ToList())
      count += header.FixLongWords();
    foreach (var footer in wordDoc.GetFooters().ToList())
      count += footer.FixLongWords();
    if (VerboseLevel > 0)
      Console.WriteLine($" {count} words fixed.");
  }

  /// <summary>
  /// Removes paragraphs that are same as headers or footers but are contained in body.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void RemoveFakeHeadersAndFooters(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nRemoving fake header/footer paragraphs");
    var removed = 0;
    HashSet<string> headers = new();
    var allHeaders = wordDoc.GetHeaders().Select(h => h.GetText(TextOptions.PlainText)).ToArray();
    foreach (var str in allHeaders)
    {
      str.TryRemoveNumbering(out var s);
      s = s.RemoveWhitespaces();
      if (s.Length > 0 && !s.IsNumber())
        headers.Add(s);
    }
    var allFooters = wordDoc.GetFooters().Select(f => f.GetText(TextOptions.PlainText)).ToArray();
    foreach (var str in allFooters)
    {
      str.TryRemoveNumbering(out var s);
      s = s.RemoveWhitespaces();
      if (s.Length > 0 && !s.IsNumber())
        headers.Add(s);
    }
    var body = wordDoc.GetBody();
    var headings1 = body.Elements<DXW.Paragraph>().Where(p => p.HeadingLevel() == 1)
      .Select(h => h.GetText(TextOptions.PlainText)).ToList();
    foreach (var str in headings1)
    {
      str.TryRemoveNumbering(out var s);
      s = s.RemoveWhitespaces();
      if (s.Length > 0 && !s.IsNumber())
        headers.Add(s);
    }
    var paragraphs = body.Elements<DXW.Paragraph>().Where(p => !p.IsHeading()).ToList();
    foreach (var paragraph in paragraphs)
    {
      var str = paragraph.GetText(TextOptions.PlainText);
      var ss = str.Split('\t');
      foreach (var s in ss)
      {
        s.TryRemoveNumbering(out var s1);
        if (headers.Contains(s1))
        {
          paragraph.Remove();
          removed++;
          break;
        }
      }
    }
    if (VerboseLevel > 0)
      Console.WriteLine($"  {removed} paragraphs removed");
  }

  /// <summary>
  /// Join sentences that are divided into multiple paragraphs.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void JoinDividedSentences(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nJoining divided sentences");
    var body = wordDoc.GetBody();
    var count = JoinDividedSentences(body);
    foreach (var header in wordDoc.GetHeaders().ToList())
      count += JoinDividedSentences(header);
    foreach (var footer in wordDoc.GetFooters().ToList())
      count += JoinDividedSentences(footer);
    if (VerboseLevel > 0)
      Console.WriteLine($"  {count} sentences joined");
  }

  /// <summary>
  /// Resets format of heading paragraphs.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void ResetHeadingsFormat(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nResetting headings format");
    var reset = 0;
    var body = wordDoc.GetBody();
    var paragraphs = body.Elements<DXW.Paragraph>().Where(p => p.IsHeading()).ToList();
    foreach (var paragraph in paragraphs)
    {
      if ((paragraph.TryResetFormat(true)))
        reset++;
    }
    if (VerboseLevel > 0)
      Console.WriteLine($"  {reset} paragraphs format reset");
  }



  /// <summary>
  /// Replace characters with a code between F000 and F0DD to corresponding unicode characters according to the symbol encoding.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void ReplaceSymbolEncoding(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nReplacing symbol encoding characters with Unicode");
    var body = wordDoc.GetBody();
    var count = body.ReplaceSymbolEncoding();
    foreach (var header in wordDoc.GetHeaders())
      count += body.ReplaceSymbolEncoding();
    foreach (var footer in wordDoc.GetFooters())
      count += body.ReplaceSymbolEncoding();
    if (VerboseLevel > 0)
      Console.WriteLine($"  {count} symbols replaced");
  }

  
  /// <summary>
  /// Find paragraphs that have the font of XML examples and track XML start and end tags.
  /// Each start tag should begin the paragraph and each end tag should be placed in a separate line.
  /// If a paragraph does not begin with a start tag, its content is moved to the previous paragraph.
  /// Whitespaces are normalized.
  /// Embedded XML tags are indented by adding two spaces on left.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void RepairXmlExamples(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nRepairing XML examples");
    int count = 0;
    var paragraphs = wordDoc.GetBody().Descendants<DXW.Paragraph>().ToList();
    //int xmlIndent = 0;
    for (int i = 0; i < paragraphs.Count; i++)
    {
      var paragraph = paragraphs[i];

      var font = paragraph.GetFont("defaultFont");
      if (font != ExampleFont)
        continue;

      var text = paragraph.GetText(TextOptions.PlainText);

      var indent = text.LeftIndentLength();
      if (IsXmlExample(text))
      {
        NormalizeXmlParagraph(paragraph, indent);
      }
      text = paragraph.GetText(TextOptions.PlainText);
      indent = text.LeftIndentLength();
      if (indent < text.Length && text[indent] != '<')
      { // if the paragraph does not start with an XML tag, append its content to the previous paragraph.
        var priorParagraph = paragraph.PreviousSibling<DXW.Paragraph>();
        if (priorParagraph != null && priorParagraph.GetText(TextOptions.PlainText).Trim().StartsWith("<"))
        {
          var priorText = priorParagraph.GetText(TextOptions.PlainText);
          text = text.Trim();
          if (!priorText.EndsWith(" "))
            text = " " + text;
          priorParagraph.AppendText(text);
          paragraph.Remove();
          paragraphs.RemoveAt(i);
          i -= 2;
          if (i < 0)
            i = 0;
          count++;
        }

      }
      else if (text.Length > indent + 1)
      {
        var k = text.IndexOf("<", indent + 1);
        if (k != -1)
        {
          if (k > 0 && k < text.Length - 1 && (text[k + 1] == '/' && text[k - 1] == ' ' || char.IsLetter(text[k + 1])))
          {
            // if the paragraph contains an XML tag but not in the beginning, split it to a new paragraph.
            //Console.WriteLine(text);
            var newParagraph = paragraph.SplitAt(k);
            paragraph.TrimEnd();
            if (newParagraph != null)
            {
              var firstRun = newParagraph.Elements<DXW.Run>().FirstOrDefault();
              if (firstRun != null)
              {
                firstRun.SetText(new String(' ', indent) + firstRun.GetText(TextOptions.PlainText));
              }
              var spacing = paragraph.GetParagraphProperties().GetSpacingBetweenLines();
              spacing.After = "8";
              paragraph.InsertAfterSelf(newParagraph);
              paragraphs.Add(newParagraph);
            }
            i--;
            count++;
            if (i < 0)
              i = 0;
          }
          else
          {
            //NormalizeXmlParagraph(paragraph, indent);
          }
        }
        else
        {
          //NormalizeXmlParagraph(paragraph, indent);
        }
      }
    }

    if (VerboseLevel > 0)
      Console.WriteLine($"  {count} XML paragraphs repaired");
  }

  public void SetStyleNames(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nSetting styles");
    var styles = wordDoc.GetStyles();
    if (styles.GetStyle(XmlExampleStyle) == null)
    {
      styles.AddChild(new DXW.Style(XmlExampleStyleDef));
    }
    
    int paragraphStyleCount = 0;
    var paragraphs = wordDoc.GetBody().Descendants<DXW.Paragraph>().ToList();
    for (int i = 0; i < paragraphs.Count; i++)
    {
      var paragraph = paragraphs[i];
      var paraText = paragraph.GetText(TextOptions.ParaText).Trim();
      var font = paragraph.GetFont("defaultFont");
      if (font == ExampleFont )
      {
        //if (paraText.Contains("<w:") || paraText.Contains("</w:"))
        {
          paragraph.SetStyle(XmlExampleStyle);
          paragraphStyleCount++;
        }
      }
    }

    if (VerboseLevel > 0)
      Console.WriteLine($"  {paragraphStyleCount} Paragraph styles set");
  }

}