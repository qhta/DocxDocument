namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Paragraph Class.
/// </summary>
public class ParagraphImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Paragraph>, Paragraph
{
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties
  {
    get;
    set;
  }
  
}
