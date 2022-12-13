namespace DocumentModel.Drawings;

/// <summary>
/// Fill Style List.
/// </summary>
public interface FillStyleList
{
  public Boolean? NoFill { get ; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get ; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get ; set; }
  
  public DocumentModel.Drawings.BlipFill? BlipFill { get ; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get ; set; }
  
  public Boolean? GroupFill { get ; set; }
  
}
