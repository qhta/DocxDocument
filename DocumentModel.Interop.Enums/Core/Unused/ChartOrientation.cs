
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartorientation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlChartOrientation")]
public enum ChartOrientation
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("xlDownward")]
  Downward = -4170,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("xlHorizontal")]
  Horizontal = -4128,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("xlUpward")]
  Upward = -4171,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("xlVertical")]
  Vertical = -4166
}
