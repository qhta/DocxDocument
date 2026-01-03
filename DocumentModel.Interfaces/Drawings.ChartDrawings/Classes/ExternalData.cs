namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a reference to external data source for a chart with automatic update capabilities.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines an external data source connection for charts
///   that links to data stored outside the chart definition, typically in Excel worksheets, database queries, or
///   other external data providers. External data references enable charts to remain synchronized with their source
///   data through relationship-based connections, supporting dynamic visualizations that automatically reflect changes
///   in the underlying data. The external data mechanism is referenced by <see cref="ChartData"/> when charts use
///   external rather than embedded data sources. This approach is preferred for charts that need to display current
///   data, as it avoids data duplication and ensures consistency between the source and the chart visualization.
///   The connection is established through a relationship identifier that points to the external data source within
///   the document package or to external files. The <see cref="AutoUpdate"/> property controls whether the chart
///   automatically refreshes when the document is opened or when the source data changes, enabling real-time or
///   on-demand data updates. External data references are commonly used in scenarios such as dashboard reports that
///   pull from live data sources, presentation charts linked to Excel workbooks, or analytical visualizations connected
///   to databases or web services. This mechanism supports various data formats and connection types while maintaining
///   the chart structure separate from the data, promoting efficient document management and enabling multiple charts
///   to share the same data source. When a document with external data references is opened, Office can refresh the
///   chart data from the source if the relationship is still valid and accessible, or preserve the last-known data
///   if the source is unavailable.
/// </remarks>
public interface ExternalData : IModelElement
{
  /// <summary>
  ///   Gets or sets the relationship identifier that references the external data source.
  /// </summary>
  /// <value>
  ///   A string containing the relationship ID that links to the external data source,
  ///   or <c>null</c> if no external data connection is specified.
  /// </value>
  /// <remarks>
   ///   The relationship identifier (RelId) establishes the connection between the chart and its external data source
  ///   by referencing a relationship defined in the document's relationship structure. This ID corresponds to a
  ///   relationship entry that specifies the location and type of the external data source, such as a reference to
  ///   an Excel worksheet range, a database connection, or another data provider. The relationship-based approach
  ///   enables the external data source to be moved, renamed, or repackaged without breaking the chart connection,
  ///   as long as the relationship is updated accordingly. Office applications use this relationship ID to locate
  ///   and access the external data when the chart needs to be rendered or refreshed. The external data source can
  ///   be part of the same document package (such as an embedded Excel worksheet) or reference external files or
  ///   services, providing flexibility in data source management and enabling various data integration scenarios.
  /// </remarks>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the chart should automatically update from the external data source.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the chart automatically refreshes from the external data source when the document is opened
  ///   or when source data changes; <c>false</c> if manual refresh is required; or <c>null</c> to use the default
  ///   update behavior.
  /// </value>
  /// <remarks>
   ///   The AutoUpdate flag controls whether the chart data is automatically refreshed from the external source,
  ///   enabling real-time or on-demand data updates. When set to <c>true</c>, Office attempts to retrieve the latest
  ///   data from the external source when the document is opened, ensuring the chart displays current information.
  ///   This is particularly valuable for dashboard reports, live data visualizations, or presentations that need to
  ///   show the most recent data without manual intervention. When set to <c>false</c>, the chart retains its last-known
  ///   data and requires manual refresh through user action or programmatic updates. This provides control over when
  ///   data is updated, which can be important for performance reasons, when working offline, or when data consistency
  ///   at a specific point in time needs to be preserved (such as in archived reports or audit documents). The automatic
  ///   update behavior respects document security settings and connection permissions, only updating if the data source
  ///   is accessible and trusted. If the external data source is unavailable during an automatic update attempt, the
  ///   chart preserves its existing data and may display a notification about the unavailable connection.
  /// </remarks>
  public bool? AutoUpdate { get; set; }
}