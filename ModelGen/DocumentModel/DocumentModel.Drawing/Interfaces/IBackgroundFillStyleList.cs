namespace DocumentModel.Drawing;

/// <summary>
/// Background Fill Style List.
/// </summary>
public interface IBackgroundFillStyleList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Boolean? NoFill { get ; set; }
  
  public DocumentModel.Drawing.ISolidFill? SolidFill { get ; set; }
  
  public DocumentModel.Drawing.IGradientFill? GradientFill { get ; set; }
  
  public DocumentModel.Drawing.IBlipFill? BlipFill { get ; set; }
  
  public DocumentModel.Drawing.IPatternFill? PatternFill { get ; set; }
  
  public System.Boolean? GroupFill { get ; set; }
  
}
