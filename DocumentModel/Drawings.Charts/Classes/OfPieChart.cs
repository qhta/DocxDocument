namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Pie of Pie or Bar of Pie Charts.
/// </summary>
public class OfPieChart
{
  /// <summary>
  ///   Pie of Pie or Bar of Pie Type.
  /// </summary>
  public OfPieKind? OfPieType { get; set; }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }

  public Collection<PieChartSeries>? PieChartSeries { get; set; }

  public DataLabels? DataLabels { get; set; }

  public UInt16? GapWidth { get; set; }

  public SplitKind? SplitType { get; set; }

  public Double? SplitPosition { get; set; }

  public CustomSplit? CustomSplit { get; set; }

  public UInt16? SecondPieSize { get; set; }

  public Collection<SeriesLines>? SeriesLines { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}