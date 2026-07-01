namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a series in a scatter chart, including index, order, text, shape properties, marker, data points, labels, Trendline, error bars, X and Y values, smoothing, and extensions.
/// </summary>
[OpenXmlType(typeof(DXDC.ScatterChartSeries))]
[DataContract]
[XmlRoot("ScatterChartSeries", Namespace = "DocumentModel.Drawings.Charts")]
public partial class ScatterChartSeries : ModelElement<DXDC.ScatterChartSeries>
{
 /// <summary>
 ///   Index of the series within the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ScatterChartSeries.Index))]
 public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }
 private UInt32? _Index;

 /// <summary>
 ///   Order of the series in the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ScatterChartSeries.Order))]
 public UInt32? Order { get => _Order; set => UpdateField(ref _Order, value, nameof(Order)); }
 private UInt32? _Order;

 /// <summary>
 ///   Text or name of the series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ScatterChartSeries.SeriesText))]
 public SeriesText? SeriesText { get => _SeriesText; set => UpdateField(ref _SeriesText, value, nameof(SeriesText)); }
 private SeriesText? _SeriesText;

 /// <summary>
 ///   Shape properties for the chart series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ScatterChartSeries.ChartShapeProperties))]
 public ChartShapeProperties? ChartShapeProperties { get => _ChartShapeProperties; set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties)); }
 private ChartShapeProperties? _ChartShapeProperties;

 /// <summary>
 ///   Marker configuration for the series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ScatterChartSeries.Marker))]
 public Marker? Marker { get => _Marker; set => UpdateField(ref _Marker, value, nameof(Marker)); }
 private Marker? _Marker;

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
 ///   X values for the series.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.XValues))]
 public XValues? XValues { get => _XValues; set => UpdateField(ref _XValues, value, nameof(XValues)); }
 private XValues? _XValues;

 /// <summary>
 ///   Y values for the series.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.YValues))]
 public YValues? YValues { get => _YValues; set => UpdateField(ref _YValues, value, nameof(YValues)); }
 private YValues? _YValues;

 /// <summary>
 ///   Indicates whether the line is smoothed.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Smooth))]
 public bool? Smooth { get => _Smooth; set => UpdateField(ref _Smooth, value, nameof(Smooth)); }
 private bool? _Smooth;

 /// <summary>
 ///   Extension list for additional series properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ScatterSerExtensionList))]
 public ScatterSerExtensionList? ScatterSerExtensionList { get => _ScatterSerExtensionList; set => UpdateField(ref _ScatterSerExtensionList, value, nameof(ScatterSerExtensionList)); }
 private ScatterSerExtensionList? _ScatterSerExtensionList;
}