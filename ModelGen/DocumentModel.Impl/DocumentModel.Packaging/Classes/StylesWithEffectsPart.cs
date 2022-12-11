namespace DocumentModel.Packaging;

/// <summary>
/// Defines the StylesWithEffectsPart
/// </summary>
public class StylesWithEffectsPartImpl: DocumentModel.Packaging.StylesPartImpl, StylesWithEffectsPart
{
  public new DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StylesWithEffectsPartImpl(): base() {}
  
  public StylesWithEffectsPartImpl(DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
