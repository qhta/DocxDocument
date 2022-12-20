namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ControlPropertiesPart
/// </summary>
public partial class ControlPropertiesPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ControlPropertiesPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.ControlPropertiesPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ControlPropertiesPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ControlPropertiesPartImpl(): base() {}
  
  public ControlPropertiesPartImpl(DocumentFormat.OpenXml.Packaging.ControlPropertiesPart openXmlElement): base(openXmlElement)
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
