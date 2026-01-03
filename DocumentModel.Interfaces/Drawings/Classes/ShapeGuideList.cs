namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Guides.
/// </summary>
public interface ShapeGuideList: IModelElement
{
  public Collection<ShapeGuide>? ShapeGuides { get; set; }
}