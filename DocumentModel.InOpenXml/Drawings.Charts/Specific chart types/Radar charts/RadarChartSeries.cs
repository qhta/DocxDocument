namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in a radar chart, including index, order, text, shape properties, picture options, marker, data points, labels, axis data, values, and extensions.
/// </summary>
[OpenXmlType(typeof(DXDC.RadarChartSeries))]
public partial class RadarChartSeries: ModelElement<DXDC.RadarChartSeries>
{
  /// <summary>
  ///   Index of the series within the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.RadarChartSeries.Index))]
  public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

  private UInt32? _Index;

  /// <summary>
  ///   Order of the series in the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.RadarChartSeries.Order))]
  public UInt32? Order { get => _Order; set => UpdateField(ref _Order, value, nameof(Order)); }

  private UInt32? _Order;

  /// <summary>
  ///   Text or name of the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.RadarChartSeries.SeriesText))]
  public SeriesText? SeriesText { get => _SeriesText; set => UpdateField(ref _SeriesText, value, nameof(SeriesText)); }

  private SeriesText? _SeriesText;

  /// <summary>
  ///   Shape properties for the chart series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.RadarChartSeries.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties;
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;

  /// <summary>
  ///   Picture options for the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.RadarChartSeries.PictureOptions))]
  public PictureOptions? PictureOptions
  {
    get => _PictureOptions;
    set => UpdateField(ref _PictureOptions, value, nameof(PictureOptions));
  }

  private PictureOptions? _PictureOptions;

  /// <summary>
  ///   Marker configuration for the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.RadarChartSeries.Marker))]
  public Marker? Marker { get => _Marker; set => UpdateField(ref _Marker, value, nameof(Marker)); }

  private Marker? _Marker;

  /// <summary>
  ///   Data points contained in the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataPoint))]
  public DataPoints? DataPoints { get => _DataPoints; set => UpdateField(ref _DataPoints, value, nameof(DataPoints)); }

  private DataPoints? _DataPoints;

  /// <summary>
  ///   Data labels configuration for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataLabels))]
  public DataLabels? DataLabels { get => _DataLabels; set => UpdateField(ref _DataLabels, value, nameof(DataLabels)); }

  private DataLabels? _DataLabels;

  /// <summary>
  ///   Category axis data for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.CategoryAxisData))]
  public CategoryAxisData? CategoryAxisData
  {
    get => _CategoryAxisData;
    set => UpdateField(ref _CategoryAxisData, value, nameof(CategoryAxisData));
  }

  private CategoryAxisData? _CategoryAxisData;

  /// <summary>
  ///   Values for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Values))]
  public Values? Values { get => _Values; set => UpdateField(ref _Values, value, nameof(Values)); }

  private Values? _Values;

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.RadarSerExtensionList))]
  public RadarSerExtensionList? RadarSerExtensionList
  {
    get => _RadarSerExtensionList;
    set => UpdateField(ref _RadarSerExtensionList, value, nameof(RadarSerExtensionList));
  }

  private RadarSerExtensionList? _RadarSerExtensionList;
}