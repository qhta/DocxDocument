namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a line chart, including grouping, color variation, series, labels, drop lines, high-low lines, up-down bars, marker and smoothing options, axis identifiers, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.LineChart))]
[DataContract]
[XmlRoot("LineChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class LineChart : ModelElement<DXDC.LineChart>, AbstractChart
{
 /// <summary>
 ///   Specifies the grouping type for the line chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.LineChart.Grouping))]
 public Grouping? Grouping { get => _Grouping; set => UpdateField(ref _Grouping, value, nameof(Grouping)); }
 private Grouping? _Grouping;

 /// <summary>
 ///   Indicates whether colors should vary between chart series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.LineChart.VaryColors))]
 public bool? VaryColors { get => _VaryColors; set => UpdateField(ref _VaryColors, value, nameof(VaryColors)); }
 private bool? _VaryColors;

 /// <summary>
 ///   Series displayed in the line chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.LineChartSeries))]
 public LineChartSeriesList? LineChartSeries { get => _LineChartSeries; set => UpdateField(ref _LineChartSeries, value, nameof(LineChartSeries)); }
 private LineChartSeriesList? _LineChartSeries;

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
 ///   High-low lines configuration for the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.HighLowLines))]
 public HighLowLines? HighLowLines { get => _HighLowLines; set => UpdateField(ref _HighLowLines, value, nameof(HighLowLines)); }
 private HighLowLines? _HighLowLines;

 /// <summary>
 ///   Up-down bars configuration for the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.UpDownBars))]
 public UpDownBars? UpDownBars { get => _UpDownBars; set => UpdateField(ref _UpDownBars, value, nameof(UpDownBars)); }
 private UpDownBars? _UpDownBars;

 /// <summary>
 ///   Indicates whether markers are shown for data points.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ShowMarker))]
 public bool? ShowMarker { get => _ShowMarker; set => UpdateField(ref _ShowMarker, value, nameof(ShowMarker)); }
 private bool? _ShowMarker;

 /// <summary>
 ///   Indicates whether the lines are smoothed.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Smooth))]
 public bool? Smooth { get => _Smooth; set => UpdateField(ref _Smooth, value, nameof(Smooth)); }
 private bool? _Smooth;

 /// <summary>
 ///   Identifiers for the axes used in the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.AxisId))]
 public AxisIds? AxisIds { get => _AxisIds; set => UpdateField(ref _AxisIds, value, nameof(AxisIds)); }
 private AxisIds? _AxisIds;

 /// <summary>
 ///   Extension list for additional chart properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.LineChartExtensionList))]
 public LineChartExtensionList? LineChartExtensionList { get => _LineChartExtensionList; set => UpdateField(ref _LineChartExtensionList, value, nameof(LineChartExtensionList)); }
 private LineChartExtensionList? _LineChartExtensionList;
}