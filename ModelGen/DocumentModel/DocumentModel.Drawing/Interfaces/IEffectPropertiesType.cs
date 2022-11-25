namespace DocumentModel.Drawing;

/// <summary>
/// Effect.
/// </summary>
public interface IEffectPropertiesType // : DocumentModel.ITypedOpenXmlCompositeElement
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
