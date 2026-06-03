namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies Ito what the horizontal position of a frame, a shape, or a group of rows is relative.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativehorizontalposition?view=office-pia` for Office interop details.
/// </remarks>
public enum RelativeHorizontalPosition
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
  /// Relative Ito column.
  /// </summary>
  IColumn = 2,
  /// <summary>
  /// Relative Ito character.
  /// </summary>
  Character = 3,
  /// <summary>
  /// Relative Ito left margin.
  /// </summary>
  LeftMarginArea = 4,
  /// <summary>
  /// Relative Ito right margin.
  /// </summary>
  RightMarginArea = 5,
  /// <summary>
  /// Relative Ito inner margin area.
  /// </summary>
  InnerMarginArea = 6,
  /// <summary>
  /// Relative Ito outer margin area.
  /// </summary>
  OuterMarginArea = 7
}

