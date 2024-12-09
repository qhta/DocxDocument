using System;

namespace Qhta.OpenXmlTools;

public partial class DocumentCleaner
{
  /// <summary>
  /// Converts all anchors to inline graphics
  /// </summary>
  /// <param name="body"></param>
  /// <returns></returns>
  public int ConvertAnchorsToInline(DX.OpenXmlCompositeElement body)
  {
    var count = 0;
    var anchors = body.Descendants<DXDW.Anchor>().ToList();
    foreach (var anchor in anchors)
    {

      if (anchor.AnchorId?.Value == "6DCB9116")
        Debug.Assert(true);
      var drawing = anchor.Parent as DXW.Drawing;
      if (drawing is null)
        continue;
      var drawingRun = drawing.Parent as DXW.Run;
      if (drawingRun is null)
      {
        if (drawing.Parent is DX.AlternateContentChoice choice)
        {
          if (choice.Parent is DX.AlternateContent alternateContent)
          {
            drawingRun = alternateContent.Parent as DXW.Run;
            if (drawingRun is not null)
            {
              drawing.Remove();
              if (drawingRun.NextSibling() is DXW.Run nextRun && nextRun.HasTabChar())
              {
                if (nextRun.IsTabChar())
                  nextRun.Remove();
                if (nextRun.GetMembers().FirstOrDefault() is DXW.TabChar nextTabChar)
                  nextTabChar.Remove();
              }
              drawingRun.ReplaceChild(drawing, alternateContent);
            }
          }
        }
      }
      if (drawingRun is null)
        continue;
      var paragraph = drawingRun.Parent as DXW.Paragraph;
      if (paragraph is null)
        continue;
      var paraText = paragraph.GetText();
      var targetParagraph = paragraph;
      var nextParagraph = paragraph.NextSibling() as DXW.Paragraph;
      if (nextParagraph != null)
      {
        targetParagraph = nextParagraph;
        var nextParaText = nextParagraph.GetText();
        var nextNextParagraph = nextParagraph.NextSibling() as DXW.Paragraph;
        var nextNextParaText = nextNextParagraph?.GetText();
        if (nextNextParaText != null)
          if (nextParaText.EndsWith(TextOptions.ParaText.DrawingSubstituteTag) && !nextNextParaText.EndsWith(TextOptions.ParaText.DrawingSubstituteTag))
            targetParagraph = nextNextParagraph;
      }
      var inline = anchor.ConvertAnchorToInline();
      drawing.Anchor = null;
      drawing.Inline = inline;
      if (targetParagraph != null)
      {
        var targetParaText = targetParagraph.GetText();
        var lastRun = targetParagraph.Elements<DXW.Run>().LastOrDefault();
        if (lastRun != null)
        {
          var lastRunMember = lastRun.GetMembers().LastOrDefault();
          if (lastRunMember is not DXW.TabChar)
          {
            lastRun.Append(new DXW.TabChar());
          }
        }
        drawingRun.Remove();
        targetParagraph!.Append(drawingRun);
        paragraph.SetSpacingAfter(0, null, null);
        if (drawing.NextSibling() is DXW.TabChar nextTabChar)
          nextTabChar.Remove();
        count++;
      }
    }
    return count;
  }

