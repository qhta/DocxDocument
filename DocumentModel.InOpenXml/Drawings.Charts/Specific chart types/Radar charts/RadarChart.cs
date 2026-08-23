namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a radar chart, including style, color variation, series, labels, axis identifiers, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.RadarChart))]
[DataContract]
[XmlRoot("RadarChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class RadarChart: ModelElement<DXDC.RadarChart>, AbstractChart
{
  /// <summary>
  ///   Style of the radar chart.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.RadarChart.RadarStyle))]
  public RadarStyle? RadarStyle
  {
    get => _RadarStyle ??= GetProperty<RadarStyle?>(GetUpdatableElement()?.RadarStyle);
    set => UpdateField(ref _RadarStyle, value, nameof(RadarStyle));
  }

  private RadarStyle? _RadarStyle;

  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.RadarChart.VaryColors))]
  public bool? VaryColors
  {
    get => _VaryColors ??= GetProperty<bool?>(GetUpdatableElement()?.VaryColors);
    set => UpdateField(ref _VaryColors, value, nameof(VaryColors));
  }

  private bool? _VaryColors;

  /// <summary>
  ///   Series displayed in the radar chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.RadarChartSeries))]
  public RadarChartSeriesList? RadarChartSeries
  {
    get => _RadarChartSeries ??= GetElement<RadarChartSeriesList, DXDC.RadarChartSeries>(GetUpdatableElement());
    set => UpdateField(ref _RadarChartSeries, value, nameof(RadarChartSeries));
  }

  private RadarChartSeriesList? _RadarChartSeries;

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
  ///   Identifiers for the axes used in the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.AxisId))]
  public AxisIds? AxisIds
  {
    get => _AxisIds ??= GetElement<AxisIds, DXDC.AxisId>(GetUpdatableElement());
    set => UpdateField(ref _AxisIds, value, nameof(AxisIds));
  }

  private AxisIds? _AxisIds;

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.RadarChartExtensionList))]
  public RadarChartExtensionList? RadarChartExtensionList
  {
    get => _RadarChartExtensionList ??=
      GetElement<RadarChartExtensionList, DXDC.RadarChartExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _RadarChartExtensionList, value, nameof(RadarChartExtensionList));
  }

  private RadarChartExtensionList? _RadarChartExtensionList;
}