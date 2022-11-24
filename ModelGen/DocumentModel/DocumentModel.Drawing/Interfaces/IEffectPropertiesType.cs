namespace DocumentModel.Drawing;

/// <summary>
/// Effect.
/// </summary>
public interface IEffectPropertiesType // : DocumentModel.ITypedOpenXmlCompositeElement
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
