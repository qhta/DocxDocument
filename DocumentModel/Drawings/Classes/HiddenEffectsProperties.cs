namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HiddenEffectsProperties Class.
/// </summary>
public partial class HiddenEffectsProperties
{
  /// <summary>
  /// Effect Container.
  /// </summary>
  public DocumentModel.Drawings.EffectList? EffectList { get; set; }
  
  /// <summary>
  /// Effect Container.
  /// </summary>
  public DocumentModel.Drawings.EffectDag? EffectDag { get; set; }
  
}
