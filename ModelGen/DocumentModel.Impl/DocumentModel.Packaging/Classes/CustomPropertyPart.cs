namespace DocumentModel.Packaging;

/// <summary>
/// Defines the CustomPropertyPart
/// </summary>
public partial class CustomPropertyPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CustomPropertyPart
{
  public new DocumentFormat.OpenXml.Packaging.CustomPropertyPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.CustomPropertyPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomPropertyPartImpl(): base() {}
  
  public CustomPropertyPartImpl(DocumentFormat.OpenXml.Packaging.CustomPropertyPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
