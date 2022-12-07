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
  
  public DataLabels1? DataLabels { get ; set; }
  
  public SplitKind? SplitType { get ; set; }
  
  public CustomSplit? CustomSplit { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
