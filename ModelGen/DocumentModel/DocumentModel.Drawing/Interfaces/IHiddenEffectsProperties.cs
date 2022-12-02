namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HiddenEffectsProperties Class.
/// </summary>
public interface IHiddenEffectsProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Effect Container.
  /// </summary>
  public DocumentModel.Drawing.IEffectList? EffectList { get ; set; }
  
  /// <summary>
  /// Effect Container.
  /// </summary>
  public DocumentModel.Drawing.IEffectDag? EffectDag { get ; set; }
  
}
