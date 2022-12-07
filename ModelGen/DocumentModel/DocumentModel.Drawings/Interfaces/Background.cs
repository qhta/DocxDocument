namespace DocumentModel.Drawings;

/// <summary>
/// Background Formatting.
/// </summary>
public interface Background
{
  public SolidFill? SolidFill { get ; set; }
  
  public GradientFill? GradientFill { get ; set; }
  
  public BlipFill1? BlipFill { get ; set; }
  
  public PatternFill? PatternFill { get ; set; }
  
  public EffectList? EffectList { get ; set; }
  
  public EffectDag? EffectDag { get ; set; }
  
}
