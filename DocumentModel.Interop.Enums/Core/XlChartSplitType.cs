
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the values
/// displayed in the second chart in a pie chart or a bar of pie chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartsplittype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlChartSplitType")]
public enum ChartSplitType
{
  /// <summary>
  /// Second chart displays the smallest values in the data series. The number of values to display is specified by
  /// the SplitValue property.
  /// </summary>
  [OfficeInteropEnumValue("xlSplitByPosition")]
  Position = 1,
  /// <summary>
  /// Second chart displays values less than some percentage of the total value. The percentage is specified by the
  /// SplitValue property.
  /// </summary>
  [OfficeInteropEnumValue("xlSplitByPercentValue")]
  PercentValue = 3,
  /// <summary>
  /// Arbitrary slides are displayed in the second chart.
  /// </summary>
  [OfficeInteropEnumValue("xlSplitByCustomSplit")]
  CustomSplit = 4,
  /// <summary>
  /// Second chart displays values less than the value specified by the SplitValue property.
  /// </summary>
  [OfficeInteropEnumValue("xlSplitByValue")]
  Value = 2
}
