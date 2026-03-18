namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a Pie of Pie or Bar of Pie chart, including type, color variation, series, labels, gap width, split options, secondary pie size, series lines, and extension list.
/// </summary>
public class OfPieChart : ModelElement<DXDC.OfPieChart>
{
  /// <summary>
  ///   Specifies the Pie of Pie or Bar of Pie chart type.
  /// </summary>
  public OfPie? OfPieType { get; set; }

  /// <summary>
  ///   Indicates whether colors should vary between chart series.
  /// </summary>
  public bool? VaryColors { get; set; }

  /// <summary>
  ///   Series displayed in the chart.
  /// </summary>
  public PieChartSeriesList? PieChartSeries { get; set; }

  /// <summary>
  ///   Data labels configuration for the chart.
  /// </summary>
  public DataLabels? DataLabels { get; set; }

  /// <summary>
  ///   Width of the gap between the main and secondary pie or bar.
  /// </summary>
  public UInt16? GapWidth { get; set; }

  /// <summary>
  ///   Type of split used to separate the secondary chart.
  /// </summary>
  public Split? SplitType { get; set; }

  /// <summary>
  ///   Position value used for splitting the chart.
  /// </summary>
  public Double? SplitPosition { get; set; }

  /// <summary>
  ///   Custom split configuration for the chart.
  /// </summary>
  public CustomSplit? CustomSplit { get; set; }

  /// <summary>
  ///   Size of the secondary pie or bar.
  /// </summary>
  public UInt16? SecondPieSize { get; set; }

  /// <summary>
  ///   Series lines connecting the main and secondary chart.
  /// </summary>
  public SeriesLinesList? SeriesLines { get; set; }

  /// <summary>
  ///   Extension list for additional chart properties.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}