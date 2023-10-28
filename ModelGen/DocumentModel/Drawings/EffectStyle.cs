namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a set of effects and 3D properties that can be applied to an object.
/// </summary>
public partial class EffectStyle
{
  public DMD.EffectList? EffectList { get; set; }
  
  public DMD.EffectDag? EffectDag { get; set; }
  
  public DMD.Scene3DType? Scene3DType { get; set; }
  
  public DMD.Shape3DType? Shape3DType { get; set; }
  
}
