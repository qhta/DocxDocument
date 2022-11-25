namespace DocumentModel.Office2010.Drawing;

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
  public DocumentModel.Drawing.IEffectContainerType? EffectDag { get ; set; }
  
}
