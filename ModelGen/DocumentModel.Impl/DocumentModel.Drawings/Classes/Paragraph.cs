namespace DocumentModel.Drawings;

/// <summary>
/// Text Paragraphs.
/// </summary>
public class ParagraphImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Paragraph>, Paragraph
{
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties
  {
    get;
    set;
  }
  
  public EndParagraphRunProperties? EndParagraphRunProperties
  {
    get;
    set;
  }
  
}
