namespace DocumentModel.Packaging;

/// <summary>
///   Defines the TableDefinitionPart
/// </summary>
public interface TableDefinitionPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public QueryTableParts QueryTableParts { get; set; }
  public string? RelationshipType { get; set; }
}