namespace DocumentModel.Drawings;

/// <summary>
///   Represents a text paragraph, including properties, runs, breaks, fields, math, and end run formatting.
/// </summary>
public interface Paragraph
{
  /// <summary>
  ///   Properties for the text paragraph.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }

  /// <summary>
  ///   Text run within the paragraph.
  /// </summary>
  public Run? Run { get; set; }

  /// <summary>
  ///   Line break within the paragraph.
  /// </summary>
  public Break? Break { get; set; }

  /// <summary>
  ///   Field element within the paragraph.
  /// </summary>
  public Field? Field { get; set; }

  /// <summary>
  ///   Indicates whether the paragraph contains mathematical text.
  /// </summary>
  public bool? TextMath { get; set; }

  /// <summary>
  ///   Formatting properties for the last run in the paragraph.
  /// </summary>
  public EndParagraphRunProperties? EndParagraphRunProperties { get; set; }
}