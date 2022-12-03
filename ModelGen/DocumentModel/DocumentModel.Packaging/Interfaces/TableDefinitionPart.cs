namespace DocumentModel.Packaging;

/// <summary>
/// Defines the TableDefinitionPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.spreadsheetml.table+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/table")]
[PartConstraint(typeof(DocumentModel.Packaging.QueryTablePart), false, true)]
public interface TableDefinitionPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public QueryTablePart? QueryTableParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.Table? Table { get ; set; }
  
}
