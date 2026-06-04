
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the marker
/// style for a point or series in a line chart, scatter chart, or radar chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlmarkerstyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlMarkerStyle))]
public enum MarkerStyle
{
  /// <summary>
  /// Automatic markers.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStyleAutomatic))]
  Automatic = -4105,
  /// <summary>
  /// Circular markers.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStyleCircle))]
  Circle = 8,
  /// <summary>
  /// Long bar markers.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStyleDash))]
  Dash = -4115,
  /// <summary>
  /// Diamond-shaped markers.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStyleDiamond))]
  Diamond = 2,
  /// <summary>
  /// Short bar markers.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStyleDot))]
  Dot = -4118,
  /// <summary>
  /// No markers.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStyleNone))]
  None = -4142,
  /// <summary>
  /// Picture markers.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStylePicture))]
  Picture = -4147,
  /// <summary>
  /// Square markers with a plus sign.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStylePlus))]
  Plus = 9,
  /// <summary>
  /// Square markers.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStyleSquare))]
  Square = 1,
  /// <summary>
  /// Square markers with an asterisk.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStyleStar))]
  Star = 5,
  /// <summary>
  /// Triangular markers.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStyleTriangle))]
  Triangle = 3,
  /// <summary>
  /// Square markers with an X.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlMarkerStyle.xlMarkerStyleX))]
  X = -4168
}
