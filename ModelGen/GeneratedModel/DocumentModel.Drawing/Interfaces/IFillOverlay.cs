namespace DocumentModel.Drawing;

public interface IFillOverlay // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public BlendMode? Blend { get ; set; }
  
  public INoFill? NoFill { get ; set; }
  
  public ISolidFill? SolidFill { get ; set; }
  
  public DocumentModel.Drawing.IGradientFill? GradientFill { get ; set; }
  
  public DocumentModel.Drawing.IBlipFill? BlipFill { get ; set; }
  
  public DocumentModel.Drawing.IPatternFill? PatternFill { get ; set; }
  
  public IGroupFill? GroupFill { get ; set; }
  
}
