namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the HiddenLineProperties Class.
/// </summary>
public partial class HiddenLineProperties
{
  
  /// <summary>
  ///   line width
  /// </summary>
  public Int32? Width { get; set; }
  
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
