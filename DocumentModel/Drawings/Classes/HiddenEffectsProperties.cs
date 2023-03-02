namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HiddenEffectsProperties Class.
/// </summary>
public record HiddenEffectsProperties
{
  /// <summary>
  ///   Effect Container.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  ///   Effect Container.
  /// </summary>
  public EffectDag? EffectDag { get; set; }
}