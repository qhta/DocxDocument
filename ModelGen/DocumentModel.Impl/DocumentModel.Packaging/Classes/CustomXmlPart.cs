namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomXmlPart
/// </summary>
public class CustomXmlPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CustomXmlPart
{
  public new DocumentFormat.OpenXml.Packaging.CustomXmlPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.CustomXmlPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.CustomXmlPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
