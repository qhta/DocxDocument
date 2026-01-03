namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PivotTableCacheDefinitionPart
/// </summary>
public interface PivotTableCacheDefinitionPart: IModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}