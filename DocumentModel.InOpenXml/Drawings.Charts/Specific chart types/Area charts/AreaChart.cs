namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an area chart, including grouping, color variation, series, labels, drop lines, axis identifiers, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.AreaChart))]
[XmlRoot("AreaChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class AreaChart : ModelElement<DXDC.AreaChart>
{
 /// <summary>
 ///   Specifies the grouping type for the area chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.AreaChart.Grouping))]
 public Grouping? Grouping { get => _Grouping; set => UpdateField(ref _Grouping, value, nameof(Grouping)); }
 private Grouping? _Grouping;

 /// <summary>
 ///   Indicates whether colors should vary between chart series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.AreaChart.VaryColors))]
 public bool? VaryColors { get => _VaryColors; set => UpdateField(ref _VaryColors, value, nameof(VaryColors)); }
 private bool? _VaryColors;

 /// <summary>
 ///   Area chart series displayed in the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.AreaChartSeries))]
 public AreaChartSeriesList? AreaChartSeries { get => _AreaChartSeries; set => UpdateField(ref _AreaChartSeries, value, nameof(AreaChartSeries)); }
 private AreaChartSeriesList? _AreaChartSeries;

 /// <summary>
 ///   Data labels configuration for the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.DataLabels))]
 public DataLabels? DataLabels { get => _DataLabels; set => UpdateField(ref _DataLabels, value, nameof(DataLabels)); }
 private DataLabels? _DataLabels;

 /// <summary>
 ///   Drop lines configuration for the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.DropLines))]
 public DropLines? DropLines { get => _DropLines; set => UpdateField(ref _DropLines, value, nameof(DropLines)); }
 private DropLines? _DropLines;

 /// <summary>
 ///   Identifiers for the axes used in the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.AxisId))]
 public AxisIds? AxisIds { get => _AxisIds; set => UpdateField(ref _AxisIds, value, nameof(AxisIds)); }
 private AxisIds? _AxisIds;

 /// <summary>
 ///   Extension list for additional chart properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.AreaChartExtensionList))]
 public AreaChartExtension? AreaChartExtension { get => _AreaChartExtension; set => UpdateField(ref _AreaChartExtension, value, nameof(AreaChartExtension)); }
 private AreaChartExtension? _AreaChartExtension;
}