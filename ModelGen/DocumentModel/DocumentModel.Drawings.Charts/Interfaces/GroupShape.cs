namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Group Shape.
/// </summary>
public interface GroupShape
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.GroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public DocumentModel.Drawings.Charts.Shape? Shape { get ; set; }
  
  public DocumentModel.Drawings.Charts.GroupShape? ChildGroupShape { get ; set; }
  
  public DocumentModel.Drawings.Charts.GraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawings.Charts.ConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawings.Charts.Picture? Picture { get ; set; }
  
}
