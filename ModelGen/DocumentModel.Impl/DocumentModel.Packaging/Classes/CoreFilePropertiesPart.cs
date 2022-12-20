namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CoreFilePropertiesPart
/// </summary>
public partial class CoreFilePropertiesPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CoreFilePropertiesPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.CoreFilePropertiesPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.CoreFilePropertiesPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CoreFilePropertiesPartImpl(): base() {}
  
  public CoreFilePropertiesPartImpl(DocumentFormat.OpenXml.Packaging.CoreFilePropertiesPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
