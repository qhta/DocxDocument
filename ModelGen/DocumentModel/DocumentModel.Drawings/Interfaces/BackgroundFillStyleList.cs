namespace DocumentModel.Drawings;

/// <summary>
/// Background Fill Style List.
/// </summary>
public interface BackgroundFillStyleList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Boolean>? NoFills { get ; set; }
  
  public Collection<SolidFill>? SolidFills { get ; set; }
  
  public Collection<GradientFill>? GradientFills { get ; set; }
  
  public Collection<BlipFill>? BlipFills { get ; set; }
  
  public Collection<PatternFill>? PatternFills { get ; set; }
  
  public Collection<Boolean>? GroupFills { get ; set; }
  
}
