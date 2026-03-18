namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a 3D surface chart, including wireframe, color variation, series, band formats, axis identifiers, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.Surface3DChart))]
public partial class Surface3DChart: ModelElement<DXDC.Surface3DChart>
{
  /// <summary>
  ///   Indicates whether the chart is rendered as a wireframe.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Surface3DChart.Wireframe))]
  public bool? Wireframe { get => _Wireframe; set => UpdateField(ref _Wireframe, value, nameof(Wireframe)); }

  private bool? _Wireframe;

  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Surface3DChart.VaryColors))]
  public bool? VaryColors { get => _VaryColors; set => UpdateField(ref _VaryColors, value, nameof(VaryColors)); }

  private bool? _VaryColors;

  /// <summary>
  ///   Series displayed in the 3D surface chart.
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
  [OpenXmlElement(typeof(DXDC.Surface3DChartExtensionList))]
  public Surface3DChartExtensionList? Surface3DChartExtensionList
  {
    get => _Surface3DChartExtensionList;
    set => UpdateField(ref _Surface3DChartExtensionList, value, nameof(Surface3DChartExtensionList));
  }

  private Surface3DChartExtensionList? _Surface3DChartExtensionList;
}