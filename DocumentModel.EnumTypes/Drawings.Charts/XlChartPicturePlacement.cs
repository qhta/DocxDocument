namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the placement of a user-selected picture on a bar in a 3-D bar or column.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartpictureplacement?view=office-pia` for Office interop details.
/// </remarks>
public enum XlChartPicturePlacement
{
  /// <summary>
  /// Display on sides.
  /// </summary>
  Sides = 1,
  /// <summary>
  /// Display on end.
  /// </summary>
  End = 2,
  /// <summary>
  /// Display on end and sides.
  /// </summary>
  EndSides = 3,
  /// <summary>
  /// Display on front.
  /// </summary>
  Front = 4,
  /// <summary>
  /// Display on front and sides.
  /// </summary>
  FrontSides = 5,
  /// <summary>
  /// Display on front and end.
  /// </summary>
  FrontEnd = 6,
  /// <summary>
  /// Display on all faces.
  /// </summary>
  AllFaces = 7
}
