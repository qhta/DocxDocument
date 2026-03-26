namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the values displayed in the second chart in a pie chart or a bar of pie chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlchartsplittype?view=office-pia` for Office interop details.
/// </remarks>
public enum ChartSplitType
{
  /// <summary>
  /// Second chart displays the smallest values in the data series. The number of values to display is specified by
  /// the SplitValue property.
  /// </summary>
  Position = 1,
  /// <summary>
  /// Second chart displays values less than the value specified by the SplitValue property.
  /// </summary>
  Value = 2,
  /// <summary>
  /// Second chart displays values less than some percentage of the total value. The percentage is specified by the
  /// SplitValue property.
  /// </summary>
  PercentValue = 3,
  /// <summary>
  /// Arbitrary slides are displayed in the second chart.
  /// </summary>
  CustomSplit = 4
}
