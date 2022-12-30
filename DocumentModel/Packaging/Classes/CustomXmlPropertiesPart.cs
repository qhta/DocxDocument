namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomXmlPropertiesPart
/// </summary>
public partial class CustomXmlPropertiesPart
{
  public String? ContentType { get; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.CustomXml.DataStoreItem? DataStoreItem { get; set; }
  
  public String? RelationshipType { get; }
  
}
