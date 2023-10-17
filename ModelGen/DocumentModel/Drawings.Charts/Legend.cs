namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Legend data and formatting.
/// </summary>
public partial class Legend
{
  
  /// <summary>
  ///   Legend Position.
  /// </summary>
  public DocumentModel.Drawings.Charts.LegendPositionKind? LegendPosition { get; set; }
  
  public DocumentModel.Drawings.Charts.Layout? Layout { get; set; }
  
  public DocumentModel.Drawings.Charts.Overlay? Overlay { get; set; }
  
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
  public DM.ElementCollection<LegendEntry>? Items { get; set; }
  
}
