namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Guides.
/// </summary>
public interface ShapeGuideList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<ShapeGuide>? ShapeGuides { get ; set; }
  
}
