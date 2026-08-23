namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a Pie of Pie or Bar of Pie chart, including type, color variation, series, labels, gap width, split options, secondary pie size, series lines, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.OfPieChart))]
[DataContract]
[XmlRoot("OfPieChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class OfPieChart : ModelElement<DXDC.OfPieChart>, AbstractChart
{
  /// <summary>
  ///   Specifies the Pie of Pie or Bar of Pie chart type.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.OfPieChart.OfPieType))]
  public OfPie? OfPieType
  {
    get => _OfPieType ??= GetProperty<OfPie?>(GetUpdatableElement()?.OfPieType);
    set => UpdateField(ref _OfPieType, value, nameof(OfPieType));
  }
  private OfPie? _OfPieType;

  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.OfPieChart.VaryColors))]
  public bool? VaryColors
  {
    get => _VaryColors ??= GetProperty<bool?>(GetUpdatableElement()?.VaryColors);
    set => UpdateField(ref _VaryColors, value, nameof(VaryColors));
  }
  private bool? _VaryColors;

  /// <summary>
  ///   Series displayed in the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.PieChartSeries))]
  public PieChartSeriesList? PieChartSeries
  {
    get => _PieChartSeries ??= GetElement<PieChartSeriesList, DXDC.PieChartSeries>(GetUpdatableElement());
    set => UpdateField(ref _PieChartSeries, value, nameof(PieChartSeries));
  }
  private PieChartSeriesList? _PieChartSeries;

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
  ///   Width of the gap between the main and secondary pie or bar.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.GapWidth))]
  public UInt16? GapWidth
  {
    get => _GapWidth ??= GetElement<UInt16, DXDC.GapWidth>(GetUpdatableElement());
    set => UpdateField(ref _GapWidth, value, nameof(GapWidth));
  }
  private UInt16? _GapWidth;

  /// <summary>
  ///   Type of split used to separate the secondary chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.SplitType))]
  public Split? SplitType
  {
    get => _SplitType ??= GetElement<Split, DXDC.SplitType>(GetUpdatableElement());
    set => UpdateField(ref _SplitType, value, nameof(SplitType));
  }
  private Split? _SplitType;

  /// <summary>
  ///   Position value used for splitting the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.SplitPosition))]
  public Double? SplitPosition
  {
    get => _SplitPosition ??= GetElement<Double, DXDC.SplitPosition>(GetUpdatableElement());
    set => UpdateField(ref _SplitPosition, value, nameof(SplitPosition));
  }
  private Double? _SplitPosition;

  /// <summary>
  ///   Custom split configuration for the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.CustomSplit))]
  public CustomSplit? CustomSplit
  {
    get => _CustomSplit ??= GetElement<CustomSplit, DXDC.CustomSplit>(GetUpdatableElement());
    set => UpdateField(ref _CustomSplit, value, nameof(CustomSplit));
  }
  private CustomSplit? _CustomSplit;

  /// <summary>
  ///   Size of the secondary pie or bar.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.SecondPieSize))]
  public UInt16? SecondPieSize
  {
    get => _SecondPieSize ??= GetElement<UInt16, DXDC.SecondPieSize>(GetUpdatableElement());
    set => UpdateField(ref _SecondPieSize, value, nameof(SecondPieSize));
  }
  private UInt16? _SecondPieSize;

  /// <summary>
  ///   Series lines connecting the main and secondary chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.SeriesLines))]
  public SeriesLinesList? SeriesLines
  {
    get => _SeriesLines ??= GetElement<SeriesLinesList, DXDC.SeriesLines>(GetUpdatableElement());
    set => UpdateField(ref _SeriesLines, value, nameof(SeriesLines));
  }
  private SeriesLinesList? _SeriesLines;

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetElement<IExtensionList, DXDC.ExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }
  private IExtensionList? _ExtensionList;
}