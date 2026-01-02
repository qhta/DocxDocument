namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PivotTableCacheDefinitionPart
/// </summary>
public class PivotTableCacheDefinitionPart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}