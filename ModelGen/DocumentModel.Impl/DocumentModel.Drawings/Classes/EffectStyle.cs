namespace DocumentModel.Drawings;

/// <summary>
/// Effect Style.
/// </summary>
public class EffectStyleImpl: ModelElementImpl, EffectStyle
{
  public DocumentFormat.OpenXml.Drawing.EffectStyle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.EffectStyle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EffectStyleImpl(): base() {}
  
  public EffectStyleImpl(DocumentFormat.OpenXml.Drawing.EffectStyle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public EffectList? EffectList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public EffectDag? EffectDag
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Scene3DType? Scene3DType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Shape3DType? Shape3DType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
