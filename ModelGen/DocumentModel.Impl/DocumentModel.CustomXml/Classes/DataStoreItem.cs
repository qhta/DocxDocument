namespace DocumentModel.CustomXml;

/// <summary>
/// Custom XML Data Properties.
/// </summary>
public class DataStoreItemImpl: ModelElementImpl, DataStoreItem
{
  public DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Custom XML Data ID
  /// </summary>
  public String? ItemId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  public SchemaReferences? SchemaReferences
  {
    get;
    set;
  }
  
}
