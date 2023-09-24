namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an outline style that can be applied to a number of different objects such as shapes and text. The line allows for the specifying of many different types of outlines including even line dashes and bevels.
/// </summary>
public partial class Outline
{
  public Boolean? NoFill { get; set; }
  
  public SolidFill? SolidFill { get; set; }
  
  public GradientFill? GradientFill { get; set; }
  
  public PatternFill? PatternFill { get; set; }
  
  public PresetLineDashKind? PresetDash { get; set; }
  
  public CustomDash? CustomDash { get; set; }
  
  public Boolean? Round { get; set; }
  
  public Boolean? LineJoinBevel { get; set; }
  
  public Miter? Miter { get; set; }
  
  public LineEndPropertiesType? HeadEnd { get; set; }
  
  public LineEndPropertiesType? TailEnd { get; set; }
  
  public LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }
  
}
