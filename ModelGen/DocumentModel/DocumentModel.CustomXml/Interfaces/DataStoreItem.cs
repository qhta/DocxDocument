namespace DocumentModel.CustomXml;

/// <summary>
/// Custom XML Data Properties.
/// </summary>
public partial interface DataStoreItem
{
  /// <summary>
  /// Custom XML Data ID
  /// </summary>
  public String? ItemId { get; set; }
  
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  public DocumentModel.CustomXml.SchemaReferences? SchemaReferences { get; set; }
  
  /// <summary>
  /// Gets the CustomXmlPropertiesPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.CustomXmlPropertiesPart? CustomXmlPropertiesPart { get; set; }
  
}
