namespace DocumentModel.Drawings;

/// <summary>
/// Effect Style List.
/// </summary>
public class EffectStyleListImpl: ModelElementImpl, EffectStyleList
{
  public DocumentFormat.OpenXml.Drawing.EffectStyleList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.EffectStyleList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<EffectStyle>? EffectStyles
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
