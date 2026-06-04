namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the placement of a user-selected picture on a bar in a 3-D bar or column.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartpictureplacement?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlChartPicturePlacement))]
public enum XlChartPicturePlacement
{
  /// <summary>
  /// Display on sides.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartPicturePlacement.xlSides))]
  Sides = 1,
  /// <summary>
  /// Display on end.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartPicturePlacement.xlEnd))]
  End = 2,
  /// <summary>
  /// Display on end and sides.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartPicturePlacement.xlEndSides))]
  EndSides = 3,
  /// <summary>
  /// Display on front.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartPicturePlacement.xlFront))]
  Front = 4,
  /// <summary>
  /// Display on front and sides.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartPicturePlacement.xlFrontSides))]
  FrontSides = 5,
  /// <summary>
  /// Display on front and end.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartPicturePlacement.xlFrontEnd))]
  FrontEnd = 6,
  /// <summary>
  /// Display on all faces.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlChartPicturePlacement.xlAllFaces))]
  AllFaces = 7
}
