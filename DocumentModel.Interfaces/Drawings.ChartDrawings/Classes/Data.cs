namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents embedded data stored directly within a chart definition.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines the structure for chart data that is
///   stored directly within the chart rather than referenced from external sources. Embedded data makes the
///   chart self-contained and portable, eliminating dependencies on external data sources such as spreadsheets
///   or databases. The data is organized into dimensions: numeric dimensions for continuous values (such as
///   sales figures, measurements, or quantities) and string dimensions for categorical information (such as
///   labels, dates, or category names). Each data instance has a unique identifier that distinguishes it
///   within the chart's data structure. This embedded approach is ideal for static charts or when portability
///   is more important than dynamic data updates. Unlike external data sources referenced through
///   <see cref="ChartData.ExternalData"/>, embedded data must be manually updated if the underlying values
///   change. The dimensional structure supports various chart types including bar charts, line charts,
///   scatter plots, and more complex visualizations that require both numeric and categorical data.
///   This functionality is available in Office 2016 and later versions for the identifier property.
/// </remarks>
public interface Data : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this data instance.
  /// </summary>
  /// <value>
  ///   An unsigned 32-bit integer representing the data identifier,
  ///   or <c>null</c> if no identifier is assigned.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2016 and later.
  ///   The identifier uniquely distinguishes this data instance from other data collections in the chart,
  ///   enabling references from chart series and other elements that need to access this specific data set.
  ///   This is particularly useful when a chart contains multiple embedded data collections.
  /// </remarks>
  public UInt32? Id { get; set; }

  /// <summary>
  ///   Gets or sets the numeric dimension containing continuous numerical data values.
  /// </summary>
  /// <value>
  ///   A <see cref="NumericDimension"/> object containing numeric data values for the chart,
  ///   or <c>null</c> if the chart does not use numeric data.
  /// </value>
  /// <remarks>
  ///   The numeric dimension stores continuous numerical values such as sales figures, measurements,
  ///   quantities, percentages, or any other numeric data that will be visualized in the chart.
  ///   This dimension is typically used for value axes in charts like bar charts, line charts, and
  ///   scatter plots. Most chart types require at least one numeric dimension to represent the data values.
  /// </remarks>
  public NumericDimension? NumericDimension { get; set; }

  /// <summary>
  ///   Gets or sets the string dimension containing categorical or label data.
  /// </summary>
  /// <value>
  ///   A <see cref="StringDimension"/> object containing string data for categories or labels,
  ///   or <c>null</c> if the chart does not use categorical data.
  /// </value>
  /// <remarks>
  ///   The string dimension stores categorical information such as category names, date labels, series names,
  ///   or any other text-based data that provides context or organization for the chart. This dimension
  ///   is typically used for category axes in bar charts and column charts, or for labeling data points
  ///   in various chart types. String dimensions enable charts to organize and label data in meaningful ways.
  /// </remarks>
  public StringDimension? StringDimension { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <value>
  ///   An <see cref="ExtensionList"/> containing extension elements,
  ///   or <c>null</c> if no extensions are defined.
  /// </value>
  /// <remarks>
  ///   Extension elements allow for future enhancements to the data structure without breaking
  ///   compatibility with existing implementations. This could include support for additional data
  ///   dimension types, metadata, or custom data properties introduced in future versions.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}