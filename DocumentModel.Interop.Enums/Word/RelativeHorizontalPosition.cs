namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies to what the horizontal position of a frame, a shape, or a group of rows is relative.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativehorizontalposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRelativeHorizontalPosition))]
public enum RelativeHorizontalPosition
{
  /// <summary>
  /// Relative to margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionMargin))]
  Margin = 0,
  /// <summary>
  /// Relative to page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionPage))]
  Page = 1,
  /// <summary>
  /// Relative to column.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionColumn))]
  Column = 2,
  /// <summary>
  /// Relative to character.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionCharacter))]
  Character = 3,
  /// <summary>
  /// Relative to left margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionLeftMarginArea))]
  LeftMarginArea = 4,
  /// <summary>
  /// Relative to right margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionRightMarginArea))]
  RightMarginArea = 5,
  /// <summary>
  /// Relative to inner margin area.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionInnerMarginArea))]
  InnerMarginArea = 6,
  /// <summary>
  /// Relative to outer margin area.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalPosition.wdRelativeHorizontalPositionOuterMarginArea))]
  OuterMarginArea = 7
}
