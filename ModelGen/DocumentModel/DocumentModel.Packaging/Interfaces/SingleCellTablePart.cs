namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SingleCellTablePart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.spreadsheetml.tableSingleCells+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells")]
public interface SingleCellTablePart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.SingleXmlCells? SingleXmlCells { get ; set; }
  
}
