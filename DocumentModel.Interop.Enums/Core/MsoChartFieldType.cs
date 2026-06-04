namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of data field to be inserted into a data label in a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msochartfieldtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoChartFieldType")]
public enum ChartFieldType
{
  /// <summary>
  /// Specifies the Bubble size of the data point.
  /// </summary>
  [OfficeInteropEnumValue("msoChartFieldBubbleSize")]
  BubbleSize = 1,
  /// <summary>
  /// Specifies the category name size of the data point.
  /// </summary>
  [OfficeInteropEnumValue("msoChartFieldCategoryName")]
  CategoryName,
  /// <summary>
  /// Specifies a percentage of the values.
  /// </summary>
  [OfficeInteropEnumValue("msoChartFieldPercentage")]
  Percentage,
  /// <summary>
  /// Specifies the data series name.
  /// </summary>
  [OfficeInteropEnumValue("msoChartFieldSeriesName")]
  SeriesName,
  /// <summary>
  /// Specifies the value of the data field.
  /// </summary>
  [OfficeInteropEnumValue("msoChartFieldValue")]
  Value,
  /// <summary>
  /// Specifies the formula used in the data point.
  /// </summary>
  [OfficeInteropEnumValue("msoChartFieldFormula")]
  Formula,
  /// <summary>
  /// Specifies the value of a range of data.
  /// </summary>
  [OfficeInteropEnumValue("msoChartFieldRange")]
  Range
}
