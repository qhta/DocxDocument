namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in a line chart, including index, order, text, shape properties, marker, picture options, data points, labels, Trendline, error bars, axis data, values, smoothing, and extensions.
/// </summary>
[OpenXmlType(typeof(DXDC.LineChartSeries))]
[DataContract]
[XmlRoot("LineChartSeries", Namespace = "DocumentModel.Drawings.Charts")]
public partial class LineChartSeries: ModelElement<DXDC.LineChartSeries>
{
  /// <summary>
  ///   Index of the series within the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.LineChartSeries.Index))]
  public UInt32? Index
  {
    get => _Index ??= GetProperty<UInt32?>(GetUpdatableElement()?.Index);
    set => UpdateField(ref _Index, value, nameof(Index));
  }

  private UInt32? _Index;

  /// <summary>
  ///   Order of the series in the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.LineChartSeries.Order))]
  public UInt32? Order
  {
    get => _Order ??= GetProperty<UInt32?>(GetUpdatableElement()?.Order);
    set => UpdateField(ref _Order, value, nameof(Order));
  }

  private UInt32? _Order;

  /// <summary>
  ///   Text or name of the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.LineChartSeries.SeriesText))]
  public SeriesText? SeriesText
  {
    get => _SeriesText ??= GetProperty<SeriesText?>(GetUpdatableElement()?.SeriesText);
    set => UpdateField(ref _SeriesText, value, nameof(SeriesText));
  }

  private SeriesText? _SeriesText;

  /// <summary>
  ///   Shape properties for the chart series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.LineChartSeries.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties ??= GetProperty<ChartShapeProperties?>(GetUpdatableElement()?.ChartShapeProperties);
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;

  /// <summary>
  ///   Marker configuration for the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.LineChartSeries.Marker))]
  public Marker? Marker
  {
    get => _Marker ??= GetProperty<Marker?>(GetUpdatableElement()?.Marker);
    set => UpdateField(ref _Marker, value, nameof(Marker));
  }

  private Marker? _Marker;

  /// <summary>
  ///   Picture options for the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.LineChartSeries.PictureOptions))]
  public PictureOptions? PictureOptions
  {
    get => _PictureOptions ??= GetProperty<PictureOptions?>(GetUpdatableElement()?.PictureOptions);
    set => UpdateField(ref _PictureOptions, value, nameof(PictureOptions));
  }

  private PictureOptions? _PictureOptions;

  /// <summary>
  ///   Data points contained in the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataPoint))]
  public DataPoints? DataPoints
  {
    get => _DataPoints ??= GetElement<DataPoints, DXDC.DataPoint>(GetUpdatableElement());
    set => UpdateField(ref _DataPoints, value, nameof(DataPoints));
  }

  private DataPoints? _DataPoints;

  /// <summary>
  ///   Data labels configuration for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataLabels))]
  public DataLabels? DataLabels
  {
    get => _DataLabels ??= GetElement<DataLabels, DXDC.DataLabels>(GetUpdatableElement());
    set => UpdateField(ref _DataLabels, value, nameof(DataLabels));
  }

  private DataLabels? _DataLabels;

  /// <summary>
  ///   Trendline associated with the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Trendline))]
  public Trendline? Trendline
  {
    get => _Trendline ??= GetElement<Trendline, DXDC.Trendline>(GetUpdatableElement());
    set => UpdateField(ref _Trendline, value, nameof(Trendline));
  }

  private Trendline? _Trendline;

  /// <summary>
  ///   Error bars for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ErrorBars))]
  public ErrorBars? ErrorBars
  {
    get => _ErrorBars ??= GetElement<ErrorBars, DXDC.ErrorBars>(GetUpdatableElement());
    set => UpdateField(ref _ErrorBars, value, nameof(ErrorBars));
  }

  private ErrorBars? _ErrorBars;

  /// <summary>
  ///   Category axis data for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.CategoryAxisData))]
  public CategoryAxisData? CategoryAxisData
  {
    get => _CategoryAxisData ??= GetElement<CategoryAxisData, DXDC.CategoryAxisData>(GetUpdatableElement());
    set => UpdateField(ref _CategoryAxisData, value, nameof(CategoryAxisData));
  }

  private CategoryAxisData? _CategoryAxisData;

  /// <summary>
  ///   Values for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Values))]
  public Values? Values
  {
    get => _Values ??= GetElement<Values, DXDC.Values>(GetUpdatableElement());
    set => UpdateField(ref _Values, value, nameof(Values));
  }

  private Values? _Values;

  /// <summary>
  ///   Indicates whether the line is smoothed.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Smooth))]
  public bool? Smooth
  {
    get => _Smooth ??= GetElement<bool, DXDC.Smooth>(GetUpdatableElement());
    set => UpdateField(ref _Smooth, value, nameof(Smooth));
  }

  private bool? _Smooth;

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.LineSerExtensionList))]
  public LineSerExtensionList? LineSerExtensionList
  {
    get => _LineSerExtensionList ??= GetElement<LineSerExtensionList, DXDC.LineSerExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _LineSerExtensionList, value, nameof(LineSerExtensionList));
  }

  private LineSerExtensionList? _LineSerExtensionList;
}