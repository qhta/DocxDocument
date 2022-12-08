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
