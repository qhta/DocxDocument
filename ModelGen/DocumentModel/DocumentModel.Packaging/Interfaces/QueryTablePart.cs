namespace DocumentModel.Packaging;

/// <summary>
/// Defines the QueryTablePart
/// </summary>
public partial interface QueryTablePart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
