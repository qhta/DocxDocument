namespace DocumentModel.Packaging;

/// <summary>
/// Defines the FontPart
/// </summary>
public class FontPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, FontPart
{
  public new DocumentFormat.OpenXml.Packaging.FontPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.FontPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
