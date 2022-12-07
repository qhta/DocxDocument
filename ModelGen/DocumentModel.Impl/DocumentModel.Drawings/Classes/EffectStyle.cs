namespace DocumentModel.Drawings;

/// <summary>
/// Effect Style.
/// </summary>
public class EffectStyleImpl: ModelElement<DocumentFormat.OpenXml.Drawing.EffectStyle>, EffectStyle
{
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
