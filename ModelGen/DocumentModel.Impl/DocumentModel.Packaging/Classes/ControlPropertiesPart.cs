namespace DocumentModel.Packaging;

/// <summary>
/// Defines the ControlPropertiesPart
/// </summary>
public class ControlPropertiesPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, ControlPropertiesPart
{
  public new DocumentFormat.OpenXml.Packaging.ControlPropertiesPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.ControlPropertiesPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ControlPropertiesPartImpl(): base() {}
  
  public ControlPropertiesPartImpl(DocumentFormat.OpenXml.Packaging.ControlPropertiesPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ControlPropertiesPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ControlPropertiesPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
