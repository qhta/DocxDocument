namespace DocumentModel.Drawings;

/// <summary>
/// Fill Style List.
/// </summary>
public interface FillStyleList
{
  public Boolean? NoFill { get ; set; }
  
  public SolidFill? SolidFill { get ; set; }
  
  public GradientFill? GradientFill { get ; set; }
  
  public BlipFill? BlipFill { get ; set; }
  
  public PatternFill? PatternFill { get ; set; }
  
  public Boolean? GroupFill { get ; set; }
  
}
