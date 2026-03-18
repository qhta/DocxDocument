namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in an area chart, including values, formatting, and data point configuration.
/// </summary>
[OpenXmlType(typeof(DXDC.AreaChartSeries))]
public partial class AreaChartSeries: ModelElement<DXDC.AreaChartSeries>
{
  /// <summary>
  ///   Index of the series within the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.AreaChartSeries.Index))]
  public uint? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

  private uint? _Index;

  /// <summary>
  ///   Order of the series in the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.AreaChartSeries.Order))]
  public uint? Order { get => _Order; set => UpdateField(ref _Order, value, nameof(Order)); }

  private uint? _Order;

  /// <summary>
  ///   Series text or name.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.AreaChartSeries.SeriesText))]
  public SeriesText? SeriesText { get => _SeriesText; set => UpdateField(ref _SeriesText, value, nameof(SeriesText)); }

  private SeriesText? _SeriesText;

  /// <summary>
  ///   Data points for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataPoint))]
  public Collection<DataPoint>? DataPoints
  {
    get => _DataPoints;
    set => UpdateField(ref _DataPoints, value, nameof(DataPoints));
  }

  private Collection<DataPoint>? _DataPoints;

  /// <summary>
  ///   Data labels for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataLabels))]
  public DataLabels? DataLabels { get => _DataLabels; set => UpdateField(ref _DataLabels, value, nameof(DataLabels)); }

  private DataLabels? _DataLabels;

  /// <summary>
  ///   Chart shape properties for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ChartShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties;
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.AreaSerExtensionList))]
  public AreaSerExtensionList? AreaSerExtensionList
  {
    get => _AreaSerExtensionList;
    set => UpdateField(ref _AreaSerExtensionList, value, nameof(AreaSerExtensionList));
  }

  private AreaSerExtensionList? _AreaSerExtensionList;
}