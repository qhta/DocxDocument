
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartorientation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlChartOrientation")]
public enum ChartOrientation
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("xlDownward")]
  Downward = -4170,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("xlHorizontal")]
  Horizontal = -4128,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("xlUpward")]
  Upward = -4171,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("xlVertical")]
  Vertical = -4166
}
