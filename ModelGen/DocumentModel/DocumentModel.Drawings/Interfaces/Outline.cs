namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Outline Class.
/// </summary>
public interface Outline
{
  public Boolean? NoFill { get ; set; }
  
  public SolidFill? SolidFill { get ; set; }
  
  public GradientFill? GradientFill { get ; set; }
  
  public PatternFill? PatternFill { get ; set; }
  
  public PresetLineDashKind? PresetDash { get ; set; }
  
  public CustomDash? CustomDash { get ; set; }
  
  public Boolean? Round { get ; set; }
  
  public Boolean? LineJoinBevel { get ; set; }
  
  public Miter? Miter { get ; set; }
  
  public LineEndPropertiesType? HeadEnd { get ; set; }
  
  public LineEndPropertiesType? TailEnd { get ; set; }
  
  public LinePropertiesExtensionList? LinePropertiesExtensionList { get ; set; }
  
}
