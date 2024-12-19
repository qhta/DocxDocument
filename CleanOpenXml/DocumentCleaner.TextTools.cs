using System;

namespace Qhta.OpenXmlTools;

public partial class DocumentCleaner
{
  /// <summary>
  /// Join sentences divided between adjacent paragraphs.
  /// </summary>
  /// <param name="body">Processed body</param>
  /// <returns>number of joins</returns>
  public int JoinDividedSentences(DX.OpenXmlCompositeElement body)
  {
    int count = 0;
    var paragraphs = body.Descendants<DXW.Paragraph>().ToList();
    for (int paraNdx = 0; paraNdx < paragraphs.Count; paraNdx++)
    {
      var para = paragraphs[paraNdx];
      var font = para.GetFont(null);
      if (font == ExampleFont)
        continue;
      var priorPara = para.PreviousSiblingMember() as DXW.Paragraph;
      var paraText = para.GetText(TextOptions.ParaText).Trim();
      if (paraText == "end note]" || paraText == "end example]" || paraText == "the results are:")
        continue;
      if (priorPara == null)
        continue;
      font = priorPara.GetFont(null);
      if (font == ExampleFont)
        continue;
      var priorParaText = priorPara.GetText(TextOptions.ParaText).Trim();
      var priorSentences = priorParaText.GetSentences();
      var lastSentence = priorSentences.LastOrDefault() ?? priorParaText;

      var lastChar = lastSentence.LastOrDefault();
      if ((char.IsUpper(lastSentence.FirstOrDefault()) && !".!?:".Contains(lastChar) &&
          char.IsLower(paraText.FirstOrDefault()))
        || lastSentence.TrimEnd().EndsWith(" and") || lastSentence.TrimEnd().EndsWith(" or"))
      {
        if (VerboseLevel == 2)
          Debug.WriteLine($"Join \"{priorParaText}\" & \"{paraText}\"");
        priorPara.JoinNextParagraph(para);
        para.Remove();
        count++;
      }
    }
    return count;
  }


  /// <summary>
  /// Check if the text contains an XML example.
  /// </summary>
  /// <param name="text"></param>
  /// <returns></returns>
  private bool IsXmlExample(string text)
  {
    var k = text.IndexOf('<');
    if (k == -1)
      return false;
    if (k < text.Length - 1 && (text[k + 1] == '/' || char.IsLetter(text[k + 1])))
      return true;
    return false;
  }

  /// <summary>
  /// Normalize the whitespaces in the XML paragraph. Keep the spaces indentation.
  /// Set paragraph indent to the specified value of characters (plus two).
  /// </summary>
  /// <param name="paragraph"></param>
  /// <param name="indent"></param>
  private void NormalizeXmlParagraph(DXW.Paragraph paragraph, int indent)
  {
    var options = TextOptions.FullText;
    var text = paragraph.GetText(options);
    var newText = text.NormalizeWhitespaces();
    var newIndent = newText.LeftIndentLength();
    if (newIndent < indent)
      newText = new String(' ', indent - newIndent) + newText;
    paragraph.SetText(newText, options);
    var indentation = paragraph.GetIndentation();
    var left = indentation.GetLeft() ?? 0;
    var hanging = ((indent + 2) * 12 * 20);
    var newLeft = hanging;
    indentation.SetLeft(newLeft);
    indentation.SetHanging(hanging);
  }
}