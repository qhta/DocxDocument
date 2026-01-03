namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the data source configuration for a chart, specifying whether data is external or embedded.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines the data source structure for a chart,
///   which can either reference external data sources or contain embedded data directly within the chart definition.
///   The chart data configuration determines where the chart retrieves its values, categories, and series information.
///   External data typically links to spreadsheet ranges, database connections, or other data sources outside the
///   chart definition, enabling dynamic updates when the source data changes. Embedded data stores the actual data
///   values within the chart structure itself, making the chart self-contained but static. The interface also supports
///   custom extensions for additional data source types or configurations. Only one data source type (external or
///   embedded) should typically be specified for a given chart, though the structure allows for flexibility in
///   data source management and future extensibility.
/// </remarks>
public interface ChartData : IModelElement
{
  /// <summary>
  ///   Gets or sets the external data source reference for the chart.
  /// </summary>
  /// <value>
  ///   An <see cref="ExternalData"/> object defining the external data source location and refresh settings,
  ///   or <c>null</c> if the chart uses embedded data.
  /// </value>
  /// <remarks>
  ///   External data references link the chart to data sources such as Excel worksheets, database queries,
  ///   or other external data providers. When external data is specified, the chart can automatically update
  ///   when the source data changes, providing dynamic visualization capabilities. This is the preferred
  ///   approach for charts that need to reflect changing data over time. Typically, either <see cref="ExternalData"/>
  ///   or <see cref="Data"/> is specified, but not both.
  /// </remarks>
  public ExternalData? ExternalData { get; set; }

  /// <summary>
  ///   Gets or sets the embedded data contained directly within the chart.
  /// </summary>
  /// <value>
  ///   A <see cref="Data"/> object containing the chart's data values, categories, and series information,
  ///   or <c>null</c> if the chart uses an external data source.
  /// </value>
  /// <remarks>
  ///   Embedded data stores the actual data points, categories, and series information directly within the
  ///   chart definition, making the chart self-contained and independent of external data sources. This approach
  ///   is suitable for static charts or when the chart needs to be portable without maintaining connections
  ///   to external data sources. However, embedded data must be manually updated if the underlying values change.
  ///   Typically, either <see cref="ExternalData"/> or <see cref="Data"/> is specified, but not both.
  /// </remarks>
  public Data? Data { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <value>
  ///   An <see cref="ExtensionList"/> containing extension elements,
  ///   or <c>null</c> if no extensions are defined.
  /// </value>
  /// <remarks>
  ///   Extension elements allow for future enhancements and custom data source types without breaking
  ///   compatibility with existing implementations. This enables support for new data source configurations
  ///   and connection types as charting capabilities evolve.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}