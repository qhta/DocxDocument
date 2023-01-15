namespace DocumentModel.Packaging;

/// <summary>
///   Defines the TableDefinitionPart
/// </summary>
public class TableDefinitionPart
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public Collection<QueryTablePart>? QueryTableParts { get; set; }

  public String? RelationshipType { get; set; }
}