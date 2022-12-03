namespace DocumentModel.Presentation;

/// <summary>
/// Background Properties.
/// </summary>
public interface BackgroundProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Shade to Title
  /// </summary>
  public Boolean? ShadeToTitle { get ; set; }
  
  public Boolean? NoFill { get ; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get ; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get ; set; }
  
  public DocumentModel.Drawings.BlipFill? BlipFill { get ; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get ; set; }
  
  public DocumentModel.Drawings.EffectList? EffectList { get ; set; }
  
  public DocumentModel.Drawings.EffectDag? EffectDag { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
