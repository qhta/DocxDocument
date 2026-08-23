namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series in an area chart, including values, formatting, and data point configuration.
/// </summary>
///<remarks>
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
[OpenXmlType(typeof(DXDC.AreaChartSeries))]
[DataContract]
[XmlRoot("AreaChartSeries", Namespace = "DocumentModel.Drawings.Charts")]
public partial class AreaChartSeries: ModelElement<DXDC.AreaChartSeries>
{
  /// <summary>
  ///   Index of the series within the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.AreaChartSeries.Index))]
  public uint? Index
  {
    get => _Index ??= GetProperty<uint?>(GetUpdatableElement()?.Index);
    set => UpdateField(ref _Index, value, nameof(Index));
  }

  private uint? _Index;

  /// <summary>
  ///   Order of the series in the chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.AreaChartSeries.Order))]
  public uint? Order
  {
    get => _Order ??= GetProperty<uint?>(GetUpdatableElement()?.Order);
    set => UpdateField(ref _Order, value, nameof(Order));
  }

  private uint? _Order;

  /// <summary>
  ///   Series text or name.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.AreaChartSeries.SeriesText))]
  public SeriesText? SeriesText
  {
    get => _SeriesText ??= GetProperty<SeriesText?>(GetUpdatableElement()?.SeriesText);
    set => UpdateField(ref _SeriesText, value, nameof(SeriesText));
  }

  private SeriesText? _SeriesText;

  /// <summary>
  ///   Data points for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataPoint))]
  public Collection<DataPoint>? DataPoints
  {
    get => _DataPoints ??= GetElement<Collection<DataPoint>, DXDC.DataPoint>(GetUpdatableElement());
    set => UpdateField(ref _DataPoints, value, nameof(DataPoints));
  }

  private Collection<DataPoint>? _DataPoints;

  /// <summary>
  ///   Data labels for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataLabels))]
  public DataLabels? DataLabels
  {
    get => _DataLabels ??= GetElement<DataLabels, DXDC.DataLabels>(GetUpdatableElement());
    set => UpdateField(ref _DataLabels, value, nameof(DataLabels));
  }

  private DataLabels? _DataLabels;

  /// <summary>
  ///   Chart shape properties for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ChartShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties ??= GetElement<ShapeProperties, DXDC.ChartShapeProperties>(GetUpdatableElement());
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  ///   Extension list for additional series properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.AreaSerExtensionList))]
  public AreaSerExtensionList? AreaSerExtensionList
  {
    get => _AreaSerExtensionList ??= GetElement<AreaSerExtensionList, DXDC.AreaSerExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _AreaSerExtensionList, value, nameof(AreaSerExtensionList));
  }

  private AreaSerExtensionList? _AreaSerExtensionList;
}