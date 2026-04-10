namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a series in a pie chart, including index, order, text, shape properties, picture options, explosion, data points, labels, axis data, values, and extensions.
/// </summary>
[OpenXmlType(typeof(DXDC.PieChartSeries))]
[XmlRoot("PieChartSeries", Namespace = "DocumentModel.Drawings.Charts")]
public partial class PieChartSeries : ModelElement<DXDC.PieChartSeries>
{
 /// <summary>
 ///   Index of the series within the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PieChartSeries.Index))]
 public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }

 private UInt32? _Index;
 /// <summary>
 ///   Order of the series in the chart.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PieChartSeries.Order))]
 public UInt32? Order { get => _Order; set => UpdateField(ref _Order, value, nameof(Order)); }

 private UInt32? _Order;
 /// <summary>
 ///   Text or name of the series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PieChartSeries.SeriesText))]
 public SeriesText? SeriesText { get => _SeriesText; set => UpdateField(ref _SeriesText, value, nameof(SeriesText)); }

 private SeriesText? _SeriesText;
 /// <summary>
 ///   Shape properties for the chart series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PieChartSeries.ChartShapeProperties))]
 public ChartShapeProperties? ChartShapeProperties { get => _ChartShapeProperties; set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties)); }

 private ChartShapeProperties? _ChartShapeProperties;
 /// <summary>
 ///   Picture options for the series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PieChartSeries.PictureOptions))]
 public PictureOptions? PictureOptions { get => _PictureOptions; set => UpdateField(ref _PictureOptions, value, nameof(PictureOptions)); }

 private PictureOptions? _PictureOptions;
 /// <summary>
 ///   Explosion value indicating how far a slice is pulled from the pie.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PieChartSeries.Explosion))]
 public UInt32? Explosion { get => _Explosion; set => UpdateField(ref _Explosion, value, nameof(Explosion)); }

 private UInt32? _Explosion;
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
 ///   Category axis data for the series.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.CategoryAxisData))]
 public CategoryAxisData? CategoryAxisData { get => _CategoryAxisData; set => UpdateField(ref _CategoryAxisData, value, nameof(CategoryAxisData)); }

 private CategoryAxisData? _CategoryAxisData;
 /// <summary>
 ///   Values for the series.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Values))]
 public Values? Values { get => _Values; set => UpdateField(ref _Values, value, nameof(Values)); }

 private Values? _Values;
 /// <summary>
 ///   Extension list for additional series properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.PieSerExtensionList))]
 public PieSerExtensionList? PieSerExtensionList { get => _PieSerExtensionList; set => UpdateField(ref _PieSerExtensionList, value, nameof(PieSerExtensionList)); }

 private PieSerExtensionList? _PieSerExtensionList;
}