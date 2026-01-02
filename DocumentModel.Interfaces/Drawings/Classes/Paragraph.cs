namespace DocumentModel.Drawings;

/// <summary>
///   Text Paragraphs.
/// </summary>
public class Paragraph: ModelElement
{
  /// <summary>
  ///   Text Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }
  public Run? Run { get; set; }
  public Break? Break { get; set; }
  public Field? Field { get; set; }
  public bool? TextMath { get; set; }
  public EndParagraphRunProperties? EndParagraphRunProperties { get; set; }
}