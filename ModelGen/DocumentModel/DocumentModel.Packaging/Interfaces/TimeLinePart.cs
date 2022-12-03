namespace DocumentModel.Packaging;

/// <summary>
/// Defines the TimeLinePart
/// </summary>
[ContentMime("application/vnd.ms-excel.timeline+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2011/relationships/timeline")]
public interface TimeLinePart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.Timelines? Timelines { get ; set; }
  
}
