namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public partial interface OfPieChart
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  public DocumentModel.Drawings.Charts.OfPieKind? OfPieType { get; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.PieChartSeries>? PieChartSerieses { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabels? DataLabels { get; set; }
  
  public UInt16? GapWidth { get; set; }
  
  public DocumentModel.Drawings.Charts.SplitKind? SplitType { get; set; }
  
  public Double? SplitPosition { get; set; }
  
  public DocumentModel.Drawings.Charts.CustomSplit? CustomSplit { get; set; }
  
  public UInt16? SecondPieSize { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.SeriesLines>? SeriesLineses { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
