namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a 3D pie chart, including color variation, series, labels, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.Pie3DChart))]
public partial class Pie3DChart: ModelElement<DXDC.Pie3DChart>, IChart
{
  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Pie3DChart.VaryColors))]
  public bool? VaryColors { get => _VaryColors; set => UpdateField(ref _VaryColors, value, nameof(VaryColors)); }

  private bool? _VaryColors;

  /// <summary>
  ///   Series displayed in the 3D pie chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.PieChartSeries))]
  public PieChartSeriesList? PieChartSeries
  {
    get => _PieChartSeries;
    set => UpdateField(ref _PieChartSeries, value, nameof(PieChartSeries));
  }

  private PieChartSeriesList? _PieChartSeries;

  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.DataLabels))]
  public DataLabels? DataLabels { get => _DataLabels; set => UpdateField(ref _DataLabels, value, nameof(DataLabels)); }

  private DataLabels? _DataLabels;

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Pie3DChartExtensionList))]
  public Pie3DChartExtensionList? Pie3DChartExtensionList
  {
    get => _Pie3DChartExtensionList;
    set => UpdateField(ref _Pie3DChartExtensionList, value, nameof(Pie3DChartExtensionList));
  }

  private Pie3DChartExtensionList? _Pie3DChartExtensionList;
}