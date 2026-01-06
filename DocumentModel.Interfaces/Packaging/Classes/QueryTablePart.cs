namespace DocumentModel.Packaging;

/// <summary>
///   Defines the QueryTablePart
/// </summary>
public interface QueryTablePart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}