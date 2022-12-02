namespace DocumentModel.Drawing;

/// <summary>
/// Whole E2O Formatting.
/// </summary>
public interface IWhole // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Outline.
  /// </summary>
  public IOutline? Outline { get ; set; }
  
  public IEffectList? EffectList { get ; set; }
  
  public IEffectDag? EffectDag { get ; set; }
  
}
