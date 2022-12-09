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
    get => (String?)OpenXmlElement?.ItemId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ItemId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  public SchemaReferences? SchemaReferences
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
