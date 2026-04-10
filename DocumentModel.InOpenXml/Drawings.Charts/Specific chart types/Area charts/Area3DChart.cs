namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a 3D Area Chart, including grouping, color variation, series, labels, drop lines, gap depth, axis identifiers, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.Area3DChart))]
[XmlRoot("Area3DChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Area3DChart : ModelElement<DXDC.Area3DChart>
{
 /// <summary>
 ///   Specifies the grouping type for the 3D area chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Area3DChart.Grouping))]
 public Grouping? Grouping { get => _Grouping; set => UpdateField(ref _Grouping, value, nameof(Grouping)); }

 private Grouping? _Grouping;
 /// <summary>
 ///   Indicates whether colors should vary between chart series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Area3DChart.VaryColors))]
 public bool? VaryColors { get => _VaryColors; set => UpdateField(ref _VaryColors, value, nameof(VaryColors)); }

 private bool? _VaryColors;
 /// <summary>
 ///   Collection of area chart series displayed in the chart.
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
 ///   Gap depth value for the 3D area chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.GapDepth))]
 public UInt16? GapDepth { get => _GapDepth; set => UpdateField(ref _GapDepth, value, nameof(GapDepth)); }

 private UInt16? _GapDepth;
 /// <summary>
 ///   Identifiers for the axes used in the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.AxisId))]
 public AxisIds? AxisIds { get => _AxisIds; set => UpdateField(ref _AxisIds, value, nameof(AxisIds)); }

 private AxisIds? _AxisIds;
 /// <summary>
 ///   Extension for additional chart properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Area3DChartExtensionList))]
 public Area3DChartExtension? Area3DChartExtension { get => _Area3DChartExtension; set => UpdateField(ref _Area3DChartExtension, value, nameof(Area3DChartExtension)); }

 private Area3DChartExtension? _Area3DChartExtension;
}