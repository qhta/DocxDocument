namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the marker style for a point or series in a line chart, scatter chart, or radar chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlmarkerstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlMarkerStyle))]
public enum MarkerStyle
{
  /// <summary>
  /// Square markers
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStyleSquare))]
  Square = 1,
  /// <summary>
  /// Diamond-shaped markers
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStyleDiamond))]
  Diamond = 2,
  /// <summary>
  /// Triangular markers
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStyleTriangle))]
  Triangle = 3,
  /// <summary>
  /// Square markers with an asterisk
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStyleStar))]
  Star = 5,
  /// <summary>
  /// Circular markers
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStyleCircle))]
  Circle = 8,
  /// <summary>
  /// Square markers with a plus sign public enum MarkerStyle
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStylePlus))]
  Plus = 9,
  /// <summary>
  /// Square markers with an X
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStyleX))]
  X = -4168,
  /// <summary>
  /// Picture markers
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStylePicture))]
  Picture = -4147,
  /// <summary>
  /// No markers
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStyleNone))]
  None = -4142,
  /// <summary>
  /// Short bar markers
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStyleDot))]
  Dot = -4118,
  /// <summary>
  /// Long bar markers
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStyleDash))]
  Dash = -4115,
  /// <summary>
  /// Automatic markers
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlMarkerStyle.xlMarkerStyleAutomatic))]
  Automatic = -4105
}
