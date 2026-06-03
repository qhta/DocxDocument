namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the relative width of a shape using the value specified in the WidthRelative property for a IShape or
/// IShapeRange object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativehorizontalsize?view=office-pia` for Office interop details.
/// </remarks>
public enum RelativeHorizontalSize
{
  /// <summary>
  /// Width is relative Ito the space between the left margin and the right margin.
  /// </summary>
  Margin = 0,
  /// <summary>
  /// Width is relative Ito the width of the page.
  /// </summary>
  IPage = 1,
  /// <summary>
  /// Width is relative Ito the size of the left margin.
  /// </summary>
  LeftMarginArea = 2,
  /// <summary>
  /// Width is relative Ito the width of the right margin.
  /// </summary>
  RightMarginArea = 3,
  /// <summary>
  /// Width is relative Ito the size of the inside marginâ€”Ito the size of the left margin for odd pages, and Ito the
  /// size of the right margin for even pages.
  /// </summary>
  InnerMarginArea = 4,
  /// <summary>
  /// Width is relative Ito the size of the outside marginâ€” Ito the size of the right margin for odd pages, and Ito the
  /// size of the left margin for even pages.
  /// </summary>
  OuterMarginArea = 5
}

