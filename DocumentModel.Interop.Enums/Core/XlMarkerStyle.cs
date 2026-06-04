
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the marker
/// style for a point or series in a line chart, scatter chart, or radar chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlmarkerstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlMarkerStyle")]
public enum MarkerStyle
{
  /// <summary>
  /// Automatic markers.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStyleAutomatic")]
  Automatic = -4105,
  /// <summary>
  /// Circular markers.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStyleCircle")]
  Circle = 8,
  /// <summary>
  /// Long bar markers.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStyleDash")]
  Dash = -4115,
  /// <summary>
  /// Diamond-shaped markers.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStyleDiamond")]
  Diamond = 2,
  /// <summary>
  /// Short bar markers.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStyleDot")]
  Dot = -4118,
  /// <summary>
  /// No markers.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStyleNone")]
  None = -4142,
  /// <summary>
  /// Picture markers.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStylePicture")]
  Picture = -4147,
  /// <summary>
  /// Square markers with a plus sign.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStylePlus")]
  Plus = 9,
  /// <summary>
  /// Square markers.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStyleSquare")]
  Square = 1,
  /// <summary>
  /// Square markers with an asterisk.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStyleStar")]
  Star = 5,
  /// <summary>
  /// Triangular markers.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStyleTriangle")]
  Triangle = 3,
  /// <summary>
  /// Square markers with an X.
  /// </summary>
  [OfficeInteropEnumValue("xlMarkerStyleX")]
  X = -4168
}
