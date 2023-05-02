namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HiddenEffectsProperties Class.
/// </summary>
public class HiddenEffectsProperties: ModelElement
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