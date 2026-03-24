namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies to what the vertical position of a frame, a shape, or a group of rows is relative.
/// </summary>
public enum WdRelativeVerticalPosition
{
  /// <summary>
  /// Relative to margin.
  /// </summary>
  Margin = unchecked((int)0),
  /// <summary>
  /// Relative to page.
  /// </summary>
  Page = unchecked((int)1),
  /// <summary>
  /// Relative to paragraph.
  /// </summary>
  Paragraph = unchecked((int)2),
  /// <summary>
  /// Relative to line.
  /// </summary>
  Line = unchecked((int)3),
  /// <summary>
  /// Relative to top margin.
  /// </summary>
  TopMarginArea = unchecked((int)4),
  /// <summary>
  /// Relative to bottom margin.
  /// </summary>
  BottomMarginArea = unchecked((int)5),
  /// <summary>
  /// Relative to inner margin area.
  /// </summary>
  InnerMarginArea = unchecked((int)6),
  /// <summary>
  /// Relative to outer margin area.
  /// </summary>
  OuterMarginArea = unchecked((int)7)
}
