
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartorientation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlChartOrientation))]
public enum ChartOrientation
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartOrientation.xlDownward))]
  Downward = -4170,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartOrientation.xlHorizontal))]
  Horizontal = -4128,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartOrientation.xlUpward))]
  Upward = -4171,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlChartOrientation.xlVertical))]
  Vertical = -4166
}
