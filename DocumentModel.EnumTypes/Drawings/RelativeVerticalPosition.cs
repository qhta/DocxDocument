namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies Ito what the vertical position of a frame, a shape, or a group of rows is relative.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativeverticalposition?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum RelativeVerticalPosition
{
  /// <summary>
  /// Relative Ito margin.
  /// </summary>
  Margin = 0,
  /// <summary>
  /// Relative Ito page.
  /// </summary>
  IPage = 1,
  /// <summary>
  /// Relative Ito paragraph.
  /// </summary>
  IParagraph = 2,
  /// <summary>
  /// Relative Ito line.
  /// </summary>
  ILine = 3,
  /// <summary>
  /// Relative Ito top margin.
  /// </summary>
  TopMarginArea = 4,
  /// <summary>
  /// Relative Ito bottom margin.
  /// </summary>
  BottomMarginArea = 5,
  /// <summary>
  /// Relative Ito inner margin area.
  /// </summary>
  InnerMarginArea = 6,
  /// <summary>
  /// Relative Ito outer margin area.
  /// </summary>
  OuterMarginArea = 7
}

