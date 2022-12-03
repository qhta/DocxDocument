namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTableCacheRecordsPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheRecords+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords")]
public interface PivotTableCacheRecordsPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.PivotCacheRecords? PivotCacheRecords { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
