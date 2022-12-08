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
  
  public EffectList? EffectList
  {
    get;
    set;
  }
  
  public EffectDag? EffectDag
  {
    get;
    set;
  }
  
  public Scene3DType? Scene3DType
  {
    get;
    set;
  }
  
  public Shape3DType? Shape3DType
  {
    get;
    set;
  }
  
}
