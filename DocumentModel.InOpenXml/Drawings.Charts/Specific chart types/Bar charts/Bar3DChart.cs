namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a 3D bar chart, including direction, grouping, color variation, series, labels, gap settings, shape, axis identifiers, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.Bar3DChart))]
[DataContract]
[XmlRoot("Bar3DChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Bar3DChart : ModelElement<DXDC.Bar3DChart>
{
 /// <summary>
 ///   Direction of the bars in the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Bar3DChart.BarDirection))]
 public BarDirection? BarDirection { get => _BarDirection; set => UpdateField(ref _BarDirection, value, nameof(BarDirection)); }
 private BarDirection? _BarDirection;

 /// <summary>
 ///   Grouping type for the bars in the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Bar3DChart.BarGrouping))]
 public BarGrouping? BarGrouping { get => _BarGrouping; set => UpdateField(ref _BarGrouping, value, nameof(BarGrouping)); }
 private BarGrouping? _BarGrouping;

 /// <summary>
 ///   Indicates whether colors should vary between chart series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.Bar3DChart.VaryColors))]
 public bool? VaryColors { get => _VaryColors; set => UpdateField(ref _VaryColors, value, nameof(VaryColors)); }
 private bool? _VaryColors;

 /// <summary>
 ///   Collection of bar chart series displayed in the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.BarChartSeries))]
 public BarChartSeriesList? BarChartSeries { get => _BarChartSeries; set => UpdateField(ref _BarChartSeries, value, nameof(BarChartSeries)); }
 private BarChartSeriesList? _BarChartSeries;

 /// <summary>
 ///   Data labels configuration for the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.DataLabels))]
 public DataLabels? DataLabels { get => _DataLabels; set => UpdateField(ref _DataLabels, value, nameof(DataLabels)); }
 private DataLabels? _DataLabels;

 /// <summary>
 ///   Width of the gap between bars.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.GapWidth))]
 public UInt16? GapWidth { get => _GapWidth; set => UpdateField(ref _GapWidth, value, nameof(GapWidth)); }
 private UInt16? _GapWidth;

 /// <summary>
 ///   Depth of the gap between bars in 3D.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.GapDepth))]
 public UInt16? GapDepth { get => _GapDepth; set => UpdateField(ref _GapDepth, value, nameof(GapDepth)); }
 private UInt16? _GapDepth;

 /// <summary>
 ///   Shape type for the bars in the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Shape))]
 public Shape? Shape { get => _Shape; set => UpdateField(ref _Shape, value, nameof(Shape)); }
 private Shape? _Shape;

 /// <summary>
 ///   Identifiers for the axes used in the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.AxisId))]
 public AxisIds? AxisIds { get => _AxisIds; set => UpdateField(ref _AxisIds, value, nameof(AxisIds)); }
 private AxisIds? _AxisIds;

 /// <summary>
 ///   Extension list for additional chart properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Bar3DChartExtensionList))]
 public Bar3DChartExtensionList? Bar3DChartExtensionList { get => _Bar3DChartExtensionList; set => UpdateField(ref _Bar3DChartExtensionList, value, nameof(Bar3DChartExtensionList)); }
 private Bar3DChartExtensionList? _Bar3DChartExtensionList;
}