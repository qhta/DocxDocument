namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents the data source configuration for a chart, specifying whether data is external or embedded.
/// </summary>
/// <remarks>
///   This class defines the data source structure for a chart,
///   which can either reference external data sources or contain embedded data directly within the chart definition.
///   The chart data configuration determines where the chart retrieves its values, categories, and series information.
///   External data typically links to spreadsheet ranges, database connections, or other data sources outside the
///   chart definition, enabling dynamic updates when the source data changes. Embedded data stores the actual data
///   values within the chart structure itself, making the chart self-contained but static. The class also supports
///   custom extensions for additional data source types or configurations. Only one data source type (external or
///   embedded) should typically be specified for a given chart, though the structure allows for flexibility in
///   data source management and future extensibility.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.ChartData))]
[DataContract]
[XmlRoot("ChartData", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class ChartData : ModelElement<DXO16DCD.ChartData>
{
  /// <summary>
  /// Specifies the external data.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ChartData.ExternalData))]
  public ExternalData? ExternalData { get => _ExternalData; set => UpdateField(ref _ExternalData, value, nameof(ExternalData)); }

  private ExternalData? _ExternalData;
  /// <summary>
  /// Specifies the data.
  /// </summary>
  public Data? Data { get => _Data; set => UpdateField(ref _Data, value, nameof(Data)); }

  private Data? _Data;
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private IExtensionList? _ExtensionList;
}