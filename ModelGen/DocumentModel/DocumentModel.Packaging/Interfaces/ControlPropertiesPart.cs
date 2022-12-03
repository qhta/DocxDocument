namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ControlPropertiesPart
/// </summary>
[ContentMime("application/vnd.ms-excel.controlproperties+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/ctrlProp")]
public interface ControlPropertiesPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Spreadsheet.FormControlProperties? FormControlProperties { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
