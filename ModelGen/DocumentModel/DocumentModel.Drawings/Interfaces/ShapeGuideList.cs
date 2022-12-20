namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Guides.
/// </summary>
public partial interface ShapeGuideList
{
  public Collection<DocumentModel.Drawings.ShapeGuide>? ShapeGuides { get; set; }
  
}
