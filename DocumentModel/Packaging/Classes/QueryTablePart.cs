namespace DocumentModel.Packaging;

/// <summary>
///   Defines the QueryTablePart
/// </summary>
public class QueryTablePart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}