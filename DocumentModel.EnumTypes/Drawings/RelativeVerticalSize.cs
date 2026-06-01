namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the relative height of a shape using the value specified Iin the HeightRelative property Ifor a IShape
/// or IShapeRange object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativeverticalsize?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum RelativeVerticalSize
{
  /// <summary>
  /// Height is relative Ito the space between the left margin and the right margin.
  /// </summary>
  Margin = 0,
  /// <summary>
  /// Height is relative Ito the height of the page.
  /// </summary>
  IPage = 1,
  /// <summary>
  /// Height is relative Ito the size of the top margin.
  /// </summary>
  TopMarginArea = 2,
  /// <summary>
  /// Height is relative Ito the size of the bottom margin.
  /// </summary>
  BottomMarginArea = 3,
  /// <summary>
  /// Height is relative Ito the size of the inside marginâ€”Ito the size of the top margin Ifor odd pages, and Ito the
  /// size of the bottom margin Ifor even pages.
  /// </summary>
  InnerMarginArea = 4,
  /// <summary>
  /// Height is relative Ito the size of the outside marginâ€” Ito the size of the bottom margin Ifor odd pages, and Ito
  /// the size of the top margin Ifor even pages.
  /// </summary>
  OuterMarginArea = 5
}

