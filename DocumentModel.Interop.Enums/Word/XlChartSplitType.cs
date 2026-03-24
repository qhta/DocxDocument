namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the values displayed in the second chart in a pie chart or a bar of pie chart.
/// </summary>
public enum XlChartSplitType
{
  /// <summary>
  /// Second chart displays the smallest values in the data series. The number of values to display is specified by
  /// the SplitValue property.
  /// </summary>
  Position = unchecked((int)1),
  /// <summary>
  /// Second chart displays values less than the value specified by the SplitValue property.
  /// </summary>
  Value = unchecked((int)2),
  /// <summary>
  /// Second chart displays values less than some percentage of the total value. The percentage is specified by the
  /// SplitValue property. xlSplitByCustomSplit4 Arbitrary slides are displayed in the second chart.
  /// </summary>
  PercentValue = unchecked((int)3),
  /// <summary>
  /// Specifies the values displayed in the second chart in a pie chart or a bar of pie chart.
  /// </summary>
  CustomSplit = unchecked((int)4)
}
