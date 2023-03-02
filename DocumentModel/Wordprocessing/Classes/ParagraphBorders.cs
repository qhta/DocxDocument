namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ParagraphBorders Class.
/// </summary>
public record ParagraphBorders
{
  /// <summary>
  ///   Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public BorderType? TopBorder { get; set; }

  /// <summary>
  ///   Left Paragraph Border.
  /// </summary>
  public BorderType? LeftBorder { get; set; }

  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public BorderType? BottomBorder { get; set; }

  /// <summary>
  ///   Right Paragraph Border.
  /// </summary>
  public BorderType? RightBorder { get; set; }

  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public BorderType? BetweenBorder { get; set; }

  /// <summary>
  ///   Paragraph Border Between Facing Pages.
  /// </summary>
  public BorderType? BarBorder { get; set; }
}