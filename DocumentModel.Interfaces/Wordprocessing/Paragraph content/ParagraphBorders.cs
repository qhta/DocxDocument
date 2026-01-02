namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ParagraphBorders Class.
/// </summary>
public class ParagraphBorders: ModelElement
{
  /// <summary>
  ///   Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public IBorder? TopBorder { get; set; }
  /// <summary>
  ///   Left Paragraph Border.
  /// </summary>
  public IBorder? LeftBorder { get; set; }
  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public IBorder? BottomBorder { get; set; }
  /// <summary>
  ///   Right Paragraph Border.
  /// </summary>
  public IBorder? RightBorder { get; set; }
  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public IBorder? BetweenBorder { get; set; }
  /// <summary>
  ///   Paragraph Border Between Facing Pages.
  /// </summary>
  public IBorder? BarBorder { get; set; }
}