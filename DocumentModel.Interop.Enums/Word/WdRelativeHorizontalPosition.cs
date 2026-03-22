namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies to what the horizontal position of a frame, a shape, or a group of rows is relative.
/// </summary>
public enum WdRelativeHorizontalPosition
{
  /// <summary>
  /// Relative to margin.
  /// </summary>
  wdRelativeHorizontalPositionMargin = unchecked((int)0),
  /// <summary>
  /// Relative to page.
  /// </summary>
  wdRelativeHorizontalPositionPage = unchecked((int)1),
  /// <summary>
  /// Relative to column.
  /// </summary>
  wdRelativeHorizontalPositionColumn = unchecked((int)2),
  /// <summary>
  /// Relative to character.
  /// </summary>
  wdRelativeHorizontalPositionCharacter = unchecked((int)3),
  /// <summary>
  /// Relative to left margin.
  /// </summary>
  wdRelativeHorizontalPositionLeftMarginArea = unchecked((int)4),
  /// <summary>
  /// Relative to right margin.
  /// </summary>
  wdRelativeHorizontalPositionRightMarginArea = unchecked((int)5),
  /// <summary>
  /// Relative to inner margin area.
  /// </summary>
  wdRelativeHorizontalPositionInnerMarginArea = unchecked((int)6),
  /// <summary>
  /// Relative to outer margin area.
  /// </summary>
  wdRelativeHorizontalPositionOuterMarginArea = unchecked((int)7)
}
