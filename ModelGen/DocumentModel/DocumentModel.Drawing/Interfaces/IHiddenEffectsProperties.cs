namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HiddenEffectsProperties Class.
/// </summary>
public interface IHiddenEffectsProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Effect Container.
  /// </summary>
  public IEffectList? EffectList { get ; set; }
  
  /// <summary>
  /// Effect Container.
  /// </summary>
  public IEffectDag? EffectDag { get ; set; }
  
}
