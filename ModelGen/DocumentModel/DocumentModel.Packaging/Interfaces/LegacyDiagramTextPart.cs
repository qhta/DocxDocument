namespace DocumentModel.Packaging;

/// <summary>
/// Defines the LegacyDiagramTextPart
/// </summary>
public partial interface LegacyDiagramTextPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