  /// <summary>
  /// Converts floating pictures to inline graphics
  /// </summary>
  /// <param name="body"></param>
  /// <returns></returns>
  public int ConvertFloatingPicturesToInline(DX.OpenXmlCompositeElement body)
  {
    var count = 0;
    var pictures = body.Descendants<DXW.Picture>().ToList();
    foreach (var picture in pictures)
    {
      if (picture.Parent is DX.AlternateContentFallback)
      {
        picture.Parent.Remove();
        count++;
        continue;
      }
      Debug.Assert(true);
      var drawing = picture.Parent as DXW.Drawing;
      if (drawing is not null)
        continue;
      var drawingRun = picture.Parent as DXW.Run;
      if (drawingRun is null)
        continue;
      var paragraph = drawingRun.Parent as DXW.Paragraph;
      if (paragraph is null)
        continue;
      var newPicture = picture.ConvertFloatingPictureToInlinePicture();
      if (newPicture is null)
        continue;
      //drawing.Anchor = null;
      //drawing.Inline = newPicture;
      //var nextParagraph = paragraph.NextSibling() as DXW.Paragraph;
      //var targetParagraph = nextParagraph;
      //if (nextParagraph is null)
      //{
      //  targetParagraph = paragraph;
      //}
      //if (targetParagraph != null)
      //{
      //  var textOptions = TextOptions.ParaText;
      //  var targetParaText = targetParagraph.GetText(textOptions);
      //  //Debug.WriteLine($"Target Para is \"{targetParaText}\"");
      //  DXW.TabChar? tabChar = null;
      //  var targetParaMembers = targetParagraph.GetFlattenedMemberList();
      //  if (targetParaMembers.Any())
      //  {
      //    var firstMember = targetParaMembers.FirstOrDefault();
      //    var firstTabCharIndex = -1;
      //    if (firstMember is DXW.TabChar tabChar1)
      //    {
      //      tabChar = tabChar1;
      //      firstTabCharIndex = 1;
      //    }
      //    if (firstMember is DXW.Drawing drawing1 && targetParaMembers.Count >= 2 && targetParaMembers[1] is DXW.TabChar tabChar2)
      //    {
      //      tabChar = tabChar2;
      //      firstTabCharIndex = 2;
      //    }
      //    for (int i = firstTabCharIndex + 1; i < targetParaMembers.Count; i++)
      //    {
      //      if (targetParaMembers[i] is DXW.TabChar tabChar3)
      //      {
      //        tabChar = tabChar3;
      //        break;
      //      }
      //    }
      //  }
      //  if (tabChar != null)
      //  {
      //    var newParagraph = targetParagraph.SplitAfter(tabChar);
      //    if (newParagraph != null)
      //      targetParagraph.InsertAfterSelf(newParagraph);

      //  }
      //  var lastRun = targetParagraph.Elements<DXW.Run>().LastOrDefault();
      //  if (lastRun != null)
      //  {
      //    var lastRunMember = lastRun.GetMembers().LastOrDefault();
      //    if (lastRunMember is not DXW.TabChar)
      //    {
      //      lastRun.Append(new DXW.TabChar());
      //    }
      //  }
      //  drawingRun.Remove();
      //  targetParagraph!.Append(drawingRun);
      //  paragraph.SetSpacingAfter(0, null, null);
      //  count++;
      //}
    }
    return count;
  }

  /// <summary>
  /// Find inline elements in the paragraph and split the paragraph after them.
  /// </summary>
  /// <param name="body"></param>
  public void SplitParagraphsAfterInlines(DX.OpenXmlCompositeElement body)
  {
    foreach (var inline in body.Descendants<DXDW.Inline>().ToList())
    {
      if (inline.AnchorId?.Value == "3182668E")
        Debug.Assert(true);
      var run = inline.GetParent<DXW.Run>();
      if (run is null)
        continue;
      if (run.Parent is not DXW.Paragraph paragraph)
        continue;
      if (run.PreviousSiblingMember() == null)
        continue;
      if (run.NextSibling() == null
          || run.NextSibling() is DXW.Run nextRun && String.IsNullOrWhiteSpace(nextRun.GetText(TextOptions.PlainText)))
        continue;
      var paragraphText = paragraph.GetText();
      var newParagraph = paragraph.SplitAfter(run);
      if (newParagraph != null)
      {
        newParagraph.TrimStart();
        if (VerboseLevel==2)
          Debug.WriteLine($"Split paragraph to \"{paragraph.GetText()}\" and \"{newParagraph.GetText()}\"");
        paragraph.InsertAfterSelf(newParagraph);
      }
    }
  }

