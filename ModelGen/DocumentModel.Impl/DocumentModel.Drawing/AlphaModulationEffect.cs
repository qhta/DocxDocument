namespace DocumentModel.Drawing;

/// <summary>
/// Alpha Modulate Effect.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectContainer))]
public class AlphaModulationEffect: IAlphaModulationEffect
{
  /// <summary>
  /// EffectContainer.
  /// </summary>
  public IEffectContainer? EffectContainer
  {
    get;
    set;
  }
  
}
