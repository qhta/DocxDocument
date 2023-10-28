namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an outline style that can be applied to a number of different objects such as shapes and text. The line allows for the specifying of many different types of outlines including even line dashes and bevels.
/// </summary>
public partial class Outline
{
  public DMD.NoFill? NoFill { get; set; }
  
  public DMD.SolidFill? SolidFill { get; set; }
  
  public DMD.GradientFill? GradientFill { get; set; }
  
  public DMD.PatternFill? PatternFill { get; set; }
  
  public DMD.PresetLineDashKind? PresetDash { get; set; }
  
  public DMD.CustomDash? CustomDash { get; set; }
  
  public DMD.Round? Round { get; set; }
  
  public DMD.LineJoinBevel? LineJoinBevel { get; set; }
  
  public DMD.Miter? Miter { get; set; }
  
  public DMD.HeadEnd? HeadEnd { get; set; }
  
  public DMD.TailEnd? TailEnd { get; set; }
  
  public DMD.LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }
  
}
