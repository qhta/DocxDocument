namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetSortMapPart
/// </summary>
[ContentMime("application/vnd.ms-excel.wsSortMap+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2006/relationships/wsSortMap")]
public interface WorksheetSortMapPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.WorksheetSortMap? WorksheetSortMap { get ; set; }
  
}
