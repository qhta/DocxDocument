namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative width of a shape using the value specified in the WidthRelative property for a Shape or
/// ShapeRange object.
/// </summary>
public enum WdRelativeHorizontalSize
{
  /// <summary>
  /// Width is relative to the space between the left margin and the right margin.
  /// </summary>
  Margin = 0,
  /// <summary>
  /// Width is relative to the width of the page. wdRelativeHorizontalSizeLeftMarginArea2 Width is relative to the
  /// size of the left margin. wdRelativeHorizontalSizeRightMarginArea3 Width is relative to the width of the right
  /// margin. wdRelativeHorizontalSizeInnerMarginArea4 Width is relative to the size of the inside margin—to the
  /// size of the left margin for odd pages, and to the size of the right margin for even pages.
  /// wdRelativeHorizontalSizeOuterMarginArea5 Width is relative to the size of the outside margin— to the size of
  /// the right margin for odd pages, and to the size of the left margin for even pages.
  /// </summary>
  Page = 1,
  /// <summary>
  /// Specifies the relative width of a shape using the value specified in the WidthRelative property for a Shape or
  /// ShapeRange object.
  /// </summary>
  LeftMarginArea = 2,
  /// <summary>
  /// Specifies the relative width of a shape using the value specified in the WidthRelative property for a Shape or
  /// ShapeRange object.
  /// </summary>
  RightMarginArea = 3,
  /// <summary>
  /// Specifies the relative width of a shape using the value specified in the WidthRelative property for a Shape or
  /// ShapeRange object.
  /// </summary>
  InnerMarginArea = 4,
  /// <summary>
  /// Specifies the relative width of a shape using the value specified in the WidthRelative property for a Shape or
  /// ShapeRange object.
  /// </summary>
  OuterMarginArea = 5
}
