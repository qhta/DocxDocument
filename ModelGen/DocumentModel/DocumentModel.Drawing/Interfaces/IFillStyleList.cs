namespace DocumentModel.Drawing;

/// <summary>
/// Fill Style List.
/// </summary>
public interface IFillStyleList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<Boolean>? NoFills { get ; set; }
  
  public Collection<ISolidFill>? SolidFills { get ; set; }
  
  public Collection<IGradientFill>? GradientFills { get ; set; }
  
  public Collection<IBlipFill>? BlipFills { get ; set; }
  
  public Collection<IPatternFill>? PatternFills { get ; set; }
  
  public Collection<Boolean>? GroupFills { get ; set; }
  
}
