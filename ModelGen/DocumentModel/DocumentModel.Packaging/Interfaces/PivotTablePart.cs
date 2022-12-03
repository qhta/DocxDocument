namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTablePart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.spreadsheetml.pivotTable+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable")]
[PartConstraint(typeof(DocumentModel.Packaging.PivotTableCacheDefinitionPart), true, false)]
public interface PivotTablePart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.PivotTableDefinition? PivotTableDefinition { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
