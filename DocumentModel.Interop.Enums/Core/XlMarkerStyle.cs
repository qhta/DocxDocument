
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the marker
/// style for a point or series in a line chart, scatter chart, or radar chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlmarkerstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum XlMarkerStyle
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Automatic markers.
  /// </summary>
  Automatic = -4105,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Circular markers.
  /// </summary>
  Circle = 8,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Long bar markers.
  /// </summary>
  Dash = -4115,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Diamond-shaped
  /// markers.
  /// </summary>
  Diamond = 2,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Short bar markers.
  /// </summary>
  Dot = -4118,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). No markers.
  /// </summary>
  None = -4142,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Picture markers.
  /// </summary>
  Picture = -4147,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Square markers with
  /// a plus sign.
  /// </summary>
  Plus = 9,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Square markers.
  /// public enum class XlMarkerStyle
  /// </summary>
  Square = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Square markers with
  /// an asterisk.
  /// </summary>
  Star = 5,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Triangular markers.
  /// </summary>
  Triangle = 3,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Square markers with
  /// an X.
  /// </summary>
  X = -4168
}
