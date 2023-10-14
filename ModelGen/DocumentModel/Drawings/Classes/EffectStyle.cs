namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a set of effects and 3D properties that can be applied to an object.
/// </summary>
public partial class EffectStyle
{
  public DocumentModel.Drawings.EffectList? EffectList { get; set; }
  
  public DocumentModel.Drawings.EffectDag? EffectDag { get; set; }
  
  public DocumentModel.Drawings.Scene3DType? Scene3DType { get; set; }
  
  public DocumentModel.Drawings.Shape3DType? Shape3DType { get; set; }
  
}
