namespace DocumentModel.Drawings;

/// <summary>
/// Group Shape.
/// </summary>
public interface GroupShape // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Non-Visual Group Shape Properties.
  /// </summary>
  public NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  /// <summary>
  /// Group Shape Properties.
  /// </summary>
  public GroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public Collection<Shape>? Shapes { get ; set; }
  
  public Collection<GroupShape>? GroupShapes { get ; set; }
  
  public Collection<GraphicFrame>? GraphicFrames { get ; set; }
  
  public Collection<ConnectionShape>? ConnectionShapes { get ; set; }
  
  public Collection<Picture>? Pictures { get ; set; }
  
}
