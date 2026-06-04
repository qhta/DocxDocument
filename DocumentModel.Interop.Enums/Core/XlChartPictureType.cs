
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies how
/// pictures are displayed on a column, bar picture chart, or legend key.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartpicturetype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlChartPictureType")]
public enum ChartPictureType
{
  /// <summary>
  /// Picture is sized to a specified number of units and repeated the length of the bar.
  /// </summary>
  [OfficeInteropEnumValue("xlStackScale")]
  ackScale = 3,
  /// <summary>
  /// Picture is sized to repeat a maximum of 15 times in the longest stacked bar.
  /// </summary>
  [OfficeInteropEnumValue("xlStack")]
  ack = 2,
  /// <summary>
  /// Picture is stretched the full length of stacked bar.
  /// </summary>
  [OfficeInteropEnumValue("xlStretch")]
  retch = 1
}
