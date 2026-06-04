namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the marker style for a point or series in a line chart, scatter chart, or radar chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlmarkerstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlMarkerStyle")]
public enum MarkerStyle
{
  /// <summary>
  /// Square markers
  /// </summary>
  [WordInteropEnumValue("xlMarkerStyleSquare")]
  Square = 1,
  /// <summary>
  /// Diamond-shaped markers
  /// </summary>
  [WordInteropEnumValue("xlMarkerStyleDiamond")]
  Diamond = 2,
  /// <summary>
  /// Triangular markers
  /// </summary>
  [WordInteropEnumValue("xlMarkerStyleTriangle")]
  Triangle = 3,
  /// <summary>
  /// Square markers with an asterisk
  /// </summary>
  [WordInteropEnumValue("xlMarkerStyleStar")]
  Star = 5,
  /// <summary>
  /// Circular markers
  /// </summary>
  [WordInteropEnumValue("xlMarkerStyleCircle")]
  Circle = 8,
  /// <summary>
  /// Square markers with a plus sign public enum MarkerStyle
  /// </summary>
  [WordInteropEnumValue("xlMarkerStylePlus")]
  Plus = 9,
  /// <summary>
  /// Square markers with an X
  /// </summary>
  [WordInteropEnumValue("xlMarkerStyleX")]
  X = -4168,
  /// <summary>
  /// Picture markers
  /// </summary>
  [WordInteropEnumValue("xlMarkerStylePicture")]
  Picture = -4147,
  /// <summary>
  /// No markers
  /// </summary>
  [WordInteropEnumValue("xlMarkerStyleNone")]
  None = -4142,
  /// <summary>
  /// Short bar markers
  /// </summary>
  [WordInteropEnumValue("xlMarkerStyleDot")]
  Dot = -4118,
  /// <summary>
  /// Long bar markers
  /// </summary>
  [WordInteropEnumValue("xlMarkerStyleDash")]
  Dash = -4115,
  /// <summary>
  /// Automatic markers
  /// </summary>
  [WordInteropEnumValue("xlMarkerStyleAutomatic")]
  Automatic = -4105
}
