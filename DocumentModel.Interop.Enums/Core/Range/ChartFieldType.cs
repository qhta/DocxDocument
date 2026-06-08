namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of data field to be inserted into a data label in a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msochartfieldtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoChartFieldType")]
public enum ChartFieldType
{
  /// <summary>
  /// Specifies the Bubble size of the data point.
  /// </summary>
  [InteropEnumValue("msoChartFieldBubbleSize")]
  BubbleSize = 1,
  /// <summary>
  /// Specifies the category name size of the data point.
  /// </summary>
  [InteropEnumValue("msoChartFieldCategoryName")]
  CategoryName,
  /// <summary>
  /// Specifies a percentage of the values.
  /// </summary>
  [InteropEnumValue("msoChartFieldPercentage")]
  Percentage,
  /// <summary>
  /// Specifies the data series name.
  /// </summary>
  [InteropEnumValue("msoChartFieldSeriesName")]
  SeriesName,
  /// <summary>
  /// Specifies the value of the data field.
  /// </summary>
  [InteropEnumValue("msoChartFieldValue")]
  Value,
  /// <summary>
  /// Specifies the formula used in the data point.
  /// </summary>
  [InteropEnumValue("msoChartFieldFormula")]
  Formula,
  /// <summary>
  /// Specifies the value of a range of data.
  /// </summary>
  [InteropEnumValue("msoChartFieldRange")]
  Range
}
