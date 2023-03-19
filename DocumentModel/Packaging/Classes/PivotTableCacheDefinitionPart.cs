namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PivotTableCacheDefinitionPart
/// </summary>
public class PivotTableCacheDefinitionPart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}