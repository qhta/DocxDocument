namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTablePart
/// </summary>
public partial interface PivotTablePart
{
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets the PivotTableCacheDefinitionPart of the PivotTablePart
  /// </summary>
  public DocumentModel.Packaging.PivotTableCacheDefinitionPart? PivotTableCacheDefinitionPart { get; }
  
  public String? RelationshipType { get; }
  
}
