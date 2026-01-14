namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the border settings for a paragraph in a WordprocessingML document.
/// This interface provides properties for configuring borders on all sides of a paragraph, as well as between identical paragraphs and between facing pages, enabling advanced formatting and visual separation of paragraph content.
/// </summary>
public class ParagraphBorders: ModelElement
{
  /// <summary>
  /// Border above identical paragraphs, specifying the top border of the paragraph.
  /// </summary>
  public Border? TopBorder { get; set; }

  /// <summary>
  /// Left border of the paragraph.
  /// </summary>
  public Border? LeftBorder { get; set; }

  /// <summary>
  /// Border between identical paragraphs, specifying the bottom border of the paragraph.
  /// </summary>
  public Border? BottomBorder { get; set; }

  /// <summary>
  /// Right border of the paragraph.
  /// </summary>
  public Border? RightBorder { get; set; }

  /// <summary>
  /// Border between identical paragraphs, used to visually separate consecutive paragraphs with the same formatting.
  /// </summary>
  public Border? BetweenBorder { get; set; }

  /// <summary>
  /// Border between facing pages, specifying a vertical bar border for the paragraph.
  /// </summary>
  public Border? BarBorder { get; set; }
}