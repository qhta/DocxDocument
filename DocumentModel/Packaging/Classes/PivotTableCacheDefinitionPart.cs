namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PivotTableCacheDefinitionPart
/// </summary>
public record PivotTableCacheDefinitionPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}