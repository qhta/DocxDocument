namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the placement of a user-selected picture on a bar in a 3-D bar or column.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartpictureplacement?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlChartPicturePlacement")]
public enum XlChartPicturePlacement
{
  /// <summary>
  /// Display on sides.
  /// </summary>
  [WordInteropEnumValue("xlSides")]
  Sides = 1,
  /// <summary>
  /// Display on end.
  /// </summary>
  [WordInteropEnumValue("xlEnd")]
  End = 2,
  /// <summary>
  /// Display on end and sides.
  /// </summary>
  [WordInteropEnumValue("xlEndSides")]
  EndSides = 3,
  /// <summary>
  /// Display on front.
  /// </summary>
  [WordInteropEnumValue("xlFront")]
  Front = 4,
  /// <summary>
  /// Display on front and sides.
  /// </summary>
  [WordInteropEnumValue("xlFrontSides")]
  FrontSides = 5,
  /// <summary>
  /// Display on front and end.
  /// </summary>
  [WordInteropEnumValue("xlFrontEnd")]
  FrontEnd = 6,
  /// <summary>
  /// Display on all faces.
  /// </summary>
  [WordInteropEnumValue("xlAllFaces")]
  AllFaces = 7
}
