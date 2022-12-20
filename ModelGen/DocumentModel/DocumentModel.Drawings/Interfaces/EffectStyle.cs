namespace DocumentModel.Drawings;

/// <summary>
/// Effect Style.
/// </summary>
public partial interface EffectStyle
{
  public DocumentModel.Drawings.EffectList? EffectList { get; set; }
  
  public DocumentModel.Drawings.EffectDag? EffectDag { get; set; }
  
  public DocumentModel.Drawings.Scene3DType? Scene3DType { get; set; }
  
  public DocumentModel.Drawings.Shape3DType? Shape3DType { get; set; }
  
}
