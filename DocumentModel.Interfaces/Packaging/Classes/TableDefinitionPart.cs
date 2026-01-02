namespace DocumentModel.Packaging;

/// <summary>
///   Defines the TableDefinitionPart
/// </summary>
public class TableDefinitionPart: ModelElement
{
  public string? ContentType { get; set; }
  /// <summary>
  ///   Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public Collection<QueryTablePart>? QueryTableParts { get; set; }
  public string? RelationshipType { get; set; }
}