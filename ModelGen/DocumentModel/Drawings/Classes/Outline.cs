namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an outline style that can be applied to a number of different objects such as shapes and text. The line allows for the specifying of many different types of outlines including even line dashes and bevels.
/// </summary>
public partial class Outline
{
  public Boolean? NoFill { get; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  public DocumentModel.Drawings.PresetLineDashValues? PresetDash { get; set; }
  
  public DocumentModel.Drawings.CustomDash? CustomDash { get; set; }
  
  public Boolean? Round { get; set; }
  
  public Boolean? LineJoinBevel { get; set; }
  
  public DocumentModel.Drawings.Miter? Miter { get; set; }
  
  public DocumentModel.Drawings.LineEndPropertiesType? HeadEnd { get; set; }
  
  public DocumentModel.Drawings.LineEndPropertiesType? TailEnd { get; set; }
  
  public DocumentModel.Drawings.LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }
  
}
