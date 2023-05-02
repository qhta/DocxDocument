namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ParagraphBorders Class.
/// </summary>
public class ParagraphBorders: ModelElement
{
  /// <summary>
  ///   Paragraph Border Above Identical Paragraphs.
  /// </summary>
  public Border? TopBorder { get; set; }

  /// <summary>
  ///   Left Paragraph Border.
  /// </summary>
  public Border? LeftBorder { get; set; }

  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public Border? BottomBorder { get; set; }

  /// <summary>
  ///   Right Paragraph Border.
  /// </summary>
  public Border? RightBorder { get; set; }

  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  public Border? BetweenBorder { get; set; }

  /// <summary>
  ///   Paragraph Border Between Facing Pages.
  /// </summary>
  public Border? BarBorder { get; set; }
}