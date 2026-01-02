namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Guides.
/// </summary>
public class ShapeGuideList: ModelElement
{
  public Collection<ShapeGuide>? ShapeGuides { get; set; }
}