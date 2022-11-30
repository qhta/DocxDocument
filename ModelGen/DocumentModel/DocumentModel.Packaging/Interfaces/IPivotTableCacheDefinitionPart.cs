namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTableCacheDefinitionPart
/// </summary>
public interface IPivotTableCacheDefinitionPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotCacheDefinition? PivotCacheDefinition { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
}
