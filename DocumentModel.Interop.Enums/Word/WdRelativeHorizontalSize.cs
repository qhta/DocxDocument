namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative width of a shape using the value specified in the WidthRelative property for a Shape or
/// ShapeRange object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativehorizontalsize?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRelativeHorizontalSize
{
  /// <summary>
  /// Width is relative to the space between the left margin and the right margin.
  /// </summary>
  Margin = 0,
  /// <summary>
  /// Width is relative to the width of the page.
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
