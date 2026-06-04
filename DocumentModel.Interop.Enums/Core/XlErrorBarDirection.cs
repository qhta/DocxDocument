
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies which axis
/// values are to receive error bars.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlerrorbardirection?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlErrorBarDirection")]
public enum ErrorBarDirection
{
  /// <summary>
  /// Bars run parallel to the Y axis for X-axis values.
  /// </summary>
  [InteropEnumValue("xlChartX")]
  X = -4168,
  /// <summary>
  /// Bars run parallel to the X axis for Y-axis values.
  /// </summary>
  [InteropEnumValue("xlChartY")]
  Y = 1
}
