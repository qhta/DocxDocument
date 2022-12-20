namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomXmlPropertiesPart
/// </summary>
public partial class CustomXmlPropertiesPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CustomXmlPropertiesPart
{
  public new DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomXmlPropertiesPartImpl(): base() {}
  
  public CustomXmlPropertiesPartImpl(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.CustomXml.DataStoreItem? DataStoreItem
  {
    get
    {
      if (OpenXmlElement?.DataStoreItem != null)
        return new DocumentModel.CustomXml.DataStoreItemImpl(OpenXmlElement.DataStoreItem);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.CustomXml.DataStoreItemImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.DataStoreItem = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
