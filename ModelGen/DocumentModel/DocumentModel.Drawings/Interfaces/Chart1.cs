namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public interface Chart1
{
  /// <summary>
  /// ChartTitle.
  /// </summary>
  public ChartTitle? ChartTitle { get ; set; }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public PlotArea1? PlotArea { get ; set; }
  
  /// <summary>
  /// Legend.
  /// </summary>
  public Legend1? Legend { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList { get ; set; }
  
}
