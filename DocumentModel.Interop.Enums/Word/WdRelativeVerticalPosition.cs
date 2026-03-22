namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies to what the vertical position of a frame, a shape, or a group of rows is relative.
/// </summary>
public enum WdRelativeVerticalPosition
{
  /// <summary>
  /// Relative to margin.
  /// </summary>
  wdRelativeVerticalPositionMargin = unchecked((int)0),
  /// <summary>
  /// Relative to page.
  /// </summary>
  wdRelativeVerticalPositionPage = unchecked((int)1),
  /// <summary>
  /// Relative to paragraph.
  /// </summary>
  wdRelativeVerticalPositionParagraph = unchecked((int)2),
  /// <summary>
  /// Relative to line.
  /// </summary>
  wdRelativeVerticalPositionLine = unchecked((int)3),
  /// <summary>
  /// Relative to top margin.
  /// </summary>
  wdRelativeVerticalPositionTopMarginArea = unchecked((int)4),
  /// <summary>
  /// Relative to bottom margin.
  /// </summary>
  wdRelativeVerticalPositionBottomMarginArea = unchecked((int)5),
  /// <summary>
  /// Relative to inner margin area.
  /// </summary>
  wdRelativeVerticalPositionInnerMarginArea = unchecked((int)6),
  /// <summary>
  /// Relative to outer margin area.
  /// </summary>
  wdRelativeVerticalPositionOuterMarginArea = unchecked((int)7)
}
