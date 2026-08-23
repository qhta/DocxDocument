namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in a bar chart, including index, order, text, shape properties, inversion, picture options, data points, labels, Trendline, error bars, axis data, values, shape, and extensions.
/// </summary>
[OpenXmlType(typeof(DXDC.BarChartSeries))]
[DataContract]
[XmlRoot("BarChartSeries", Namespace = "DocumentModel.Drawings.Charts")]
public partial class BarChartSeries: ModelElement<DXDC.BarChartSeries>
{
  /// <summary>
  ///   Index of the series within the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BarChartSeries.Index))]
  public UInt32? Index
  {
    get => _Index ??= GetProperty<UInt32?>(GetUpdatableElement()?.Index);
    set => UpdateField(ref _Index, value, nameof(Index));
  }

  private UInt32? _Index;

  /// <summary>
  ///   Order of the series in the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BarChartSeries.Order))]
  public UInt32? Order
  {
    get => _Order ??= GetProperty<UInt32?>(GetUpdatableElement()?.Order);
    set => UpdateField(ref _Order, value, nameof(Order));
  }

  private UInt32? _Order;

  /// <summary>
  ///   Text or name of the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BarChartSeries.SeriesText))]
  public SeriesText? SeriesText
  {
    get => _SeriesText ??= GetProperty<SeriesText?>(GetUpdatableElement()?.SeriesText);
    set => UpdateField(ref _SeriesText, value, nameof(SeriesText));
  }

  private SeriesText? _SeriesText;

  /// <summary>
  ///   Shape properties for the chart series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BarChartSeries.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties ??= GetProperty<ChartShapeProperties?>(GetUpdatableElement()?.ChartShapeProperties);
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;

  /// <summary>
  ///   Indicates whether to invert colors if the value is negative.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BarChartSeries.InvertIfNegative))]
  public bool? InvertIfNegative
  {
    get => _InvertIfNegative ??= GetProperty<bool?>(GetUpdatableElement()?.InvertIfNegative);
    set => UpdateField(ref _InvertIfNegative, value, nameof(InvertIfNegative));
  }

  private bool? _InvertIfNegative;

  /// <summary>
  ///   Picture options for the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BarChartSeries.PictureOptions))]
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
  ///   Shape type for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Shape))]
  public Shape? Shape
  {
    get => _Shape ??= GetElement<Shape, DXDC.Shape>(GetUpdatableElement());
    set => UpdateField(ref _Shape, value, nameof(Shape));
  }

  private Shape? _Shape;

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.BarSerExtensionList))]
  public BarSerExtensionList? BarSerExtensionList
  {
    get => _BarSerExtensionList ??= GetElement<BarSerExtensionList, DXDC.BarSerExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _BarSerExtensionList, value, nameof(BarSerExtensionList));
  }

  private BarSerExtensionList? _BarSerExtensionList;
}