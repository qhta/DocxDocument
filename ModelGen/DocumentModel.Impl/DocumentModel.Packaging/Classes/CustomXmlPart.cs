namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomXmlPart
/// </summary>
public partial class CustomXmlPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CustomXmlPart
{
  public new DocumentFormat.OpenXml.Packaging.CustomXmlPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.CustomXmlPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomXmlPartImpl(): base() {}
  
  public CustomXmlPartImpl(DocumentFormat.OpenXml.Packaging.CustomXmlPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the CustomXmlPropertiesPart of the CustomXmlPart
  /// </summary>
  public DocumentModel.Packaging.CustomXmlPropertiesPart? CustomXmlPropertiesPart
  {
    get
    {
      if (OpenXmlElement?.CustomXmlPropertiesPart != null)
        return new DocumentModel.Packaging.CustomXmlPropertiesPartImpl(OpenXmlElement.CustomXmlPropertiesPart);
      return null;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
