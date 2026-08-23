namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a stock chart, including series, labels, drop lines, high-low lines, up-down bars, axis identifiers, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.StockChart))]
[DataContract]
[XmlRoot("StockChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class StockChart: ModelElement<DXDC.StockChart>
{
  /// <summary>
  ///   Series displayed in the stock chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.LineChartSeries))]
  public LineChartSeriesList? LineChartSeries
  {
    get => _LineChartSeries ??= GetElement<LineChartSeriesList, DXDC.LineChartSeries>(GetUpdatableElement());
    set => UpdateField(ref _LineChartSeries, value, nameof(LineChartSeries));
  }

  private LineChartSeriesList? _LineChartSeries;

  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataLabels))]
  public DataLabels? DataLabels
  {
    get => _DataLabels ??= GetElement<DataLabels, DXDC.DataLabels>(GetUpdatableElement());
    set => UpdateField(ref _DataLabels, value, nameof(DataLabels));
  }

  private DataLabels? _DataLabels;

  /// <summary>
  ///   Drop lines configuration for the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DropLines))]
  public DropLines? DropLines
  {
    get => _DropLines ??= GetElement<DropLines, DXDC.DropLines>(GetUpdatableElement());
    set => UpdateField(ref _DropLines, value, nameof(DropLines));
  }

  private DropLines? _DropLines;

  /// <summary>
  ///   High-low lines configuration for the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.HighLowLines))]
  public HighLowLines? HighLowLines
  {
    get => _HighLowLines ??= GetElement<HighLowLines, DXDC.HighLowLines>(GetUpdatableElement());
    set => UpdateField(ref _HighLowLines, value, nameof(HighLowLines));
  }

  private HighLowLines? _HighLowLines;

  /// <summary>
  ///   Up-down bars configuration for the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.UpDownBars))]
  public UpDownBars? UpDownBars
  {
    get => _UpDownBars ??= GetElement<UpDownBars, DXDC.UpDownBars>(GetUpdatableElement());
    set => UpdateField(ref _UpDownBars, value, nameof(UpDownBars));
  }

  private UpDownBars? _UpDownBars;

  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.AxisId))]
  public AxisIds? AxisIds
  {
    get => _AxisIds ??= GetElement<AxisIds, DXDC.AxisId>(GetUpdatableElement());
    set => UpdateField(ref _AxisIds, value, nameof(AxisIds));
  }

  private AxisIds? _AxisIds;

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.StockChartExtensionList))]
  public StockChartExtensionList? StockChartExtensionList
  {
    get => _StockChartExtensionList ??=
      GetElement<StockChartExtensionList, DXDC.StockChartExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _StockChartExtensionList, value, nameof(StockChartExtensionList));
  }

  private StockChartExtensionList? _StockChartExtensionList;
}