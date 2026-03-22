namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a surface chart, including wireframe, series, band formats, axis identifiers, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.SurfaceChart))]
public partial class SurfaceChart: ModelElement<DXDC.SurfaceChart>, IChart
{
  /// <summary>
  ///   Indicates whether the chart is rendered as a wireframe.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.SurfaceChart.Wireframe))]
  public bool? Wireframe { get => _Wireframe; set => UpdateField(ref _Wireframe, value, nameof(Wireframe)); }
  private bool? _Wireframe;
  /// <summary>
  ///   Series displayed in the surface chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.SurfaceChartSeries))]
  public SurfaceChartSeriesList? SurfaceChartSeries
  {
    get => _SurfaceChartSeries;
    set => UpdateField(ref _SurfaceChartSeries, value, nameof(SurfaceChartSeries));
  }
  private SurfaceChartSeriesList? _SurfaceChartSeries;
  /// <summary>
  ///   Band formats configuration for the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.BandFormats))]
  public BandFormats? BandFormats
  {
    get => _BandFormats;
    set => UpdateField(ref _BandFormats, value, nameof(BandFormats));
  }
  private BandFormats? _BandFormats;
  /// <summary>
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.AxisId))]
  public AxisIds? AxisIds { get => _AxisIds; set => UpdateField(ref _AxisIds, value, nameof(AxisIds)); }
  private AxisIds? _AxisIds;
  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.SurfaceChartExtensionList))]
  public SurfaceChartExtensionList? SurfaceChartExtensionList
  {
    get => _SurfaceChartExtensionList;
    set => UpdateField(ref _SurfaceChartExtensionList, value, nameof(SurfaceChartExtensionList));
  }
  private SurfaceChartExtensionList? _SurfaceChartExtensionList;
}