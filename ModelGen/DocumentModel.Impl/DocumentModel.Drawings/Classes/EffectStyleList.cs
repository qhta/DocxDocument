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
  
  public EffectStyleListImpl(): base() {}
  
  public EffectStyleListImpl(DocumentFormat.OpenXml.Drawing.EffectStyleList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Drawings.EffectStyle? EffectStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
