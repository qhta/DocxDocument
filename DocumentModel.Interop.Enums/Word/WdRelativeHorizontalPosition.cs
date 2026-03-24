namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies to what the horizontal position of a frame, a shape, or a group of rows is relative.
/// </summary>
public enum WdRelativeHorizontalPosition
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
  /// Relative to column.
  /// </summary>
  Column = unchecked((int)2),
  /// <summary>
  /// Relative to character.
  /// </summary>
  Character = unchecked((int)3),
  /// <summary>
  /// Relative to left margin.
  /// </summary>
  LeftMarginArea = unchecked((int)4),
  /// <summary>
  /// Relative to right margin.
  /// </summary>
  RightMarginArea = unchecked((int)5),
  /// <summary>
  /// Relative to inner margin area.
  /// </summary>
  InnerMarginArea = unchecked((int)6),
  /// <summary>
  /// Relative to outer margin area.
  /// </summary>
  OuterMarginArea = unchecked((int)7)
}
