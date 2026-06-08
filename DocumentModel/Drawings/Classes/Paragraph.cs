namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text IParagraphs.
/// </summary>
public class IParagraph: ModelElement
{
  /// <summary>
  ///   Text IParagraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }

  public Run? Run { get; set; }

  public IBreak? IBreak { get; set; }

  public IField? IField { get; set; }

  public bool? TextMath { get; set; }

  public EndParagraphRunProperties? EndParagraphRunProperties { get; set; }
}
