namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SlicersPart
/// </summary>
[ContentMime("application/vnd.ms-excel.slicer+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2007/relationships/slicer")]
public interface SlicersPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.Slicers? Slicers { get ; set; }
  
}
