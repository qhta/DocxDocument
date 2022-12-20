namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Adjust Values.
/// </summary>
public partial interface AdjustValueList
{
  public Collection<DocumentModel.Drawings.ShapeGuide>? ShapeGuides { get; set; }
  
}
