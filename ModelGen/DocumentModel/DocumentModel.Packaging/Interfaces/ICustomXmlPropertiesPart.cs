namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomXmlPropertiesPart
/// </summary>
public interface ICustomXmlPropertiesPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.CustomXml.IDataStoreItem? DataStoreItem { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
