namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Specifies the reference point for determining the vertical size of a drawing element relative to another element in a Wordprocessing document.
/// This enumeration provides options for margins, page boundaries, and other layout anchors used in relative sizing calculations.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SizeRelativeVerticallyKind
{

  /// <summary>
  /// The entire margin area is used as the reference for vertical sizing.
  /// </summary>
  Margin,

  /// <summary>
  /// The page boundary is used as the reference for vertical sizing.
  /// </summary>
  Page,

  /// <summary>
  /// The top margin is used as the reference for vertical sizing.
  /// </summary>
  TopMargin,

  /// <summary>
  /// The bottom margin is used as the reference for vertical sizing.
  /// </summary>
  BottomMargin,

  /// <summary>
  /// The inside margin (typically for facing pages) is used as the reference for vertical sizing.
  /// </summary>
  InsideMargin,

  /// <summary>
  /// The outside margin (typically for facing pages) is used as the reference for vertical sizing.
  /// </summary>
  OutsideMargin
}