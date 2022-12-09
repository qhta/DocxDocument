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
  
  public override String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ControlPropertiesPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.ControlPropertiesPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
