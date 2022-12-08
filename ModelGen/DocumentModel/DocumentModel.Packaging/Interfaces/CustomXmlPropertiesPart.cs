namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomXmlPropertiesPart
/// </summary>
public interface CustomXmlPropertiesPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.CustomXml.DataStoreItem? DataStoreItem { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
