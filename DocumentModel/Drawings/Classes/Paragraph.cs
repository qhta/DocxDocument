namespace DocumentModel.Drawings;

/// <summary>
///   Text Paragraphs.
/// </summary>
public record Paragraph
{
  /// <summary>
  ///   Text Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }

  public Run? Run { get; set; }

  public Break? Break { get; set; }

  public Field? Field { get; set; }

  public Boolean? TextMath { get; set; }

  public EndParagraphRunProperties? EndParagraphRunProperties { get; set; }
}