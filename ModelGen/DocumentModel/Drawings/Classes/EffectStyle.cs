namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a set of effects and 3D properties that can be applied to an object.
/// </summary>
public partial class EffectStyle
{
  public EffectList? EffectList { get; set; }
  
  public EffectDag? EffectDag { get; set; }
  
  public Scene3DType? Scene3DType { get; set; }
  
  public Shape3DType? Shape3DType { get; set; }
  
}
