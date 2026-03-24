namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative height of a shape using the value specified in the HeightRelative property for a Shape
/// or ShapeRange object.
/// </summary>
public enum WdRelativeVerticalSize
{
  /// <summary>
  /// Height is relative to the space between the left margin and the right margin.
  /// </summary>
  Margin = unchecked((int)0),
  /// <summary>
  /// Height is relative to the height of the page.
  /// </summary>
  Page = unchecked((int)1),
  /// <summary>
  /// Height is relative to the size of the top margin. wdRelativeVerticalSizeBottomMarginArea3 Height is relative
  /// to the size of the bottom margin. wdRelativeVerticalSizeInnerMarginArea4 Height is relative to the size of the
  /// inside margin—to the size of the top margin for odd pages, and to the size of the bottom margin for even
  /// pages. wdRelativeVerticalSizeOuterMarginArea5 Height is relative to the size of the outside margin— to the
  /// size of the bottom margin for odd pages, and to the size of the top margin for even pages.
  /// </summary>
  TopMarginArea = unchecked((int)2),
  /// <summary>
  /// Specifies the relative height of a shape using the value specified in the HeightRelative property for a Shape
  /// or ShapeRange object.
  /// </summary>
  BottomMarginArea = unchecked((int)3),
  /// <summary>
  /// Specifies the relative height of a shape using the value specified in the HeightRelative property for a Shape
  /// or ShapeRange object.
  /// </summary>
  InnerMarginArea = unchecked((int)4),
  /// <summary>
  /// Specifies the relative height of a shape using the value specified in the HeightRelative property for a Shape
  /// or ShapeRange object.
  /// </summary>
  OuterMarginArea = unchecked((int)5)
}
