namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTableCacheDefinitionPart
/// </summary>
public interface IPivotTableCacheDefinitionPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotCacheDefinition? PivotCacheDefinition { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
