namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ExtendedFilePropertiesPart
/// </summary>
public partial class ExtendedFilePropertiesPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ExtendedFilePropertiesPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.ExtendedFilePropertiesPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ExtendedFilePropertiesPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ExtendedFilePropertiesPartImpl(): base() {}
  
  public ExtendedFilePropertiesPartImpl(DocumentFormat.OpenXml.Packaging.ExtendedFilePropertiesPart openXmlElement): base(openXmlElement)
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
  public DocumentModel.Properties.ExtendedProperties? Properties
  {
    get
    {
      if (OpenXmlElement?.Properties != null)
        return new DocumentModel.Properties.ExtendedPropertiesImpl(OpenXmlElement.Properties);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Properties.ExtendedPropertiesImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Properties = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
