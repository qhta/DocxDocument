namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a pie chart, including color variation, series, labels, first slice angle, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.PieChart))]
[XmlRoot("PieChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class PieChart : ModelElement<DXDC.PieChart>, AbstractChart
{
 /// <summary>
 ///   Indicates whether colors should vary between chart series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PieChart.VaryColors))]
 public bool? VaryColors { get => _VaryColors; set => UpdateField(ref _VaryColors, value, nameof(VaryColors)); }
 private bool? _VaryColors;

 /// <summary>
 ///   Series displayed in the pie chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.PieChartSeries))]
 public PieChartSeriesList? PieChartSeries { get => _PieChartSeries; set => UpdateField(ref _PieChartSeries, value, nameof(PieChartSeries)); }
 private PieChartSeriesList? _PieChartSeries;

 /// <summary>
 ///   Data labels configuration for the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.DataLabels))]
 public DataLabels? DataLabels { get => _DataLabels; set => UpdateField(ref _DataLabels, value, nameof(DataLabels)); }
 private DataLabels? _DataLabels;

 /// <summary>
 ///   Angle of the first slice in the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.FirstSliceAngle))]
 public UInt16? FirstSliceAngle { get => _FirstSliceAngle; set => UpdateField(ref _FirstSliceAngle, value, nameof(FirstSliceAngle)); }
 private UInt16? _FirstSliceAngle;

 /// <summary>
 ///   Extension list for additional chart properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.PieChartExtensionList))]
 public PieChartExtensionList? PieChartExtensionList { get => _PieChartExtensionList; set => UpdateField(ref _PieChartExtensionList, value, nameof(PieChartExtensionList)); }
 private PieChartExtensionList? _PieChartExtensionList;
}