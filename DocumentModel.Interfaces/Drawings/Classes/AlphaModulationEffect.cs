namespace DocumentModel.Drawings;

/// <summary>
///   Alpha Modulate Effect.
/// </summary>
public interface AlphaModulationEffect: IModelElement
{
  /// <summary>
  ///   EffectContainer.
  /// </summary>
  public EffectContainer? EffectContainer { get; set; }
}