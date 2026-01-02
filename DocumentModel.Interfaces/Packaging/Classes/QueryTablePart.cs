namespace DocumentModel.Packaging;

/// <summary>
///   Defines the QueryTablePart
/// </summary>
public class QueryTablePart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}