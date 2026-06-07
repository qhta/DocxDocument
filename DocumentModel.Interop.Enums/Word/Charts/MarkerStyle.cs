namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the marker style for a point or series in a line chart, scatter chart, or radar chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlmarkerstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlMarkerStyle")]
public enum MarkerStyle
{
  /// <summary>
  /// Square markers
  /// </summary>
  [InteropEnumValue("xlMarkerStyleSquare")]
  Square = 1,
  /// <summary>
  /// Diamond-shaped markers
  /// </summary>
  [InteropEnumValue("xlMarkerStyleDiamond")]
  Diamond = 2,
  /// <summary>
  /// Triangular markers
  /// </summary>
  [InteropEnumValue("xlMarkerStyleTriangle")]
  Triangle = 3,
  /// <summary>
  /// Square markers with an asterisk
  /// </summary>
  [InteropEnumValue("xlMarkerStyleStar")]
  Star = 5,
  /// <summary>
  /// Circular markers
  /// </summary>
  [InteropEnumValue("xlMarkerStyleCircle")]
  Circle = 8,
  /// <summary>
  /// Square markers with a plus sign public enum MarkerStyle
  /// </summary>
  [InteropEnumValue("xlMarkerStylePlus")]
  Plus = 9,
  /// <summary>
  /// Square markers with an X
  /// </summary>
  [InteropEnumValue("xlMarkerStyleX")]
  X = -4168,
  /// <summary>
  /// Picture markers
  /// </summary>
  [InteropEnumValue("xlMarkerStylePicture")]
  Picture = -4147,
  /// <summary>
  /// No markers
  /// </summary>
  [InteropEnumValue("xlMarkerStyleNone")]
  None = -4142,
  /// <summary>
  /// Short bar markers
  /// </summary>
  [InteropEnumValue("xlMarkerStyleDot")]
  Dot = -4118,
  /// <summary>
  /// Long bar markers
  /// </summary>
  [InteropEnumValue("xlMarkerStyleDash")]
  Dash = -4115,
  /// <summary>
  /// Automatic markers
  /// </summary>
  [InteropEnumValue("xlMarkerStyleAutomatic")]
  Automatic = -4105
}

