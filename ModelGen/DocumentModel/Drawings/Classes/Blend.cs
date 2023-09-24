namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a blend of several effects. The container specifies the raw effects to blend while the blend mode specifies how the effects are to be blended.
/// </summary>
public partial class Blend
{
  
  /// <summary>
  ///   Specifies how to blend the two effects.
  /// </summary>
  public BlendMode? BlendMode { get; set; }
  
  
  /// <summary>
  ///   Effect to blend.
  /// </summary>
  public EffectContainer? EffectContainer { get; set; }
  
}
