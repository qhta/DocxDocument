namespace DocumentModel.Packaging;

/// <summary>
/// Defines the QueryTablePart
/// </summary>
public interface QueryTablePart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
