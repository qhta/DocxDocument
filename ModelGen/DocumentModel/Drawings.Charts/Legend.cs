namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Legend data and formatting.
/// </summary>
public partial class Legend
{
  
  /// <summary>
  ///   Legend Position.
  /// </summary>
  public DMDC.LegendPositionKind? LegendPosition { get; set; }
  
  public DMDC.Layout? Layout { get; set; }
  
  public DMDC.Overlay? Overlay { get; set; }
  
  public DMDC.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  public DMDC.TextProperties? TextProperties { get; set; }
  
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
