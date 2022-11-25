namespace DocumentModel.Drawing;

/// <summary>
/// Alpha Modulate Effect.
/// </summary>
public interface IAlphaModulationEffect // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// EffectContainer.
  /// </summary>
  public DocumentModel.Drawing.IEffectContainerType? EffectContainer { get ; set; }
  
}
