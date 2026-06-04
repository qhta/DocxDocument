namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the values displayed in the second chart in a pie chart or a bar of pie chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartsplittype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlChartSplitType")]
public enum ChartSplitType
{
  /// <summary>
  /// Second chart displays the smallest values in the data series. The number of values to display is specified by
  /// the SplitValue property.
  /// </summary>
  [InteropEnumValue("xlSplitByPosition")]
  Position = 1,
  /// <summary>
  /// Second chart displays values less than the value specified by the SplitValue property.
  /// </summary>
  [InteropEnumValue("xlSplitByValue")]
  Value = 2,
  /// <summary>
  /// Second chart displays values less than some percentage of the total value. The percentage is specified by the
  /// SplitValue property.
  /// </summary>
  [InteropEnumValue("xlSplitByPercentValue")]
  PercentValue = 3,
  /// <summary>
  /// Arbitrary slides are displayed in the second chart.
  /// </summary>
  [InteropEnumValue("xlSplitByCustomSplit")]
  CustomSplit = 4
}
