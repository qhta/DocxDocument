namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the visibility settings that control which components are displayed in data labels.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines visibility flags for different information
///   components that can be included in chart data labels. Data labels can display various types of information
///   to help users understand data points, including the series name, category name, and actual data value. This
///   interface provides granular control over which components appear in labels, enabling customization based on
///   the chart's purpose and the information density desired. For example, a simple chart might show only values
///   to avoid clutter, while a complex multi-series chart might include series names to distinguish data points.
///   The visibility settings apply as defaults at the series level through <see cref="DataLabels"/> or can be
///   customized for individual data points through <see cref="DataLabel"/>. When multiple components are visible,
///   they are typically separated by the separator string defined in the parent data labels configuration. Common
///   configurations include showing only values for simple charts, combining values with category names for clarity,
///   or including all three components (series name, category name, and value) for comprehensive labeling in
///   complex visualizations. The visibility flags provide flexibility in balancing information richness with visual
///   clarity, allowing charts to be tailored to specific audiences and use cases.
///   This functionality is available in Office 2016 and later versions.
/// </remarks>
public interface DataLabelVisibilities : IModelElement
{
  /// <summary>
  ///   Gets or sets a value indicating whether the series name is displayed in data labels.
  /// </summary>
  /// <value>
  ///   <c>true</c> to show the series name; <c>false</c> to hide it; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2016 and later.
  ///   The series name identifies which data series a data point belongs to, which is particularly valuable in
  ///   multi-series charts where data points from different series may appear near each other. Showing the series
  ///   name helps users immediately identify the source of the data without needing to reference the legend or
  ///   match colors. This is especially useful in charts where multiple series share similar values or when the
  ///   chart includes many series that may be difficult to distinguish visually. For single-series charts, the
  ///   series name is often redundant and can be hidden to reduce clutter.
  /// </remarks>
  public bool? SeriesName { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the category name is displayed in data labels.
  /// </summary>
  /// <value>
  ///   <c>true</c> to show the category name; <c>false</c> to hide it; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2016 and later.
  ///   The category name identifies which category a data point represents, providing context about what the value
  ///   measures. This is particularly valuable in charts where the category axis labels may be hard to read due to
  ///   space constraints, rotation, or truncation, or when data labels are positioned away from the axis. Showing
  ///   category names directly on data labels ensures users can understand what each data point represents without
  ///   having to trace lines to the axis labels. For charts with clear, readable axis labels and well-positioned
  ///   data points, category names in labels may be redundant and can be hidden to maintain visual simplicity.
  /// </remarks>
  public bool? CategoryName { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the data value is displayed in data labels.
  /// </summary>
  /// <value>
  ///   <c>true</c> to show the data value; <c>false</c> to hide it; or <c>null</c> to use the default visibility.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2016 and later.
  ///   The data value is the actual numeric value represented by the data point, which is the most fundamental
  ///   piece of information a data label can display. Showing values enables precise reading of data points without
  ///   requiring users to estimate values from axis gridlines or scales. This is particularly important when exact
  ///   values matter, such as in financial reports, performance metrics, or comparison charts. In some cases, such
  ///   as when labels show only category or series names to identify points, or when displaying percentages or
  ///   other calculated values instead, the raw value may be hidden. However, values are typically the primary
  ///   component shown in most data labels, as they provide the quantitative information that charts are designed
  ///   to communicate.
  /// </remarks>
  public bool? Value { get; set; }
}