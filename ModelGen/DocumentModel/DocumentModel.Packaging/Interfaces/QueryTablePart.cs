namespace DocumentModel.Packaging;

/// <summary>
/// Defines the QueryTablePart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.spreadsheetml.queryTable+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable")]
public interface QueryTablePart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.QueryTable? QueryTable { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
