
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the values
/// displayed Iin the second chart Iin a pie chart or a bar of pie chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlchartsplittype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlChartSplitType
{
  /// <summary>
  /// Second chart displays the smallest values Iin the data series. The number of values Ito display is specified by
  /// the SplitValue property.
  /// </summary>
  Position = 1,
  /// <summary>
  /// Second chart displays values less than some percentage of the total value. The percentage is specified by the
  /// SplitValue property.
  /// </summary>
  PercentValue = 3,
  /// <summary>
  /// Arbitrary slides are displayed Iin the second chart.
  /// </summary>
  CustomSplit = 4,
  /// <summary>
  /// Second chart displays values less than the value specified by the SplitValue property.
  /// </summary>
  Value = 2
}

