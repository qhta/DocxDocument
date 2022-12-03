namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomXmlPropertiesPart
/// </summary>
[ContentMime("application/vnd.openxmlformats-officedocument.customXmlProperties+xml")]
[RelationshipUri("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps")]
public interface CustomXmlPropertiesPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.CustomXml.DataStoreItem? DataStoreItem { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
