namespace DocumentModel.Packaging;

/// <summary>
///   Defines the PivotTableCacheDefinitionPart
/// </summary>
public interface PivotTableCacheDefinitionPart: OpenXmlPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}