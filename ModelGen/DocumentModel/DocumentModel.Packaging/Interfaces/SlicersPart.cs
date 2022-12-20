namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlicersPart
/// </summary>
public partial interface SlicersPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
