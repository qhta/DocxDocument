namespace DocumentModel.Drawings;

/// <summary>
/// Group Shape.
/// </summary>
public interface GroupShape
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  public NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public GroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public Shape? Shape { get ; set; }
  
  public GroupShape? ChildGroupShape { get ; set; }
  
  public GraphicFrame? GraphicFrame { get ; set; }
  
  public ConnectionShape? ConnectionShape { get ; set; }
  
  public Picture? Picture { get ; set; }
  
}
