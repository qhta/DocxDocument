namespace DocumentModel.Drawing;

/// <summary>
/// Effect Style.
/// </summary>
public interface IEffectStyle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.IEffectList? EffectList { get ; set; }
  
  public DocumentModel.Drawing.IEffectDag? EffectDag { get ; set; }
  
  public DocumentModel.Drawing.IScene3DType? Scene3DType { get ; set; }
  
  public DocumentModel.Drawing.IShape3DType? Shape3DType { get ; set; }
  
}
