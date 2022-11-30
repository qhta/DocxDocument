namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Outline Class.
/// </summary>
public interface IOutline // : DocumentModel.Drawing.ILinePropertiesType
{
  public System.Boolean? NoFill { get ; set; }
  
  public DocumentModel.Drawing.ISolidFill? SolidFill { get ; set; }
  
  public DocumentModel.Drawing.IGradientFill? GradientFill { get ; set; }
  
  public DocumentModel.Drawing.IPatternFill? PatternFill { get ; set; }
  
  public DocumentModel.Drawing.PresetLineDashKind? PresetDash { get ; set; }
  
  public DocumentModel.Drawing.ICustomDash? CustomDash { get ; set; }
  
  public System.Boolean? Round { get ; set; }
  
  public System.Boolean? LineJoinBevel { get ; set; }
  
  public DocumentModel.Drawing.IMiter? Miter { get ; set; }
  
  public DocumentModel.Drawing.ILineEndPropertiesType? HeadEnd { get ; set; }
  
  public DocumentModel.Drawing.ILineEndPropertiesType? TailEnd { get ; set; }
  
  public DocumentModel.Drawing.ILinePropertiesExtensionList? LinePropertiesExtensionList { get ; set; }
  
}
