namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of data field to be inserted into a data label in a chart.
/// </summary>
public enum MsoChartFieldType
{
  /// <summary>
  /// Specifies the Bubble size of the data point. msoChartFieldCategoryName2 Specifies the category name size of
  /// the data point.
  /// </summary>
  msoChartFieldBubbleSize = 1,
  /// <summary>
  /// Specifies the type of data field to be inserted into a data label in a chart.
  /// </summary>
  msoChartFieldCategoryName,
  /// <summary>
  /// Specifies a percentage of the values.
  /// </summary>
  msoChartFieldPercentage,
  /// <summary>
  /// Specifies the data series name.
  /// </summary>
  msoChartFieldSeriesName,
  /// <summary>
  /// Specifies the value of the data field.
  /// </summary>
  msoChartFieldValue,
  /// <summary>
  /// Specifies the formula used in the data point.
  /// </summary>
  msoChartFieldFormula,
  /// <summary>
  /// Specifies the value of a range of data.
  /// </summary>
  msoChartFieldRange
}
