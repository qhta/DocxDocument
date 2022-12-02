namespace DocumentModel.Drawing;

/// <summary>
/// Effect Style.
/// </summary>
public interface IEffectStyle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public IEffectList? EffectList { get ; set; }
  
  public IEffectDag? EffectDag { get ; set; }
  
  public IScene3DType? Scene3DType { get ; set; }
  
  public IShape3DType? Shape3DType { get ; set; }
  
}
