namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a scatter chart, including style, color variation, series, labels, axis identifiers, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.ScatterChart))]
public partial class ScatterChart: ModelElement<DXDC.ScatterChart>, AbstractChart
{
  /// <summary>
  ///   Style of the scatter chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ScatterChart.ScatterStyle))]
  public ScatterStyle? ScatterStyle
  {
    get => _ScatterStyle;
    set => UpdateField(ref _ScatterStyle, value, nameof(ScatterStyle));
  }
  private ScatterStyle? _ScatterStyle;
  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ScatterChart.VaryColors))]
  public bool? VaryColors { get => _VaryColors; set => UpdateField(ref _VaryColors, value, nameof(VaryColors)); }
  private bool? _VaryColors;
  /// <summary>
  ///   Series displayed in the scatter chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ScatterChartSeries))]
  public ScatterChartSeriesList? ScatterChartSeries
  {
    get => _ScatterChartSeries;
    set => UpdateField(ref _ScatterChartSeries, value, nameof(ScatterChartSeries));
  }
  private ScatterChartSeriesList? _ScatterChartSeries;
  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataLabels))]
  public DataLabels? DataLabels { get => _DataLabels; set => UpdateField(ref _DataLabels, value, nameof(DataLabels)); }
  private DataLabels? _DataLabels;
  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.AxisId))]
  public AxisIds? AxisIds { get => _AxisIds; set => UpdateField(ref _AxisIds, value, nameof(AxisIds)); }
  private AxisIds? _AxisIds;
  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ScatterChartExtensionList))]
  public ScatterChartExtensionList? ScatterChartExtensionList
  {
    get => _ScatterChartExtensionList;
    set => UpdateField(ref _ScatterChartExtensionList, value, nameof(ScatterChartExtensionList));
  }
  private ScatterChartExtensionList? _ScatterChartExtensionList;
}