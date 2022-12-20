namespace DocumentModel.Packaging;

/// <summary>
/// Defines the TimeLinePart
/// </summary>
public partial interface TimeLinePart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
