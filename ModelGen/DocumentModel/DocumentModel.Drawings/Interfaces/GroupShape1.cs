namespace DocumentModel.Drawings;

/// <summary>
/// Group Shape.
/// </summary>
public interface GroupShape1
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  public NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public GroupShapeProperties1? GroupShapeProperties { get ; set; }
  
  public Collection<Shape1>? Shapes { get ; set; }
  
  public Collection<GroupShape1>? GroupShapes { get ; set; }
  
  public Collection<GraphicFrame>? GraphicFrames { get ; set; }
  
  public Collection<ConnectionShape>? ConnectionShapes { get ; set; }
  
  public Collection<Picture>? Pictures { get ; set; }
  
}
