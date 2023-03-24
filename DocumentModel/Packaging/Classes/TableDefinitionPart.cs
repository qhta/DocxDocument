namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableDefinitionPart
/// </summary>
public class TableDefinitionPart: ModelElement
{
  public String? ContentType { get; set; }

  /// <summary>
  ///   Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public Collection<QueryTablePart>? QueryTableParts { get; set; }

  public String? RelationshipType { get; set; }
}