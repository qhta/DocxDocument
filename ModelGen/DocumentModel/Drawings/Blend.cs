namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a blend of several effects. The container specifies the raw effects to blend while the blend mode specifies how the effects are to be blended.
/// </summary>
public partial class Blend
{
  
  /// <summary>
  ///   Effect to blend.
  /// </summary>
  public DMD.EffectContainer? EffectContainer { get; set; }
  
}
