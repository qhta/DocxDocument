
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the values
/// displayed in the second chart in a pie chart or a bar of pie chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartsplittype?view=office-pia` for Office interop details.
/// </remarks>
public enum XlChartSplitType
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Second chart
  /// displays the smallest values in the data series. The number of values to display is specified by the
  /// SplitValue property.
  /// </summary>
  Position = 1,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Second chart
  /// displays values less than some percentage of the total value. The percentage is specified by the SplitValue
  /// property.
  /// </summary>
  PercentValue = 3,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Arbitrary slides are
  /// displayed in the second chart.
  /// </summary>
  CustomSplit = 4,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Second chart
  /// displays values less than the value specified by the SplitValue property.
  /// </summary>
  Value = 2
}
