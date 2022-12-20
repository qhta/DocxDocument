namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTableCacheDefinitionPart
/// </summary>
public partial interface PivotTableCacheDefinitionPart
{
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the PivotTableCacheRecordsPart of the PivotTableCacheDefinitionPart
  /// </summary>
  public DocumentModel.Packaging.PivotTableCacheRecordsPart? PivotTableCacheRecordsPart { get; }
  
  public String? RelationshipType { get; }
  
}
