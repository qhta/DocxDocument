namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public partial class Chart
{
  /// <summary>
  /// ChartTitle.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ChartTitle? ChartTitle { get; set; }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.PlotArea? PlotArea { get; set; }
  
  /// <summary>
  /// Legend.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.Legend? Legend { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get; set; }
  
}
