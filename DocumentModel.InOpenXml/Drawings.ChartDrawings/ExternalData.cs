namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a reference to external data source for a chart with automatic update capabilities.
/// </summary>
/// <remarks>
///   This class defines an external data source connection for charts
///   that links to data stored outside the chart definition, typically in Excel worksheets, database queries, or
///   other external data providers. External data references enable charts to remain synchronized with their source
///   data through relationship-based connections, supporting dynamic visualizations that automatically reflect changes
///   in the underlying data. The external data mechanism is referenced by <see cref = "ChartData"/> when charts use
///   external rather than embedded data sources. This approach is preferred for charts that need to display current
///   data, as it avoids data duplication and ensures consistency between the source and the chart visualization.
///   The connection is established through a relationship identifier that points to the external data source within
///   the document package or to external files. The <see cref = "AutoUpdate"/> property controls whether the chart
///   automatically refreshes when the document is opened or when the source data changes, enabling real-time or
///   on-demand data updates. External data references are commonly used in scenarios such as dashboard reports that
///   pull from live data sources, presentation charts linked to Excel workbooks, or analytical visualizations connected
///   to databases or web services. This mechanism supports various data formats and connection types while maintaining
///   the chart structure separate from the data, promoting efficient document management and enabling multiple charts
///   to share the same data source. When a document with external data references is opened, Office can refresh the
///   chart data from the source if the relationship is still valid and accessible, or preserve the last-known data
///   if the source is unavailable.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.ExternalData))]
[DataContract]
[XmlRoot("ExternalData", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class ExternalData : ModelElement<DXO16DCD.ExternalData>
{
  /// <summary>
  /// Specifies the unique identifier of the element.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ExternalData.Id))]
  public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

  private string? _Id;
  /// <summary>
  /// Specifies the auto update.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ExternalData.AutoUpdate))]
  public bool? AutoUpdate { get => _AutoUpdate; set => UpdateField(ref _AutoUpdate, value, nameof(AutoUpdate)); }

  private bool? _AutoUpdate;
}