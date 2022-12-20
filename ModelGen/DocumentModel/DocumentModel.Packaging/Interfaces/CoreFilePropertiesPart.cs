namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CoreFilePropertiesPart
/// </summary>
public partial interface CoreFilePropertiesPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
