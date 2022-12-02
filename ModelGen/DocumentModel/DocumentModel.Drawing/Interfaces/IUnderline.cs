namespace DocumentModel.Drawing;

/// <summary>
/// Underline Stroke.
/// </summary>
public interface IUnderline // : DocumentModel.Drawing.ILinePropertiesType
{
  public Boolean? NoFill { get ; set; }
  
  public ISolidFill? SolidFill { get ; set; }
  
  public IGradientFill? GradientFill { get ; set; }
  
  public IPatternFill? PatternFill { get ; set; }
  
  public PresetLineDashKind? PresetDash { get ; set; }
  
  public ICustomDash? CustomDash { get ; set; }
  
  public Boolean? Round { get ; set; }
  
  public Boolean? LineJoinBevel { get ; set; }
  
  public IMiter? Miter { get ; set; }
  
  public ILineEndPropertiesType? HeadEnd { get ; set; }
  
  public ILineEndPropertiesType? TailEnd { get ; set; }
  
  public ILinePropertiesExtensionList? LinePropertiesExtensionList { get ; set; }
  
}
