namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Point List.
/// </summary>
public partial interface PointList
{
  public Collection<DocumentModel.Drawings.Diagrams.Point>? Points { get; set; }
  
}
