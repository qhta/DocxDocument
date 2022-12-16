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
  
  public DataStoreItemImpl(): base() {}
  
  public DataStoreItemImpl(DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Custom XML Data ID
  /// </summary>
  public String? ItemId
  {
    get => (System.String?)OpenXmlElement?.ItemId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ItemId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Set of Associated XML Schemas.
  /// </summary>
  public DocumentModel.CustomXml.SchemaReferences? SchemaReferences
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences>();
        if (item != null)
          return new DocumentModel.CustomXml.SchemaReferencesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.CustomXml.SchemaReferencesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
