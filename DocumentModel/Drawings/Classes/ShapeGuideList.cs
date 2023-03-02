namespace DocumentModel.Drawings;

/// <summary>
///   List of Shape Guides.
/// </summary>
public record ShapeGuideList
{
  public Collection<ShapeGuide>? ShapeGuides { get; set; }
}