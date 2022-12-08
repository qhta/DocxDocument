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
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
