using System;

using DocumentFormat.OpenXml.Wordprocessing;

namespace Qhta.OpenXmlTools;

/// <summary>
/// A composite tool for cleaning a Wordprocessing document.
/// </summary>
public partial class DocumentCleaner
{

  /// <summary>
  /// Detect paragraphs that contain a bullet and enter a new paragraph with bullet numbering.
  /// </summary>
  /// <param name="wordDoc"></param>
  public void FixParagraphNumbering(DXPack.WordprocessingDocument wordDoc)
  {
    if (VerboseLevel > 0)
      Console.WriteLine("\nRepairing paragraphs numbering");
    var body = wordDoc.GetBody();
    var bulleted = FixParagraphsWithBullets(body);
    var numbered = FixParagraphsWithNumbers(body);

    if (VerboseLevel > 0)
    {
      Console.WriteLine($"  {bulleted} paragraphs with bullet symbol fixed");
      Console.WriteLine($"  {numbered} paragraphs with numbering fixed");

    }
  }

  /// <summary>
  /// Fix paragraphs with bullets.
  /// If the paragraph starts with a bullet, the bullet is removed and the paragraph is bulleted.
  /// If the paragraph contains a bullet inside text, the paragraph is divided and new paragraph is bulleted.
  /// </summary>
  /// <param name="body"></param>
  /// <returns></returns>
  public int FixParagraphsWithBullets(DX.OpenXmlCompositeElement body)
  {
    var numbering = body.GetMainDocumentPart()!.GetNumberingDefinitions();
    var abstractNumbering = body.FindMostFrequentBulletedAbstractNumbering();
    if (abstractNumbering == null)
      abstractNumbering = numbering.GetDefaultBulletedAbstractNumbering();

    int abstractNumId = abstractNumbering.AbstractNumberId!;
    var numberingStatistic = body.GetNumberingInstanceStatistics(abstractNumId);
    var numberingInstance = numberingStatistic.MostFrequent();
    DXW.ParagraphProperties? defaultParagraphProperties = null;
    if (numberingInstance != null)
      defaultParagraphProperties = numberingInstance.Parent as DXW.ParagraphProperties;
    if (defaultParagraphProperties == null)
    {
      if (numberingInstance == null)
      {
        numberingInstance = numbering.GetNumberingInstance(abstractNumId);
      }
      defaultParagraphProperties = new DXW.ParagraphProperties();
      defaultParagraphProperties.SetNumbering(numberingInstance.NumberID?.Value);
    }
    int count = 0;
    var paragraphs = body.Descendants<DXW.Paragraph>().ToList();
    for (int i = 0; i < paragraphs.Count; i++)
    {
      var paragraph = paragraphs[i];
      //var paraText = paragraph.GetInnerText();
      //if (paraText.Contains("Video (\u00a715.2.17)"))
      //  Debug.Assert(true);
      foreach (var run in paragraph.Elements<DXW.Run>())
      {
        var text = run.GetText(TextOptions.PlainText);
        if (text.Contains("•"))
        {
          var textItem = run.Descendants<DXW.Text>().FirstOrDefault(t => t.Text.TrimStart().StartsWith("•"));
          if (textItem == null)
            continue;
          textItem.Text = text.Replace("•", "");
          count++;
          DXW.Paragraph? bulletedParagraph = null;
          if (paragraph.IsBulleted())
            bulletedParagraph = paragraph;
          else
          {
            bulletedParagraph = paragraph.GetPreviousNumberedParagraph();
            if (bulletedParagraph == null)
              bulletedParagraph = paragraph.GetNextNumberedParagraph();
          }
          DXW.ParagraphProperties? numberingParagraphProperties =
            bulletedParagraph?.ParagraphProperties;
          if (numberingParagraphProperties == null)
            numberingParagraphProperties = defaultParagraphProperties;
          numberingParagraphProperties = (DXW.ParagraphProperties)numberingParagraphProperties.CloneNode(true);

          var prevSibling = run.PreviousSiblingMember();
          if (prevSibling != null &&
              !String.IsNullOrWhiteSpace((prevSibling as DXW.Run)?.GetText(TextOptions.PlainText)))
          {
            var newParagraph = new DXW.Paragraph();
            newParagraph.ParagraphProperties = numberingParagraphProperties;
            var tailItems = new List<DX.OpenXmlElement>();
            tailItems.Add(run);
            var siblingItem = run.NextSibling();
            while (siblingItem != null)
            {
              tailItems.Add(siblingItem);
              siblingItem = siblingItem.NextSibling();
            }
            foreach (var item in tailItems)
            {
              item.Remove();
              if (item is DXW.Run runItem && newParagraph.IsEmpty())
                runItem.TrimStart();
              newParagraph.Append(item);
            }
            paragraph.TrimEnd();
            newParagraph.TrimStart();
            newParagraph.TrimEnd();
            if (paragraph.IsEmpty())
            {
              numberingParagraphProperties?.Remove();
              paragraph.ParagraphProperties = numberingParagraphProperties;
              var priorParagraph = paragraph.PreviousSibling<DXW.Paragraph>();
              var after = priorParagraph?.ParagraphProperties?.SpacingBetweenLines?.After;
              if (after != null)
                paragraph.GetParagraphProperties().GetSpacingBetweenLines().After = after;
              foreach (var item in newParagraph.GetMembers())
              {
                item.Remove();
                paragraph.AppendChild(item);
              }
            }
            else
            {
              var priorParagraph = paragraph.PreviousSibling<DXW.Paragraph>();
              if (priorParagraph != null && priorParagraph.ParagraphProperties?.NumberingProperties != null)
                paragraph.ParagraphProperties =
                  (DXW.ParagraphProperties)priorParagraph.ParagraphProperties.CloneNode(true);
              newParagraph.TrimEnd();
              paragraph.InsertAfterSelf(newParagraph);
              paragraphs.Insert(i + 1, newParagraph);
              //if (paragraph.IsEmpty())
              //{
              //  paragraph.Remove();
              //  paragraphs.RemoveAt(i);
              //  i--;
              //}
            }
          }
          else // if it is the first run in the paragraph then do not create a new paragraph.
          {
            paragraph.ParagraphProperties = numberingParagraphProperties;
            paragraph.TrimStart();
            paragraph.TrimEnd();
            i--;
          }
        }
      }
    }
    return count;
  }


