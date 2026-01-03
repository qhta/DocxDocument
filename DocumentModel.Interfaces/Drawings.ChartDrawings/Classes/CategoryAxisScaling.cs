namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the scaling properties for a category axis in a chart.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines the scaling configuration for category
///   axes, which display discrete data such as text labels, dates, or named categories. Unlike value axes
///   that represent continuous numeric data with minimum and maximum ranges, category axes organize data
///   into distinct, ordered categories. The primary scaling property for category axes is the gap width,
///   which controls the spacing between categories or groups of data. This is particularly relevant for
///   bar charts, column charts, and other visualizations where the spacing between categorical elements
///   affects both the visual appearance and data interpretation. Category axis scaling is used in conjunction
///   with the <see cref="Axis"/> interface, where either <c>CategoryAxisScaling</c> or <see cref="ValueAxisScaling"/>
///   is specified depending on the axis type.
///   This functionality is available in Office 2016 and later versions.
/// </remarks>
public interface CategoryAxisScaling : IModelElement
{
  /// <summary>
  ///   Gets or sets the width of the gap between categories as a percentage of the bar or column width.
  /// </summary>
  /// <value>
  ///   A string containing the numeric gap width percentage value,
  ///   or <c>null</c> if the default gap width is used.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2016 and later.
  ///   The gap width determines the spacing between categories or groups in bar and column charts.
  ///   It is expressed as a percentage of the bar or column width. For example, a gap width of "50"
  ///   means the gap between categories is 50% of the width of each bar or column. A larger gap width
  ///   creates more spacing between categories, making individual categories more distinct but reducing
  ///   the space available for data display. A smaller gap width creates denser visualizations with less
  ///   spacing. Typical values range from 0 (no gap) to 500 (very wide gaps), with common defaults
  ///   around 150-200 depending on the chart type.
  /// </remarks>
  public string? GapWidth { get; set; }
}