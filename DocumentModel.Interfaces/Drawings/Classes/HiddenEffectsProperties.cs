namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HiddenEffectsProperties interface.
/// </summary>
public interface HiddenEffectsProperties: IModelElement
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