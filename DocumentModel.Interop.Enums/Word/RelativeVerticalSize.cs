namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative height of a shape using the value specified in the HeightRelative property for a Shape
/// or ShapeRange object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativeverticalsize?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdRelativeVerticalSize")]
public enum RelativeVerticalSize
{
  /// <summary>
  /// Height is relative to the space between the left margin and the right margin.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalSizeMargin")]
  Margin = 0,
  /// <summary>
  /// Height is relative to the height of the page.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalSizePage")]
  Page = 1,
  /// <summary>
  /// Height is relative to the size of the top margin.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalSizeTopMarginArea")]
  TopMarginArea = 2,
  /// <summary>
  /// Height is relative to the size of the bottom margin.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalSizeBottomMarginArea")]
  BottomMarginArea = 3,
  /// <summary>
  /// Height is relative to the size of the inside marginâ€”to the size of the top margin for odd pages, and to the
  /// size of the bottom margin for even pages.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalSizeInnerMarginArea")]
  InnerMarginArea = 4,
  /// <summary>
  /// Height is relative to the size of the outside marginâ€” to the size of the bottom margin for odd pages, and to
  /// the size of the top margin for even pages.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalSizeOuterMarginArea")]
  OuterMarginArea = 5
}
