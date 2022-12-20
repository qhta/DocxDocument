namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Shape Adjust List.
/// </summary>
public partial interface AdjustList
{
  public Collection<DocumentModel.Drawings.Diagrams.Adjust>? Adjusts { get; set; }
  
}
