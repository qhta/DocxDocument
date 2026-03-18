namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in an area chart, including index, order, text, shape properties, picture options, data points, labels, Trendline, error bars, axis data, values, and extensions.
/// </summary>
///<remarks>>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties"/> <c>&lt;c:spPr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList"/> <c>&lt;c:extLst&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData"/> <c>&lt;c:cat&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.DataLabels"/> <c>&lt;c:dLbls&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.DataPoint"/> <c>&lt;c:dPt&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.ErrorBars"/> <c>&lt;c:errBars&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Values"/> <c>&lt;c:val&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.PictureOptions"/> <c>&lt;c:pictureOptions&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.SeriesText"/> <c>&lt;c:tx&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Trendline"/> <c>&lt;c:trendline&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Index"/> <c>&lt;c:idx&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Charts.Order"/> <c>&lt;c:order&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlType(typeof(DXO13DC.AreaChartSeries))]
public partial class AreaChartSeries3: ModelElement<DXO13DC.AreaChartSeries>
{
  /// <summary>
  ///   Index of the series within the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DC.AreaChartSeries.Index))]
  public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

  private UInt32? _Index;

  /// <summary>
  ///   Order of the series in the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DC.AreaChartSeries.Order))]
  public UInt32? Order { get => _Order; set => UpdateField(ref _Order, value, nameof(Order)); }

  private UInt32? _Order;

  /// <summary>
  ///   Text or name of the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DC.AreaChartSeries.SeriesText))]
  public SeriesText? SeriesText { get => _SeriesText; set => UpdateField(ref _SeriesText, value, nameof(SeriesText)); }

  private SeriesText? _SeriesText;

  /// <summary>
  ///   Shape properties for the chart series.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DC.AreaChartSeries.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties;
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;

  /// <summary>
  ///   Picture options for the series.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13DC.AreaChartSeries.PictureOptions))]
  public PictureOptions? PictureOptions
  {
    get => _PictureOptions;
    set => UpdateField(ref _PictureOptions, value, nameof(PictureOptions));
  }

  private PictureOptions? _PictureOptions;

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
  ///   Trendline associated with the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Trendline))]
  public Trendline? Trendline { get => _Trendline; set => UpdateField(ref _Trendline, value, nameof(Trendline)); }

  private Trendline? _Trendline;

  /// <summary>
  ///   Error bars for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ErrorBars))]
  public ErrorBars? ErrorBars { get => _ErrorBars; set => UpdateField(ref _ErrorBars, value, nameof(ErrorBars)); }

  private ErrorBars? _ErrorBars;

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
  [OpenXmlElement(typeof(DXDC.AreaSerExtensionList))]
  public AreaSerExtensionList? AreaSerExtensionList
  {
    get => _AreaSerExtensionList;
    set => UpdateField(ref _AreaSerExtensionList, value, nameof(AreaSerExtensionList));
  }

  private AreaSerExtensionList? _AreaSerExtensionList;
}