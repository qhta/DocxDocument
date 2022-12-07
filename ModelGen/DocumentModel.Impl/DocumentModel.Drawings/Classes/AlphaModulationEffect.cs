namespace DocumentModel.Drawings;

/// <summary>
/// Alpha Modulate Effect.
/// </summary>
public class AlphaModulationEffectImpl: ModelElement<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>, AlphaModulationEffect
{
  /// <summary>
  /// EffectContainer.
  /// </summary>
  public EffectContainer? EffectContainer
  {
    get;
    set;
  }
  
}
