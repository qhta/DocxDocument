namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a bar chart, including direction, grouping, color variation, series, labels, gap settings, overlap, series lines, axis identifiers, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.BarChart))]
[DataContract]
[XmlRoot("BarChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class BarChart : ModelElement<DXDC.BarChart>, AbstractChart
{
 /// <summary>
 ///   Direction of the bars in the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.BarChart.BarDirection))]
 public BarDirection? BarDirection { get => _BarDirection; set => UpdateField(ref _BarDirection, value, nameof(BarDirection)); }
 private BarDirection? _BarDirection;

 /// <summary>
 ///   Grouping type for the bars in the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.BarChart.BarGrouping))]
 public BarGrouping? BarGrouping { get => _BarGrouping; set => UpdateField(ref _BarGrouping, value, nameof(BarGrouping)); }
 private BarGrouping? _BarGrouping;

 /// <summary>
 ///   Indicates whether colors should vary between chart series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.BarChart.VaryColors))]
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
 ///   Overlap value for the bars in the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Overlap))]
 public SByte? Overlap { get => _Overlap; set => UpdateField(ref _Overlap, value, nameof(Overlap)); }
 private SByte? _Overlap;

 /// <summary>
 ///   Series lines configuration for the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.SeriesLines))]
 public SeriesLinesList? SeriesLines { get => _SeriesLines; set => UpdateField(ref _SeriesLines, value, nameof(SeriesLines)); }
 private SeriesLinesList? _SeriesLines;

 /// <summary>
 ///   Identifiers for the axes used in the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.AxisId))]
 public AxisIds? AxisIds { get => _AxisIds; set => UpdateField(ref _AxisIds, value, nameof(AxisIds)); }
 private AxisIds? _AxisIds;

 /// <summary>
 ///   Extension list for additional chart properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.BarChartExtensionList))]
 public BarChartExtensionList? BarChartExtensionList { get => _BarChartExtensionList; set => UpdateField(ref _BarChartExtensionList, value, nameof(BarChartExtensionList)); }
 private BarChartExtensionList? _BarChartExtensionList;
}