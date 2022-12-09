namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomPropertyPart
/// </summary>
public class CustomPropertyPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CustomPropertyPart
{
  public new DocumentFormat.OpenXml.Packaging.CustomPropertyPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.CustomPropertyPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.CustomPropertyPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
