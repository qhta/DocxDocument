namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative width of a shape using the value specified in the WidthRelative property for a Shape or
/// ShapeRange object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativehorizontalsize?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRelativeHorizontalSize))]
public enum RelativeHorizontalSize
{
  /// <summary>
  /// Width is relative to the space between the left margin and the right margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalSize.wdRelativeHorizontalSizeMargin))]
  Margin = 0,
  /// <summary>
  /// Width is relative to the width of the page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalSize.wdRelativeHorizontalSizePage))]
  Page = 1,
  /// <summary>
  /// Width is relative to the size of the left margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalSize.wdRelativeHorizontalSizeLeftMarginArea))]
  LeftMarginArea = 2,
  /// <summary>
  /// Width is relative to the width of the right margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalSize.wdRelativeHorizontalSizeRightMarginArea))]
  RightMarginArea = 3,
  /// <summary>
  /// Width is relative to the size of the inside marginâ€”to the size of the left margin for odd pages, and to the
  /// size of the right margin for even pages.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalSize.wdRelativeHorizontalSizeInnerMarginArea))]
  InnerMarginArea = 4,
  /// <summary>
  /// Width is relative to the size of the outside marginâ€” to the size of the right margin for odd pages, and to the
  /// size of the left margin for even pages.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeHorizontalSize.wdRelativeHorizontalSizeOuterMarginArea))]
  OuterMarginArea = 5
}
