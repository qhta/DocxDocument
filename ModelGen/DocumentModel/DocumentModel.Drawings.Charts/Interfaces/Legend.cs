namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Legend data and formatting.
/// </summary>
public partial interface Legend
{
  /// <summary>
  /// Legend Position.
  /// </summary>
  public DocumentModel.Drawings.Charts.LegendPositionKind? LegendPosition { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.LegendEntry>? LegendEntries { get; set; }
  
  public DocumentModel.Drawings.Charts.Layout? Layout { get; set; }
  
  public Boolean? Overlay { get; set; }
  
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
