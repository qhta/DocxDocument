namespace DocumentModel.Presentation;

/// <summary>
/// Group Shape.
/// </summary>
public interface GroupShape // : DocumentModel.Presentation.GroupShapeType
{
  public NonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  public GroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public Collection<Shape>? Shapes { get ; set; }
  
  public Collection<GroupShape>? GroupShapes { get ; set; }
  
  public Collection<GraphicFrame>? GraphicFrames { get ; set; }
  
  public Collection<ConnectionShape>? ConnectionShapes { get ; set; }
  
  public Collection<Picture>? Pictures { get ; set; }
  
  public ExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
