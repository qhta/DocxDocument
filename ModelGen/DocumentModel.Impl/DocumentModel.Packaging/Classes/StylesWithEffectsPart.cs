namespace DocumentModel.Packaging;

/// <summary>
/// Defines the StylesWithEffectsPart
/// </summary>
public partial class StylesWithEffectsPartImpl: DocumentModel.Packaging.StylesPartImpl, StylesWithEffectsPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public StylesWithEffectsPartImpl(): base() {}
  
  public StylesWithEffectsPartImpl(DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart openXmlElement): base(openXmlElement)
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