  /// <summary>
  /// Find inline elements that are at the beginning of the paragraph and join the paragraph with the previous one.
  /// </summary>
  /// <param name="body"></param>
  public void JoinParagraphsWithNextInlines(DX.OpenXmlCompositeElement body)
  {
    foreach (var inline in body.Descendants<DXDW.Inline>().ToList())
    {
      //if (inline.AnchorId?.Value != "01FCA715")
      //  continue;
      var run = inline.GetParent<DXW.Run>();
      if (run is null)
        continue;
      if (run.Parent is not DXW.Paragraph paragraph)
        continue;
      var previousSibling = run.PreviousSiblingMember();
      while (previousSibling != null && previousSibling is DXW.Run previousRun
                                     && String.IsNullOrWhiteSpace(previousRun.GetText(TextOptions.PlainText)))
        previousSibling = previousSibling.PreviousSiblingMember();
      if (previousSibling is not null && previousSibling is not DXW.ParagraphProperties)
        continue;
      //if (run.NextSiblingMember() == null
      //    || run.NextSiblingMember() is DXW.Run nextRun && String.IsNullOrWhiteSpace(nextRun.GetText(TextOptions.PlainText)))
      //  continue;
      var paragraphText = paragraph.GetText();
      var priorParagraph = paragraph.PreviousSiblingMember() as DXW.Paragraph;
      if (priorParagraph == null)
        continue;
      if (VerboseLevel == 2)
        Debug.WriteLine($"Join paragraphs \"{priorParagraph.GetText()}\" and \"{paragraph.GetText()}\"");
      priorParagraph.JoinNextParagraph(paragraph);
      if (VerboseLevel == 2)
        Debug.WriteLine($"             to \"{priorParagraph.GetText()}\"");
    }
  }

  /// <summary>
  /// Find colons with no following drawings in the paragraphs and split the paragraphs after them.
  /// </summary>
  /// <param name="body"></param>
  public int SplitParagraphsAfterColonsWithNoFollowingDrawings(DX.OpenXmlCompositeElement body)
  {
    var count = 0;
    foreach (var paragraph in body.Descendants<DXW.Paragraph>())
    {
      if (TrySplitParagraphAfterColonWithNoFollowingDrawings(paragraph))
        count++;
    }
    return count;
  }

  /// <summary>
  /// Find colon with no following drawings in the paragraph and split the paragraph after them.
  /// </summary>
  /// <param name="paragraph"></param>
  public bool TrySplitParagraphAfterColonWithNoFollowingDrawings(DXW.Paragraph paragraph)
  {
    var paragraphText = paragraph.GetText(TextOptions.ParaText);
    var k = paragraphText.IndexOf(':');
    if (k > 0 && k < paragraphText.Length - 1)
    {
      var leadText = paragraphText.Substring(0, k + 1).TrimEnd();
      if (!leadText.Contains("["))
      {
        var tailText = paragraphText.Substring(k + 1);
        var tailText1 = tailText.TrimStart();
        var tailLead = tailText1 != "" ? tailText.Replace(tailText1, "") : "";
        if (!String.IsNullOrWhiteSpace(tailText1))
        {
          if (tailText1.StartsWith(TextOptions.ParaText.DrawingSubstituteTag))
          {
            if (!tailLead.Contains("\t"))
            {
              paragraph.InsertAt(k + 1, new DXW.TabChar(), TextOptions.ParaText);
              var paraText = paragraph.GetText(TextOptions.ParaText);
              if (VerboseLevel == 2)
                Debug.WriteLine($"Tab inserted to \"{paragraph.GetText()}\"");
            }
          }
          else
          {
            var newParagraph = paragraph.SplitAt(k + 1, TextOptions.ParaText);
            if (newParagraph != null)
            {
              newParagraph.TrimStart();
              if (VerboseLevel == 2) 
                Debug.WriteLine($"Split paragraph to \"{paragraph.GetText()}\" and \"{newParagraph.GetText()}\"");
              paragraph.InsertAfterSelf(newParagraph);
            }
          }
        }
      }
    }
    return false;
  }
}