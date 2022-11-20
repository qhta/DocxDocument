namespace DocumentModel.Drawing;

/// <summary>
/// Alpha Modulate Effect.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectContainer))]
public interface IAlphaModulationEffect // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// EffectContainer.
  /// </summary>
  public IEffectContainer? EffectContainer { get ; set; }
  
}
