namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTableCacheDefinitionPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition")]
[PartConstraint(typeof(DocumentModel.Packaging.PivotTableCacheRecordsPart), false, false)]
public interface PivotTableCacheDefinitionPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.PivotCacheDefinition? PivotCacheDefinition { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
