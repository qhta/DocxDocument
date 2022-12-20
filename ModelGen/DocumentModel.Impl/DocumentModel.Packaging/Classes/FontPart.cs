namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FontPart
/// </summary>
public partial class FontPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, FontPart
{
  public new DocumentFormat.OpenXml.Packaging.FontPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.FontPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FontPartImpl(): base() {}
  
  public FontPartImpl(DocumentFormat.OpenXml.Packaging.FontPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
