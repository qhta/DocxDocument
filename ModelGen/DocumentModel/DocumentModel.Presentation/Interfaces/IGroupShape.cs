namespace DocumentModel.Presentation;

/// <summary>
/// Group Shape.
/// </summary>
public interface IGroupShape // : DocumentModel.Presentation.IGroupShapeType
{
  public INonVisualGroupShapeProperties? NonVisualGroupShapeProperties { get ; set; }
  
  public IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
  public Collection<IShape>? Shapes { get ; set; }
  
  public Collection<IGroupShape>? GroupShapes { get ; set; }
  
  public Collection<IGraphicFrame>? GraphicFrames { get ; set; }
  
  public Collection<IConnectionShape>? ConnectionShapes { get ; set; }
  
  public Collection<IPicture>? Pictures { get ; set; }
  
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
