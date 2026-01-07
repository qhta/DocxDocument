namespace DocumentModel.Drawings;

/// <summary>
///   Represents a list style, including default and per-level paragraph formatting for multi-level lists.
/// </summary>
public interface ListStyle : ExtendableElement
{
  /// <summary>
  ///   Default paragraph style for the list.
  /// </summary>
  public ParagraphProperties? DefaultParagraphProperties { get; set; }

  /// <summary>
  ///   Paragraph style for list level 1.
  /// </summary>
  public ParagraphProperties? Level1ParagraphProperties { get; set; }

  /// <summary>
  ///   Paragraph style for list level 2.
  /// </summary>
  public ParagraphProperties? Level2ParagraphProperties { get; set; }

  /// <summary>
  ///   Paragraph style for list level 3.
  /// </summary>
  public ParagraphProperties? Level3ParagraphProperties { get; set; }

  /// <summary>
  ///   Paragraph style for list level 4.
  /// </summary>
  public ParagraphProperties? Level4ParagraphProperties { get; set; }

  /// <summary>
  ///   Paragraph style for list level 5.
  /// </summary>
  public ParagraphProperties? Level5ParagraphProperties { get; set; }

  /// <summary>
  ///   Paragraph style for list level 6.
  /// </summary>
  public ParagraphProperties? Level6ParagraphProperties { get; set; }

  /// <summary>
  ///   Paragraph style for list level 7.
  /// </summary>
  public ParagraphProperties? Level7ParagraphProperties { get; set; }

  /// <summary>
  ///   Paragraph style for list level 8.
  /// </summary>
  public ParagraphProperties? Level8ParagraphProperties { get; set; }

  /// <summary>
  ///   Paragraph style for list level 9.
  /// </summary>
  public ParagraphProperties? Level9ParagraphProperties { get; set; }
}