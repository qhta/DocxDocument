namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies to what the horizontal position of a frame, a shape, or a group of rows is relative.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativehorizontalposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdRelativeHorizontalPosition")]
public enum RelativeHorizontalPosition
{
  /// <summary>
  /// Relative to margin.
  /// </summary>
  [WordInteropEnumValue("wdRelativeHorizontalPositionMargin")]
  Margin = 0,
  /// <summary>
  /// Relative to page.
  /// </summary>
  [WordInteropEnumValue("wdRelativeHorizontalPositionPage")]
  Page = 1,
  /// <summary>
  /// Relative to column.
  /// </summary>
  [WordInteropEnumValue("wdRelativeHorizontalPositionColumn")]
  Column = 2,
  /// <summary>
  /// Relative to character.
  /// </summary>
  [WordInteropEnumValue("wdRelativeHorizontalPositionCharacter")]
  Character = 3,
  /// <summary>
  /// Relative to left margin.
  /// </summary>
  [WordInteropEnumValue("wdRelativeHorizontalPositionLeftMarginArea")]
  LeftMarginArea = 4,
  /// <summary>
  /// Relative to right margin.
  /// </summary>
  [WordInteropEnumValue("wdRelativeHorizontalPositionRightMarginArea")]
  RightMarginArea = 5,
  /// <summary>
  /// Relative to inner margin area.
  /// </summary>
  [WordInteropEnumValue("wdRelativeHorizontalPositionInnerMarginArea")]
  InnerMarginArea = 6,
  /// <summary>
  /// Relative to outer margin area.
  /// </summary>
  [WordInteropEnumValue("wdRelativeHorizontalPositionOuterMarginArea")]
  OuterMarginArea = 7
}
