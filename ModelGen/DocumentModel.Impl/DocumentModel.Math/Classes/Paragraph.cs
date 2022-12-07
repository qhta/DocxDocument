namespace DocumentModel.Math;

/// <summary>
/// Defines the Paragraph Class.
/// </summary>
public class ParagraphImpl: ModelElement<DocumentFormat.OpenXml.Math.Paragraph>, Paragraph
{
  /// <summary>
  /// Office Math Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties
  {
    get;
    set;
  }
  
}
