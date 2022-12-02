namespace DocumentModel.Drawing;

/// <summary>
/// Background Formatting.
/// </summary>
public interface IBackground // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Boolean? NoFill { get ; set; }
  
  public ISolidFill? SolidFill { get ; set; }
  
  public IGradientFill? GradientFill { get ; set; }
  
  public IBlipFill? BlipFill { get ; set; }
  
  public IPatternFill? PatternFill { get ; set; }
  
  public Boolean? GroupFill { get ; set; }
  
  public IEffectList? EffectList { get ; set; }
  
  public IEffectDag? EffectDag { get ; set; }
  
}
