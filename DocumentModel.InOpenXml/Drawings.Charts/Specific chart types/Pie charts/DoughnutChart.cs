namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a doughnut chart, including color variation, series, labels, first slice angle, hole size, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.DoughnutChart))]
[DataContract]
[XmlRoot("DoughnutChart", Namespace = "DocumentModel.Drawings.Charts")]
public partial class DoughnutChart : ModelElement<DXDC.DoughnutChart>
{
 /// <summary>
 ///   Indicates whether colors should vary between chart series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.DoughnutChart.VaryColors))]
 public bool? VaryColors { get => _VaryColors ??= GetProperty<bool?>(GetUpdatableElement()?.VaryColors); set => UpdateField(ref _VaryColors, value, nameof(VaryColors)); }
 private bool? _VaryColors;

 /// <summary>
 ///   Series displayed in the doughnut chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.PieChartSeries))]
 public PieChartSeriesList? PieChartSeries { get => _PieChartSeries ??= GetElement<PieChartSeriesList, DXDC.PieChartSeries>(GetUpdatableElement()); set => UpdateField(ref _PieChartSeries, value, nameof(PieChartSeries)); }
 private PieChartSeriesList? _PieChartSeries;

 /// <summary>
 ///   Data labels configuration for the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.DataLabels))]
 public DataLabels? DataLabels { get => _DataLabels ??= GetElement<DataLabels, DXDC.DataLabels>(GetUpdatableElement()); set => UpdateField(ref _DataLabels, value, nameof(DataLabels)); }
 private DataLabels? _DataLabels;

 /// <summary>
 ///   Angle of the first slice in the chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.FirstSliceAngle))]
 public UInt16? FirstSliceAngle { get => _FirstSliceAngle ??= GetElement<UInt16, DXDC.FirstSliceAngle>(GetUpdatableElement()); set => UpdateField(ref _FirstSliceAngle, value, nameof(FirstSliceAngle)); }
 private UInt16? _FirstSliceAngle;

 /// <summary>
 ///   Size of the hole in the center of the doughnut chart.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.HoleSize))]
 public Byte? HoleSize { get => _HoleSize ??= GetElement<Byte, DXDC.HoleSize>(GetUpdatableElement()); set => UpdateField(ref _HoleSize, value, nameof(HoleSize)); }
 private Byte? _HoleSize;

 /// <summary>
 ///   Extension list for additional chart properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ExtensionList))]
 public IExtensionList? ExtensionList { get => _ExtensionList ??= GetElement<IExtensionList, DXDC.ExtensionList>(GetUpdatableElement()); set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private IExtensionList? _ExtensionList;
}