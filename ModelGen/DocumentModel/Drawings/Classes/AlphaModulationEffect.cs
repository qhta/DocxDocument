namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a more or less opaque version of its input color. An alpha modulate never increases the alpha beyond 100%. A 200% alpha modulate makes an input color twice as opaque as before. A 50% alpha modulate makes an input color half as opaque as before.
/// </summary>
public partial class AlphaModulationEffect
{
  
  /// <summary>
  ///   EffectContainer.
  /// </summary>
  public EffectContainer? EffectContainer { get; set; }
  
}
