namespace DocumentModel.Drawing;

/// <summary>
/// Whole E2O Formatting.
/// </summary>
public interface IWhole // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawing.IOutline? Outline { get ; set; }
  
  public DocumentModel.Drawing.IEffectList? EffectList { get ; set; }
  
  public DocumentModel.Drawing.IEffectDag? EffectDag { get ; set; }
  
}
