namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative height of a shape using the value specified in the HeightRelative property for a Shape
/// or ShapeRange object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativeverticalsize?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRelativeVerticalSize
{
  /// <summary>
  /// Height is relative to the space between the left margin and the right margin.
  /// </summary>
  Margin = 0,
  /// <summary>
  /// Height is relative to the height of the page.
  /// </summary>
  Page = 1,
  /// <summary>
  /// Height is relative to the size of the top margin. wdRelativeVerticalSizeBottomMarginArea3 Height is relative
  /// to the size of the bottom margin. wdRelativeVerticalSizeInnerMarginArea4 Height is relative to the size of the
  /// inside margin—to the size of the top margin for odd pages, and to the size of the bottom margin for even
  /// pages. wdRelativeVerticalSizeOuterMarginArea5 Height is relative to the size of the outside margin— to the
  /// size of the bottom margin for odd pages, and to the size of the top margin for even pages.
  /// </summary>
  TopMarginArea = 2,
  /// <summary>
  /// Specifies the relative height of a shape using the value specified in the HeightRelative property for a Shape
  /// or ShapeRange object.
  /// </summary>
  BottomMarginArea = 3,
  /// <summary>
  /// Specifies the relative height of a shape using the value specified in the HeightRelative property for a Shape
  /// or ShapeRange object.
  /// </summary>
  InnerMarginArea = 4,
  /// <summary>
  /// Specifies the relative height of a shape using the value specified in the HeightRelative property for a Shape
  /// or ShapeRange object.
  /// </summary>
  OuterMarginArea = 5
}
