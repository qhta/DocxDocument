namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BubbleChartSeries Class.
/// </summary>
[OpenXmlType(typeof(DXDC.BubbleChartSeries))]
public partial class BubbleChartSeries: ModelElement<DXDC.BubbleChartSeries>
{
  /// <summary>
  ///   Index.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BubbleChartSeries.Index))]
  public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

  private UInt32? _Index;

  /// <summary>
  ///   Order.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BubbleChartSeries.Order))]
  public UInt32? Order { get => _Order; set => UpdateField(ref _Order, value, nameof(Order)); }

  private UInt32? _Order;

  /// <summary>
  ///   Series Text.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BubbleChartSeries.SeriesText))]
  public SeriesText? SeriesText { get => _SeriesText; set => UpdateField(ref _SeriesText, value, nameof(SeriesText)); }

  private SeriesText? _SeriesText;

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BubbleChartSeries.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties;
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;

  /// <summary>
  ///   PictureOptions.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BubbleChartSeries.PictureOptions))]
  public PictureOptions? PictureOptions
  {
    get => _PictureOptions;
    set => UpdateField(ref _PictureOptions, value, nameof(PictureOptions));
  }

  private PictureOptions? _PictureOptions;

  /// <summary>
  ///   InvertIfNegative.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.BubbleChartSeries.InvertIfNegative))]
  public bool? InvertIfNegative
  {
    get => _InvertIfNegative;
    set => UpdateField(ref _InvertIfNegative, value, nameof(InvertIfNegative));
  }

  private bool? _InvertIfNegative;

  /// <summary>
  /// DataPoints.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataPoint))]
  public DataPoints? DataPoints { get => _DataPoints; set => UpdateField(ref _DataPoints, value, nameof(DataPoints)); }

  private DataPoints? _DataPoints;

  /// <summary>
  /// DataLabels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataLabels))]
  public DataLabels? DataLabels { get => _DataLabels; set => UpdateField(ref _DataLabels, value, nameof(DataLabels)); }

  private DataLabels? _DataLabels;

  /// <summary>
  /// Trendline.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Trendline))]
  public Trendline? Trendline { get => _Trendline; set => UpdateField(ref _Trendline, value, nameof(Trendline)); }

  private Trendline? _Trendline;

  /// <summary>
  /// ErrorBars.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ErrorBars))]
  public ErrorBars? ErrorBars { get => _ErrorBars; set => UpdateField(ref _ErrorBars, value, nameof(ErrorBars)); }

  private ErrorBars? _ErrorBars;

  /// <summary>
  /// XValues.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.XValues))]
  public XValues? XValues { get => _XValues; set => UpdateField(ref _XValues, value, nameof(XValues)); }

  private XValues? _XValues;

  /// <summary>
  /// YValues.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.YValues))]
  public YValues? YValues { get => _YValues; set => UpdateField(ref _YValues, value, nameof(YValues)); }

  private YValues? _YValues;

  /// <summary>
  /// BubbleSize.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.BubbleSize))]
  public BubbleSize? BubbleSize { get => _BubbleSize; set => UpdateField(ref _BubbleSize, value, nameof(BubbleSize)); }

  private BubbleSize? _BubbleSize;

  /// <summary>
  /// Bubble3D.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Bubble3D))]
  public bool? Bubble3D { get => _Bubble3D; set => UpdateField(ref _Bubble3D, value, nameof(Bubble3D)); }

  private bool? _Bubble3D;

  /// <summary>
  /// Bubble Series Extension List.
  /// </summary> 
  [OpenXmlElement(typeof(DXDC.BubbleSerExtensionList))]
  public BubbleSerExtensionList? BubbleSerExtensionList
  {
    get => _BubbleSerExtensionList;
    set => UpdateField(ref _BubbleSerExtensionList, value, nameof(BubbleSerExtensionList));
  }

  private BubbleSerExtensionList? _BubbleSerExtensionList;
}