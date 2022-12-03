namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NamedSheetViewsPart
/// </summary>
[ContentMime("application/vnd.ms-excel.namedsheetviews+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2019/04/relationships/namedSheetView")]
public interface NamedSheetViewsPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.NamedSheetViews? NamedSheetViews { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
