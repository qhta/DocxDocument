namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the placement of a user-selected picture on a bar in a 3-D bar or column.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartpictureplacement?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlChartPicturePlacement")]
public enum ChartPicturePlacement
{
  /// <summary>
  /// Display on sides.
  /// </summary>
  [InteropEnumValue("xlSides")]
  Sides = 1,
  /// <summary>
  /// Display on end.
  /// </summary>
  [InteropEnumValue("xlEnd")]
  End = 2,
  /// <summary>
  /// Display on end and sides.
  /// </summary>
  [InteropEnumValue("xlEndSides")]
  EndSides = 3,
  /// <summary>
  /// Display on front.
  /// </summary>
  [InteropEnumValue("xlFront")]
  Front = 4,
  /// <summary>
  /// Display on front and sides.
  /// </summary>
  [InteropEnumValue("xlFrontSides")]
  FrontSides = 5,
  /// <summary>
  /// Display on front and end.
  /// </summary>
  [InteropEnumValue("xlFrontEnd")]
  FrontEnd = 6,
  /// <summary>
  /// Display on all faces.
  /// </summary>
  [InteropEnumValue("xlAllFaces")]
  AllFaces = 7
}

