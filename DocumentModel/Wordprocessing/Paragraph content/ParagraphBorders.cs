namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ParagraphBorders Class.
/// </summary>
public class ParagraphBorders: ModelElement
{
  /// <summary>
  ///   IParagraph IBorder Above Identical IParagraphs.
  /// </summary>
  public IBorder? TopBorder { get; set; }

  /// <summary>
  ///   Left IParagraph IBorder.
  /// </summary>
  public IBorder? LeftBorder { get; set; }

  /// <summary>
  ///   IParagraph IBorder Between Identical IParagraphs.
  /// </summary>
  public IBorder? BottomBorder { get; set; }

  /// <summary>
  ///   Right IParagraph IBorder.
  /// </summary>
  public IBorder? RightBorder { get; set; }

  /// <summary>
  ///   IParagraph IBorder Between Identical IParagraphs.
  /// </summary>
  public IBorder? BetweenBorder { get; set; }

  /// <summary>
  ///   IParagraph IBorder Between Facing IPages.
  /// </summary>
  public IBorder? BarBorder { get; set; }
}
