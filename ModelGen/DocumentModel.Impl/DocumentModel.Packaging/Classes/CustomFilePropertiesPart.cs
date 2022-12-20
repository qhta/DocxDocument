namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomFilePropertiesPart
/// </summary>
public partial class CustomFilePropertiesPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CustomFilePropertiesPart
{
  public new DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomFilePropertiesPartImpl(): base() {}
  
  public CustomFilePropertiesPartImpl(DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart openXmlElement): base(openXmlElement)
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
  public DocumentModel.Properties.CustomProperties? Properties
  {
    get
    {
      if (OpenXmlElement?.Properties != null)
        return new DocumentModel.Properties.CustomPropertiesImpl(OpenXmlElement.Properties);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Properties.CustomPropertiesImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Properties = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
