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
  wdRelativeHorizontalSizeMargin = unchecked((int)0),
  /// <summary>
  /// Width is relative to the width of the page. wdRelativeHorizontalSizeLeftMarginArea2 Width is relative to the
  /// size of the left margin. wdRelativeHorizontalSizeRightMarginArea3 Width is relative to the width of the right
  /// margin. wdRelativeHorizontalSizeInnerMarginArea4 Width is relative to the size of the inside margin—to the
  /// size of the left margin for odd pages, and to the size of the right margin for even pages.
  /// wdRelativeHorizontalSizeOuterMarginArea5 Width is relative to the size of the outside margin— to the size of
  /// the right margin for odd pages, and to the size of the left margin for even pages.
  /// </summary>
  wdRelativeHorizontalSizePage = unchecked((int)1),
  /// <summary>
  /// Specifies the relative width of a shape using the value specified in the WidthRelative property for a Shape or
  /// ShapeRange object.
  /// </summary>
  wdRelativeHorizontalSizeLeftMarginArea = unchecked((int)2),
  /// <summary>
  /// Specifies the relative width of a shape using the value specified in the WidthRelative property for a Shape or
  /// ShapeRange object.
  /// </summary>
  wdRelativeHorizontalSizeRightMarginArea = unchecked((int)3),
  /// <summary>
  /// Specifies the relative width of a shape using the value specified in the WidthRelative property for a Shape or
  /// ShapeRange object.
  /// </summary>
  wdRelativeHorizontalSizeInnerMarginArea = unchecked((int)4),
  /// <summary>
  /// Specifies the relative width of a shape using the value specified in the WidthRelative property for a Shape or
  /// ShapeRange object.
  /// </summary>
  wdRelativeHorizontalSizeOuterMarginArea = unchecked((int)5)
}