  /// <summary>
  /// Fix paragraphs with numbering.
  /// Numbering is a digit or a sequence of digits, a letter or two letters followed by a dot or closing parenthesis.
  /// If the paragraph starts with a numbering, the numbering is removed and the paragraph is numbered.
  /// </summary>
  /// <param name="body"></param>
  /// <returns></returns>
  public int FixParagraphsWithNumbers(DX.OpenXmlCompositeElement body)
  {
    var options = TextOptions.FullText;
    var numbering = body.GetMainDocumentPart()!.GetNumberingDefinitions();
    int count = 0;
    var paragraphs = body.Descendants<DXW.Paragraph>().ToList();
    for (int i = 0; i < paragraphs.Count; i++)
    {
      var paragraph = paragraphs[i];
      var paraText = paragraph.GetText(options);
      var numberingString = paraText.GetNumberingString();
      if (numberingString == null)
        continue;
      //if (paraText.Contains("Video (\u00a715.2.17)"))
      //  Debug.Assert(true);
      var run = paragraph.Elements<DXW.Run>().FirstOrDefault();
      if (run == null)
        continue;
      {
        var text = run.GetText(options);
        if (text.StartsWith(numberingString))
        {
          DXW.AbstractNum? abstractNumbering = null;
          DXW.Level? numLevel = null;
          foreach (var abstractNum in numbering.Elements<AbstractNum>().ToList())
          {
            foreach (var level in abstractNum.Elements<Level>().ToList())
            {
              if (level.IsCompatibleWith(numberingString))
              {
                abstractNumbering = abstractNum;
                numLevel = level;
                break;
              }
            }
          }
          if (abstractNumbering != null && numLevel != null)
          {
            var tailText = text.Substring(numberingString.Length).TrimStart();
            if (tailText.Length == 0)
              run.Remove();
            else
              run.SetText(tailText, TextOptions.FullText);
            paragraph.SetNumbering(abstractNumbering, numLevel);
            paragraph.TrimStart();
            count++;
          }
        }
      }
    }
    return count;
  }


}
