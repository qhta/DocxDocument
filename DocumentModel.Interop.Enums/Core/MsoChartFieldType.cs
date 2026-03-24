namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of data field to be inserted into a data label in a chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msochartfieldtype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoChartFieldType
{
  /// <summary>
  /// Specifies the Bubble size of the data point. msoChartFieldCategoryName2 Specifies the category name size of
  /// the data point.
  /// </summary>
  BubbleSize = 1,
  /// <summary>
  /// Specifies the type of data field to be inserted into a data label in a chart.
  /// </summary>
  CategoryName,
  /// <summary>
  /// Specifies a percentage of the values.
  /// </summary>
  Percentage,
  /// <summary>
  /// Specifies the data series name.
  /// </summary>
  SeriesName,
  /// <summary>
  /// Specifies the value of the data field.
  /// </summary>
  Value,
  /// <summary>
  /// Specifies the formula used in the data point.
  /// </summary>
  Formula,
  /// <summary>
  /// Specifies the value of a range of data.
  /// </summary>
  Range
}
