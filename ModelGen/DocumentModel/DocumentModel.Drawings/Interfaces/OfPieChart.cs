namespace DocumentModel.Drawings;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public interface OfPieChart
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  public OfPieKind? OfPieType { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<PieChartSeries1>? PieChartSerieses { get ; set; }
  
  public DataLabels2? DataLabels { get ; set; }
  
  public UInt16? GapWidth { get ; set; }
  
  public SplitKind? SplitType { get ; set; }
  
  public Double? SplitPosition { get ; set; }
  
  public CustomSplit? CustomSplit { get ; set; }
  
  public UInt16? SecondPieSize { get ; set; }
  
  public Collection<SeriesLines>? SeriesLineses { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
