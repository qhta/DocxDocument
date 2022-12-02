namespace DocumentModel.Presentation;

/// <summary>
/// Background Properties.
/// </summary>
public interface IBackgroundProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shade to Title
  /// </summary>
  public Boolean? ShadeToTitle { get ; set; }
  
  public Boolean? NoFill { get ; set; }
  
  public DocumentModel.Drawing.ISolidFill? SolidFill { get ; set; }
  
  public DocumentModel.Drawing.IGradientFill? GradientFill { get ; set; }
  
  public DocumentModel.Drawing.IBlipFill? BlipFill { get ; set; }
  
  public DocumentModel.Drawing.IPatternFill? PatternFill { get ; set; }
  
  public DocumentModel.Drawing.IEffectList? EffectList { get ; set; }
  
  public DocumentModel.Drawing.IEffectDag? EffectDag { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
